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
			this.components = new System.ComponentModel.Container();
			this.lblConsultarClientes = new System.Windows.Forms.Label();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnEditar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataSetFat = new WindowsFormsApp1.DataSetFat();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tIPOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOMECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.cargos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.carros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.cliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratocarro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratopneus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratoseguros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratosinistros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratoviagens)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.cor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.endereco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.entradasaida)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.funcionarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.manutencao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.manutencaopeca)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.modelos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.montadora)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.motoristas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.multas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.pecas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.pneus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.telefonecliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.usuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblConsultarClientes
			// 
			this.lblConsultarClientes.AutoSize = true;
			this.lblConsultarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblConsultarClientes.Location = new System.Drawing.Point(284, 0);
			this.lblConsultarClientes.Name = "lblConsultarClientes";
			this.lblConsultarClientes.Size = new System.Drawing.Size(188, 25);
			this.lblConsultarClientes.TabIndex = 2;
			this.lblConsultarClientes.Text = "Consultar Clientes";
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblFiltro.Location = new System.Drawing.Point(3, 45);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(44, 20);
			this.lblFiltro.TabIndex = 3;
			this.lblFiltro.Text = "Filtro";
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(284, 48);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(180, 20);
			this.txtPesquisa.TabIndex = 4;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(478, 48);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 5;
			this.btnPesquisar.Text = "Pesquisar...";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50443F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.05706F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.84715F));
			this.tableLayoutPanel1.Controls.Add(this.lblConsultarClientes, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.ComboFiltro, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtPesquisa, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnPesquisar, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnEditar, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltro, 0, 2);
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
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(478, 77);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar...";
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.tIPOCLIENTEDataGridViewTextBoxColumn,
            this.nOMECLIENTEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.clienteBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(38, 113);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(695, 254);
			this.dataGridView1.TabIndex = 9;
			// 
			// dataSetFat
			// 
			// 
			// cargos
			// 
			this.dataSetFat.cargos.Owner = this;
			// 
			// carros
			// 
			this.dataSetFat.carros.Owner = this;
			// 
			// cliente
			// 
			this.dataSetFat.cliente.Owner = this;
			// 
			// contratocarro
			// 
			this.dataSetFat.contratocarro.Owner = this;
			// 
			// contratopneus
			// 
			this.dataSetFat.contratopneus.Owner = this;
			// 
			// contratos
			// 
			this.dataSetFat.contratos.Owner = this;
			// 
			// contratoseguros
			// 
			this.dataSetFat.contratoseguros.Owner = this;
			// 
			// contratosinistros
			// 
			this.dataSetFat.contratosinistros.Owner = this;
			// 
			// contratoviagens
			// 
			this.dataSetFat.contratoviagens.Owner = this;
			// 
			// cor
			// 
			this.dataSetFat.cor.Owner = this;
			this.dataSetFat.DataSetName = "DataSetFat";
			// 
			// endereco
			// 
			this.dataSetFat.endereco.Owner = this;
			// 
			// entradasaida
			// 
			this.dataSetFat.entradasaida.Owner = this;
			// 
			// funcionarios
			// 
			this.dataSetFat.funcionarios.Owner = this;
			// 
			// manutencao
			// 
			this.dataSetFat.manutencao.Owner = this;
			// 
			// manutencaopeca
			// 
			this.dataSetFat.manutencaopeca.Owner = this;
			// 
			// modelos
			// 
			this.dataSetFat.modelos.Owner = this;
			// 
			// montadora
			// 
			this.dataSetFat.montadora.Owner = this;
			// 
			// motoristas
			// 
			this.dataSetFat.motoristas.Owner = this;
			// 
			// multas
			// 
			this.dataSetFat.multas.Owner = this;
			this.dataSetFat.Name = "dataSetFat";
			// 
			// pecas
			// 
			this.dataSetFat.pecas.Owner = this;
			// 
			// pneus
			// 
			this.dataSetFat.pneus.Owner = this;
			// 
			// telefonecliente
			// 
			this.dataSetFat.telefonecliente.Owner = this;
			// 
			// usuarios
			// 
			this.dataSetFat.usuarios.Owner = this;
			this.dataSetFat.Owner = this;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "cliente";
			this.clienteBindingSource.DataSource = this.dataSetFat;
			// 
			// iDCLIENTEDataGridViewTextBoxColumn
			// 
			this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "IDCLIENTE";
			this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
			// 
			// tIPOCLIENTEDataGridViewTextBoxColumn
			// 
			this.tIPOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "TIPO_CLIENTE";
			this.tIPOCLIENTEDataGridViewTextBoxColumn.HeaderText = "TIPO";
			this.tIPOCLIENTEDataGridViewTextBoxColumn.Name = "tIPOCLIENTEDataGridViewTextBoxColumn";
			// 
			// nOMECLIENTEDataGridViewTextBoxColumn
			// 
			this.nOMECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NOME_CLIENTE";
			this.nOMECLIENTEDataGridViewTextBoxColumn.HeaderText = "NOME";
			this.nOMECLIENTEDataGridViewTextBoxColumn.Name = "nOMECLIENTEDataGridViewTextBoxColumn";
			this.nOMECLIENTEDataGridViewTextBoxColumn.Width = 250;
			// 
			// eMAILDataGridViewTextBoxColumn
			// 
			this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
			this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
			this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
			// 
			// cPFDataGridViewTextBoxColumn
			// 
			this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
			this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
			this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
			// 
			// FormConsultarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 456);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FormConsultarCliente";
			this.Text = "Consultar Clientes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormConsultarCliente_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.cargos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.carros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.cliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratocarro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratopneus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratoseguros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratosinistros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.contratoviagens)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.cor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.endereco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.entradasaida)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.funcionarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.manutencao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.manutencaopeca)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.modelos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.montadora)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.motoristas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.multas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.pecas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.pneus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.telefonecliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat.usuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetFat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblConsultarClientes;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tIPOCLIENTEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nOMECLIENTEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource clienteBindingSource;
		private DataSetFat dataSetFat;
	}
}