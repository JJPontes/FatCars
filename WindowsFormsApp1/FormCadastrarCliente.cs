using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using Correios.CorreiosServiceReference;
using Correios.CEP;

namespace WindowsFormsApp1
{
	public partial class FormCadastrarCliente : Form
	{
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
			label4.Left = (Width - label4.Width) / 2;
			LayoutDados.Left = (Width - LayoutDados.Width) / 2;
			//groupBoxEndereco.Left = (Width - groupBoxEndereco.Width) / 2;
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
			cepConsulta address = correiosCEP.GetAddress(txtCep.Text);

			txtRua.Text = address.Rua;
			txtCidade.Text = address.Cidade;
			txtBairro.Text = address.Bairro;
			txtEstado.Text = address.UF;
		}

		
	}
}
