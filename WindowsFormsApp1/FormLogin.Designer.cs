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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnLogin
			// 
			this.BtnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.Location = new System.Drawing.Point(178, 199);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(109, 23);
			this.BtnLogin.TabIndex = 3;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.button2_Click);
			// 
			// TextUsuario
			// 
			this.TextUsuario.Location = new System.Drawing.Point(73, 99);
			this.TextUsuario.Name = "TextUsuario";
			this.TextUsuario.Size = new System.Drawing.Size(176, 20);
			this.TextUsuario.TabIndex = 1;
			// 
			// TextSenha
			// 
			this.TextSenha.Location = new System.Drawing.Point(73, 160);
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
			this.label1.Location = new System.Drawing.Point(70, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(70, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Senha";
			// 
			// btn_SairSistema
			// 
			this.btn_SairSistema.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SairSistema.Location = new System.Drawing.Point(47, 199);
			this.btn_SairSistema.Name = "btn_SairSistema";
			this.btn_SairSistema.Size = new System.Drawing.Size(109, 23);
			this.btn_SairSistema.TabIndex = 0;
			this.btn_SairSistema.TabStop = false;
			this.btn_SairSistema.Text = "Sair do sistema";
			this.btn_SairSistema.UseVisualStyleBackColor = true;
			this.btn_SairSistema.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(114, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 279);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.TextSenha);
			this.Controls.Add(this.TextUsuario);
			this.Controls.Add(this.BtnLogin);
			this.Controls.Add(this.btn_SairSistema);
			this.Name = "FormLogin";
			this.Text = "FatCars - Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing_1);
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}