﻿using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{

	public static class Program
	{


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

		public static Precos Valores { get; set; } = new Precos();
			
	}
}

