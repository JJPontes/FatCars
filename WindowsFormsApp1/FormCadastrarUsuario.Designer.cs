﻿namespace WindowsFormsApp1
{
	partial class FormCadastrarUsuario
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
			this.Btn_Salvar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.txtCargo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.ComboNivelAcesso = new System.Windows.Forms.ComboBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtSenha_conf = new System.Windows.Forms.TextBox();
			this.LayoutCadastrar = new System.Windows.Forms.TableLayoutPanel();
			this.groupCadastro = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.button1 = new System.Windows.Forms.Button();
			this.LayoutCadastrar.SuspendLayout();
			this.groupCadastro.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Salvar
			// 
			this.Btn_Salvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Btn_Salvar.Location = new System.Drawing.Point(178, 226);
			this.Btn_Salvar.Name = "Btn_Salvar";
			this.Btn_Salvar.Size = new System.Drawing.Size(105, 40);
			this.Btn_Salvar.TabIndex = 8;
			this.Btn_Salvar.Text = "Salvar";
			this.Btn_Salvar.UseVisualStyleBackColor = true;
			this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome de Usuário";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(98, 3);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(266, 20);
			this.txtNome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Senha";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Confirmar Senha";
			// 
			// TxtEmail
			// 
			this.TxtEmail.Location = new System.Drawing.Point(98, 32);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(266, 20);
			this.TxtEmail.TabIndex = 2;
			// 
			// txtCargo
			// 
			this.txtCargo.Location = new System.Drawing.Point(98, 61);
			this.txtCargo.Name = "txtCargo";
			this.txtCargo.Size = new System.Drawing.Size(266, 20);
			this.txtCargo.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(77, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cadastrar Novo Usuário";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Nome";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Cargo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 87);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Nível de acesso";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "E-Mail";
			// 
			// ComboNivelAcesso
			// 
			this.ComboNivelAcesso.FormattingEnabled = true;
			this.ComboNivelAcesso.Items.AddRange(new object[] {
            "Usuário",
            "Supervisor",
            "Administrador"});
			this.ComboNivelAcesso.Location = new System.Drawing.Point(98, 90);
			this.ComboNivelAcesso.Name = "ComboNivelAcesso";
			this.ComboNivelAcesso.Size = new System.Drawing.Size(121, 21);
			this.ComboNivelAcesso.TabIndex = 4;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(98, 119);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(266, 20);
			this.txtUsuario.TabIndex = 5;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(98, 148);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(266, 20);
			this.txtSenha.TabIndex = 6;
			// 
			// txtSenha_conf
			// 
			this.txtSenha_conf.Location = new System.Drawing.Point(98, 177);
			this.txtSenha_conf.Name = "txtSenha_conf";
			this.txtSenha_conf.Size = new System.Drawing.Size(266, 20);
			this.txtSenha_conf.TabIndex = 7;
			// 
			// LayoutCadastrar
			// 
			this.LayoutCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LayoutCadastrar.ColumnCount = 2;
			this.LayoutCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.LayoutCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.LayoutCadastrar.Controls.Add(this.label5, 0, 0);
			this.LayoutCadastrar.Controls.Add(this.txtSenha_conf, 1, 6);
			this.LayoutCadastrar.Controls.Add(this.label8, 0, 1);
			this.LayoutCadastrar.Controls.Add(this.txtSenha, 1, 5);
			this.LayoutCadastrar.Controls.Add(this.label6, 0, 2);
			this.LayoutCadastrar.Controls.Add(this.txtUsuario, 1, 4);
			this.LayoutCadastrar.Controls.Add(this.ComboNivelAcesso, 1, 3);
			this.LayoutCadastrar.Controls.Add(this.label1, 0, 4);
			this.LayoutCadastrar.Controls.Add(this.label2, 0, 5);
			this.LayoutCadastrar.Controls.Add(this.txtCargo, 1, 2);
			this.LayoutCadastrar.Controls.Add(this.label3, 0, 6);
			this.LayoutCadastrar.Controls.Add(this.TxtEmail, 1, 1);
			this.LayoutCadastrar.Controls.Add(this.txtNome, 1, 0);
			this.LayoutCadastrar.Controls.Add(this.label7, 0, 3);
			this.LayoutCadastrar.Controls.Add(this.Btn_Salvar, 1, 8);
			this.LayoutCadastrar.Location = new System.Drawing.Point(17, 65);
			this.LayoutCadastrar.Name = "LayoutCadastrar";
			this.LayoutCadastrar.RowCount = 9;
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutCadastrar.Size = new System.Drawing.Size(364, 272);
			this.LayoutCadastrar.TabIndex = 12;
			// 
			// groupCadastro
			// 
			this.groupCadastro.Controls.Add(this.LayoutCadastrar);
			this.groupCadastro.Controls.Add(this.label4);
			this.groupCadastro.Location = new System.Drawing.Point(149, 12);
			this.groupCadastro.Name = "groupCadastro";
			this.groupCadastro.Size = new System.Drawing.Size(400, 348);
			this.groupCadastro.TabIndex = 13;
			this.groupCadastro.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(577, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormCadastrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupCadastro);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "FormCadastrarUsuario";
			this.Text = "Cadastrar Usuários";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormCadastrarUsuario_Load);
			this.Resize += new System.EventHandler(this.FormCadastrarUsuario_Resize);
			this.LayoutCadastrar.ResumeLayout(false);
			this.LayoutCadastrar.PerformLayout();
			this.groupCadastro.ResumeLayout(false);
			this.groupCadastro.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Btn_Salvar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.TextBox txtCargo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox ComboNivelAcesso;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtSenha_conf;
		private System.Windows.Forms.TableLayoutPanel LayoutCadastrar;
		private System.Windows.Forms.GroupBox groupCadastro;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button button1;
	}
}