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
		FileInfoList fileInfoList;

		public FormMain()
		{
			InitializeComponent();

			//string xmlKind = "net/lan";
			//if (xmlKind == "net:")
			//{
			//    client = new NetFolderClient();
			//}
			//else
			//{
			//    client = new LanFolderClient();
			//}
		}
		bool retbool = false;

		//XmlDocument doc = new XmlDocument();
		//获得程序所在路径
		public ISBFile GetPath()
		{
			//doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"lanfolder.xml");

			//Xmlpath = doc.SelectSingleNode("lanfolder /root").InnerText;
			ISBFile XmlpathFile = new LanFile();
			XmlpathFile.Name = "yinchunlei";
			XmlpathFile.Path = "D:\\yinchunlei";
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

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode node = treeView1.SelectedNode;
			ISBFile isbFile = node.Tag as ISBFile;
			string Path = isbFile.Path;
			textBox1.Text = Path;
			if (node.Nodes.Count == 0)
			{
				PaintTreeView(node, @Path);
			}
			DisplayListView(Path);
		}

		#region 显示listview

		private void DisplayListView(string nodePath)
		{
			try
			{
				listView1.Items.Clear(); //清空listView
				//ISBFile[] fileList = client.List(nodePath);
				//if (fileList.Count() == 0)
				//{
				//    return;
				//}

				////循环文件
				//for (int i = 0; i < fileList.Count(); i++)
				//{
				//    ListViewItem li = new ListViewItem();
				//    if (!fileList[i].IsFolder)
				//    {
				//        li.Text = fileList[i].Name;
				//        li.SubItems.Add("1");
				//        li.SubItems.Add("2");
				//        li.SubItems.Add("3");
				//        li.SubItems.Add(fileList[i].UpdateTime);
				//        li.SubItems.Add(string.Format(("{0:N0}"), fileList[i].Size));
				//        listView1.Items.Add(li);
				//    }
				//}
				string[] filespath = Directory.GetFiles(nodePath);
				fileInfoList = new FileInfoList(filespath);
				if (fileInfoList.list.Count() == 0)
				{
					return;
				}
				foreach (FileInfoWithIcon file in fileInfoList.list)
				{
					ListViewItem item = new ListViewItem();
					item.Text = file.fileInfo.Name;
					item.ImageIndex = file.iconIndex;
					item.SubItems.Add("1");
					item.SubItems.Add("2");
					item.SubItems.Add("3");
					item.SubItems.Add(file.fileInfo.LastWriteTime.ToString());
					item.SubItems.Add(string.Format(("{0:N0}"), file.fileInfo.Length));
					listView1.Items.Add(item);
				}
				listView1.LargeImageList = fileInfoList.imageListLargeIcon;
				listView1.SmallImageList = fileInfoList.imageListSmallIcon;
				listView1.Show();
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
				Goto();
			}
		}

		//路径有效则跳转
		private void Goto()
		{
			for (int i = 0; i < treeView1.Nodes.Count; i++)
			{
				TreeNode node = treeView1.Nodes[i];
				ISBFile isbFile = node.Tag as ISBFile;
				if (isbFile.Path == textBox1.Text && isbFile.IsFolder)
				{
					DisplayListView(textBox1.Text);
					break;
				}
				else
				{
					//MessageBox.Show("无效路径！");
					//textBox1.Clear();
				}
			}
		}

		//刷新文件目录
		private void refresh_button_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			Goto();
		}


		//搜索文件
		private void keySearch_button_Click(object sender, EventArgs e)
		{
			bool ret;
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
			}
			else
			{
				listView1.ListViewItemSorter = new ListViewStrSort(e.Column, listView1.Columns[e.Column].Tag);//指定排序器并传送列索引与升序降序关键字
			}
			listView1.Sort();//对列表进行自定义排序

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

		private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//client.Delete(ISBFile);
		}


	}
}
