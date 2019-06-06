namespace WindowsFormsApp1.Views.Desktop
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
			this.txtEstado = new System.Windows.Forms.TextBox();
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
			this.maskedEmitida = new System.Windows.Forms.MaskedTextBox();
			this.lblEmitida = new System.Windows.Forms.Label();
			this.txtTelCel = new System.Windows.Forms.MaskedTextBox();
			this.lblTelCel = new System.Windows.Forms.Label();
			this.maskedValidade = new System.Windows.Forms.MaskedTextBox();
			this.txtTelRes = new System.Windows.Forms.MaskedTextBox();
			this.lblTelRes = new System.Windows.Forms.Label();
			this.lblValidade = new System.Windows.Forms.Label();
			this.lblProfissao = new System.Windows.Forms.Label();
			this.txtCategoria = new System.Windows.Forms.TextBox();
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textNrRegistro = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.groupEndereco.SuspendLayout();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.AccessibleName = "Buscar Cliente";
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Image = global::WindowsFormsApp1.Properties.Resources.lupa;
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
			this.groupEndereco.Controls.Add(this.txtEstado);
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
			this.groupEndereco.TabIndex = 271;
			this.groupEndereco.TabStop = false;
			this.groupEndereco.Text = "Endereço";
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(16, 39);
			this.txtCep.MaxLength = 9;
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(81, 20);
			this.txtCep.TabIndex = 7;
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
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(282, 79);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(173, 20);
			this.txtEstado.TabIndex = 95;
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
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(279, 62);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(40, 13);
			this.lblEstado.TabIndex = 15;
			this.lblEstado.Text = "Estado";
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
			this.txtBairro.Location = new System.Drawing.Point(442, 39);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(73, 20);
			this.txtBairro.TabIndex = 96;
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
			this.txtNumero.Location = new System.Drawing.Point(16, 78);
			this.txtNumero.MaxLength = 5;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(81, 20);
			this.txtNumero.TabIndex = 8;
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
			// maskedEmitida
			// 
			this.maskedEmitida.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.maskedEmitida.HidePromptOnLeave = true;
			this.maskedEmitida.Location = new System.Drawing.Point(375, 168);
			this.maskedEmitida.Mask = "00/00/0000";
			this.maskedEmitida.Name = "maskedEmitida";
			this.maskedEmitida.Size = new System.Drawing.Size(75, 20);
			this.maskedEmitida.TabIndex = 270;
			this.maskedEmitida.ValidatingType = typeof(System.DateTime);
			// 
			// lblEmitida
			// 
			this.lblEmitida.AutoSize = true;
			this.lblEmitida.Location = new System.Drawing.Point(372, 152);
			this.lblEmitida.Name = "lblEmitida";
			this.lblEmitida.Size = new System.Drawing.Size(61, 13);
			this.lblEmitida.TabIndex = 269;
			this.lblEmitida.Text = "Emitida em:";
			// 
			// txtTelCel
			// 
			this.txtTelCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelCel.Location = new System.Drawing.Point(471, 79);
			this.txtTelCel.Mask = "(00) 00000-0000";
			this.txtTelCel.Name = "txtTelCel";
			this.txtTelCel.Size = new System.Drawing.Size(94, 20);
			this.txtTelCel.TabIndex = 254;
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
			// maskedValidade
			// 
			this.maskedValidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.maskedValidade.HidePromptOnLeave = true;
			this.maskedValidade.Location = new System.Drawing.Point(459, 168);
			this.maskedValidade.Mask = "00/00/0000";
			this.maskedValidade.Name = "maskedValidade";
			this.maskedValidade.Size = new System.Drawing.Size(75, 20);
			this.maskedValidade.TabIndex = 266;
			this.maskedValidade.ValidatingType = typeof(System.DateTime);
			// 
			// txtTelRes
			// 
			this.txtTelRes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelRes.Location = new System.Drawing.Point(370, 79);
			this.txtTelRes.Mask = "(00) 0000-0000";
			this.txtTelRes.Name = "txtTelRes";
			this.txtTelRes.Size = new System.Drawing.Size(81, 20);
			this.txtTelRes.TabIndex = 250;
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
			this.lblValidade.Location = new System.Drawing.Point(456, 152);
			this.lblValidade.Name = "lblValidade";
			this.lblValidade.Size = new System.Drawing.Size(51, 13);
			this.lblValidade.TabIndex = 265;
			this.lblValidade.Text = "Validade:";
			// 
			// lblProfissao
			// 
			this.lblProfissao.AutoSize = true;
			this.lblProfissao.Location = new System.Drawing.Point(28, 110);
			this.lblProfissao.Name = "lblProfissao";
			this.lblProfissao.Size = new System.Drawing.Size(78, 13);
			this.lblProfissao.TabIndex = 258;
			this.lblProfissao.Text = "Data Admissão";
			// 
			// txtCategoria
			// 
			this.txtCategoria.Location = new System.Drawing.Point(321, 168);
			this.txtCategoria.MaxLength = 2;
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(39, 20);
			this.txtCategoria.TabIndex = 268;
			// 
			// txtNascimento
			// 
			this.txtNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtNascimento.HidePromptOnLeave = true;
			this.txtNascimento.Location = new System.Drawing.Point(586, 129);
			this.txtNascimento.Mask = "00/00/0000";
			this.txtNascimento.Name = "txtNascimento";
			this.txtNascimento.Size = new System.Drawing.Size(71, 20);
			this.txtNascimento.TabIndex = 247;
			this.txtNascimento.ValidatingType = typeof(System.DateTime);
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(318, 152);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(55, 13);
			this.lblCategoria.TabIndex = 267;
			this.lblCategoria.Text = "Categoria:";
			// 
			// txtCNH
			// 
			this.txtCNH.Location = new System.Drawing.Point(114, 168);
			this.txtCNH.Name = "txtCNH";
			this.txtCNH.Size = new System.Drawing.Size(205, 20);
			this.txtCNH.TabIndex = 264;
			// 
			// lblNascimento
			// 
			this.lblNascimento.AutoSize = true;
			this.lblNascimento.Location = new System.Drawing.Point(583, 113);
			this.lblNascimento.Name = "lblNascimento";
			this.lblNascimento.Size = new System.Drawing.Size(80, 13);
			this.lblNascimento.TabIndex = 256;
			this.lblNascimento.Text = "Dt. Nascimento";
			// 
			// lblCNH
			// 
			this.lblCNH.AutoSize = true;
			this.lblCNH.Location = new System.Drawing.Point(111, 152);
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
			this.maskedCpf.TabIndex = 246;
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
			this.txtRG.TabIndex = 259;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(28, 79);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(332, 20);
			this.txtEmail.TabIndex = 245;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(105, 40);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(377, 20);
			this.txtNome.TabIndex = 244;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(615, 348);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(136, 42);
			this.btnSalvar.TabIndex = 255;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 274;
			this.label1.Text = "Data Demissão";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(113, 129);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 20);
			this.textBox2.TabIndex = 275;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(108, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 276;
			this.label2.Text = "Nº PIS";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(269, 129);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(150, 20);
			this.textBox3.TabIndex = 277;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(266, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 278;
			this.label3.Text = "Nº CTPS";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(430, 129);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(150, 20);
			this.textBox4.TabIndex = 279;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(430, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 280;
			this.label4.Text = "Titulo de eleitor";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(578, 79);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(150, 20);
			this.textBox5.TabIndex = 281;
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
			this.richTextBox1.TabIndex = 284;
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
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(31, 129);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(76, 20);
			this.maskedTextBox1.TabIndex = 287;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(31, 168);
			this.maskedTextBox2.Mask = "00/00/0000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(76, 20);
			this.maskedTextBox2.TabIndex = 288;
			this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
			// 
			// FormCadastrarFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.maskedTextBox2);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textNrRegistro);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupEndereco);
			this.Controls.Add(this.maskedEmitida);
			this.Controls.Add(this.lblEmitida);
			this.Controls.Add(this.txtTelCel);
			this.Controls.Add(this.lblTelCel);
			this.Controls.Add(this.maskedValidade);
			this.Controls.Add(this.txtTelRes);
			this.Controls.Add(this.lblTelRes);
			this.Controls.Add(this.lblValidade);
			this.Controls.Add(this.lblProfissao);
			this.Controls.Add(this.txtCategoria);
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
		private System.Windows.Forms.TextBox txtEstado;
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
		private System.Windows.Forms.MaskedTextBox maskedEmitida;
		private System.Windows.Forms.Label lblEmitida;
		private System.Windows.Forms.MaskedTextBox txtTelCel;
		private System.Windows.Forms.Label lblTelCel;
		private System.Windows.Forms.MaskedTextBox maskedValidade;
		private System.Windows.Forms.MaskedTextBox txtTelRes;
		private System.Windows.Forms.Label lblTelRes;
		private System.Windows.Forms.Label lblValidade;
		private System.Windows.Forms.Label lblProfissao;
		private System.Windows.Forms.TextBox txtCategoria;
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
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textNrRegistro;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
	}
}