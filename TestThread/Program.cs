/*
 * Created by SharpDevelop.
 * User: Kandi
 * Date: 01.03.2018
 * Time: 10:06
 */
using System;
using System.Windows.Forms;

namespace TestThread
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
