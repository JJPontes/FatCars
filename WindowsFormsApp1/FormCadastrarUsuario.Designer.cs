namespace WindowsFormsApp1
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
			this.SuspendLayout();
			// 
			// Btn_Salvar
			// 
			this.Btn_Salvar.Location = new System.Drawing.Point(283, 242);
			this.Btn_Salvar.Name = "Btn_Salvar";
			this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
			this.Btn_Salvar.TabIndex = 4;
			this.Btn_Salvar.Text = "Salvar";
			this.Btn_Salvar.UseVisualStyleBackColor = true;
			this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Usuário";
			// 
			// TextUsuario
			// 
			this.TextUsuario.Location = new System.Drawing.Point(196, 113);
			this.TextUsuario.Name = "TextUsuario";
			this.TextUsuario.Size = new System.Drawing.Size(266, 20);
			this.TextUsuario.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Senha";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Confirmar Senha";
			// 
			// TextSenha
			// 
			this.TextSenha.Location = new System.Drawing.Point(196, 147);
			this.TextSenha.Name = "TextSenha";
			this.TextSenha.Size = new System.Drawing.Size(266, 20);
			this.TextSenha.TabIndex = 2;
			// 
			// TextConfirmarSenha
			// 
			this.TextConfirmarSenha.Location = new System.Drawing.Point(196, 180);
			this.TextConfirmarSenha.Name = "TextConfirmarSenha";
			this.TextConfirmarSenha.Size = new System.Drawing.Size(266, 20);
			this.TextConfirmarSenha.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(240, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cadastrar Usuário";
			// 
			// FormCadastrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TextConfirmarSenha);
			this.Controls.Add(this.TextSenha);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TextUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn_Salvar);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "FormCadastrarUsuario";
			this.Text = "Cadastrar Usuários";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormCadastrarUsuario_Load);
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
	}
}