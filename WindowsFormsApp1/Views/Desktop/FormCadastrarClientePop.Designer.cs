namespace WindowsFormsApp1.Views.Desktop
{
	partial class FormCadastrarClientePop
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
			this.radioPj = new System.Windows.Forms.RadioButton();
			this.radioPF = new System.Windows.Forms.RadioButton();
			this.LayoutDados = new System.Windows.Forms.TableLayoutPanel();
			this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
			this.txtCpf = new System.Windows.Forms.MaskedTextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblRG = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblNascimento = new System.Windows.Forms.Label();
			this.lblProfissao = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtProfissao = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtTelCom = new System.Windows.Forms.MaskedTextBox();
			this.txtTelRes = new System.Windows.Forms.MaskedTextBox();
			this.txtTelCel = new System.Windows.Forms.MaskedTextBox();
			this.lblTelCel = new System.Windows.Forms.Label();
			this.lblTelCom = new System.Windows.Forms.Label();
			this.lblTelRes = new System.Windows.Forms.Label();
			this.lblCadastrarCliente = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtCep = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			this.lblCep = new System.Windows.Forms.Label();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.LayoutDados.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioPj
			// 
			this.radioPj.AutoSize = true;
			this.radioPj.Location = new System.Drawing.Point(459, 64);
			this.radioPj.Name = "radioPj";
			this.radioPj.Size = new System.Drawing.Size(101, 17);
			this.radioPj.TabIndex = 210;
			this.radioPj.TabStop = true;
			this.radioPj.Text = "Pessoa Jurídica";
			this.radioPj.UseVisualStyleBackColor = true;
			this.radioPj.CheckedChanged += new System.EventHandler(this.radioPj_CheckedChanged);
			// 
			// radioPF
			// 
			this.radioPF.AutoSize = true;
			this.radioPF.Location = new System.Drawing.Point(244, 64);
			this.radioPF.Name = "radioPF";
			this.radioPF.Size = new System.Drawing.Size(92, 17);
			this.radioPF.TabIndex = 209;
			this.radioPF.TabStop = true;
			this.radioPF.Text = "Pessoa Física";
			this.radioPF.UseVisualStyleBackColor = true;
			// 
			// LayoutDados
			// 
			this.LayoutDados.ColumnCount = 4;
			this.LayoutDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.31986F));
			this.LayoutDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.55001F));
			this.LayoutDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.00626F));
			this.LayoutDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.12387F));
			this.LayoutDados.Controls.Add(this.txtNascimento, 3, 1);
			this.LayoutDados.Controls.Add(this.txtCpf, 3, 0);
			this.LayoutDados.Controls.Add(this.lblNome, 0, 0);
			this.LayoutDados.Controls.Add(this.lblEmail, 0, 1);
			this.LayoutDados.Controls.Add(this.lblRG, 0, 2);
			this.LayoutDados.Controls.Add(this.lblCpf, 2, 0);
			this.LayoutDados.Controls.Add(this.lblNascimento, 2, 1);
			this.LayoutDados.Controls.Add(this.lblProfissao, 2, 2);
			this.LayoutDados.Controls.Add(this.txtNome, 1, 0);
			this.LayoutDados.Controls.Add(this.txtProfissao, 3, 2);
			this.LayoutDados.Controls.Add(this.txtEmail, 1, 1);
			this.LayoutDados.Controls.Add(this.txtRG, 1, 2);
			this.LayoutDados.Location = new System.Drawing.Point(29, 106);
			this.LayoutDados.Name = "LayoutDados";
			this.LayoutDados.RowCount = 3;
			this.LayoutDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.LayoutDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.LayoutDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.LayoutDados.Size = new System.Drawing.Size(743, 86);
			this.LayoutDados.TabIndex = 206;
			// 
			// txtNascimento
			// 
			this.txtNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtNascimento.Location = new System.Drawing.Point(536, 31);
			this.txtNascimento.Mask = "00/00/0000";
			this.txtNascimento.Name = "txtNascimento";
			this.txtNascimento.Size = new System.Drawing.Size(71, 20);
			this.txtNascimento.TabIndex = 5;
			this.txtNascimento.ValidatingType = typeof(System.DateTime);
			// 
			// txtCpf
			// 
			this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtCpf.Location = new System.Drawing.Point(536, 3);
			this.txtCpf.Mask = "000.000.000-00";
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(87, 20);
			this.txtCpf.TabIndex = 4;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(3, 0);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 9;
			this.lblNome.Text = "Nome";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(3, 28);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(36, 13);
			this.lblEmail.TabIndex = 10;
			this.lblEmail.Text = "E-Mail";
			// 
			// lblRG
			// 
			this.lblRG.AutoSize = true;
			this.lblRG.Location = new System.Drawing.Point(3, 56);
			this.lblRG.Name = "lblRG";
			this.lblRG.Size = new System.Drawing.Size(23, 13);
			this.lblRG.TabIndex = 11;
			this.lblRG.Text = "RG";
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Location = new System.Drawing.Point(425, 0);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(27, 13);
			this.lblCpf.TabIndex = 19;
			this.lblCpf.Text = "CPF";
			// 
			// lblNascimento
			// 
			this.lblNascimento.AutoSize = true;
			this.lblNascimento.Location = new System.Drawing.Point(425, 28);
			this.lblNascimento.Name = "lblNascimento";
			this.lblNascimento.Size = new System.Drawing.Size(104, 13);
			this.lblNascimento.TabIndex = 18;
			this.lblNascimento.Text = "Data de Nascimento";
			// 
			// lblProfissao
			// 
			this.lblProfissao.AutoSize = true;
			this.lblProfissao.Location = new System.Drawing.Point(425, 56);
			this.lblProfissao.Name = "lblProfissao";
			this.lblProfissao.Size = new System.Drawing.Size(50, 13);
			this.lblProfissao.TabIndex = 20;
			this.lblProfissao.Text = "Profissão";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(87, 3);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(332, 20);
			this.txtNome.TabIndex = 1;
			// 
			// txtProfissao
			// 
			this.txtProfissao.Location = new System.Drawing.Point(536, 59);
			this.txtProfissao.Name = "txtProfissao";
			this.txtProfissao.Size = new System.Drawing.Size(150, 20);
			this.txtProfissao.TabIndex = 6;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(87, 31);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(332, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// txtRG
			// 
			this.txtRG.AccessibleDescription = "Digite seu RG";
			this.txtRG.AccessibleName = "RG";
			this.txtRG.Location = new System.Drawing.Point(87, 59);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(136, 20);
			this.txtRG.TabIndex = 21;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.txtTelCom, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtTelRes, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtTelCel, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.lblTelCel, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.lblTelCom, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.lblTelRes, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(469, 198);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 77);
			this.tableLayoutPanel2.TabIndex = 207;
			// 
			// txtTelCom
			// 
			this.txtTelCom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelCom.Location = new System.Drawing.Point(103, 28);
			this.txtTelCom.Mask = "(00) 0000-0000";
			this.txtTelCom.Name = "txtTelCom";
			this.txtTelCom.Size = new System.Drawing.Size(81, 20);
			this.txtTelCom.TabIndex = 10;
			this.txtTelCom.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtTelRes
			// 
			this.txtTelRes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelRes.Location = new System.Drawing.Point(103, 3);
			this.txtTelRes.Mask = "(00) 0000-0000";
			this.txtTelRes.Name = "txtTelRes";
			this.txtTelRes.Size = new System.Drawing.Size(81, 20);
			this.txtTelRes.TabIndex = 9;
			this.txtTelRes.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtTelCel
			// 
			this.txtTelCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelCel.Location = new System.Drawing.Point(103, 53);
			this.txtTelCel.Mask = "(00) 00000-0000";
			this.txtTelCel.Name = "txtTelCel";
			this.txtTelCel.Size = new System.Drawing.Size(94, 20);
			this.txtTelCel.TabIndex = 11;
			// 
			// lblTelCel
			// 
			this.lblTelCel.AutoSize = true;
			this.lblTelCel.Location = new System.Drawing.Point(3, 50);
			this.lblTelCel.Name = "lblTelCel";
			this.lblTelCel.Size = new System.Drawing.Size(70, 13);
			this.lblTelCel.TabIndex = 23;
			this.lblTelCel.Text = "Telefone Cel.";
			// 
			// lblTelCom
			// 
			this.lblTelCom.AutoSize = true;
			this.lblTelCom.Location = new System.Drawing.Point(3, 25);
			this.lblTelCom.Name = "lblTelCom";
			this.lblTelCom.Size = new System.Drawing.Size(76, 13);
			this.lblTelCom.TabIndex = 22;
			this.lblTelCom.Text = "Telefone Com.";
			// 
			// lblTelRes
			// 
			this.lblTelRes.AutoSize = true;
			this.lblTelRes.Location = new System.Drawing.Point(3, 0);
			this.lblTelRes.Name = "lblTelRes";
			this.lblTelRes.Size = new System.Drawing.Size(74, 13);
			this.lblTelRes.TabIndex = 21;
			this.lblTelRes.Text = "Telefone Res.";
			// 
			// lblCadastrarCliente
			// 
			this.lblCadastrarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCadastrarCliente.AutoSize = true;
			this.lblCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastrarCliente.Location = new System.Drawing.Point(317, 3);
			this.lblCadastrarCliente.Name = "lblCadastrarCliente";
			this.lblCadastrarCliente.Size = new System.Drawing.Size(179, 25);
			this.lblCadastrarCliente.TabIndex = 204;
			this.lblCadastrarCliente.Text = "Cadastrar Cliente";
			this.lblCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.43183F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.56817F));
			this.tableLayoutPanel1.Controls.Add(this.txtCep, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtEstado, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.txtNumero, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtBairro, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.txtCidade, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtRua, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblLogradouro, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtComplemento, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblCep, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblComplemento, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblEstado, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.lblBairro, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblCidade, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblNumero, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 198);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28574F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28574F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28574F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28559F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28574F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28574F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28574F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 201);
			this.tableLayoutPanel1.TabIndex = 208;
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(87, 3);
			this.txtCep.MaxLength = 9;
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(81, 20);
			this.txtCep.TabIndex = 7;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(87, 171);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(173, 20);
			this.txtEstado.TabIndex = 95;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(87, 59);
			this.txtNumero.MaxLength = 5;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(81, 20);
			this.txtNumero.TabIndex = 8;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(87, 143);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(173, 20);
			this.txtBairro.TabIndex = 96;
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(87, 115);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(173, 20);
			this.txtCidade.TabIndex = 97;
			// 
			// txtRua
			// 
			this.txtRua.Location = new System.Drawing.Point(87, 31);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(336, 20);
			this.txtRua.TabIndex = 99;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Location = new System.Drawing.Point(3, 28);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
			this.lblLogradouro.TabIndex = 12;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// txtComplemento
			// 
			this.txtComplemento.Location = new System.Drawing.Point(87, 87);
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(336, 20);
			this.txtComplemento.TabIndex = 98;
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Location = new System.Drawing.Point(3, 0);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(28, 13);
			this.lblCep.TabIndex = 16;
			this.lblCep.Text = "CEP";
			// 
			// lblComplemento
			// 
			this.lblComplemento.AutoSize = true;
			this.lblComplemento.Location = new System.Drawing.Point(3, 84);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(71, 13);
			this.lblComplemento.TabIndex = 17;
			this.lblComplemento.Text = "Complemento";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(3, 168);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(40, 13);
			this.lblEstado.TabIndex = 15;
			this.lblEstado.Text = "Estado";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Location = new System.Drawing.Point(3, 140);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(34, 13);
			this.lblBairro.TabIndex = 13;
			this.lblBairro.Text = "Bairro";
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(3, 112);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(40, 13);
			this.lblCidade.TabIndex = 14;
			this.lblCidade.Text = "Cidade";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(3, 56);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(44, 13);
			this.lblNumero.TabIndex = 18;
			this.lblNumero.Text = "Número";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(392, 407);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(105, 40);
			this.btnSalvar.TabIndex = 205;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// FormCadastrarClientePop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 465);
			this.Controls.Add(this.radioPj);
			this.Controls.Add(this.radioPF);
			this.Controls.Add(this.LayoutDados);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.lblCadastrarCliente);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnSalvar);
			this.Name = "FormCadastrarClientePop";
			this.Text = "Cadastrar novo cliente";
			this.LayoutDados.ResumeLayout(false);
			this.LayoutDados.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioPj;
		private System.Windows.Forms.RadioButton radioPF;
		private System.Windows.Forms.TableLayoutPanel LayoutDados;
		private System.Windows.Forms.MaskedTextBox txtNascimento;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblRG;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblNascimento;
		private System.Windows.Forms.Label lblProfissao;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtProfissao;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.MaskedTextBox txtTelCom;
		private System.Windows.Forms.MaskedTextBox txtTelRes;
		private System.Windows.Forms.MaskedTextBox txtTelCel;
		private System.Windows.Forms.Label lblTelCel;
		private System.Windows.Forms.Label lblTelCom;
		private System.Windows.Forms.Label lblTelRes;
		private System.Windows.Forms.Label lblCadastrarCliente;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtCep;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.TextBox txtComplemento;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Button btnSalvar;
	}
}