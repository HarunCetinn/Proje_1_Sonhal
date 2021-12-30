using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace Proje_1_Teknik_Servis.Formlar
{
    public partial class FrmQrKod : Form
    {
        public FrmQrKod()
        {
            InitializeComponent();
        }

        private void FrmQrKod_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnQR_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(textEdit1.Text);
        }
    }
}
