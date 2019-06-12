namespace Forms.Views.Desktop
{
	partial class FormCadastrarFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarFuncionario));
			this.button2 = new System.Windows.Forms.Button();
			this.groupEndereco = new System.Windows.Forms.GroupBox();
			this.txtCep = new System.Windows.Forms.TextBox();
			this.lblCep = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtUF = new System.Windows.Forms.TextBox();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.maskedEmitidaCNH = new System.Windows.Forms.MaskedTextBox();
			this.lblEmitida = new System.Windows.Forms.Label();
			this.txtTelCel = new System.Windows.Forms.MaskedTextBox();
			this.lblTelCel = new System.Windows.Forms.Label();
			this.maskedValidadeCNH = new System.Windows.Forms.MaskedTextBox();
			this.txtTelRes = new System.Windows.Forms.MaskedTextBox();
			this.lblTelRes = new System.Windows.Forms.Label();
			this.lblValidade = new System.Windows.Forms.Label();
			this.lblProfissao = new System.Windows.Forms.Label();
			this.txtCategoriaCNH = new System.Windows.Forms.TextBox();
			this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.txtCNH = new System.Windows.Forms.TextBox();
			this.lblNascimento = new System.Windows.Forms.Label();
			this.lblCNH = new System.Windows.Forms.Label();
			this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblRG = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCTPS = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPIS = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTitEleitor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSalario = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textNrRegistro = new System.Windows.Forms.TextBox();
			this.maskedDataAdmissao = new System.Windows.Forms.MaskedTextBox();
			this.maskedDataDemissao = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboCargo = new System.Windows.Forms.ComboBox();
			this.groupEndereco.SuspendLayout();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.AccessibleName = "Buscar Cliente";
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Image = global::Forms.Properties.Resources.lupa;
			this.button2.Location = new System.Drawing.Point(488, 39);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(31, 20);
			this.button2.TabIndex = 272;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupEndereco
			// 
			this.groupEndereco.Controls.Add(this.txtCep);
			this.groupEndereco.Controls.Add(this.lblCep);
			this.groupEndereco.Controls.Add(this.lblNumero);
			this.groupEndereco.Controls.Add(this.txtUF);
			this.groupEndereco.Controls.Add(this.lblLogradouro);
			this.groupEndereco.Controls.Add(this.txtRua);
			this.groupEndereco.Controls.Add(this.lblEstado);
			this.groupEndereco.Controls.Add(this.lblComplemento);
			this.groupEndereco.Controls.Add(this.txtBairro);
			this.groupEndereco.Controls.Add(this.lblCidade);
			this.groupEndereco.Controls.Add(this.txtNumero);
			this.groupEndereco.Controls.Add(this.txtComplemento);
			this.groupEndereco.Controls.Add(this.txtCidade);
			this.groupEndereco.Controls.Add(this.lblBairro);
			this.groupEndereco.Location = new System.Drawing.Point(28, 194);
			this.groupEndereco.Name = "groupEndereco";
			this.groupEndereco.Size = new System.Drawing.Size(729, 115);
			this.groupEndereco.TabIndex = 19;
			this.groupEndereco.TabStop = false;
			this.groupEndereco.Text = "Endereço";
			this.groupEndereco.Enter += new System.EventHandler(this.groupEndereco_Enter);
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(16, 39);
			this.txtCep.MaxLength = 9;
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(81, 20);
			this.txtCep.TabIndex = 20;
			this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Location = new System.Drawing.Point(13, 23);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(28, 13);
			this.lblCep.TabIndex = 16;
			this.lblCep.Text = "CEP";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(439, 23);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(44, 13);
			this.lblNumero.TabIndex = 18;
			this.lblNumero.Text = "Número";
			// 
			// txtUF
			// 
			this.txtUF.Location = new System.Drawing.Point(282, 78);
			this.txtUF.Name = "txtUF";
			this.txtUF.Size = new System.Drawing.Size(34, 20);
			this.txtUF.TabIndex = 95;
			this.txtUF.TabStop = false;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Location = new System.Drawing.Point(101, 23);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
			this.lblLogradouro.TabIndex = 12;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// txtRua
			// 
			this.txtRua.Location = new System.Drawing.Point(104, 39);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(332, 20);
			this.txtRua.TabIndex = 99;
			this.txtRua.TabStop = false;
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(279, 62);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(21, 13);
			this.lblEstado.TabIndex = 15;
			this.lblEstado.Text = "UF";
			// 
			// lblComplemento
			// 
			this.lblComplemento.AutoSize = true;
			this.lblComplemento.Location = new System.Drawing.Point(518, 23);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(71, 13);
			this.lblComplemento.TabIndex = 17;
			this.lblComplemento.Text = "Complemento";
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(16, 78);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(73, 20);
			this.txtBairro.TabIndex = 96;
			this.txtBairro.TabStop = false;
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(100, 62);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(40, 13);
			this.lblCidade.TabIndex = 14;
			this.lblCidade.Text = "Cidade";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(443, 39);
			this.txtNumero.MaxLength = 5;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(70, 20);
			this.txtNumero.TabIndex = 21;
			// 
			// txtComplemento
			// 
			this.txtComplemento.Location = new System.Drawing.Point(521, 39);
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(202, 20);
			this.txtComplemento.TabIndex = 98;
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(103, 78);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(173, 20);
			this.txtCidade.TabIndex = 97;
			this.txtCidade.TabStop = false;
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Location = new System.Drawing.Point(13, 62);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(34, 13);
			this.lblBairro.TabIndex = 13;
			this.lblBairro.Text = "Bairro";
			// 
			// maskedEmitidaCNH
			// 
			this.maskedEmitidaCNH.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.maskedEmitidaCNH.HidePromptOnLeave = true;
			this.maskedEmitidaCNH.Location = new System.Drawing.Point(372, 160);
			this.maskedEmitidaCNH.Mask = "00/00/0000";
			this.maskedEmitidaCNH.Name = "maskedEmitidaCNH";
			this.maskedEmitidaCNH.Size = new System.Drawing.Size(75, 20);
			this.maskedEmitidaCNH.TabIndex = 17;
			this.maskedEmitidaCNH.ValidatingType = typeof(System.DateTime);
			// 
			// lblEmitida
			// 
			this.lblEmitida.AutoSize = true;
			this.lblEmitida.Location = new System.Drawing.Point(369, 144);
			this.lblEmitida.Name = "lblEmitida";
			this.lblEmitida.Size = new System.Drawing.Size(61, 13);
			this.lblEmitida.TabIndex = 269;
			this.lblEmitida.Text = "Emitida em:";
			// 
			// txtTelCel
			// 
			this.txtTelCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelCel.HidePromptOnLeave = true;
			this.txtTelCel.Location = new System.Drawing.Point(471, 79);
			this.txtTelCel.Mask = "(00) 00000-0000";
			this.txtTelCel.Name = "txtTelCel";
			this.txtTelCel.Size = new System.Drawing.Size(94, 20);
			this.txtTelCel.TabIndex = 6;
			// 
			// lblTelCel
			// 
			this.lblTelCel.AutoSize = true;
			this.lblTelCel.Location = new System.Drawing.Point(468, 63);
			this.lblTelCel.Name = "lblTelCel";
			this.lblTelCel.Size = new System.Drawing.Size(70, 13);
			this.lblTelCel.TabIndex = 262;
			this.lblTelCel.Text = "Telefone Cel.";
			// 
			// maskedValidadeCNH
			// 
			this.maskedValidadeCNH.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.maskedValidadeCNH.HidePromptOnLeave = true;
			this.maskedValidadeCNH.Location = new System.Drawing.Point(456, 160);
			this.maskedValidadeCNH.Mask = "00/00/0000";
			this.maskedValidadeCNH.Name = "maskedValidadeCNH";
			this.maskedValidadeCNH.Size = new System.Drawing.Size(75, 20);
			this.maskedValidadeCNH.TabIndex = 18;
			this.maskedValidadeCNH.ValidatingType = typeof(System.DateTime);
			// 
			// txtTelRes
			// 
			this.txtTelRes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelRes.HidePromptOnLeave = true;
			this.txtTelRes.Location = new System.Drawing.Point(370, 79);
			this.txtTelRes.Mask = "(00) 0000-0000";
			this.txtTelRes.Name = "txtTelRes";
			this.txtTelRes.Size = new System.Drawing.Size(81, 20);
			this.txtTelRes.TabIndex = 5;
			this.txtTelRes.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblTelRes
			// 
			this.lblTelRes.AutoSize = true;
			this.lblTelRes.Location = new System.Drawing.Point(367, 63);
			this.lblTelRes.Name = "lblTelRes";
			this.lblTelRes.Size = new System.Drawing.Size(74, 13);
			this.lblTelRes.TabIndex = 260;
			this.lblTelRes.Text = "Telefone Res.";
			// 
			// lblValidade
			// 
			this.lblValidade.AutoSize = true;
			this.lblValidade.Location = new System.Drawing.Point(453, 144);
			this.lblValidade.Name = "lblValidade";
			this.lblValidade.Size = new System.Drawing.Size(51, 13);
			this.lblValidade.TabIndex = 265;
			this.lblValidade.Text = "Validade:";
			// 
			// lblProfissao
			// 
			this.lblProfissao.AutoSize = true;
			this.lblProfissao.Location = new System.Drawing.Point(25, 102);
			this.lblProfissao.Name = "lblProfissao";
			this.lblProfissao.Size = new System.Drawing.Size(78, 13);
			this.lblProfissao.TabIndex = 258;
			this.lblProfissao.Text = "Data Admissão";
			// 
			// txtCategoriaCNH
			// 
			this.txtCategoriaCNH.Location = new System.Drawing.Point(322, 160);
			this.txtCategoriaCNH.MaxLength = 2;
			this.txtCategoriaCNH.Name = "txtCategoriaCNH";
			this.txtCategoriaCNH.Size = new System.Drawing.Size(39, 20);
			this.txtCategoriaCNH.TabIndex = 16;
			// 
			// txtNascimento
			// 
			this.txtNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtNascimento.HidePromptOnLeave = true;
			this.txtNascimento.Location = new System.Drawing.Point(657, 121);
			this.txtNascimento.Mask = "00/00/0000";
			this.txtNascimento.Name = "txtNascimento";
			this.txtNascimento.Size = new System.Drawing.Size(71, 20);
			this.txtNascimento.TabIndex = 13;
			this.txtNascimento.ValidatingType = typeof(System.DateTime);
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(315, 144);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(55, 13);
			this.lblCategoria.TabIndex = 267;
			this.lblCategoria.Text = "Categoria:";
			// 
			// txtCNH
			// 
			this.txtCNH.Location = new System.Drawing.Point(111, 160);
			this.txtCNH.Name = "txtCNH";
			this.txtCNH.Size = new System.Drawing.Size(205, 20);
			this.txtCNH.TabIndex = 15;
			// 
			// lblNascimento
			// 
			this.lblNascimento.AutoSize = true;
			this.lblNascimento.Location = new System.Drawing.Point(654, 105);
			this.lblNascimento.Name = "lblNascimento";
			this.lblNascimento.Size = new System.Drawing.Size(80, 13);
			this.lblNascimento.TabIndex = 256;
			this.lblNascimento.Text = "Dt. Nascimento";
			// 
			// lblCNH
			// 
			this.lblCNH.AutoSize = true;
			this.lblCNH.Location = new System.Drawing.Point(108, 144);
			this.lblCNH.Name = "lblCNH";
			this.lblCNH.Size = new System.Drawing.Size(88, 13);
			this.lblCNH.TabIndex = 263;
			this.lblCNH.Text = "Número da CNH:";
			// 
			// maskedCpf
			// 
			this.maskedCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.maskedCpf.HidePromptOnLeave = true;
			this.maskedCpf.Location = new System.Drawing.Point(525, 40);
			this.maskedCpf.Mask = "000.000.000-00";
			this.maskedCpf.Name = "maskedCpf";
			this.maskedCpf.Size = new System.Drawing.Size(87, 20);
			this.maskedCpf.TabIndex = 2;
			this.maskedCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Location = new System.Drawing.Point(522, 24);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(27, 13);
			this.lblCpf.TabIndex = 257;
			this.lblCpf.Text = "CPF";
			// 
			// lblRG
			// 
			this.lblRG.AutoSize = true;
			this.lblRG.Location = new System.Drawing.Point(617, 23);
			this.lblRG.Name = "lblRG";
			this.lblRG.Size = new System.Drawing.Size(23, 13);
			this.lblRG.TabIndex = 253;
			this.lblRG.Text = "RG";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(25, 63);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(36, 13);
			this.lblEmail.TabIndex = 251;
			this.lblEmail.Text = "E-Mail";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(102, 24);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 249;
			this.lblNome.Text = "Nome";
			// 
			// txtRG
			// 
			this.txtRG.AccessibleDescription = "Digite seu RG";
			this.txtRG.AccessibleName = "RG";
			this.txtRG.Location = new System.Drawing.Point(620, 39);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(108, 20);
			this.txtRG.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(28, 79);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(332, 20);
			this.txtEmail.TabIndex = 4;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(105, 40);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(377, 20);
			this.txtNome.TabIndex = 1;
			this.txtNome.Tag = "";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(615, 348);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(136, 42);
			this.btnSalvar.TabIndex = 23;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 274;
			this.label1.Text = "Data Demissão";
			// 
			// txtCTPS
			// 
			this.txtCTPS.Location = new System.Drawing.Point(227, 121);
			this.txtCTPS.Name = "txtCTPS";
			this.txtCTPS.Size = new System.Drawing.Size(139, 20);
			this.txtCTPS.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(369, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 276;
			this.label2.Text = "Nº PIS";
			// 
			// txtPIS
			// 
			this.txtPIS.Location = new System.Drawing.Point(372, 121);
			this.txtPIS.Name = "txtPIS";
			this.txtPIS.Size = new System.Drawing.Size(147, 20);
			this.txtPIS.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 278;
			this.label3.Text = "Nº CTPS";
			// 
			// txtTitEleitor
			// 
			this.txtTitEleitor.Location = new System.Drawing.Point(525, 121);
			this.txtTitEleitor.Name = "txtTitEleitor";
			this.txtTitEleitor.Size = new System.Drawing.Size(126, 20);
			this.txtTitEleitor.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(522, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 280;
			this.label4.Text = "Titulo de eleitor";
			// 
			// txtSalario
			// 
			this.txtSalario.Location = new System.Drawing.Point(578, 79);
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Size = new System.Drawing.Size(150, 20);
			this.txtSalario.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(573, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 282;
			this.label5.Text = "Salário";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 312);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 13);
			this.label6.TabIndex = 283;
			this.label6.Text = "Informações adicionais";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(28, 329);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(455, 61);
			this.richTextBox1.TabIndex = 22;
			this.richTextBox1.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 13);
			this.label7.TabIndex = 286;
			this.label7.Text = "Nº Registro";
			// 
			// textNrRegistro
			// 
			this.textNrRegistro.Location = new System.Drawing.Point(28, 40);
			this.textNrRegistro.Name = "textNrRegistro";
			this.textNrRegistro.ReadOnly = true;
			this.textNrRegistro.Size = new System.Drawing.Size(71, 20);
			this.textNrRegistro.TabIndex = 285;
			// 
			// maskedDataAdmissao
			// 
			this.maskedDataAdmissao.HidePromptOnLeave = true;
			this.maskedDataAdmissao.Location = new System.Drawing.Point(28, 121);
			this.maskedDataAdmissao.Mask = "00/00/0000";
			this.maskedDataAdmissao.Name = "maskedDataAdmissao";
			this.maskedDataAdmissao.Size = new System.Drawing.Size(76, 20);
			this.maskedDataAdmissao.TabIndex = 8;
			this.maskedDataAdmissao.ValidatingType = typeof(System.DateTime);
			// 
			// maskedDataDemissao
			// 
			this.maskedDataDemissao.HidePromptOnLeave = true;
			this.maskedDataDemissao.Location = new System.Drawing.Point(28, 160);
			this.maskedDataDemissao.Mask = "00/00/0000";
			this.maskedDataDemissao.Name = "maskedDataDemissao";
			this.maskedDataDemissao.Size = new System.Drawing.Size(76, 20);
			this.maskedDataDemissao.TabIndex = 14;
			this.maskedDataDemissao.ValidatingType = typeof(System.DateTime);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(107, 102);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 290;
			this.label9.Text = "Cargo";
			// 
			// comboCargo
			// 
			this.comboCargo.FormattingEnabled = true;
			this.comboCargo.Location = new System.Drawing.Point(110, 120);
			this.comboCargo.Name = "comboCargo";
			this.comboCargo.Size = new System.Drawing.Size(110, 21);
			this.comboCargo.TabIndex = 9;
			// 
			// FormCadastrarFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.comboCargo);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.maskedDataDemissao);
			this.Controls.Add(this.maskedDataAdmissao);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textNrRegistro);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTitEleitor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPIS);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCTPS);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupEndereco);
			this.Controls.Add(this.maskedEmitidaCNH);
			this.Controls.Add(this.lblEmitida);
			this.Controls.Add(this.txtTelCel);
			this.Controls.Add(this.lblTelCel);
			this.Controls.Add(this.maskedValidadeCNH);
			this.Controls.Add(this.txtTelRes);
			this.Controls.Add(this.lblTelRes);
			this.Controls.Add(this.lblValidade);
			this.Controls.Add(this.lblProfissao);
			this.Controls.Add(this.txtCategoriaCNH);
			this.Controls.Add(this.txtNascimento);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.txtCNH);
			this.Controls.Add(this.lblNascimento);
			this.Controls.Add(this.lblCNH);
			this.Controls.Add(this.maskedCpf);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblRG);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.btnSalvar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarFuncionario";
			this.Text = "Cadastro de Funcionários";
			this.Load += new System.EventHandler(this.FormCadastrarFuncionario_Load);
			this.groupEndereco.ResumeLayout(false);
			this.groupEndereco.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupEndereco;
		private System.Windows.Forms.TextBox txtCep;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtUF;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtComplemento;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.MaskedTextBox maskedEmitidaCNH;
		private System.Windows.Forms.Label lblEmitida;
		private System.Windows.Forms.MaskedTextBox txtTelCel;
		private System.Windows.Forms.Label lblTelCel;
		private System.Windows.Forms.MaskedTextBox maskedValidadeCNH;
		private System.Windows.Forms.MaskedTextBox txtTelRes;
		private System.Windows.Forms.Label lblTelRes;
		private System.Windows.Forms.Label lblValidade;
		private System.Windows.Forms.Label lblProfissao;
		private System.Windows.Forms.TextBox txtCategoriaCNH;
		private System.Windows.Forms.MaskedTextBox txtNascimento;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.TextBox txtCNH;
		private System.Windows.Forms.Label lblNascimento;
		private System.Windows.Forms.Label lblCNH;
		private System.Windows.Forms.MaskedTextBox maskedCpf;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblRG;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCTPS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPIS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTitEleitor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSalario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textNrRegistro;
		private System.Windows.Forms.MaskedTextBox maskedDataAdmissao;
		private System.Windows.Forms.MaskedTextBox maskedDataDemissao;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboCargo;
	}
}