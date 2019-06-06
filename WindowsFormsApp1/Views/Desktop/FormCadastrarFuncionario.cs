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
	}
}
