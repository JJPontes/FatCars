namespace WindowsFormsApp1
{
	partial class FormConsultarCliente
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RgCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPFCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(240, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 33);
			this.label1.TabIndex = 2;
			this.label1.Text = "Consultar Clientes";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(59, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Filtro";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(361, 86);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(486, 86);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Pesquisar...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "CPF"});
			this.ComboFiltro.Location = new System.Drawing.Point(123, 86);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 6;
			this.ComboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NomeCliente,
            this.RgCliente,
            this.CPFCliente});
			this.dataGridView1.Location = new System.Drawing.Point(63, 163);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(654, 150);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// IdCliente
			// 
			this.IdCliente.HeaderText = "ID";
			this.IdCliente.Name = "IdCliente";
			this.IdCliente.ReadOnly = true;
			this.IdCliente.Width = 50;
			// 
			// NomeCliente
			// 
			this.NomeCliente.HeaderText = "Nome";
			this.NomeCliente.Name = "NomeCliente";
			this.NomeCliente.ReadOnly = true;
			this.NomeCliente.Width = 205;
			// 
			// RgCliente
			// 
			this.RgCliente.HeaderText = "RG";
			this.RgCliente.Name = "RgCliente";
			this.RgCliente.ReadOnly = true;
			// 
			// CPFCliente
			// 
			this.CPFCliente.HeaderText = "CPF";
			this.CPFCliente.Name = "CPFCliente";
			this.CPFCliente.ReadOnly = true;
			// 
			// FormConsultarCliente
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
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormConsultarCliente";
			this.Text = "Consultar Clientes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn RgCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPFCliente;
	}
}