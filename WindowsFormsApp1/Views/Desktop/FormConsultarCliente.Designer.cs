﻿namespace WindowsFormsApp1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tBClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pIM1DataSet = new WindowsFormsApp1.PIM1DataSet();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.tB_ClienteTableAdapter = new WindowsFormsApp1.PIM1DataSetTableAdapters.TB_ClienteTableAdapter();
			this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
			this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBClienteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSet)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.fillByToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.label1.Location = new System.Drawing.Point(284, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Consultar Clientes";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(3, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Filtro";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(284, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(180, 20);
			this.textBox1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(478, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Pesquisar...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "CPF"});
			this.ComboFiltro.Location = new System.Drawing.Point(72, 48);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 6;
			this.ComboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tBClienteBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 101);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(800, 355);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.Visible = false;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// iDClienteDataGridViewTextBoxColumn
			// 
			this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
			this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
			this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
			this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rGDataGridViewTextBoxColumn
			// 
			this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
			this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
			this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
			this.rGDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cPFDataGridViewTextBoxColumn
			// 
			this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
			this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
			this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
			this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tBClienteBindingSource
			// 
			this.tBClienteBindingSource.DataMember = "TB_Cliente";
			this.tBClienteBindingSource.DataSource = this.pIM1DataSet;
			// 
			// pIM1DataSet
			// 
			this.pIM1DataSet.DataSetName = "PIM1DataSet";
			this.pIM1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50443F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.05706F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.84715F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.ComboFiltro, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.button1, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.button2, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 107);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(478, 77);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Editar...";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// tB_ClienteTableAdapter
			// 
			this.tB_ClienteTableAdapter.ClearBeforeFill = true;
			// 
			// fillByToolStrip
			// 
			this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
			this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fillByToolStrip.Name = "fillByToolStrip";
			this.fillByToolStrip.Size = new System.Drawing.Size(111, 25);
			this.fillByToolStrip.TabIndex = 9;
			this.fillByToolStrip.Text = "fillByToolStrip";
			// 
			// fillByToolStripButton
			// 
			this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fillByToolStripButton.Name = "fillByToolStripButton";
			this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
			this.fillByToolStripButton.Text = "FillBy";
			this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
			// 
			// FormConsultarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 456);
			this.ControlBox = false;
			this.Controls.Add(this.fillByToolStrip);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormConsultarCliente";
			this.Text = "Consultar Clientes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormConsultarCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBClienteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSet)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.fillByToolStrip.ResumeLayout(false);
			this.fillByToolStrip.PerformLayout();
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button2;
		private PIM1DataSet pIM1DataSet;
		private System.Windows.Forms.BindingSource tBClienteBindingSource;
		private PIM1DataSetTableAdapters.TB_ClienteTableAdapter tB_ClienteTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStrip fillByToolStrip;
		private System.Windows.Forms.ToolStripButton fillByToolStripButton;
	}
}