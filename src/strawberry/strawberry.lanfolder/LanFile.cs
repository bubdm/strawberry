using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using strawberry.client;
using System.Drawing;

namespace strawberry.lanfolder
{
	public class LanFile : ISBFile
	{
		public string Name { get; set; }
		public string Path { get; set; }
		public long Size { get; set; }//byte
		public Image Icon { get; set; }
		public bool IsFolder { get; set; }
	
	}
}
