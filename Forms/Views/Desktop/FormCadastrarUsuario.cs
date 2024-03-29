﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
	public partial class FormCadastrarUsuario : Form
	{
		public FormCadastrarUsuario()
		{
		
			InitializeComponent();
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
		private void FormCadastrarUsuario_Load(object sender, EventArgs e)
		{
			
			//centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;

		}

		private void Btn_Salvar_Click(object sender, EventArgs e)
		{
			
			MessageBox.Show("Usuário Cadastrado com Sucesso!");
			limparTextBoxes(this.Controls);
			this.Hide();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void FormCadastrarUsuario_Resize(object sender, EventArgs e)
		{
			//centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void groupCadastro_Enter(object sender, EventArgs e)
		{

		}

		private void btnCadastrarCNH_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarMotorista cadastrarMotorista = new Views.Desktop.FormCadastrarMotorista();
			cadastrarMotorista.ControlBox = true;
			cadastrarMotorista.Show();
		
		}

		private void lblEmail_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaFuncionario buscaFuncionario = new Views.Desktop.FormBuscaFuncionario();
			buscaFuncionario.Show();

		}
	}
}
