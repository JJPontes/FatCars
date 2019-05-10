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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
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
	}
}
