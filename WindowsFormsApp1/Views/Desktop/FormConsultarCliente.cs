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
	public partial class FormConsultarCliente : Form
	{
		public FormConsultarCliente()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = true;
		}

		private void FormConsultarCliente_Load(object sender, EventArgs e)
		{
			

		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			

		}
	}
}
