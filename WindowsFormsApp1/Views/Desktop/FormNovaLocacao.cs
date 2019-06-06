using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormNovaLocacao : Form
	{
		public FormNovaLocacao()
		{
			InitializeComponent();
		}
		DateTime Entrada = new DateTime();
		DateTime Saida = new DateTime();

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
			if (Saida <= Entrada)
			{
				checkSegRoubo.Checked = false;
				MessageBox.Show("Favor entrar com as datas corretamente.");
			}
			else
			{
				if (checkSegRoubo.Checked == true)
				{
					double seg;
					seg = double.Parse(lblValorSeguro.Text) + (Program.Valores.SegFurtoBatida * double.Parse(lblDias.Text));

					lblValorSeguro.Text = seg.ToString("F2");
				}
				else
				{
					double seg;
					seg = double.Parse(lblValorSeguro.Text) - (Program.Valores.SegFurtoBatida * double.Parse(lblDias.Text));
					lblValorSeguro.Text = seg.ToString("F2");
				}
			}
		}

		

		private void lblValorSeguro_Click(object sender, EventArgs e)
		{

		}

		private void checkSegTerceiros_CheckedChanged(object sender, EventArgs e)
		{
			if (Saida <= Entrada)
			{
				checkSegTerceiros.Checked = false;
				MessageBox.Show("Favor entrar com as datas corretamente.");
			}
			else
			{
				if (checkSegTerceiros.Checked == true)
				{
					double seg;
					seg = double.Parse(lblValorSeguro.Text) + (Program.Valores.SegTerceiros * double.Parse(lblDias.Text));
					lblValorSeguro.Text = seg.ToString("F2");
				}
				else
				{
					double seg;
					seg = double.Parse(lblValorSeguro.Text) - (Program.Valores.SegTerceiros * double.Parse(lblDias.Text));
					lblValorSeguro.Text = seg.ToString("F2");
				}
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
			

			Entrada = DateTime.Parse(dateTimeRetirada.Text);
			Saida = DateTime.Parse(dateTimeDevolucao.Text);
			int dif = (Saida.Subtract(Entrada)).Days;
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

		private void FormNovaLocacao_Load(object sender, EventArgs e)
		{
			lblValorSegRoubo.Text ="(" + Program.Valores.SegFurtoBatida.ToString("C") +  "/dia)";
			lblValorSegTerceiros.Text ="(" + Program.Valores.SegTerceiros.ToString("C") + "/dia)";
		}
	}
}
