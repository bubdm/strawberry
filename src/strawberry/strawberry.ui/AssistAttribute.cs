using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using strawberry.ui;
using System.Collections;
using strawberry.lanfolder;
using strawberry.client;
using Microsoft.VisualBasic;

namespace strawberry.ui
{
	public partial class AssistAttribute : Form
	{
		public AssistAttribute()
		{
			InitializeComponent();
		}
		public void Init()
		{
			FormMain frmMain = new FormMain();
			ListViewItem listViewItem = frmMain.listViewSelectedItem;
			string path = listViewItem.Tag.ToString();
			label18.Text = path.Substring(path.LastIndexOf("\\") + 1);
			label17.Text = listViewItem.SubItems[5].Text + "KB";
			label16.Text = "creator";
			label15.Text = File.GetCreationTime(path).ToString();
			label14.Text = "updater";
			label13.Text = File.GetLastWriteTime(path).ToString();
		}

		private void AssistAttribute_Load(object sender, EventArgs e)
		{
			Init();
		}
	}
}
