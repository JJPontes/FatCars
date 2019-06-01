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
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.txtNomePeca = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.lblCadastrarEstoque = new System.Windows.Forms.Label();
			this.groupCadastro.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupCadastro
			// 
			this.groupCadastro.Controls.Add(this.btnSalvar);
			this.groupCadastro.Controls.Add(this.tableLayoutPanel1);
			this.groupCadastro.Controls.Add(this.lblCadastrarEstoque);
			this.groupCadastro.Location = new System.Drawing.Point(42, 67);
			this.groupCadastro.Name = "groupCadastro";
			this.groupCadastro.Size = new System.Drawing.Size(544, 230);
			this.groupCadastro.TabIndex = 0;
			this.groupCadastro.TabStop = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(194, 170);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(105, 40);
			this.btnSalvar.TabIndex = 13;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.125F));
			this.tableLayoutPanel1.Controls.Add(this.txtQuantidade, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtNomePeca, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblNome, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblQuantidade, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 72);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 65);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(100, 35);
			this.txtQuantidade.MaxLength = 4;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(61, 20);
			this.txtQuantidade.TabIndex = 12;
			// 
			// txtNomePeca
			// 
			this.txtNomePeca.Location = new System.Drawing.Point(100, 3);
			this.txtNomePeca.Name = "txtNomePeca";
			this.txtNomePeca.Size = new System.Drawing.Size(315, 20);
			this.txtNomePeca.TabIndex = 10;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(3, 0);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(77, 13);
			this.lblNome.TabIndex = 9;
			this.lblNome.Text = "Nome da peça";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Location = new System.Drawing.Point(3, 32);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
			this.lblQuantidade.TabIndex = 11;
			this.lblQuantidade.Text = "Quantidade";
			// 
			// lblCadastrarEstoque
			// 
			this.lblCadastrarEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCadastrarEstoque.AutoSize = true;
			this.lblCadastrarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastrarEstoque.Location = new System.Drawing.Point(149, 16);
			this.lblCadastrarEstoque.Name = "lblCadastrarEstoque";
			this.lblCadastrarEstoque.Size = new System.Drawing.Size(191, 25);
			this.lblCadastrarEstoque.TabIndex = 8;
			this.lblCadastrarEstoque.Text = "Cadastrar Estoque";
			this.lblCadastrarEstoque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.TextBox txtNomePeca;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblCadastrarEstoque;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}