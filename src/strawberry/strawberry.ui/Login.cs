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
using System.Timers;

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
				this.DialogResult = DialogResult.OK;
				if (regkey.GetValue("CheckState").ToString() == "Checked")
				{
					System.Timers.Timer timer1 = new System.Timers.Timer();
					// 循环间隔时间
					timer1.Interval = 50000;
					// 允许Timer执行
					timer1.Enabled = true;
					// 到时间的时候执行事件
					timer1.Elapsed += new ElapsedEventHandler(timer1_Tick);
					//执行一次
					timer1.AutoReset = false;
				}
				//this.Close();
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
			this.Close();
		}
	}
}
