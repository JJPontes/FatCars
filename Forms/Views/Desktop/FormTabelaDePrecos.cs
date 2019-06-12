using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Views.Desktop
{
	public partial class FormTabelaDePrecos : Form
	{
		public FormTabelaDePrecos()
		{
			InitializeComponent();
		}

		private void txtSegFurtoBatida_Leave(object sender, EventArgs e)
		{
			txtSegFurtoBatida.Text = double.Parse(txtSegFurtoBatida.Text).ToString("F2");
		}

		private void txtSeguroTerceiros_Leave(object sender, EventArgs e)
		{
			txtSeguroTerceiros.Text = double.Parse(txtSeguroTerceiros.Text).ToString("F2");

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{

			Program.Valores.SegFurtoBatida = double.Parse(txtSegFurtoBatida.Text);
			Program.Valores.SegTerceiros = double.Parse(txtSeguroTerceiros.Text);
			MessageBox.Show("Preços Atualizados com Sucesso!");
			this.Hide();
		}

		private void FormTabelaDePrecos_Load(object sender, EventArgs e)
		{
			txtSeguroTerceiros.Text = Program.Valores.SegTerceiros.ToString("F2");
			txtSegFurtoBatida.Text = Program.Valores.SegFurtoBatida.ToString("F2");
			

		}

		private void TxtSegFurtoBatida_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
