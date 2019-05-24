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
	public partial class FormPrincipal : Form
	{

		public FormPrincipal()
		{
			InitializeComponent();
		}

		private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			
		}

		private void opçoesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void administraçaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
		
		}

		private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void cadastrarNovoCarroToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormSobre sobre = new FormSobre();
			sobre.Show();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Environment.Exit(0);
			}

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				Environment.Exit(0);
			}

		}

		private void efetuarLogoffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				FormLogin login = new FormLogin();
				login.Show();
				this.Hide();
			}
	
			
		}

		private void cadastrarNovoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//FormCadastrarNovoVeiculo cadastro = new FormCadastrarNovoVeiculo();
			//cadastro.Show();

			FormCadastrarNovoVeiculo cadastrarNovoVeiculo = new FormCadastrarNovoVeiculo();
			cadastrarNovoVeiculo.MdiParent = this;
			cadastrarNovoVeiculo.Show();

		}

		private void cadastrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCadastrarUsuario cadastrarUsuario = new FormCadastrarUsuario();
			cadastrarUsuario.MdiParent = this;
			cadastrarUsuario.Show();
		}

		private void editarExcluirUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormEditarUsuario editarUsuario = new FormEditarUsuario();
			editarUsuario.MdiParent = this;
			editarUsuario.Show();
		}

		private void editarExcluirVeículosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormEditarVeiculo editarVeiculo = new FormEditarVeiculo();
			editarVeiculo.MdiParent = this;
			editarVeiculo.Show();
		}

		private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FormConsultarCliente consultarCliente = new FormConsultarCliente();
			consultarCliente.MdiParent = this;
			consultarCliente.Show();
		}

		private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormConsultarVeiculo consultarVeiculo = new FormConsultarVeiculo();
			consultarVeiculo.MdiParent = this;
			consultarVeiculo.Show();
		}

		private void reservasDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRelatorioReservas relatorioReservas = new FormRelatorioReservas();
			relatorioReservas.MdiParent = this;
			relatorioReservas.Show();
		}

		private void multasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRelatorioMultas relatorioMultas = new FormRelatorioMultas();
			relatorioMultas.MdiParent = this;
			relatorioMultas.Show();
		}

		private void sinistrosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRelatorioSinistro relatorioSinistro = new FormRelatorioSinistro();
			relatorioSinistro.MdiParent = this;
			relatorioSinistro.Show();
		}

		private void FormPrincipal_Load(object sender, EventArgs e)
		{

			FormPrincipal1 principal1 = new FormPrincipal1();
			principal1.MdiParent = this;
			principal1.Show();
		}

		private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		
			FormCadastrarCliente cadastrarCliente = new FormCadastrarCliente();
			cadastrarCliente.MdiParent = this;
			cadastrarCliente.Show();
			
		}

		private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCadastrarPecaEstoque cadastrarPecaEstoque = new FormCadastrarPecaEstoque();
			cadastrarPecaEstoque.MdiParent = this;
			cadastrarPecaEstoque.Show();

		}

		private void monitorarVeículosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMonitoramentoVeiculo formMonitoramentoVeiculo = new FormMonitoramentoVeiculo();
			formMonitoramentoVeiculo.MdiParent = this;
			formMonitoramentoVeiculo.Show();
		}

		private void consultarComprovantesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormConsultarComprovantes formConsultarComprovantes = new FormConsultarComprovantes();
			formConsultarComprovantes.MdiParent = this;
			formConsultarComprovantes.Show();
		}

		private void RelatóriosToolStripMenuItem2_Click(object sender, EventArgs e)
		{

		}

		private void NovaLocaçaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormNovaLocacao formNovaLocacao = new FormNovaLocacao();
			formNovaLocacao.MdiParent = this;
			formNovaLocacao.Show();
		}
	}
	}

