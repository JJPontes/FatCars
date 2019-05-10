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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TextModelo = new System.Windows.Forms.TextBox();
			this.TextPlaca = new System.Windows.Forms.TextBox();
			this.TextCor = new System.Windows.Forms.TextBox();
			this.TextAno = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TextMarca = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TextChassi = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(412, 329);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 30);
			this.button1.TabIndex = 8;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.label1.Location = new System.Drawing.Point(240, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cadastro de Veículos";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "COR";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "PLACA";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "MODELO";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "ANO FAB";
			// 
			// TextModelo
			// 
			this.TextModelo.Location = new System.Drawing.Point(110, 140);
			this.TextModelo.MaxLength = 100;
			this.TextModelo.Name = "TextModelo";
			this.TextModelo.Size = new System.Drawing.Size(412, 20);
			this.TextModelo.TabIndex = 2;
			// 
			// TextPlaca
			// 
			this.TextPlaca.Location = new System.Drawing.Point(110, 200);
			this.TextPlaca.Name = "TextPlaca";
			this.TextPlaca.Size = new System.Drawing.Size(129, 20);
			this.TextPlaca.TabIndex = 4;
			// 
			// TextCor
			// 
			this.TextCor.Location = new System.Drawing.Point(110, 230);
			this.TextCor.Name = "TextCor";
			this.TextCor.Size = new System.Drawing.Size(115, 20);
			this.TextCor.TabIndex = 5;
			// 
			// TextAno
			// 
			this.TextAno.Location = new System.Drawing.Point(110, 260);
			this.TextAno.Name = "TextAno";
			this.TextAno.Size = new System.Drawing.Size(100, 20);
			this.TextAno.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "MARCA";
			// 
			// TextMarca
			// 
			this.TextMarca.Location = new System.Drawing.Point(110, 110);
			this.TextMarca.Name = "TextMarca";
			this.TextMarca.Size = new System.Drawing.Size(412, 20);
			this.TextMarca.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "CHASSI";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// TextChassi
			// 
			this.TextChassi.Location = new System.Drawing.Point(110, 170);
			this.TextChassi.Name = "TextChassi";
			this.TextChassi.Size = new System.Drawing.Size(217, 20);
			this.TextChassi.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(31, 293);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "ANO MOD";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(110, 290);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 7;
			// 
			// FormCadastrarNovoVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 457);
			this.ControlBox = false;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.TextChassi);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TextMarca);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TextAno);
			this.Controls.Add(this.TextCor);
			this.Controls.Add(this.TextPlaca);
			this.Controls.Add(this.TextModelo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "FormCadastrarNovoVeiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Cadastro de Veículos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TextModelo;
		private System.Windows.Forms.TextBox TextPlaca;
		private System.Windows.Forms.TextBox TextCor;
		private System.Windows.Forms.TextBox TextAno;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TextMarca;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TextChassi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
	}
}