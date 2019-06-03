namespace WindowsFormsApp1
{
	partial class FormCadastrarNovoVeiculo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSalvar = new System.Windows.Forms.Button();
			this.lblCadastroDeVeiculos = new System.Windows.Forms.Label();
			this.lblCor = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblFab = new System.Windows.Forms.Label();
			this.lblMontadora = new System.Windows.Forms.Label();
			this.lblChassi = new System.Windows.Forms.Label();
			this.txtChassi = new System.Windows.Forms.TextBox();
			this.lblAnoMod = new System.Windows.Forms.Label();
			this.maskedTxtPlaca = new System.Windows.Forms.MaskedTextBox();
			this.comboCores = new System.Windows.Forms.ComboBox();
			this.comboMontadora = new System.Windows.Forms.ComboBox();
			this.comboModelo = new System.Windows.Forms.ComboBox();
			this.groupCadastro = new System.Windows.Forms.GroupBox();
			this.lblOpcionais = new System.Windows.Forms.Label();
			this.checkedOpcionais = new System.Windows.Forms.CheckedListBox();
			this.txtRenavam = new System.Windows.Forms.TextBox();
			this.lblRenavam = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtObservacoes = new System.Windows.Forms.RichTextBox();
			this.lblPortas = new System.Windows.Forms.Label();
			this.upDownPortas = new System.Windows.Forms.DomainUpDown();
			this.txtAnoMod = new System.Windows.Forms.TextBox();
			this.txtAnoFab = new System.Windows.Forms.TextBox();
			this.groupCadastro.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(441, 336);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(105, 40);
			this.btnSalvar.TabIndex = 8;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblCadastroDeVeiculos
			// 
			this.lblCadastroDeVeiculos.AutoSize = true;
			this.lblCadastroDeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblCadastroDeVeiculos.Location = new System.Drawing.Point(165, 16);
			this.lblCadastroDeVeiculos.Name = "lblCadastroDeVeiculos";
			this.lblCadastroDeVeiculos.Size = new System.Drawing.Size(217, 25);
			this.lblCadastroDeVeiculos.TabIndex = 1;
			this.lblCadastroDeVeiculos.Text = "Cadastro de Veículos";
			this.lblCadastroDeVeiculos.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblCor
			// 
			this.lblCor.AutoSize = true;
			this.lblCor.Location = new System.Drawing.Point(231, 120);
			this.lblCor.Name = "lblCor";
			this.lblCor.Size = new System.Drawing.Size(23, 13);
			this.lblCor.TabIndex = 2;
			this.lblCor.Text = "Cor";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(6, 297);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(34, 13);
			this.lblPlaca.TabIndex = 3;
			this.lblPlaca.Text = "Placa";
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(180, 72);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(42, 13);
			this.lblModelo.TabIndex = 4;
			this.lblModelo.Text = "Modelo";
			// 
			// lblFab
			// 
			this.lblFab.AutoSize = true;
			this.lblFab.Location = new System.Drawing.Point(3, 122);
			this.lblFab.Name = "lblFab";
			this.lblFab.Size = new System.Drawing.Size(47, 13);
			this.lblFab.TabIndex = 5;
			this.lblFab.Text = "Ano Fab";
			// 
			// lblMontadora
			// 
			this.lblMontadora.AutoSize = true;
			this.lblMontadora.Location = new System.Drawing.Point(6, 72);
			this.lblMontadora.Name = "lblMontadora";
			this.lblMontadora.Size = new System.Drawing.Size(58, 13);
			this.lblMontadora.TabIndex = 10;
			this.lblMontadora.Text = "Montadora";
			// 
			// lblChassi
			// 
			this.lblChassi.AutoSize = true;
			this.lblChassi.Location = new System.Drawing.Point(180, 297);
			this.lblChassi.Name = "lblChassi";
			this.lblChassi.Size = new System.Drawing.Size(38, 13);
			this.lblChassi.TabIndex = 12;
			this.lblChassi.Text = "Chassi";
			this.lblChassi.Click += new System.EventHandler(this.label7_Click);
			// 
			// txtChassi
			// 
			this.txtChassi.Location = new System.Drawing.Point(183, 313);
			this.txtChassi.MaxLength = 15;
			this.txtChassi.Name = "txtChassi";
			this.txtChassi.Size = new System.Drawing.Size(188, 20);
			this.txtChassi.TabIndex = 3;
			// 
			// lblAnoMod
			// 
			this.lblAnoMod.AutoSize = true;
			this.lblAnoMod.Location = new System.Drawing.Point(78, 122);
			this.lblAnoMod.Name = "lblAnoMod";
			this.lblAnoMod.Size = new System.Drawing.Size(50, 13);
			this.lblAnoMod.TabIndex = 14;
			this.lblAnoMod.Text = "Ano Mod";
			// 
			// maskedTxtPlaca
			// 
			this.maskedTxtPlaca.Location = new System.Drawing.Point(6, 313);
			this.maskedTxtPlaca.Mask = "???-0000";
			this.maskedTxtPlaca.Name = "maskedTxtPlaca";
			this.maskedTxtPlaca.Size = new System.Drawing.Size(55, 20);
			this.maskedTxtPlaca.TabIndex = 4;
			// 
			// comboCores
			// 
			this.comboCores.FormattingEnabled = true;
			this.comboCores.Items.AddRange(new object[] {
            "PRETO",
            "BRANCO",
            "VERMELHO",
            "VERDE",
            "AZUL"});
			this.comboCores.Location = new System.Drawing.Point(234, 136);
			this.comboCores.Name = "comboCores";
			this.comboCores.Size = new System.Drawing.Size(92, 21);
			this.comboCores.TabIndex = 5;
			this.comboCores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboMontadora
			// 
			this.comboMontadora.FormattingEnabled = true;
			this.comboMontadora.Items.AddRange(new object[] {
            "Audi",
            "Bentley",
            "BMW",
            "Chevrolet",
            "Chrysler",
            "Citroën",
            "Daihatsu",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Ford",
            "General Motors",
            "Honda",
            "Hyundai",
            "JAC Motors",
            "Jaguar",
            "Jeep",
            "KIA",
            "Land-Rover",
            "Lexus",
            "Mazda",
            "Mercedes-Bens",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Porsche",
            "RAM",
            "Renault",
            "Subaru",
            "Suzuki",
            "Tata Motors",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
			this.comboMontadora.Location = new System.Drawing.Point(6, 88);
			this.comboMontadora.Name = "comboMontadora";
			this.comboMontadora.Size = new System.Drawing.Size(161, 21);
			this.comboMontadora.Sorted = true;
			this.comboMontadora.TabIndex = 1;
			this.comboMontadora.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboModelo
			// 
			this.comboModelo.FormattingEnabled = true;
			this.comboModelo.Location = new System.Drawing.Point(180, 88);
			this.comboModelo.Name = "comboModelo";
			this.comboModelo.Size = new System.Drawing.Size(146, 21);
			this.comboModelo.TabIndex = 15;
			// 
			// groupCadastro
			// 
			this.groupCadastro.Controls.Add(this.txtAnoFab);
			this.groupCadastro.Controls.Add(this.txtAnoMod);
			this.groupCadastro.Controls.Add(this.upDownPortas);
			this.groupCadastro.Controls.Add(this.lblOpcionais);
			this.groupCadastro.Controls.Add(this.lblCadastroDeVeiculos);
			this.groupCadastro.Controls.Add(this.checkedOpcionais);
			this.groupCadastro.Controls.Add(this.txtRenavam);
			this.groupCadastro.Controls.Add(this.lblRenavam);
			this.groupCadastro.Controls.Add(this.label9);
			this.groupCadastro.Controls.Add(this.txtObservacoes);
			this.groupCadastro.Controls.Add(this.lblPortas);
			this.groupCadastro.Controls.Add(this.comboMontadora);
			this.groupCadastro.Controls.Add(this.comboCores);
			this.groupCadastro.Controls.Add(this.lblAnoMod);
			this.groupCadastro.Controls.Add(this.lblFab);
			this.groupCadastro.Controls.Add(this.lblMontadora);
			this.groupCadastro.Controls.Add(this.maskedTxtPlaca);
			this.groupCadastro.Controls.Add(this.lblCor);
			this.groupCadastro.Controls.Add(this.lblModelo);
			this.groupCadastro.Controls.Add(this.lblPlaca);
			this.groupCadastro.Controls.Add(this.lblChassi);
			this.groupCadastro.Controls.Add(this.txtChassi);
			this.groupCadastro.Controls.Add(this.btnSalvar);
			this.groupCadastro.Controls.Add(this.comboModelo);
			this.groupCadastro.Location = new System.Drawing.Point(43, 57);
			this.groupCadastro.Name = "groupCadastro";
			this.groupCadastro.Size = new System.Drawing.Size(569, 391);
			this.groupCadastro.TabIndex = 16;
			this.groupCadastro.TabStop = false;
			// 
			// lblOpcionais
			// 
			this.lblOpcionais.AutoSize = true;
			this.lblOpcionais.Location = new System.Drawing.Point(416, 72);
			this.lblOpcionais.Name = "lblOpcionais";
			this.lblOpcionais.Size = new System.Drawing.Size(54, 13);
			this.lblOpcionais.TabIndex = 23;
			this.lblOpcionais.Text = "Opcionais";
			// 
			// checkedOpcionais
			// 
			this.checkedOpcionais.FormattingEnabled = true;
			this.checkedOpcionais.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Direção Hidráulica",
            "Vidro Elétrico",
            "Air Bag",
            "Freios ABS"});
			this.checkedOpcionais.Location = new System.Drawing.Point(416, 91);
			this.checkedOpcionais.Name = "checkedOpcionais";
			this.checkedOpcionais.Size = new System.Drawing.Size(141, 79);
			this.checkedOpcionais.TabIndex = 22;
			// 
			// txtRenavam
			// 
			this.txtRenavam.Location = new System.Drawing.Point(67, 313);
			this.txtRenavam.Name = "txtRenavam";
			this.txtRenavam.Size = new System.Drawing.Size(100, 20);
			this.txtRenavam.TabIndex = 21;
			// 
			// lblRenavam
			// 
			this.lblRenavam.AutoSize = true;
			this.lblRenavam.Location = new System.Drawing.Point(70, 297);
			this.lblRenavam.Name = "lblRenavam";
			this.lblRenavam.Size = new System.Drawing.Size(53, 13);
			this.lblRenavam.TabIndex = 17;
			this.lblRenavam.Text = "Renavam";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 174);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "lblObservacoes";
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.Location = new System.Drawing.Point(6, 193);
			this.txtObservacoes.MaxLength = 250;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(320, 96);
			this.txtObservacoes.TabIndex = 19;
			this.txtObservacoes.Text = "Observações...";
			// 
			// lblPortas
			// 
			this.lblPortas.AutoSize = true;
			this.lblPortas.Location = new System.Drawing.Point(177, 120);
			this.lblPortas.Name = "lblPortas";
			this.lblPortas.Size = new System.Drawing.Size(37, 13);
			this.lblPortas.TabIndex = 16;
			this.lblPortas.Text = "Portas";
			// 
			// upDownPortas
			// 
			this.upDownPortas.Items.Add("2");
			this.upDownPortas.Items.Add("3");
			this.upDownPortas.Items.Add("4");
			this.upDownPortas.Items.Add("5");
			this.upDownPortas.Items.Add("6");
			this.upDownPortas.Items.Add("7");
			this.upDownPortas.Items.Add("8");
			this.upDownPortas.Location = new System.Drawing.Point(180, 138);
			this.upDownPortas.Name = "upDownPortas";
			this.upDownPortas.ReadOnly = true;
			this.upDownPortas.Size = new System.Drawing.Size(42, 20);
			this.upDownPortas.Sorted = true;
			this.upDownPortas.TabIndex = 26;
			// 
			// txtAnoMod
			// 
			this.txtAnoMod.Location = new System.Drawing.Point(81, 138);
			this.txtAnoMod.Name = "txtAnoMod";
			this.txtAnoMod.Size = new System.Drawing.Size(69, 20);
			this.txtAnoMod.TabIndex = 27;
			// 
			// txtAnoFab
			// 
			this.txtAnoFab.Location = new System.Drawing.Point(6, 138);
			this.txtAnoFab.Name = "txtAnoFab";
			this.txtAnoFab.Size = new System.Drawing.Size(69, 20);
			this.txtAnoFab.TabIndex = 28;
			// 
			// FormCadastrarNovoVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.ControlBox = false;
			this.Controls.Add(this.groupCadastro);
			this.Name = "FormCadastrarNovoVeiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Cadastro de Veículos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormCadastrarNovoVeiculo_Load);
			this.Resize += new System.EventHandler(this.FormCadastrarNovoVeiculo_Resize);
			this.groupCadastro.ResumeLayout(false);
			this.groupCadastro.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblCadastroDeVeiculos;
		private System.Windows.Forms.Label lblCor;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Label lblFab;
		private System.Windows.Forms.Label lblMontadora;
		private System.Windows.Forms.Label lblChassi;
		private System.Windows.Forms.TextBox txtChassi;
		private System.Windows.Forms.Label lblAnoMod;
		private System.Windows.Forms.MaskedTextBox maskedTxtPlaca;
		private System.Windows.Forms.ComboBox comboCores;
		private System.Windows.Forms.GroupBox groupCadastro;
		private System.Windows.Forms.ComboBox comboMontadora;
		private System.Windows.Forms.ComboBox comboModelo;
		private System.Windows.Forms.Label lblRenavam;
		private System.Windows.Forms.TextBox txtRenavam;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RichTextBox txtObservacoes;
		private System.Windows.Forms.Label lblPortas;
		private System.Windows.Forms.Label lblOpcionais;
		private System.Windows.Forms.CheckedListBox checkedOpcionais;
		private System.Windows.Forms.DomainUpDown upDownPortas;
		private System.Windows.Forms.TextBox txtAnoFab;
		private System.Windows.Forms.TextBox txtAnoMod;
	}
}