using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Tickets
{
    public partial class Frm_Zoom : Form
    {
        Image Zoom;
        public Frm_Zoom(Image Img)
        {
            Zoom = Img;
            InitializeComponent();
        }

        private void Frm_Zoom_Load(object sender, EventArgs e)
        {
            pic_Zoom.Image = Zoom;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void brn_Rotar_Click(object sender, EventArgs e)
        {
            pic_Zoom.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pic_Zoom.Refresh();
        }
    }
}
