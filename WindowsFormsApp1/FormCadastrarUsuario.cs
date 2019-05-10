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
			//Centralizando
			label4.Left = (Width - label4.Width) / 2;
			LayoutCadastrar.Left = (Width - LayoutCadastrar.Width) / 2;
			Btn_Salvar.Left = (Width - Btn_Salvar.Width) / 2;

		}

		private void Btn_Salvar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Usuário Cadastrado com Sucesso!");
			limparTextBoxes(this.Controls);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
		
	}
}
