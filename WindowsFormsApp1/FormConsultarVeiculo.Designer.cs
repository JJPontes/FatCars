namespace WindowsFormsApp1
{
	partial class FormConsultarVeiculo
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.MarcaCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ModeloCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CorCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlacaCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChassiCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(214, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 42);
			this.label1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(240, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(259, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "Consultar Veiculos";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarcaCarro,
            this.ModeloCarro,
            this.CorCarro,
            this.PlacaCarro,
            this.ChassiCarro});
			this.dataGridView1.Location = new System.Drawing.Point(93, 167);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(651, 150);
			this.dataGridView1.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(89, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Filtro";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(350, 90);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 20);
			this.textBox1.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(516, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Pesquisar...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Placa"});
			this.ComboFiltro.Location = new System.Drawing.Point(153, 90);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 12;
			// 
			// MarcaCarro
			// 
			this.MarcaCarro.HeaderText = "Marca";
			this.MarcaCarro.Name = "MarcaCarro";
			this.MarcaCarro.ReadOnly = true;
			// 
			// ModeloCarro
			// 
			this.ModeloCarro.HeaderText = "Modelo";
			this.ModeloCarro.Name = "ModeloCarro";
			this.ModeloCarro.ReadOnly = true;
			this.ModeloCarro.Width = 205;
			// 
			// CorCarro
			// 
			this.CorCarro.HeaderText = "Cor";
			this.CorCarro.Name = "CorCarro";
			this.CorCarro.ReadOnly = true;
			// 
			// PlacaCarro
			// 
			this.PlacaCarro.HeaderText = "Placa";
			this.PlacaCarro.Name = "PlacaCarro";
			this.PlacaCarro.ReadOnly = true;
			// 
			// ChassiCarro
			// 
			this.ChassiCarro.HeaderText = "Chassi";
			this.ChassiCarro.Name = "ChassiCarro";
			this.ChassiCarro.ReadOnly = true;
			// 
			// FormConsultarVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ComboFiltro);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormConsultarVeiculo";
			this.Text = "Consultar Veículo";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MarcaCarro;
		private System.Windows.Forms.DataGridViewTextBoxColumn ModeloCarro;
		private System.Windows.Forms.DataGridViewTextBoxColumn CorCarro;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCarro;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChassiCarro;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox ComboFiltro;
	}
}