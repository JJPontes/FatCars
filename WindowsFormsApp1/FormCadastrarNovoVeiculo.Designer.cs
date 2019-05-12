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
			this.Btn_Salvar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TextModelo = new System.Windows.Forms.TextBox();
			this.TextAno = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.TextChassi = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.LayoutCadastro = new System.Windows.Forms.TableLayoutPanel();
			this.groupCadastro = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.LayoutCadastro.SuspendLayout();
			this.groupCadastro.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Salvar
			// 
			this.Btn_Salvar.Location = new System.Drawing.Point(107, 345);
			this.Btn_Salvar.Name = "Btn_Salvar";
			this.Btn_Salvar.Size = new System.Drawing.Size(110, 30);
			this.Btn_Salvar.TabIndex = 8;
			this.Btn_Salvar.Text = "Salvar";
			this.Btn_Salvar.UseVisualStyleBackColor = true;
			this.Btn_Salvar.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.label1.Location = new System.Drawing.Point(51, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cadastro de Veículos";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Placa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Modelo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Ano Fab";
			// 
			// TextModelo
			// 
			this.TextModelo.Location = new System.Drawing.Point(72, 42);
			this.TextModelo.MaxLength = 30;
			this.TextModelo.Name = "TextModelo";
			this.TextModelo.Size = new System.Drawing.Size(213, 20);
			this.TextModelo.TabIndex = 2;
			// 
			// TextAno
			// 
			this.TextAno.Location = new System.Drawing.Point(72, 198);
			this.TextAno.MaxLength = 4;
			this.TextAno.Name = "TextAno";
			this.TextAno.Size = new System.Drawing.Size(67, 20);
			this.TextAno.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Marca";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Chassi";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// TextChassi
			// 
			this.TextChassi.Location = new System.Drawing.Point(72, 81);
			this.TextChassi.MaxLength = 15;
			this.TextChassi.Name = "TextChassi";
			this.TextChassi.Size = new System.Drawing.Size(213, 20);
			this.TextChassi.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 234);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Ano Mod";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 237);
			this.textBox1.MaxLength = 4;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(67, 20);
			this.textBox1.TabIndex = 7;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(72, 120);
			this.maskedTextBox1.Mask = "???-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(67, 20);
			this.maskedTextBox1.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "PRETO",
            "BRANCO",
            "VERMELHO",
            "VERDE",
            "AZUL"});
			this.comboBox1.Location = new System.Drawing.Point(72, 159);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(92, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// LayoutCadastro
			// 
			this.LayoutCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LayoutCadastro.ColumnCount = 2;
			this.LayoutCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47719F));
			this.LayoutCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.5228F));
			this.LayoutCadastro.Controls.Add(this.comboBox2, 1, 0);
			this.LayoutCadastro.Controls.Add(this.label6, 0, 0);
			this.LayoutCadastro.Controls.Add(this.textBox1, 1, 6);
			this.LayoutCadastro.Controls.Add(this.comboBox1, 1, 4);
			this.LayoutCadastro.Controls.Add(this.TextAno, 1, 5);
			this.LayoutCadastro.Controls.Add(this.label4, 0, 1);
			this.LayoutCadastro.Controls.Add(this.maskedTextBox1, 1, 3);
			this.LayoutCadastro.Controls.Add(this.label7, 0, 2);
			this.LayoutCadastro.Controls.Add(this.label3, 0, 3);
			this.LayoutCadastro.Controls.Add(this.TextChassi, 1, 2);
			this.LayoutCadastro.Controls.Add(this.label8, 0, 6);
			this.LayoutCadastro.Controls.Add(this.TextModelo, 1, 1);
			this.LayoutCadastro.Controls.Add(this.label2, 0, 4);
			this.LayoutCadastro.Controls.Add(this.label5, 0, 5);
			this.LayoutCadastro.Location = new System.Drawing.Point(6, 57);
			this.LayoutCadastro.Name = "LayoutCadastro";
			this.LayoutCadastro.RowCount = 7;
			this.LayoutCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.LayoutCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.LayoutCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.LayoutCadastro.Size = new System.Drawing.Size(294, 274);
			this.LayoutCadastro.TabIndex = 15;
			// 
			// groupCadastro
			// 
			this.groupCadastro.Controls.Add(this.label1);
			this.groupCadastro.Controls.Add(this.Btn_Salvar);
			this.groupCadastro.Controls.Add(this.LayoutCadastro);
			this.groupCadastro.Location = new System.Drawing.Point(266, 57);
			this.groupCadastro.Name = "groupCadastro";
			this.groupCadastro.Size = new System.Drawing.Size(309, 381);
			this.groupCadastro.TabIndex = 16;
			this.groupCadastro.TabStop = false;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
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
            "Mitsubish",
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
			this.comboBox2.Location = new System.Drawing.Point(72, 3);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(152, 21);
			this.comboBox2.Sorted = true;
			this.comboBox2.TabIndex = 1;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
			this.LayoutCadastro.ResumeLayout(false);
			this.LayoutCadastro.PerformLayout();
			this.groupCadastro.ResumeLayout(false);
			this.groupCadastro.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Btn_Salvar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TextModelo;
		private System.Windows.Forms.TextBox TextAno;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TextChassi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TableLayoutPanel LayoutCadastro;
		private System.Windows.Forms.GroupBox groupCadastro;
		private System.Windows.Forms.ComboBox comboBox2;
	}
}