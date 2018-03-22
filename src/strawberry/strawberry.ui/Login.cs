using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;
using System.Threading;

namespace strawberry.ui
{
	public partial class Login : Form
	{
		RegistryKey regkey = Registry.CurrentUser.OpenSubKey("StrawBerry");
		public string checkState
		{
			get
			{
				return checkBox1.CheckState.ToString();
			}
		}
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			//this.Enabled = true;
			if (regkey.GetValue("CheckState").ToString() == "Checked")
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
			if (checkBox1.Checked)
			{
				button1_Click(null, null);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//this.Enabled = false;
			List<string> keyList = UsersXmlRead();
			if (checkBox1.Checked && regkey.GetValue("UserName") != null && regkey.GetValue("PassWord") != null)
			{
				textBox_UserName.Text = regkey.GetValue("UserName").ToString();
				textBox_PassWord.Text = regkey.GetValue("PassWord").ToString();
			}
			String key = textBox_UserName.Text + textBox_PassWord.Text;
			if (keyList.Contains(key))
			{
				Registry.CurrentUser.DeleteSubKey("StrawBerry", false);
				regkey = Registry.CurrentUser.CreateSubKey("StrawBerry");
				regkey.SetValue("CheckState", checkBox1.CheckState);
				regkey.SetValue("UserName", textBox_UserName.Text);
				regkey.SetValue("PassWord", textBox_PassWord.Text);
				if (regkey.GetValue("CheckState").ToString() == "Checked")
				{
					timer1.Interval = 1000;
					timer1.Enabled = true;
				}
				else
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("请确认用户名或密码！");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private List<string> UsersXmlRead()
		{
			List<string> keyList = new List<string>();
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + @"users.xml");
			XmlNode root = xmlDoc.SelectSingleNode("users");
			foreach (XmlNode node in root.ChildNodes)
			{
				string temp = node.Attributes["account"].Value + node.Attributes["password"].Value;
				keyList.Add(temp);
			}
			return keyList;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			this.DialogResult = DialogResult.OK;
		}
	}
}
