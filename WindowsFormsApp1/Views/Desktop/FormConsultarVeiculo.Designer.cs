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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Btn_Editar = new System.Windows.Forms.Button();
			this.pIM1DataSet = new WindowsFormsApp1.PIM1DataSet();
			this.pIM1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pIM1DataSet1 = new WindowsFormsApp1.PIM1DataSet1();
			this.tBCarrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_CarrosTableAdapter = new WindowsFormsApp1.PIM1DataSet1TableAdapters.TB_CarrosTableAdapter();
			this.idCarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chassiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBCarrosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(190, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 42);
			this.label1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.label2.Location = new System.Drawing.Point(257, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Consultar Veiculos";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarroDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.chassiDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tBCarrosBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 113);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(800, 337);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(3, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Filtro";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(257, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(180, 20);
			this.textBox1.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(455, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Pesquisar...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Placa",
            "Chassi"});
			this.ComboFiltro.Location = new System.Drawing.Point(84, 48);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 12;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.49481F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83507F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83506F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83506F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.button1, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.ComboFiltro, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.Btn_Editar, 3, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 106);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// Btn_Editar
			// 
			this.Btn_Editar.Location = new System.Drawing.Point(455, 77);
			this.Btn_Editar.Name = "Btn_Editar";
			this.Btn_Editar.Size = new System.Drawing.Size(75, 23);
			this.Btn_Editar.TabIndex = 13;
			this.Btn_Editar.Text = "Editar...";
			this.Btn_Editar.UseVisualStyleBackColor = true;
			// 
			// pIM1DataSet
			// 
			this.pIM1DataSet.DataSetName = "PIM1DataSet";
			this.pIM1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pIM1DataSetBindingSource
			// 
			this.pIM1DataSetBindingSource.DataSource = this.pIM1DataSet;
			this.pIM1DataSetBindingSource.Position = 0;
			// 
			// pIM1DataSet1
			// 
			this.pIM1DataSet1.DataSetName = "PIM1DataSet1";
			this.pIM1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBCarrosBindingSource
			// 
			this.tBCarrosBindingSource.DataMember = "TB_Carros";
			this.tBCarrosBindingSource.DataSource = this.pIM1DataSet1;
			// 
			// tB_CarrosTableAdapter
			// 
			this.tB_CarrosTableAdapter.ClearBeforeFill = true;
			// 
			// idCarroDataGridViewTextBoxColumn
			// 
			this.idCarroDataGridViewTextBoxColumn.DataPropertyName = "Id_Carro";
			this.idCarroDataGridViewTextBoxColumn.HeaderText = "Id_Carro";
			this.idCarroDataGridViewTextBoxColumn.Name = "idCarroDataGridViewTextBoxColumn";
			this.idCarroDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// marcaDataGridViewTextBoxColumn
			// 
			this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
			this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
			this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
			this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// modeloDataGridViewTextBoxColumn
			// 
			this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
			this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
			this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
			this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// corDataGridViewTextBoxColumn
			// 
			this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
			this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
			this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
			this.corDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// placaDataGridViewTextBoxColumn
			// 
			this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
			this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
			this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
			this.placaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// chassiDataGridViewTextBoxColumn
			// 
			this.chassiDataGridViewTextBoxColumn.DataPropertyName = "Chassi";
			this.chassiDataGridViewTextBoxColumn.HeaderText = "Chassi";
			this.chassiDataGridViewTextBoxColumn.Name = "chassiDataGridViewTextBoxColumn";
			this.chassiDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// FormConsultarVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "FormConsultarVeiculo";
			this.Text = "Consultar Veículo";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormConsultarVeiculo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBCarrosBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button Btn_Editar;
		private System.Windows.Forms.BindingSource pIM1DataSetBindingSource;
		private PIM1DataSet pIM1DataSet;
		private PIM1DataSet1 pIM1DataSet1;
		private System.Windows.Forms.BindingSource tBCarrosBindingSource;
		private PIM1DataSet1TableAdapters.TB_CarrosTableAdapter tB_CarrosTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCarroDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn chassiDataGridViewTextBoxColumn;
	}
}