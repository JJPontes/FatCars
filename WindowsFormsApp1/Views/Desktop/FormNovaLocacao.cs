using System;
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
	public partial class FormNovaLocacao : Form
	{
		public FormNovaLocacao()
		{
			InitializeComponent();
		}


		private void button2_Click(object sender, EventArgs e)
		{
			FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
			formCadastrarCliente.ControlBox = true;
			formCadastrarCliente.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FormCadastrarNovoVeiculo formCadastrarNovoVeiculo = new FormCadastrarNovoVeiculo();
			formCadastrarNovoVeiculo.ControlBox = true;
			formCadastrarNovoVeiculo.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCliente formBuscaCliente = new Views.Desktop.FormBuscaCliente();
			formBuscaCliente.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}

		private void maskedHoraRetirada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void checkSegRoubo_CheckedChanged(object sender, EventArgs e)
		{
			if (checkSegRoubo.Checked == true)
			{
				double seg;
				seg = double.Parse(lblValorSeguro.Text) + (30 * double.Parse(lblDias.Text));
			
				lblValorSeguro.Text = seg.ToString("F2");
			}
			else
			{
				double seg;
				seg = double.Parse(lblValorSeguro.Text) - (30 * double.Parse(lblDias.Text));
				lblValorSeguro.Text = seg.ToString("F2");
			}
		}

		private void lblValorSeguro_Click(object sender, EventArgs e)
		{

		}

		private void checkSegTerceiros_CheckedChanged(object sender, EventArgs e)
		{
			if (checkSegTerceiros.Checked == true)
			{
				double seg;
				seg = double.Parse(lblValorSeguro.Text) + (30 * double.Parse(lblDias.Text));
				lblValorSeguro.Text = seg.ToString("F2");
			}
			else
			{
				double seg;
				seg = double.Parse(lblValorSeguro.Text) - (30 * double.Parse(lblDias.Text));
				lblValorSeguro.Text = seg.ToString("F2");
			}
		}

		private void txtPagoRetirada_TextChanged(object sender, EventArgs e)
		{
			lblValorPagoRetirada.Text = double.Parse(txtPagoRetirada.Text).ToString("F2");
		}

		private void lblDias_Click(object sender, EventArgs e)
		{

		}

		private void dateTimeDevolucao_ValueChanged(object sender, EventArgs e)
		{
			DateTime entrada = new DateTime();
			DateTime saida = new DateTime();

			entrada = DateTime.Parse(dateTimeRetirada.Text);
			saida = DateTime.Parse(dateTimeDevolucao.Text);
			int dif = (saida.Subtract(entrada)).Days;
			lblDias.Text = dif.ToString();
		}

		private void lblDias_TextChanged(object sender, EventArgs e)
		{
			double dif = (double.Parse(lblDias.Text) * double.Parse(lblValorDiaria.Text));
			lblSubTotal.Text = dif.ToString("F2");
		}

		private void lblValorSeguro_TextChanged(object sender, EventArgs e)
		{
			double total = ((double.Parse(lblValorSeguro.Text)  - double.Parse(lblValorPagoRetirada.Text))
				+ double.Parse(lblSubTotal.Text));

			lblValorRestante.Text = total.ToString("F2");
		}

		private void lblValorPagoRetirada_TextChanged(object sender, EventArgs e)
		{

			double total = ((double.Parse(lblValorSeguro.Text) - double.Parse(lblValorPagoRetirada.Text))
				+ double.Parse(lblSubTotal.Text));

			lblValorRestante.Text = total.ToString("F2");
		}

		private void lblSubTotal_TextChanged(object sender, EventArgs e)
		{

			double total = (((double.Parse(lblValorSeguro.Text) * double.Parse(lblDias.Text)) - double.Parse(lblValorPagoRetirada.Text))
				+ double.Parse(lblSubTotal.Text));

			lblValorRestante.Text = total.ToString("F2");
		}
	}
}
