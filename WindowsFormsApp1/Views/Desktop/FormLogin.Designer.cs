namespace WindowsFormsApp1
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.BtnLogin = new System.Windows.Forms.Button();
			this.TextUsuario = new System.Windows.Forms.TextBox();
			this.TextSenha = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_SairSistema = new System.Windows.Forms.Button();
			this.LogoFat = new System.Windows.Forms.PictureBox();
			this.LayoutLogin = new System.Windows.Forms.TableLayoutPanel();
			this.LayoutBotoes = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.LogoFat)).BeginInit();
			this.LayoutLogin.SuspendLayout();
			this.LayoutBotoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnLogin
			// 
			this.BtnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.Location = new System.Drawing.Point(133, 3);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(109, 23);
			this.BtnLogin.TabIndex = 3;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.button2_Click);
			// 
			// TextUsuario
			// 
			this.TextUsuario.Location = new System.Drawing.Point(3, 28);
			this.TextUsuario.Name = "TextUsuario";
			this.TextUsuario.Size = new System.Drawing.Size(176, 20);
			this.TextUsuario.TabIndex = 1;
			// 
			// TextSenha
			// 
			this.TextSenha.Location = new System.Drawing.Point(3, 78);
			this.TextSenha.Name = "TextSenha";
			this.TextSenha.Size = new System.Drawing.Size(176, 20);
			this.TextSenha.TabIndex = 2;
			this.TextSenha.UseSystemPasswordChar = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(103, 225);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(117, 13);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Esqueci minha senha...";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Senha";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btn_SairSistema
			// 
			this.btn_SairSistema.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SairSistema.Location = new System.Drawing.Point(3, 3);
			this.btn_SairSistema.Name = "btn_SairSistema";
			this.btn_SairSistema.Size = new System.Drawing.Size(109, 23);
			this.btn_SairSistema.TabIndex = 0;
			this.btn_SairSistema.TabStop = false;
			this.btn_SairSistema.Text = "Sair do sistema";
			this.btn_SairSistema.UseVisualStyleBackColor = true;
			this.btn_SairSistema.Click += new System.EventHandler(this.button1_Click);
			// 
			// LogoFat
			// 
			this.LogoFat.Image = ((System.Drawing.Image)(resources.GetObject("LogoFat.Image")));
			this.LogoFat.Location = new System.Drawing.Point(114, 12);
			this.LogoFat.Name = "LogoFat";
			this.LogoFat.Size = new System.Drawing.Size(100, 50);
			this.LogoFat.TabIndex = 8;
			this.LogoFat.TabStop = false;
			// 
			// LayoutLogin
			// 
			this.LayoutLogin.ColumnCount = 1;
			this.LayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutLogin.Controls.Add(this.TextUsuario, 0, 1);
			this.LayoutLogin.Controls.Add(this.label1, 0, 0);
			this.LayoutLogin.Controls.Add(this.label2, 0, 2);
			this.LayoutLogin.Controls.Add(this.TextSenha, 0, 3);
			this.LayoutLogin.Location = new System.Drawing.Point(67, 78);
			this.LayoutLogin.Name = "LayoutLogin";
			this.LayoutLogin.RowCount = 4;
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.Size = new System.Drawing.Size(200, 100);
			this.LayoutLogin.TabIndex = 9;
			// 
			// LayoutBotoes
			// 
			this.LayoutBotoes.ColumnCount = 2;
			this.LayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutBotoes.Controls.Add(this.btn_SairSistema, 0, 0);
			this.LayoutBotoes.Controls.Add(this.BtnLogin, 1, 0);
			this.LayoutBotoes.Location = new System.Drawing.Point(45, 184);
			this.LayoutBotoes.Name = "LayoutBotoes";
			this.LayoutBotoes.RowCount = 1;
			this.LayoutBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutBotoes.Size = new System.Drawing.Size(261, 38);
			this.LayoutBotoes.TabIndex = 10;
			this.LayoutBotoes.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 279);
			this.Controls.Add(this.LayoutBotoes);
			this.Controls.Add(this.LayoutLogin);
			this.Controls.Add(this.LogoFat);
			this.Controls.Add(this.linkLabel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormLogin";
			this.Text = "FatCars - Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing_1);
			this.Load += new System.EventHandler(this.Login_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormLogin_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.LogoFat)).EndInit();
			this.LayoutLogin.ResumeLayout(false);
			this.LayoutLogin.PerformLayout();
			this.LayoutBotoes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.TextBox TextUsuario;
		private System.Windows.Forms.TextBox TextSenha;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_SairSistema;
		private System.Windows.Forms.PictureBox LogoFat;
		private System.Windows.Forms.TableLayoutPanel LayoutLogin;
		private System.Windows.Forms.TableLayoutPanel LayoutBotoes;
	}
}