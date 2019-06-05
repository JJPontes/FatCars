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
	public partial class FormBuscaCliente : Form
	{
		public FormBuscaCliente()
		{
			InitializeComponent();
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{

		}

		private void FormBuscaCliente_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'pIM1DataSet.TB_Cliente'. Você pode movê-la ou removê-la conforme necessário.
			this.tB_ClienteTableAdapter.Fill(this.pIM1DataSet.TB_Cliente);

		}
	}
}
