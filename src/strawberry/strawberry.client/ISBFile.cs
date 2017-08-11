using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace strawberry.client
{
	public interface ISBFile
	{
		string Name { get; set; }
		string Path { get; set; }
		long Size { get; set; }//byte
		Image Icon { get; set; }
	}
}
