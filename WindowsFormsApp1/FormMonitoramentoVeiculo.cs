﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormMonitoramentoVeiculo : Form
	{
		public FormMonitoramentoVeiculo()
		{
			InitializeComponent();
		}

		private void FormMonitoramentoVeiculo_Load(object sender, EventArgs e)
		{
			groupBox1.Left = (Width - groupBox1.Width) / 2;
			groupBox1.Top = ((Height - groupBox1.Height) - 50) / 2;
		}

		private void FormMonitoramentoVeiculo_Resize(object sender, EventArgs e)
		{
			groupBox1.Left = (Width - groupBox1.Width) / 2;
			groupBox1.Top = ((Height - groupBox1.Height) - 50) / 2;
		}
	}
}
