
namespace QR1
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button_generat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonDefault = new System.Windows.Forms.RadioButton();
			this.radioButtonL = new System.Windows.Forms.RadioButton();
			this.radioButtonM = new System.Windows.Forms.RadioButton();
			this.radioButtonQ = new System.Windows.Forms.RadioButton();
			this.radioButtonH = new System.Windows.Forms.RadioButton();
			this.buttonSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(12, 8);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(417, 65);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(89, 81);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(340, 326);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button_generat
			// 
			this.button_generat.Location = new System.Drawing.Point(8, 82);
			this.button_generat.Name = "button_generat";
			this.button_generat.Size = new System.Drawing.Size(75, 23);
			this.button_generat.TabIndex = 2;
			this.button_generat.Text = "Generat";
			this.button_generat.UseVisualStyleBackColor = true;
			this.button_generat.Click += new System.EventHandler(this.button_generat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonH);
			this.groupBox1.Controls.Add(this.radioButtonQ);
			this.groupBox1.Controls.Add(this.radioButtonM);
			this.groupBox1.Controls.Add(this.radioButtonL);
			this.groupBox1.Controls.Add(this.radioButtonDefault);
			this.groupBox1.Location = new System.Drawing.Point(12, 213);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(75, 129);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ECCLevel";
			// 
			// radioButtonDefault
			// 
			this.radioButtonDefault.AutoSize = true;
			this.radioButtonDefault.Location = new System.Drawing.Point(6, 18);
			this.radioButtonDefault.Name = "radioButtonDefault";
			this.radioButtonDefault.Size = new System.Drawing.Size(60, 16);
			this.radioButtonDefault.TabIndex = 0;
			this.radioButtonDefault.Text = "Default";
			this.radioButtonDefault.UseVisualStyleBackColor = true;
			// 
			// radioButtonL
			// 
			this.radioButtonL.AutoSize = true;
			this.radioButtonL.Location = new System.Drawing.Point(6, 40);
			this.radioButtonL.Name = "radioButtonL";
			this.radioButtonL.Size = new System.Drawing.Size(29, 16);
			this.radioButtonL.TabIndex = 1;
			this.radioButtonL.Text = "L";
			this.radioButtonL.UseVisualStyleBackColor = true;
			// 
			// radioButtonM
			// 
			this.radioButtonM.AutoSize = true;
			this.radioButtonM.Location = new System.Drawing.Point(6, 62);
			this.radioButtonM.Name = "radioButtonM";
			this.radioButtonM.Size = new System.Drawing.Size(32, 16);
			this.radioButtonM.TabIndex = 2;
			this.radioButtonM.Text = "M";
			this.radioButtonM.UseVisualStyleBackColor = true;
			// 
			// radioButtonQ
			// 
			this.radioButtonQ.AutoSize = true;
			this.radioButtonQ.Checked = true;
			this.radioButtonQ.Location = new System.Drawing.Point(6, 84);
			this.radioButtonQ.Name = "radioButtonQ";
			this.radioButtonQ.Size = new System.Drawing.Size(31, 16);
			this.radioButtonQ.TabIndex = 3;
			this.radioButtonQ.TabStop = true;
			this.radioButtonQ.Text = "Q";
			this.radioButtonQ.UseVisualStyleBackColor = true;
			// 
			// radioButtonH
			// 
			this.radioButtonH.AutoSize = true;
			this.radioButtonH.Location = new System.Drawing.Point(6, 107);
			this.radioButtonH.Name = "radioButtonH";
			this.radioButtonH.Size = new System.Drawing.Size(31, 16);
			this.radioButtonH.TabIndex = 4;
			this.radioButtonH.Text = "H";
			this.radioButtonH.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Location = new System.Drawing.Point(8, 111);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numericUpDown1.Location = new System.Drawing.Point(12, 381);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(64, 26);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 366);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "Size";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 417);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button_generat);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button_generat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonQ;
		private System.Windows.Forms.RadioButton radioButtonM;
		private System.Windows.Forms.RadioButton radioButtonL;
		private System.Windows.Forms.RadioButton radioButtonDefault;
		private System.Windows.Forms.RadioButton radioButtonH;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
	}
}

