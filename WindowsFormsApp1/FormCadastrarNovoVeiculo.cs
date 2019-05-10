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
	public partial class FormCadastrarNovoVeiculo : Form
	{
		public FormCadastrarNovoVeiculo()
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

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Veiculo Cadastrado com sucesso!");
			limparTextBoxes(this.Controls);


		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
