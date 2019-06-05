using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Desktop
{
	public partial class FormControlePatio : Form
	{
		public FormControlePatio()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void txtkmRetorno_TextChanged(object sender, EventArgs e)
		{
			lblKmRodado.Text = (int.Parse(txtkmRetorno.Text) - int.Parse(txtKmSaida.Text)).ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarMotorista formCadastrarMotorista = new FormCadastrarMotorista();
			formCadastrarMotorista.ControlBox = true;
			formCadastrarMotorista.Show();
		}

		private void btnAddCarro_Click(object sender, EventArgs e)
		{
			FormCadastrarNovoVeiculo formCadastrarNovoVeiculo = new FormCadastrarNovoVeiculo();
			formCadastrarNovoVeiculo.ControlBox = true;
			formCadastrarNovoVeiculo.Show();
		}
	}
}
