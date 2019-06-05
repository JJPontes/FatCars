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
	public partial class FormDevolução : Form
	{
		public FormDevolução()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FormCadastrarNovoVeiculo formCadastrarNovoVeiculo = new FormCadastrarNovoVeiculo();
			formCadastrarNovoVeiculo.ControlBox = true;
			formCadastrarNovoVeiculo.TabCadastroVeiculos.SelectTab(3);
			formCadastrarNovoVeiculo.Show();
				
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaLocacao buscaLocacao = new Views.Desktop.FormBuscaLocacao();
			buscaLocacao.Show();
		}
	}
}
