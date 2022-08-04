namespace Barcode_and_QR_generator
{
    partial class BarcodeQRGenerator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BarcodetextBox = new System.Windows.Forms.TextBox();
            this.BarcodeButton = new System.Windows.Forms.Button();
            this.QRButton = new System.Windows.Forms.Button();
            this.QRtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SavaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode: ";
            // 
            // BarcodetextBox
            // 
            this.BarcodetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarcodetextBox.Location = new System.Drawing.Point(109, 29);
            this.BarcodetextBox.Name = "BarcodetextBox";
            this.BarcodetextBox.Size = new System.Drawing.Size(403, 29);
            this.BarcodetextBox.TabIndex = 1;
            // 
            // BarcodeButton
            // 
            this.BarcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarcodeButton.Location = new System.Drawing.Point(542, 23);
            this.BarcodeButton.Name = "BarcodeButton";
            this.BarcodeButton.Size = new System.Drawing.Size(106, 36);
            this.BarcodeButton.TabIndex = 2;
            this.BarcodeButton.Text = "Generate";
            this.BarcodeButton.UseVisualStyleBackColor = true;
            this.BarcodeButton.Click += new System.EventHandler(this.BarcodeButton_Click);
            // 
            // QRButton
            // 
            this.QRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QRButton.Location = new System.Drawing.Point(542, 79);
            this.QRButton.Name = "QRButton";
            this.QRButton.Size = new System.Drawing.Size(106, 36);
            this.QRButton.TabIndex = 5;
            this.QRButton.Text = "Generate";
            this.QRButton.UseVisualStyleBackColor = true;
            this.QRButton.Click += new System.EventHandler(this.QRButton_Click);
            // 
            // QRtextBox
            // 
            this.QRtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QRtextBox.Location = new System.Drawing.Point(109, 85);
            this.QRtextBox.Name = "QRtextBox";
            this.QRtextBox.Size = new System.Drawing.Size(403, 29);
            this.QRtextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "QRcode: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 284);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SavaButton
            // 
            this.SavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SavaButton.Location = new System.Drawing.Point(281, 419);
            this.SavaButton.Name = "SavaButton";
            this.SavaButton.Size = new System.Drawing.Size(106, 36);
            this.SavaButton.TabIndex = 7;
            this.SavaButton.Text = "Save";
            this.SavaButton.UseVisualStyleBackColor = true;
            this.SavaButton.Click += new System.EventHandler(this.SavaButton_Click);
            // 
            // BarcodeQRGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 488);
            this.Controls.Add(this.SavaButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QRButton);
            this.Controls.Add(this.QRtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarcodeButton);
            this.Controls.Add(this.BarcodetextBox);
            this.Controls.Add(this.label1);
            this.Name = "BarcodeQRGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode & QR generator";
            this.Load += new System.EventHandler(this.BarcodeQRGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarcodetextBox;
        private System.Windows.Forms.Button BarcodeButton;
        private System.Windows.Forms.Button QRButton;
        private System.Windows.Forms.TextBox QRtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SavaButton;
    }
}

