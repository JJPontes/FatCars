using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

	public static class Program
	{
		public static Exemplo Teste { get; set; }



		/// <summary>

		/// Ponto de entrada principal para o aplicativo.

		/// </summary>

		[STAThread]

		static void Main()
		{


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
		}
	}
}
