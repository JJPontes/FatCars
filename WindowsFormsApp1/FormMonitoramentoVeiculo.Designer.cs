namespace WindowsFormsApp1
{
	partial class FormMonitoramentoVeiculo
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(277, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(273, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "Monitoramento de Veículos";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Selecione o Veiculo";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(151, 61);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 11;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(63, 112);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(641, 287);
			this.webBrowser1.TabIndex = 12;
			this.webBrowser1.Url = new System.Uri("https://www.google.com.br/maps/place/UNIP-+Norte+Vila+Guilherme/@-23.5128757,-46." +
        "6118936,17z/data=!3m1!4b1!4m5!3m4!1s0x94ce58bcf5add8b5:0x7f4b742aebee617a!8m2!3d" +
        "-23.5128806!4d-46.6097049", System.UriKind.Absolute);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.webBrowser1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 416);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// FormMonitoramentoVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Name = "FormMonitoramentoVeiculo";
			this.Text = "Monitoramento de Veiculos";
			this.Load += new System.EventHandler(this.FormMonitoramentoVeiculo_Load);
			this.Resize += new System.EventHandler(this.FormMonitoramentoVeiculo_Resize);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}