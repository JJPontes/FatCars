﻿namespace WindowsFormsApp1
{
	partial class FormPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.administraçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novaLocaçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controleDePátioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cadastrarNovoUsuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.efetuarLogoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.motoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monitorarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.controleDePneusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monitorarVeículosAtivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viagensAtivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.emitirAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visualizarProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEditarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEditarEstoqueDePeçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarReservasAtivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarComprovantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.reservasDeVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.consumoMédioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quilometragemRodadaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sinistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reservadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçaoToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.monitorarToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.relatóriosToolStripMenuItem1,
            this.relatóriosToolStripMenuItem2,
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(804, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// administraçaoToolStripMenuItem
			// 
			this.administraçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaLocaçaoToolStripMenuItem,
            this.devoluçãoToolStripMenuItem,
            this.controleDePátioToolStripMenuItem,
            this.toolStripSeparator2,
            this.cadastrarNovoUsuárioToolStripMenuItem1,
            this.toolStripSeparator3,
            this.efetuarLogoffToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.administraçaoToolStripMenuItem.Name = "administraçaoToolStripMenuItem";
			this.administraçaoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.administraçaoToolStripMenuItem.Text = "Administração";
			this.administraçaoToolStripMenuItem.Click += new System.EventHandler(this.administraçaoToolStripMenuItem_Click);
			// 
			// novaLocaçaoToolStripMenuItem
			// 
			this.novaLocaçaoToolStripMenuItem.Name = "novaLocaçaoToolStripMenuItem";
			this.novaLocaçaoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.novaLocaçaoToolStripMenuItem.Text = "Nova Locação...";
			this.novaLocaçaoToolStripMenuItem.Click += new System.EventHandler(this.NovaLocaçaoToolStripMenuItem_Click);
			// 
			// devoluçãoToolStripMenuItem
			// 
			this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
			this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.devoluçãoToolStripMenuItem.Text = "Devolução...";
			this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoToolStripMenuItem_Click);
			// 
			// controleDePátioToolStripMenuItem
			// 
			this.controleDePátioToolStripMenuItem.Name = "controleDePátioToolStripMenuItem";
			this.controleDePátioToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.controleDePátioToolStripMenuItem.Text = "Controle de pátio...";
			this.controleDePátioToolStripMenuItem.Click += new System.EventHandler(this.controleDePátioToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
			// 
			// cadastrarNovoUsuárioToolStripMenuItem1
			// 
			this.cadastrarNovoUsuárioToolStripMenuItem1.Name = "cadastrarNovoUsuárioToolStripMenuItem1";
			this.cadastrarNovoUsuárioToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
			this.cadastrarNovoUsuárioToolStripMenuItem1.Text = "Cadastrar Novo Usuário...";
			this.cadastrarNovoUsuárioToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoUsuárioToolStripMenuItem1_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
			// 
			// efetuarLogoffToolStripMenuItem
			// 
			this.efetuarLogoffToolStripMenuItem.Name = "efetuarLogoffToolStripMenuItem";
			this.efetuarLogoffToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.efetuarLogoffToolStripMenuItem.Text = "Efetuar Logoff...";
			this.efetuarLogoffToolStripMenuItem.Click += new System.EventHandler(this.efetuarLogoffToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.cadastrarNovoVeículoToolStripMenuItem,
            this.motoristaToolStripMenuItem});
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.cadastrarToolStripMenuItem.Text = "Cadastros";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
			// 
			// cadastrarClienteToolStripMenuItem
			// 
			this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
			this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.cadastrarClienteToolStripMenuItem.Text = "Clientes...";
			this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
			// 
			// cadastrarNovoVeículoToolStripMenuItem
			// 
			this.cadastrarNovoVeículoToolStripMenuItem.Name = "cadastrarNovoVeículoToolStripMenuItem";
			this.cadastrarNovoVeículoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.cadastrarNovoVeículoToolStripMenuItem.Text = "Veículos...";
			this.cadastrarNovoVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoVeículoToolStripMenuItem_Click);
			// 
			// motoristaToolStripMenuItem
			// 
			this.motoristaToolStripMenuItem.Name = "motoristaToolStripMenuItem";
			this.motoristaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.motoristaToolStripMenuItem.Text = "Motoristas...";
			this.motoristaToolStripMenuItem.Click += new System.EventHandler(this.motoristaToolStripMenuItem_Click);
			// 
			// monitorarToolStripMenuItem
			// 
			this.monitorarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem1,
            this.controleDePneusToolStripMenuItem,
            this.monitorarVeículosAtivosToolStripMenuItem,
            this.viagensAtivasToolStripMenuItem});
			this.monitorarToolStripMenuItem.Name = "monitorarToolStripMenuItem";
			this.monitorarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.monitorarToolStripMenuItem.Text = "Monitorar";
			// 
			// estoqueToolStripMenuItem1
			// 
			this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
			this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
			this.estoqueToolStripMenuItem1.Text = "Estoque...";
			this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
			// 
			// controleDePneusToolStripMenuItem
			// 
			this.controleDePneusToolStripMenuItem.Name = "controleDePneusToolStripMenuItem";
			this.controleDePneusToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.controleDePneusToolStripMenuItem.Text = "Controle de Pneus";
			this.controleDePneusToolStripMenuItem.Click += new System.EventHandler(this.controleDePneusToolStripMenuItem_Click);
			// 
			// monitorarVeículosAtivosToolStripMenuItem
			// 
			this.monitorarVeículosAtivosToolStripMenuItem.Name = "monitorarVeículosAtivosToolStripMenuItem";
			this.monitorarVeículosAtivosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.monitorarVeículosAtivosToolStripMenuItem.Text = "Rastrear Motoristas";
			this.monitorarVeículosAtivosToolStripMenuItem.Click += new System.EventHandler(this.monitorarVeículosAtivosToolStripMenuItem_Click);
			// 
			// viagensAtivasToolStripMenuItem
			// 
			this.viagensAtivasToolStripMenuItem.Name = "viagensAtivasToolStripMenuItem";
			this.viagensAtivasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.viagensAtivasToolStripMenuItem.Text = "Viagens Ativas";
			// 
			// manutençãoToolStripMenuItem
			// 
			this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirAlertaToolStripMenuItem,
            this.registrarAlertaToolStripMenuItem,
            this.visualizarProcessoToolStripMenuItem});
			this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
			this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.manutençãoToolStripMenuItem.Text = "Manutenção";
			// 
			// emitirAlertaToolStripMenuItem
			// 
			this.emitirAlertaToolStripMenuItem.Name = "emitirAlertaToolStripMenuItem";
			this.emitirAlertaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.emitirAlertaToolStripMenuItem.Text = "Emitir Alerta...";
			// 
			// registrarAlertaToolStripMenuItem
			// 
			this.registrarAlertaToolStripMenuItem.Name = "registrarAlertaToolStripMenuItem";
			this.registrarAlertaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.registrarAlertaToolStripMenuItem.Text = "Registrar Alerta...";
			// 
			// visualizarProcessoToolStripMenuItem
			// 
			this.visualizarProcessoToolStripMenuItem.Name = "visualizarProcessoToolStripMenuItem";
			this.visualizarProcessoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.visualizarProcessoToolStripMenuItem.Text = "Visualizar Processo...";
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.veiculosToolStripMenuItem,
            this.consultarEditarUsuáriosToolStripMenuItem,
            this.consultarEditarEstoqueDePeçasToolStripMenuItem,
            this.consultarReservasAtivasToolStripMenuItem,
            this.consultarComprovantesToolStripMenuItem,
            this.consultarEmpresasToolStripMenuItem});
			this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.consultarToolStripMenuItem.Text = "Consultar";
			// 
			// clientesToolStripMenuItem1
			// 
			this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
			this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
			this.clientesToolStripMenuItem1.Text = "Consultar/Editar Clientes...";
			this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
			// 
			// veiculosToolStripMenuItem
			// 
			this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
			this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.veiculosToolStripMenuItem.Text = "Consultar/Editar Veículos...";
			this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
			// 
			// consultarEditarUsuáriosToolStripMenuItem
			// 
			this.consultarEditarUsuáriosToolStripMenuItem.Name = "consultarEditarUsuáriosToolStripMenuItem";
			this.consultarEditarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEditarUsuáriosToolStripMenuItem.Text = "Consultar/Editar Usuários...";
			// 
			// consultarEditarEstoqueDePeçasToolStripMenuItem
			// 
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Name = "consultarEditarEstoqueDePeçasToolStripMenuItem";
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Text = "Consultar/Editar Estoque de peças...";
			// 
			// consultarReservasAtivasToolStripMenuItem
			// 
			this.consultarReservasAtivasToolStripMenuItem.Name = "consultarReservasAtivasToolStripMenuItem";
			this.consultarReservasAtivasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarReservasAtivasToolStripMenuItem.Text = "Consultar Reservas ativas...";
			// 
			// consultarComprovantesToolStripMenuItem
			// 
			this.consultarComprovantesToolStripMenuItem.Name = "consultarComprovantesToolStripMenuItem";
			this.consultarComprovantesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarComprovantesToolStripMenuItem.Text = "Consultar Comprovantes...";
			this.consultarComprovantesToolStripMenuItem.Click += new System.EventHandler(this.consultarComprovantesToolStripMenuItem_Click);
			// 
			// consultarEmpresasToolStripMenuItem
			// 
			this.consultarEmpresasToolStripMenuItem.Name = "consultarEmpresasToolStripMenuItem";
			this.consultarEmpresasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEmpresasToolStripMenuItem.Text = "Consultar Empresas...";
			this.consultarEmpresasToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpresasToolStripMenuItem_Click);
			// 
			// relatóriosToolStripMenuItem1
			// 
			this.relatóriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasDeVeiculosToolStripMenuItem});
			this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
			this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
			this.relatóriosToolStripMenuItem1.Text = "Visualizar";
			this.relatóriosToolStripMenuItem1.Click += new System.EventHandler(this.relatóriosToolStripMenuItem1_Click);
			// 
			// reservasDeVeiculosToolStripMenuItem
			// 
			this.reservasDeVeiculosToolStripMenuItem.Name = "reservasDeVeiculosToolStripMenuItem";
			this.reservasDeVeiculosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.reservasDeVeiculosToolStripMenuItem.Text = "Reservas de Veiculos";
			this.reservasDeVeiculosToolStripMenuItem.Click += new System.EventHandler(this.reservasDeVeiculosToolStripMenuItem_Click);
			// 
			// relatóriosToolStripMenuItem2
			// 
			this.relatóriosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumoMédioToolStripMenuItem,
            this.quilometragemRodadaToolStripMenuItem1,
            this.sinistrosToolStripMenuItem,
            this.multasToolStripMenuItem,
            this.reservadToolStripMenuItem});
			this.relatóriosToolStripMenuItem2.Name = "relatóriosToolStripMenuItem2";
			this.relatóriosToolStripMenuItem2.Size = new System.Drawing.Size(71, 20);
			this.relatóriosToolStripMenuItem2.Text = "Relatórios";
			this.relatóriosToolStripMenuItem2.Click += new System.EventHandler(this.RelatóriosToolStripMenuItem2_Click);
			// 
			// consumoMédioToolStripMenuItem
			// 
			this.consumoMédioToolStripMenuItem.Name = "consumoMédioToolStripMenuItem";
			this.consumoMédioToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.consumoMédioToolStripMenuItem.Text = "Consumo médio";
			// 
			// quilometragemRodadaToolStripMenuItem1
			// 
			this.quilometragemRodadaToolStripMenuItem1.Name = "quilometragemRodadaToolStripMenuItem1";
			this.quilometragemRodadaToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
			this.quilometragemRodadaToolStripMenuItem1.Text = "Quilometragem rodada";
			// 
			// sinistrosToolStripMenuItem
			// 
			this.sinistrosToolStripMenuItem.Name = "sinistrosToolStripMenuItem";
			this.sinistrosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.sinistrosToolStripMenuItem.Text = "Sinistros";
			// 
			// multasToolStripMenuItem
			// 
			this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
			this.multasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.multasToolStripMenuItem.Text = "Multas";
			// 
			// reservadToolStripMenuItem
			// 
			this.reservadToolStripMenuItem.Name = "reservadToolStripMenuItem";
			this.reservadToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.reservadToolStripMenuItem.Text = "Reservas";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.toolStripSeparator1,
            this.sobreToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.ajudaToolStripMenuItem.Text = "Ajuda";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.sobreToolStripMenuItem.Text = "Sobre...";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// cadastrarNovoCarroToolStripMenuItem
			// 
			this.cadastrarNovoCarroToolStripMenuItem.Name = "cadastrarNovoCarroToolStripMenuItem";
			this.cadastrarNovoCarroToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.cadastrarNovoCarroToolStripMenuItem.Text = "Cadastrar novo veículo...";
			this.cadastrarNovoCarroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoCarroToolStripMenuItem_Click);
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 571);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FatCars";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.FormPrincipal_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem administraçaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cadastrarNovoCarroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarNovoVeículoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reservasDeVeiculosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem efetuarLogoffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEditarUsuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEditarEstoqueDePeçasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem monitorarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monitorarVeículosAtivosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarReservasAtivasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarComprovantesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem consumoMédioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quilometragemRodadaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sinistrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novaLocaçaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem motoristaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viagensAtivasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEmpresasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reservadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem emitirAlertaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarAlertaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visualizarProcessoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem controleDePátioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem controleDePneusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
	}
}

