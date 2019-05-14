namespace WindowsFormsApp1
{
	partial class FormConsultarComprovantes
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.Btn_Pesquisar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Btn_Pesquisar);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(92, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(670, 297);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(214, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(249, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "Consultar Comprovantes";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(248, 88);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(96, 17);
			this.radioButton1.TabIndex = 10;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Ultimos 30 dias";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(245, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Escolha o periodo desejado:";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(248, 111);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(96, 17);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Ultimos 60 dias";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(248, 162);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(248, 134);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(94, 17);
			this.radioButton3.TabIndex = 14;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Personalizado:";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(216, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "De:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(216, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Até:";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(248, 188);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(231, 20);
			this.dateTimePicker2.TabIndex = 17;
			// 
			// Btn_Pesquisar
			// 
			this.Btn_Pesquisar.Location = new System.Drawing.Point(281, 240);
			this.Btn_Pesquisar.Name = "Btn_Pesquisar";
			this.Btn_Pesquisar.Size = new System.Drawing.Size(105, 40);
			this.Btn_Pesquisar.TabIndex = 18;
			this.Btn_Pesquisar.Text = "Pesquisar";
			this.Btn_Pesquisar.UseVisualStyleBackColor = true;
			// 
			// FormConsultarComprovantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Name = "FormConsultarComprovantes";
			this.Text = "Consultar Comprovantes";
			this.Load += new System.EventHandler(this.FormConsultarComprovantes_Load);
			this.Resize += new System.EventHandler(this.FormConsultarComprovantes_Resize);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Btn_Pesquisar;
	}
}