using Correios.CEP;
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
	public partial class FormCadastrarFuncionario : Form
	{
		public FormCadastrarFuncionario()
		{
			InitializeComponent();
		}

		private void FormCadastrarFuncionario_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaFuncionario buscaFuncionario = new FormBuscaFuncionario();
			buscaFuncionario.Show();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			funcionarios funcionario = new funcionarios();

			funcionario.NOME = txtNome.Text;
			funcionario.CPF = int.Parse(maskedCpf.Text);
			funcionario.RG = int.Parse(txtRG.Text);
			funcionario.EMAIL = txtEmail.Text;
			funcionario.TELRES = txtTelRes.Text;
			funcionario.TELCEL = txtTelCel.Text;
			funcionario.SALARIO = decimal.Parse(txtSalario.Text);
			funcionario.ADMISSAO = DateTime.Parse(maskedDataAdmissao.Text.Replace("/", "-"));
			funcionario.CTPS = int.Parse(txtCTPS.Text);
			funcionario.PIS = int.Parse(txtPIS.Text);
			funcionario.TITELEITOR = int.Parse(txtTitEleitor.Text);
			funcionario.NASCIMENTO = txtNascimento.Text;
			funcionario.CEP = txtCep.Text;
			funcionario.LOGRADOURO = txtRua.Text;
			funcionario.NUM = txtNumero.Text;
			funcionario.COMPLEMENTO = txtComplemento.Text;
			funcionario.BAIRRO = txtBairro.Text;
			funcionario.CIDADE = txtCidade.Text;
			funcionario.UF = txtUF.Text;
		}

		private void groupEndereco_Enter(object sender, EventArgs e)
		{

		}

		private void txtCep_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtCep.Text))
			{
				cepConsulta endereco = correiosCEP.GetAddress(txtCep.Text);

				if (endereco.Cep != null)
				{
					txtRua.Text = endereco.Rua;
					txtCidade.Text = endereco.Cidade;
					txtBairro.Text = endereco.Bairro;
					txtUF.Text = endereco.UF;
				}
				else
				{
					MessageBox.Show("Cep não localizado...");
				}
			}
			else
			{
				MessageBox.Show("Favor inserir um CEP válido.");

			}
		}
	}
}
