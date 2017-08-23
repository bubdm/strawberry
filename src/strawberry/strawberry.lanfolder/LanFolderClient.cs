using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using strawberry.client;

namespace strawberry.lanfolder
{
	public class LanFolderClient : ISBClient
	{
		public ISBFile[] List(string fullPath)
		{

			try
			{
				DirectoryInfo dirs = new DirectoryInfo(fullPath); //获得程序所在路径的目录对象

				DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象

				FileInfo[] file = dirs.GetFiles();//获得目录下文件对象

				int dircount = dir.Count();//获得文件夹对象数量

				int filecount = file.Count();//获得文件对象数量
				ISBFile[] fileList = new ISBFile[dircount + filecount];

				//循环文件夹

				for (int i = 0; i < dircount; i++)
				{
					string pathNode = fullPath + "\\" + dir[i].Name;
					LanFile lanFile = new LanFile();
					lanFile.Name = dir[i].Name;
					lanFile.Path = pathNode;
					lanFile.IsFolder = true;
					fileList[i] = lanFile;
				}


				//循环文件

				for (int j = 0; j < filecount; j++)
				{
					LanFile lanFile = new LanFile();
					lanFile.Name = file[j].Name;
					lanFile.Path = fullPath + "\\" + file[j].Name;
					lanFile.IsFolder = false;
					fileList[dircount + j] = lanFile;
				}
				return fileList;

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n出错的位置为：FormMain.PaintTreeView()");
				return null;
			}

		}
	}
}
