using System;
using System.Windows.Forms;
using Correios.CEP;


namespace WindowsFormsApp1
{
	public partial class FormCadastrarCliente : Form
	{
		public Exemplo Teste { get; private set; }

		public FormCadastrarCliente()

		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void FormCadastrarCliente_Load(object sender, EventArgs e)
		{
			
			//Centralizando
		
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height)-50) / 2;
		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void FormCadastrarCliente_Leave(object sender, EventArgs e)
		{

		}

		

		private void maskedTextBox1_Leave(object sender, EventArgs e)
		{
			
			
		}

		private void txtCep_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtCep_Leave(object sender, EventArgs e)
		{
		

		
		}

		private void txtCep_Leave_1(object sender, EventArgs e)
		{

			if (!string.IsNullOrWhiteSpace(txtCep.Text))
			{
				cepConsulta endereco = correiosCEP.GetAddress(txtCep.Text);

				if (endereco.Cep != null)
				{
					txtRua.Text = endereco.Rua;
					txtCidade.Text = endereco.Cidade;
					txtBairro.Text = endereco.Bairro;
					txtEstado.Text = endereco.UF;
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

		private void FormCadastrarCliente_Resize(object sender, EventArgs e)
		{
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
		}

		private void txtCep_TextChanged_1(object sender, EventArgs e)
		{

		}
		//Metodo para limpar todos os textbox
		private void limparTextBoxes(Control.ControlCollection controles)
		{
			//Faz um laço para todos os controles passados no parâmetro
			foreach (Control ctrl in controles)
			{
				//Se o contorle for um TextBox...
				if (ctrl is TextBox)
				{
					((TextBox)(ctrl)).Text = String.Empty;
				}
			}
		}

		private void Btn_Salvar_Click(object sender, EventArgs e)
		{
			Teste = new Exemplo();

			Teste.Nome = txtNome.Text;
			Teste.Email = txtEmail.Text;
			Teste.RG = Convert.ToString(txtRG.Text);
			Teste.CPF = Convert.ToString(txtCpf.Text);
			Teste.Nascimento = Convert.ToString(txtNascimento.Text);
			Teste.Profissao = txtProfissao.Text;
			Teste.CEP = txtCep.Text;
			Teste.Rua = txtRua.Text;
			Teste.Numero = txtNumero.Text;
			Teste.Complemento = txtComplemento.Text;
			Teste.Cidade = txtCidade.Text;
			Teste.UF = txtEstado.Text;
			Teste.TelRes = Convert.ToString(txtTelRes.Text);
			Teste.TelCom = Convert.ToString(txtTelCom.Text);
			Teste.TelCel = Convert.ToString(txtTelCel.Text);


			MessageBox.Show("Cliente Cadastrado com sucesso!");
			limparTextBoxes(this.Controls);
		}
	}
}
