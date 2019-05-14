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
			this.efetuarLogoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.reservasDeVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consumoMédioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.quilometragemRodadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sinistrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.multasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEditarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.consultarEditarEstoqueDePeçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçaoToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.relatóriosToolStripMenuItem1,
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
            this.efetuarLogoffToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.administraçaoToolStripMenuItem.Name = "administraçaoToolStripMenuItem";
			this.administraçaoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.administraçaoToolStripMenuItem.Text = "Administração";
			this.administraçaoToolStripMenuItem.Click += new System.EventHandler(this.administraçaoToolStripMenuItem_Click);
			// 
			// efetuarLogoffToolStripMenuItem
			// 
			this.efetuarLogoffToolStripMenuItem.Name = "efetuarLogoffToolStripMenuItem";
			this.efetuarLogoffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.efetuarLogoffToolStripMenuItem.Text = "Efetuar Logoff...";
			this.efetuarLogoffToolStripMenuItem.Click += new System.EventHandler(this.efetuarLogoffToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoVeículoToolStripMenuItem,
            this.cadastrarNovoUsuárioToolStripMenuItem,
            this.cadastrarClienteToolStripMenuItem,
            this.estoqueToolStripMenuItem});
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
			// 
			// cadastrarNovoVeículoToolStripMenuItem
			// 
			this.cadastrarNovoVeículoToolStripMenuItem.Name = "cadastrarNovoVeículoToolStripMenuItem";
			this.cadastrarNovoVeículoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.cadastrarNovoVeículoToolStripMenuItem.Text = "Cadastrar novo veículo...";
			this.cadastrarNovoVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoVeículoToolStripMenuItem_Click);
			// 
			// cadastrarNovoUsuárioToolStripMenuItem
			// 
			this.cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
			this.cadastrarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.cadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar novo usuário...";
			this.cadastrarNovoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoUsuárioToolStripMenuItem_Click);
			// 
			// cadastrarClienteToolStripMenuItem
			// 
			this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
			this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar novo cliente...";
			this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.veiculosToolStripMenuItem,
            this.consultarEditarUsuáriosToolStripMenuItem,
            this.consultarEditarEstoqueDePeçasToolStripMenuItem});
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
			// relatóriosToolStripMenuItem1
			// 
			this.relatóriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasDeVeiculosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
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
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumoMédioToolStripMenuItem1,
            this.quilometragemRodadaToolStripMenuItem,
            this.sinistrosToolStripMenuItem1,
            this.multasToolStripMenuItem1});
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.relatóriosToolStripMenuItem.Text = "Relatórios";
			// 
			// consumoMédioToolStripMenuItem1
			// 
			this.consumoMédioToolStripMenuItem1.Name = "consumoMédioToolStripMenuItem1";
			this.consumoMédioToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
			this.consumoMédioToolStripMenuItem1.Text = "Consumo Médio...";
			// 
			// quilometragemRodadaToolStripMenuItem
			// 
			this.quilometragemRodadaToolStripMenuItem.Name = "quilometragemRodadaToolStripMenuItem";
			this.quilometragemRodadaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.quilometragemRodadaToolStripMenuItem.Text = "Quilometragem Rodada...";
			// 
			// sinistrosToolStripMenuItem1
			// 
			this.sinistrosToolStripMenuItem1.Name = "sinistrosToolStripMenuItem1";
			this.sinistrosToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
			this.sinistrosToolStripMenuItem1.Text = "Sinistros...";
			// 
			// multasToolStripMenuItem1
			// 
			this.multasToolStripMenuItem1.Name = "multasToolStripMenuItem1";
			this.multasToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
			this.multasToolStripMenuItem1.Text = "Multas...";
			// 
			// consultarEditarUsuáriosToolStripMenuItem
			// 
			this.consultarEditarUsuáriosToolStripMenuItem.Name = "consultarEditarUsuáriosToolStripMenuItem";
			this.consultarEditarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEditarUsuáriosToolStripMenuItem.Text = "Consultar/Editar Usuários...";
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ajudaToolStripMenuItem.Text = "Ajuda";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// consultarEditarEstoqueDePeçasToolStripMenuItem
			// 
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Name = "consultarEditarEstoqueDePeçasToolStripMenuItem";
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Text = "Consultar/Editar Estoque de peças...";
			// 
			// estoqueToolStripMenuItem
			// 
			this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
			this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.estoqueToolStripMenuItem.Text = "Cadastrar Peça em estoque...";
			this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
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
		private System.Windows.Forms.ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reservasDeVeiculosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem efetuarLogoffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEditarUsuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEditarEstoqueDePeçasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consumoMédioToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem quilometragemRodadaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sinistrosToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

