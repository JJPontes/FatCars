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
			this.TextUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TextSenha = new System.Windows.Forms.TextBox();
			this.TextConfirmarSenha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.ComboNivelAcesso = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Salvar
			// 
			this.Btn_Salvar.Location = new System.Drawing.Point(359, 341);
			this.Btn_Salvar.Name = "Btn_Salvar";
			this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
			this.Btn_Salvar.TabIndex = 8;
			this.Btn_Salvar.Text = "Salvar";
			this.Btn_Salvar.UseVisualStyleBackColor = true;
			this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Usuário";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// TextUsuario
			// 
			this.TextUsuario.Location = new System.Drawing.Point(94, 3);
			this.TextUsuario.Name = "TextUsuario";
			this.TextUsuario.Size = new System.Drawing.Size(266, 20);
			this.TextUsuario.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Senha";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Confirmar Senha";
			// 
			// TextSenha
			// 
			this.TextSenha.Location = new System.Drawing.Point(94, 37);
			this.TextSenha.Name = "TextSenha";
			this.TextSenha.Size = new System.Drawing.Size(266, 20);
			this.TextSenha.TabIndex = 2;
			// 
			// TextConfirmarSenha
			// 
			this.TextConfirmarSenha.Location = new System.Drawing.Point(94, 71);
			this.TextConfirmarSenha.Name = "TextConfirmarSenha";
			this.TextConfirmarSenha.Size = new System.Drawing.Size(266, 20);
			this.TextConfirmarSenha.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(265, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cadastrar Novo Usuário";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			this.label6.Location = new System.Drawing.Point(3, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Cargo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Nível de acesso";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 34);
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
			this.ComboNivelAcesso.Location = new System.Drawing.Point(94, 105);
			this.ComboNivelAcesso.Name = "ComboNivelAcesso";
			this.ComboNivelAcesso.Size = new System.Drawing.Size(121, 21);
			this.ComboNivelAcesso.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(94, 139);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(266, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(94, 173);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(266, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(94, 207);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(266, 20);
			this.textBox3.TabIndex = 7;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.ComboNivelAcesso, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.TextConfirmarSenha, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.TextSenha, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.TextUsuario, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(161, 80);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 243);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// FormCadastrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Btn_Salvar);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "FormCadastrarUsuario";
			this.Text = "Cadastrar Usuários";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormCadastrarUsuario_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_Salvar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextSenha;
		private System.Windows.Forms.TextBox TextConfirmarSenha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox ComboNivelAcesso;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}