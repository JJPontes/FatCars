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
	public partial class FormNovaLocacao : Form
	{
		public FormNovaLocacao()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarClientePop formCadastrarClientePop = new Views.Desktop.FormCadastrarClientePop();
			formCadastrarClientePop.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarNovoVeiculoPop formCadastrarNovoVeiculoPop = new Views.Desktop.FormCadastrarNovoVeiculoPop();
			formCadastrarNovoVeiculoPop.Show();
		}
	}
}
