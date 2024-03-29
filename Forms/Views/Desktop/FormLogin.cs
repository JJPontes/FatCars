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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
			TxtUsuario.Focus();
		}

		private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormPrincipal form = new FormPrincipal();
			form.Show();
			this.Hide();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			//Centralizando
			ImgLogoFat.Left = (Width - ImgLogoFat.Width) / 2;
			LayoutLogin.Left = (Width - LayoutLogin.Width) / 2;
			LayoutBotoes.Left = (Width - LayoutBotoes.Width) / 2;
			LinkEsqueciSenha.Left = (Width - LinkEsqueciSenha.Width) / 2;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if
				(MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Environment.Exit(0);

			}

		}

		private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			if 
				(MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				Environment.Exit(0);
			}

		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
			{
				if (e.KeyChar == 13)
				{
					FormPrincipal form = new FormPrincipal();
					form.Show();
					this.Hide();
				}
			}
		}

		private void LayoutLogin_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
