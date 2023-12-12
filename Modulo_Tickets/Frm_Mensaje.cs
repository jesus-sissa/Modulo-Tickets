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
    public partial class Frm_Mensaje : Form
    {
        public int time = 2;
        int con = 0;
        public Frm_Mensaje()
        {
            InitializeComponent();
        }

        private void Btn_Imagen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Mensaje_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            con++;
            if (con==time)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
