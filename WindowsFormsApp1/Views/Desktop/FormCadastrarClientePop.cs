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
	public partial class FormCadastrarClientePop : Form
	{
		public FormCadastrarClientePop()
		{
			InitializeComponent();
		}

		private void radioPj_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void radioPF_CheckedChanged(object sender, EventArgs e)
		{
			if (radioPF.Checked == true)
			{
				lblCpf.Text = "CPF";
				lblRG.Text = "RG";
				lblProfissao.Text = "Profissão";
				lblCNH.Show();
				txtCNH.Show();
				lblCategoria.Show();
				txtCategoria.Show();
				lblValidade.Show();
				maskedValidade.Show();
				lblTelCel.Show();
				txtTelCel.Show();
				lblTelRes.Show();
				txtTelRes.Show();
			}

			else
			{
				lblCpf.Text = "CNPJ";
				lblRG.Text = "IE";
				lblProfissao.Text = "Contato";
				lblTelCom.Text = "Telefone";
				lblCNH.Hide();
				txtCNH.Hide();
				lblCategoria.Hide();
				txtCategoria.Hide();
				lblValidade.Hide();
				maskedValidade.Hide();
				lblTelCel.Hide();
				txtTelCel.Hide();
				lblTelRes.Hide();
				txtTelRes.Hide();
			}
		}

		private void radioPj_CheckedChanged_1(object sender, EventArgs e)
		{
			if (radioPj.Checked == true)
			{
				lblCpf.Text = "CNPJ";
				lblRG.Text = "IE";
				lblProfissao.Text = "Contato";
				lblTelCom.Text = "Telefone";
				lblCNH.Hide();
				txtCNH.Hide();
				lblCategoria.Hide();
				txtCategoria.Hide();
				lblValidade.Hide();
				maskedValidade.Hide();
				lblTelCel.Hide();
				txtTelCel.Hide();
				lblTelRes.Hide();
				txtTelRes.Hide();



			}
			else
			{
				lblCpf.Text = "CPF";
				lblRG.Text = "RG";
				lblProfissao.Text = "Profissão";
				lblCNH.Show();
				txtCNH.Show();
				lblCategoria.Show();
				txtCategoria.Show();
				lblValidade.Show();
				maskedValidade.Show();
				lblTelCel.Show();
				txtTelCel.Show();
				lblTelRes.Show();
				txtTelRes.Show();

			}
		}
	}
}
