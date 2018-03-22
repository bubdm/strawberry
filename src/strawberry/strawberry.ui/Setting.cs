using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace strawberry.ui
{
	public partial class Setting : Form
	{
		public Setting()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Setting_Load(object sender, EventArgs e)
		{
			ShowListView();
		}

		private void ShowListView()
		{
			FormMain frmMain = new FormMain();
			RegistryKey reg = Registry.CurrentUser.OpenSubKey("StrawBerry");
			string checkState = reg.GetValue("CheckState").ToString();
			string userName = reg.GetValue("UserName").ToString();
			ListViewItem li = new ListViewItem();
			li.Text = frmMain.path;
			li.SubItems.Add(userName);
			if (checkState == "Checked")
			{
				li.SubItems.Add("はい");
			}
			else
			{
				li.SubItems.Add("いいえ");
			}
			listView1.Items.Add(li);
			reg.Close();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			SetingEdit st = new SetingEdit();
			st.ShowDialog();
			if (st.DialogResult == DialogResult.OK)
			{
				listView1.Items.Clear();
				ShowListView();
			}
			else
			{
				return;
			}
		}
	}
}
