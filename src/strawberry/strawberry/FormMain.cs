using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Collections;
using Microsoft.VisualBasic;
using strawberry.lanfolder;
using strawberry.client;
namespace strawberry
{
	public partial class FormMain : Form
	{
		ISBClient client = new LanFolderClient();

		string str;
		public FormMain()
		{
			InitializeComponent();

			string xmlKind = "net/lan";
			if (xmlKind == "net:")
			{
				client = new NetFolderClient();
			}
			else
			{
				client = new LanFolderClient();
			}
		}
		bool m_edit = false;
		string Xmlpath;
		bool retbool = false;

		XmlDocument doc = new XmlDocument();
		//获得程序所在路径
		public ISBFile GetPath()
		{
			//doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"lanfolder.xml");

			//Xmlpath = doc.SelectSingleNode("lanfolder /root").InnerText;
			ISBFile XmlpathFile = new LanFile();
			XmlpathFile.Name = "guominmin2";
			XmlpathFile.Path = "C:\\guominmin2";
			return XmlpathFile;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear(); //清空TreeView
			TreeNode root = new TreeNode();
			ISBFile rootFile = GetPath();
			root.Text = rootFile.Path;
			root.Tag = rootFile;
			treeView1.Nodes.Add(root);

			PaintTreeView(treeView1.Nodes[0], rootFile.Path);

		}


		#region 生成程序所在根目录的TreeView

		private void PaintTreeView(TreeNode ptreeNode, string fullPath)
		{

			try
			{
				ISBFile[] fileList = client.List(fullPath);

				//treeView.Nodes.Clear(); //清空TreeView

				//循环文件夹

				for (int i = 0; i < fileList.Count(); i++)
				{
					TreeNode treeNode = new TreeNode();
					treeNode.Text = fileList[i].Name;
					treeNode.Tag = fileList[i];
					if (fileList[i].IsFolder)
					{
						ptreeNode.Nodes.Add(treeNode);
					}
				}
			}

			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + "\r\n出错的位置为：FormMain.PaintTreeView()");

			}

		}

		#endregion


		#region 遍历TreeView根节点下文件和文件夹

		private bool GetMultiNode(TreeNode treeNode, string path)
		{

			if (Directory.Exists(path) == false)

			{ return false; }


			DirectoryInfo dirs = new DirectoryInfo(path); //获得程序所在路径的目录对象

			DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象

			FileInfo[] file = dirs.GetFiles();//获得目录下文件对象

			int dircount = dir.Count();//获得文件夹对象数量

			int filecount = file.Count();//获得文件对象数量

			int sumcount = dircount + filecount;


			if (sumcount == 0)

			{ return false; }


			//循环文件夹
			if (treeNode.Nodes.Count == 0)
			{
				for (int j = 0; j < dircount; j++)
				{
					treeNode.Nodes.Add(dir[j].Name);
				}

			}
			else
			{
				for (int j = 0; j < dircount; j++)
				{
					TreeNode ret = FindNode(treeNode.Nodes, dir[j].Name);
					if (ret == null)
					{
						treeNode.Nodes.Add(dir[j].Name);
						continue;
					}

					//string pathNodeB = path + "\\" + dir[j].Name;

					//GetMultiNode(treeNode.Nodes[j], pathNodeB);

				}
			}




			return true;

		}
		private bool GetAllFile(string path)
		{
			DirectoryInfo dirs = new DirectoryInfo(path); //获得程序所在路径的目录对象

			DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象

			FileInfo[] file = dirs.GetFiles();//获得目录下文件对象

			int dircount = dir.Count();//获得文件夹对象数量

			int filecount = file.Count();//获得文件对象数量

			int sumcount = dircount + filecount;


			//循环文件夹
			for (int j = 0; j < dircount; j++)
			{
				if (dir[j].Name.IndexOf(search_textBox.Text.Trim()) >= 0)
				{
					ListViewItem li = new ListViewItem();
					li.Text = dir[j].Name;
					li.SubItems.Add("1");
					li.SubItems.Add("2");
					li.SubItems.Add("3");
					li.SubItems.Add(dir[j].LastWriteTime.ToString());
					li.SubItems.Add("");
					listView1.Items.Add(li);
					retbool = true;
				}
				string pathNodeB = path + "\\" + dir[j].Name;
				if (dir[j].GetDirectories().Count() + dir[j].GetFiles().Count() == 0)
				{
					continue;
				}
				GetAllFile(pathNodeB);
			}

			//循环文件
			for (int j = 0; j < filecount; j++)
			{
				if (file[j].Name.IndexOf(search_textBox.Text.Trim()) >= 0)
				{
					ListViewItem lj = new ListViewItem();
					lj.Text = file[j].Name;
					lj.SubItems.Add("1");
					lj.SubItems.Add("2");
					lj.SubItems.Add("3");
					lj.SubItems.Add(file[j].LastWriteTime.ToString());
					lj.SubItems.Add(string.Format(("{0:N0}"), file[j].Length));
					listView1.Items.Add(lj);
					retbool = true;
				}
			}
			return retbool;
		}


		private TreeNode FindNode(TreeNodeCollection node, string name)
		{
			//接受返回的节点
			TreeNode ret = null;
			//循环查找
			foreach (TreeNode temp in node)
			{
				if (temp.Text == name)
				{
					ret = temp;
					return ret;
				}
			}

			return ret;
		}

		#endregion


		// 返回选中节点的完整路径
		private string selectNodePath(TreeView treeview, TreeNode node1)
		{
			TreeNode tn = new TreeNode();
			tn = node1.Parent;
			if (tn == null)
			{
				str = str.Insert(0, node1.Text.ToString() + "\\");

			}
			else
			{
				str = str.Insert(0, node1.Text.ToString() + "\\");
				selectNodePath(treeview, tn);
			}
			return str;
		}

		//private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		//{
		//    str = "";
		//    TreeNode node = new TreeNode();
		//    node = treeView1.SelectedNode;
		//    string snp = selectNodePath(treeView1, node);

		//    string Path = snp.Substring(0, snp.Length - 1);

		//    textBox1.Text = Path;
		//    if (node.Parent != null)
		//    {
		//        GetMultiNode(node, @Path);
		//    }
		//    DisplayListView(Path);

		//}

		#region 显示listview

		private void DisplayListView(string nodePath)
		{

			try
			{

				listView1.Items.Clear(); //清空listView

				DirectoryInfo dirs = new DirectoryInfo(nodePath); //获得程序所在路径的目录对象

				DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象

				FileInfo[] file = dirs.GetFiles();//获得目录下文件对象

				int dircount = dir.Count();//获得文件夹对象数量

				int filecount = file.Count();//获得文件对象数量

				int sumcount = dircount + filecount;

				if (sumcount == 0)
				{
					return;
				}


				//循环文件夹

				for (int i = 0; i < dircount; i++)
				{
					ListViewItem li = new ListViewItem();
					li.Text = dir[i].Name;
					li.SubItems.Add("1");
					li.SubItems.Add("2");
					li.SubItems.Add("3");
					li.SubItems.Add(dir[i].LastWriteTime.ToString());
					li.SubItems.Add("");
					listView1.Items.Add(li);

				}


				//循环文件

				for (int j = 0; j < filecount; j++)
				{

					ListViewItem lj = new ListViewItem();
					lj.Text = file[j].Name;
					lj.SubItems.Add("1");
					lj.SubItems.Add("2");
					lj.SubItems.Add("3");
					lj.SubItems.Add(file[j].LastWriteTime.ToString());
					lj.SubItems.Add(string.Format(("{0:N0}"), file[j].Length));
					listView1.Items.Add(lj);

				}

			}

			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + "\r\n出错的位置为：FormMain.DisplayListView()");

			}
		}

		#endregion

		//回车跳转到当前输入路径
		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			listView1.Items.Clear();
			if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
			{
				isTruePath();
			}
		}

		//路径有效则跳转
		private void isTruePath()
		{
			if (textBox1.Text != null && textBox1.Text.Contains("\\"))
			{
				string[] b = textBox1.Text.Split('\\');
				if (b.Length >= 2 && b[b.Length - 1] != "")
				{
					if (b.Length == 2)
					{
						string path = b[0] + "\\" + b[1];
						//if (path == GetPath())
						//{
						//    DisplayListView(textBox1.Text);
						//}
						//else
						//{
						//    MessageBox.Show("无效路径！");
						//    textBox1.Clear();
						//}
					}
					else
					{
						foreach (TreeNode tnc in treeView1.Nodes)
						{
							nextNodes(tnc, b[b.Length - 1]);
						}
						if (listView1.Items.Count == 0)
						{
							MessageBox.Show("无效路径！");
							textBox1.Clear();
						}
					}
				}
				else
				{
					MessageBox.Show("无效路径！");
					textBox1.Clear();
				}
			}
			else
			{
				MessageBox.Show("无效路径！");
				textBox1.Clear();
			}
		}

		//遍历所有节点
		private void nextNodes(TreeNode node, string text)
		{
			foreach (TreeNode tn in node.Nodes)
			{
				if (tn.Text == text.Trim())    //判断节点的名称是否和你的textbox中显示的值相等
				{
					str = "";
					string snp = selectNodePath(treeView1, tn);
					string Path = snp.Substring(0, snp.Length - 1);
					if (Path == textBox1.Text)
					{
						DisplayListView(textBox1.Text);
					}
				}
			}
			foreach (TreeNode tn in node.Nodes)
			{
				//递归
				nextNodes(tn, text);
			}
		}

		//刷新文件目录
		private void refresh_button_Click(object sender, EventArgs e)
		{

			listView1.Items.Clear();
			
			isTruePath();


			//DisplayListView(textBox1.Text);

		}


		//搜索文件
		private void keySearch_button_Click(object sender, EventArgs e)
		{
			bool ret;
			str = "";
			if (search_textBox.Text == "")
			{
				return;
			}
			listView1.Items.Clear();
			ret = GetAllFile(textBox1.Text);
			if (ret == false)
			{
				MessageBox.Show("没有找到信息", "注意！");
				search_textBox.Text = "";
			}
		}

		private void search_textBox_KeyUp(object sender, KeyEventArgs e)
		{
			bool ret;
			str = "";
			if (search_textBox.Text == "")
			{
				return;
			}
			listView1.Items.Clear();
			ret = GetAllFile(textBox1.Text);
			if (ret == false)
			{
				MessageBox.Show("没有找到信息", "注意！");
				search_textBox.Text = "";
			}
		}


		private void FormMain_Shown(object sender, EventArgs e)
		{
			//button3.Visible = false;
			refresh_button.Visible = true;
		}


		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (listView1.Columns[e.Column].Tag == null)
			{
				listView1.Columns[e.Column].Tag = true;
			}
			bool tabK = (bool)listView1.Columns[e.Column].Tag;
			if (tabK)
			{
				listView1.Columns[e.Column].Tag = false;
			}
			else
			{
				listView1.Columns[e.Column].Tag = true;
			}
			if (e.Column == 3 || e.Column == 5)//需要数值排序的列
			{
				listView1.ListViewItemSorter = new ListViewIntSort(e.Column, listView1.Columns[e.Column].Tag);//指定排序器并传送列索引与升序降序关键字
				for (int i = 0; i < listView1.Items.Count; i++)
				{
					if (listView1.Items[i].SubItems[e.Column].Text == "-1")
					{
						listView1.Items[i].SubItems[e.Column].Text = "";
					}
				}
			}
			else
			{
				listView1.ListViewItemSorter = new ListViewStrSort(e.Column, listView1.Columns[e.Column].Tag);//指定排序器并传送列索引与升序降序关键字
			}
			//listView1.Sort();//对列表进行自定义排序

		}

		//字符排序类的定义:
		public class ListViewStrSort : IComparer
		{
			private int col;
			private bool descK;

			public ListViewStrSort()
			{
				col = 0;
			}
			public ListViewStrSort(int column, object Desc)
			{
				descK = (bool)Desc;
				col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递
			}
			public int Compare(object x, object y)
			{
				int tempInt = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
				if (descK)
				{
					return -tempInt;
				}
				else
				{
					return tempInt;
				}
			}
		}

		//数值排序类的定义:
		public class ListViewIntSort : IComparer
		{
			private int col;
			private bool descK;

			public ListViewIntSort()
			{
				col = 0;
			}
			public ListViewIntSort(int column, object Desc)
			{
				descK = (bool)Desc;
				col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递
			}
			private CaseInsensitiveComparer ObjectCompare = new CaseInsensitiveComparer();
			public int Compare(object x, object y)
			{
				if (((ListViewItem)x).SubItems[col].Text == "")
				{
					((ListViewItem)x).SubItems[col].Text = "-1";
				}
				if (((ListViewItem)y).SubItems[col].Text == "")
				{
					((ListViewItem)y).SubItems[col].Text = "-1";
				}
				int tempInt = ObjectCompare.Compare(Convert.ToDecimal(((ListViewItem)x).SubItems[col].Text), Convert.ToDecimal(((ListViewItem)y).SubItems[col].Text));
				if (descK)
				{
					return -tempInt;
				}
				else
				{
					return tempInt;
				}
			}
		}

		private void treeView1_Click(object sender, EventArgs e)
		{
			str = "";
			TreeNode node = treeView1.SelectedNode;
			ISBFile isbFile = node.Tag as ISBFile;


			string Path = isbFile.Path;

			textBox1.Text = Path;
			if (node.Parent != null)
			{
				if (node.Nodes.Count == 0)
				{
					PaintTreeView(node, @Path);
				}
			}
			//DisplayListView(Path);
		}

		private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			client.Delete(ISBFile);
		}


	}
}
