using System;
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
	public partial class FormConsultarVeiculo : Form
	{
		public FormConsultarVeiculo()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = true;
		}

		private void FormConsultarVeiculo_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'pIM1DataSet1.TB_Carros'. Você pode movê-la ou removê-la conforme necessário.
			this.tB_CarrosTableAdapter.Fill(this.pIM1DataSet1.TB_Carros);

		}
	}
}
