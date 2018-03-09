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

namespace strawberry.ui
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<string> keyList = UsersXmlRead();
			String key = this.textBox_UserName.Text + this.textBox_PassWord.Text;
			if (keyList.Contains(key))
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
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
	}
}
