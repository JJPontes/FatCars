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
			txtNome.Focus();

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void FormCadastrarCliente_Load(object sender, EventArgs e)
		{

			/*Centralizando

			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height)-50) / 2;
			*/
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
			/*
			 * groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
			*/
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

			if (txtNome.Text != null) Program.Teste.Nome = txtNome.Text;
			if (txtEmail.Text != null) Program.Teste.Email = txtEmail.Text;
			if (txtRG.Text != null) Program.Teste.RG = Convert.ToString(txtRG.Text);
			if (maskedCpf.Text != null) Program.Teste.CPF = Convert.ToString(maskedCpf.Text);
			if (txtNascimento.Text != null) Program.Teste.Nascimento = txtNascimento.Text;
			if (txtProfissao.Text != null) Program.Teste.Profissao = txtProfissao.Text;
			if (txtCep.Text != null) Program.Teste.CEP = txtCep.Text;
			if (txtRua.Text != null) Program.Teste.Rua = txtRua.Text;
			if (txtNumero.Text != null) Program.Teste.Numero = txtNumero.Text;
			if (txtComplemento.Text != null) Program.Teste.Complemento = txtComplemento.Text;
			if (txtCidade.Text != null) Program.Teste.Cidade = txtCidade.Text;
			if (txtEstado.Text != null) Program.Teste.UF = txtEstado.Text;
			if (txtTelRes.Text != null) Program.Teste.TelRes = Convert.ToString(txtTelRes.Text);
			if (txtTelCom.Text != null) Program.Teste.TelCom = Convert.ToString(txtTelCom.Text);
			if (txtTelCel.Text != null) Program.Teste.TelCel = Convert.ToString(txtTelCel.Text);


			MessageBox.Show("Cliente Cadastrado com sucesso!");
			limparTextBoxes(this.Controls);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(" " + Program.Teste.Nome + "\n" + Program.Teste.Nascimento);
		}

		private void Label12_Click(object sender, EventArgs e)
		{
			
		}

		private void RadioPF_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void RadioPj_CheckedChanged(object sender, EventArgs e)
		{
			

		}

		private void TxtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void txtNome_TextChanged(object sender, EventArgs e)
		{
		
		}

		

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void radioPF_CheckedChanged_1(object sender, EventArgs e)
		{
			if (radioPF.Checked == true)
			{
				lblCpf.Text = "CPF";
				maskedCpf.Name = "maskedCPF";
				maskedCpf.Mask = "999.999.999-99";
				lblRG.Text = "RG";
				lblProfissao.Text = "Profissão";
				lblCNH.Show();
				txtCNH.Show();
				lblCategoria.Show();
				txtCategoria.Show();
				lblEmitida.Show();
				maskedEmitida.Show();
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
				lblEmitida.Hide();
				maskedEmitida.Hide();
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
				maskedCpf.Name = "maskedCNPJ";
				maskedCpf.Mask = "99.999.999/9999-99";
				lblRG.Text = "IE";
				lblProfissao.Text = "Contato";
				lblTelCom.Text = "Telefone";
				lblCNH.Hide();
				txtCNH.Hide();
				lblCategoria.Hide();
				txtCategoria.Hide();
				lblEmitida.Hide();
				maskedEmitida.Hide();
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
				lblEmitida.Show();
				maskedEmitida.Show();
				lblValidade.Show();
				maskedValidade.Show();
				lblTelCel.Show();
				txtTelCel.Show();
				lblTelRes.Show();
				txtTelRes.Show();

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCliente formBuscaCliente = new Views.Desktop.FormBuscaCliente();
			formBuscaCliente.Show();
		}
	}
}
