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
	public partial class FormCadastrarNovoVeiculo : Form
	{
		public FormCadastrarNovoVeiculo()
		{
			InitializeComponent();
		}
	

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void FormCadastrarNovoVeiculo_Load(object sender, EventArgs e)
		{
			/*centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;

			label1.Left = (Width - label1.Width) / 2;
			LayoutCadastro.Left = (Width - LayoutCadastro.Width) / 2;
			Btn_Salvar.Left = (Width - Btn_Salvar.Width) / 2;
			*/

		}

		private void FormCadastrarNovoVeiculo_Resize(object sender, EventArgs e)
		{
			/*centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
			*/
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}

		private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void btnLocalizar_Click_1(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}

		private void txtValorDiaria_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtValorDiaria_Leave(object sender, EventArgs e)
		{
			txtValorDiaria.Text = double.Parse(txtValorDiaria.Text).ToString("C");

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			carros carro = new carros();
			carro.ANO_FAB = (int)numericFab.Value;
			carro.ANO_MOD = (int)numericMod.Value;
			carro.PORTAS = (int)numericPortas.Value;
			carro.cor.COR1 = comboCor.Text;
			carro.PLACA = maskedTxtPlaca.Text;
			carro.RENAVAM = txtRenavam.Text;
			carro.CHASSI = txtChassi.Text;
			carro.QUILOMETRAGEM = int.Parse(txtOdometro.Text);



			MessageBox.Show("Veiculo Cadastrado com sucesso!");

		}

		private void checkedOpcionais_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
