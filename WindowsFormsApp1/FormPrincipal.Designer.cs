namespace WindowsFormsApp1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.administraçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.efetuarLogoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarExcluirUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarExcluirVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.reservasDeVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consumoMédioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quilometragemMédiaRodadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sinistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.editarToolStripMenuItem,
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
			this.efetuarLogoffToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.efetuarLogoffToolStripMenuItem.Text = "Efetuar Logoff...";
			this.efetuarLogoffToolStripMenuItem.Click += new System.EventHandler(this.efetuarLogoffToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoVeículoToolStripMenuItem,
            this.cadastrarNovoUsuárioToolStripMenuItem,
            this.cadastrarClienteToolStripMenuItem});
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
			// 
			// cadastrarNovoVeículoToolStripMenuItem
			// 
			this.cadastrarNovoVeículoToolStripMenuItem.Name = "cadastrarNovoVeículoToolStripMenuItem";
			this.cadastrarNovoVeículoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.cadastrarNovoVeículoToolStripMenuItem.Text = "Cadastrar novo veículo...";
			this.cadastrarNovoVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoVeículoToolStripMenuItem_Click);
			// 
			// cadastrarNovoUsuárioToolStripMenuItem
			// 
			this.cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
			this.cadastrarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.cadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar novo usuário...";
			this.cadastrarNovoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoUsuárioToolStripMenuItem_Click);
			// 
			// cadastrarClienteToolStripMenuItem
			// 
			this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
			this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente...";
			this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
			// 
			// editarToolStripMenuItem
			// 
			this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarExcluirUsuáriosToolStripMenuItem,
            this.editarExcluirVeículosToolStripMenuItem});
			this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.editarToolStripMenuItem.Text = "Editar";
			// 
			// editarExcluirUsuáriosToolStripMenuItem
			// 
			this.editarExcluirUsuáriosToolStripMenuItem.Name = "editarExcluirUsuáriosToolStripMenuItem";
			this.editarExcluirUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.editarExcluirUsuáriosToolStripMenuItem.Text = "Editar/Excluir Usuários...";
			this.editarExcluirUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.editarExcluirUsuáriosToolStripMenuItem_Click);
			// 
			// editarExcluirVeículosToolStripMenuItem
			// 
			this.editarExcluirVeículosToolStripMenuItem.Name = "editarExcluirVeículosToolStripMenuItem";
			this.editarExcluirVeículosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.editarExcluirVeículosToolStripMenuItem.Text = "Editar/Excluir Veículos...";
			this.editarExcluirVeículosToolStripMenuItem.Click += new System.EventHandler(this.editarExcluirVeículosToolStripMenuItem_Click);
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.veiculosToolStripMenuItem});
			this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.consultarToolStripMenuItem.Text = "Consultar";
			// 
			// clientesToolStripMenuItem1
			// 
			this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
			this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
			this.clientesToolStripMenuItem1.Text = "Clientes...";
			this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
			// 
			// veiculosToolStripMenuItem
			// 
			this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
			this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.veiculosToolStripMenuItem.Text = "Veiculos...";
			this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
			// 
			// relatóriosToolStripMenuItem1
			// 
			this.relatóriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasDeVeiculosToolStripMenuItem,
            this.consumoMédioToolStripMenuItem,
            this.quilometragemMédiaRodadaToolStripMenuItem,
            this.multasToolStripMenuItem,
            this.sinistrosToolStripMenuItem});
			this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
			this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
			this.relatóriosToolStripMenuItem1.Text = "Relatórios";
			this.relatóriosToolStripMenuItem1.Click += new System.EventHandler(this.relatóriosToolStripMenuItem1_Click);
			// 
			// reservasDeVeiculosToolStripMenuItem
			// 
			this.reservasDeVeiculosToolStripMenuItem.Name = "reservasDeVeiculosToolStripMenuItem";
			this.reservasDeVeiculosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.reservasDeVeiculosToolStripMenuItem.Text = "Reservas de Veiculos";
			this.reservasDeVeiculosToolStripMenuItem.Click += new System.EventHandler(this.reservasDeVeiculosToolStripMenuItem_Click);
			// 
			// consumoMédioToolStripMenuItem
			// 
			this.consumoMédioToolStripMenuItem.Name = "consumoMédioToolStripMenuItem";
			this.consumoMédioToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.consumoMédioToolStripMenuItem.Text = "Consumo médio";
			// 
			// quilometragemMédiaRodadaToolStripMenuItem
			// 
			this.quilometragemMédiaRodadaToolStripMenuItem.Name = "quilometragemMédiaRodadaToolStripMenuItem";
			this.quilometragemMédiaRodadaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.quilometragemMédiaRodadaToolStripMenuItem.Text = "Quilometragem média Rodada";
			// 
			// multasToolStripMenuItem
			// 
			this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
			this.multasToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.multasToolStripMenuItem.Text = "Multas";
			this.multasToolStripMenuItem.Click += new System.EventHandler(this.multasToolStripMenuItem_Click);
			// 
			// sinistrosToolStripMenuItem
			// 
			this.sinistrosToolStripMenuItem.Name = "sinistrosToolStripMenuItem";
			this.sinistrosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.sinistrosToolStripMenuItem.Text = "Sinistros";
			this.sinistrosToolStripMenuItem.Click += new System.EventHandler(this.sinistrosToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
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
		private System.Windows.Forms.ToolStripMenuItem consumoMédioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quilometragemMédiaRodadaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sinistrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarExcluirUsuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarExcluirVeículosToolStripMenuItem;
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
	}
}

