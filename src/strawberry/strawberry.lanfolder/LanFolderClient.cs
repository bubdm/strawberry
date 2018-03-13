using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using strawberry.client;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace strawberry.lanfolder
{
	public class LanFolderClient : ISBClient
	{
		System.Collections.Specialized.StringCollection strcoll = new System.Collections.Specialized.StringCollection();
		public ISBFile[] List(string fullPath)
		{

			try
			{
				DirectoryInfo dirs = new DirectoryInfo(fullPath);       //获得程序所在路径的目录对象
				DirectoryInfo[] dir = dirs.GetDirectories();            //获得目录下文件夹对象
				FileInfo[] file = dirs.GetFiles();                      //获得目录下文件对象
				int dircount = dir.Count();                             //获得文件夹对象数量
				int filecount = file.Count();                           //获得文件对象数量
				ISBFile[] fileList = new ISBFile[dircount + filecount]; //文件信息List

				string[] filespath = Directory.GetFiles(fullPath);
				FileInfoList fileInfoList = new FileInfoList(filespath);
				Dictionary<string, int> dict = new Dictionary<string, int>();

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

				foreach (FileInfoWithIcon fileInf in fileInfoList.list)
				{
					dict.Add(fileInf.fileInfo.Name, fileInf.iconIndex);
				}

				//循环文件
				for (int j = 0; j < filecount; j++)
				{
					LanFile lanFile = new LanFile();
					lanFile.Name = file[j].Name;
					foreach (string key in dict.Keys)
					{
						if (key == file[j].Name)
						{
							lanFile.ImageIndex = dict[key];
							break;
						}
					}
					lanFile.Path = fullPath + "\\" + file[j].Name;
					lanFile.Size = file[j].Length;
					lanFile.UpdateTime = file[j].LastWriteTime.ToString();
					lanFile.IsFolder = false;
					fileList[dircount + j] = lanFile;
				}
				return fileList;
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n出错的位置为：LanFolderClient.List()");
				return null;
			}

		}

		public void Rename(string filePath, string newFilename)
		{
			Computer MyComputer = new Computer();
			MyComputer.FileSystem.RenameFile(filePath, newFilename);
		}

		public void Delete(string path)
		{
			FileAttributes attr = File.GetAttributes(path);
			if (attr == FileAttributes.Directory)
			{
				Directory.Delete(path, true);
			}
			else
			{
				File.Delete(path);
			}
		}

		public void Open(string filePath)
		{
			System.Diagnostics.Process.Start(filePath);
		}

		public void Copy(string filePath)
		{
			strcoll.Clear();
			strcoll.Add(filePath);
			Clipboard.SetFileDropList(strcoll);
		}

		public void Move(string dirPath)
		{
			strcoll = Clipboard.GetFileDropList();
			if (strcoll.Count != 0)
			{
				string filePath = strcoll[0];
				dirPath = Path.Combine(dirPath, Path.GetFileName(filePath));
				if (filePath != dirPath)
				{
					System.IO.File.Copy(filePath, dirPath, true);
				}
				else
				{
					string extension = System.IO.Path.GetExtension(filePath);
					string path = filePath.Replace(filePath.Substring(filePath.IndexOf(".")), "");
					dirPath = path + "1" + extension;
					System.IO.File.Copy(filePath, dirPath, true);
				}
			}
		}
	}
}
