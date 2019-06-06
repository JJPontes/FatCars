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
	public partial class FormCadastrarMotorista : Form
	{
		public FormCadastrarMotorista()
		{
			InitializeComponent();
		}

		private void FormCadastrarMotorista_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
			formCadastrarCliente.ControlBox = true;
			formCadastrarCliente.Show();
		}
	}
}
