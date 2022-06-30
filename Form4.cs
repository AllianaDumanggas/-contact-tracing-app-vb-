using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Contact_Tracing_App
{
    public partial class generatingqrcode : Form
    {
        public generatingqrcode()
        {
            InitializeComponent();
        }

        private void generate_qr_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(info.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrcode = new QRCode(data);
            qrpicbox.Image = qrcode.GetGraphic(5);

            string Initialdirectory = @"C:\Users\universal\Pictures";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = Initialdirectory;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                qrpicbox.Image.Save(dialog.FileName); 
            }
        }
    }
}
