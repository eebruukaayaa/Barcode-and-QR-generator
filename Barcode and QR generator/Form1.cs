using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode_and_QR_generator
{
    public partial class BarcodeQRGenerator : Form
    {
        bool isGenerated = false;
       

        public BarcodeQRGenerator()
        {
            InitializeComponent();
        }



        private void BarcodeQRGenerator_Load(object sender, EventArgs e)
        {

        }

        private void BarcodeButton_Click(object sender, EventArgs e)
         
        {
            isGenerated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(BarcodetextBox.Text, 200);
        }

        private void QRButton_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrBarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrBarcode.Draw(BarcodetextBox.Text, 200);
        }

        private void SavaButton_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                pictureBox1.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg",
                    ImageFormat.Jpeg);
            }
            
        }
    }
}
        

