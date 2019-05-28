namespace WindowsFormsApp1
{
	partial class FormCadastrarPecaEstoque
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
			this.groupCadastro = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNomePeca = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Btn_Salvar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupCadastro.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupCadastro
			// 
			this.groupCadastro.Controls.Add(this.Btn_Salvar);
			this.groupCadastro.Controls.Add(this.tableLayoutPanel1);
			this.groupCadastro.Controls.Add(this.label4);
			this.groupCadastro.Location = new System.Drawing.Point(42, 67);
			this.groupCadastro.Name = "groupCadastro";
			this.groupCadastro.Size = new System.Drawing.Size(544, 230);
			this.groupCadastro.TabIndex = 0;
			this.groupCadastro.TabStop = false;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(149, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(191, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cadastrar Estoque";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Nome da peça";
			// 
			// txtNomePeca
			// 
			this.txtNomePeca.Location = new System.Drawing.Point(100, 3);
			this.txtNomePeca.Name = "txtNomePeca";
			this.txtNomePeca.Size = new System.Drawing.Size(315, 20);
			this.txtNomePeca.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Quantidade";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(100, 35);
			this.textBox1.MaxLength = 4;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(61, 20);
			this.textBox1.TabIndex = 12;
			// 
			// Btn_Salvar
			// 
			this.Btn_Salvar.Location = new System.Drawing.Point(194, 170);
			this.Btn_Salvar.Name = "Btn_Salvar";
			this.Btn_Salvar.Size = new System.Drawing.Size(105, 40);
			this.Btn_Salvar.TabIndex = 13;
			this.Btn_Salvar.Text = "Salvar";
			this.Btn_Salvar.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.125F));
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtNomePeca, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 72);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 65);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// FormCadastrarPecaEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.groupCadastro);
			this.Name = "FormCadastrarPecaEstoque";
			this.Text = "Cadastro de Estoque";
			this.Load += new System.EventHandler(this.FormCadastrarPecaEstoque_Load);
			this.Resize += new System.EventHandler(this.FormCadastrarPecaEstoque_Resize);
			this.groupCadastro.ResumeLayout(false);
			this.groupCadastro.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupCadastro;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomePeca;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Btn_Salvar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}