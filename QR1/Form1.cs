using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Aspose.BarCode;
//using Aspose.BarCode.Generation;
using QRCoder;

namespace QR1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private QRCodeGenerator.ECCLevel getECCLevel()
		{
			QRCodeGenerator.ECCLevel lvl = QRCodeGenerator.ECCLevel.Q;

			if (radioButtonDefault.Checked) lvl = QRCodeGenerator.ECCLevel.Default;
			if (radioButtonL.Checked) lvl = QRCodeGenerator.ECCLevel.L;
			if (radioButtonM.Checked) lvl = QRCodeGenerator.ECCLevel.M;
			if (radioButtonQ.Checked) lvl = QRCodeGenerator.ECCLevel.Q;
			if (radioButtonH.Checked) lvl = QRCodeGenerator.ECCLevel.H;

			return lvl;
		}

		private void generat()
		{
			var txt = textBox1.Text;
			//var generator = new BarcodeGenerator(EncodeTypes.QR);
			var generator = new QRCodeGenerator();

			// エンコードするコードテキストを指定する
			var qrCodeData = generator.CreateQrCode(txt, getECCLevel());

			// 画像のサイズを指定する
			var qrCode = new PngByteQRCode(qrCodeData);


			// 生成されたQRコードを表示
			var bmp = new ArtQRCode(qrCodeData).GetGraphic((int)numericUpDown1.Value);

			pictureBox1.Size = new System.Drawing.Size(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

			pictureBox1.Image = bmp;
			buttonSave.Enabled = true;
		}


		private void button_generat_Click(object sender, EventArgs e)
		{
			generat();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Title = "Save Work Pict";

			if (pictureBox1.Image != null)
			{
				saveFileDialog1.DefaultExt = "png";
				saveFileDialog1.Title = "PNG";
				saveFileDialog1.Filter = "Pct File(*.png;*.jpg;*.bmp)|*.png|PNG File(*.png)|*.png|Jpeg File(*.jpg)|*.jpg|BMP File(*.bmp)|*.bmp|ALL|*.*";
				saveFileDialog1.FileName = System.DateTime.Now.ToString().Replace("/", "-").Replace(":", "-").Replace(" ", "_") + ".png";

				saveFileDialog1.ShowDialog();
			}
			else
			{
				MessageBox.Show("絵が無いです．");
			}
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			pictureBox1.Image.Save(saveFileDialog1.FileName);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			generat();
		}
	}
}
