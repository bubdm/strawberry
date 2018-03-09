using System;
using System.Collections.Generic;
using System.Windows.Forms;
using strawberry.ui;

namespace strawberry
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Login ln = new Login();
			ln.ShowDialog();
			if (ln.DialogResult == DialogResult.OK)
			{
				Application.Run(new FormMain());
			}
			else
			{
				return;
			}
		}
	}
}
