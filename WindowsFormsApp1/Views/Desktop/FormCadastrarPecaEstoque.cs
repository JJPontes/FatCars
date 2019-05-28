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
	public partial class FormCadastrarPecaEstoque : Form
	{
		public FormCadastrarPecaEstoque()
		{
			InitializeComponent();
		}

		private void FormCadastrarPecaEstoque_Load(object sender, EventArgs e)
		{
			//centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
		}

		private void FormCadastrarPecaEstoque_Resize(object sender, EventArgs e)
		{
			//centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
		}
	}
}
