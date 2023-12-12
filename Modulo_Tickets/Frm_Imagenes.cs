using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;
using Modulo_Tickets.Model.Repository;
using Modulo_Tickets.Model;
using System.IO;
using System.Diagnostics;

namespace Modulo_Tickets
{
    public partial class Frm_Imagenes : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        int _Id_Ticket = 0;
        int _Id_Tarea = 0;
        private TicketRepository ticketRepository;
        private ImagenRequest ImagenRequest;
        private string nombre_Documento;
        string Cambio;
        public Frm_Imagenes(int Id_Ticket, int Id_Tarea)
        {
            _Id_Ticket = Id_Ticket;
            _Id_Tarea = Id_Tarea;
            InitializeComponent();
        }
    void Lista_Documentos()
    {
        FLow.Controls.Clear();
        foreach (var item in TicketRepository.Consulta(new ImagenRequest { Id_Ticket = _Id_Ticket, Id_Flujo = _Id_Tarea }))
        {
            Agregar(item.Nombre, item.Id, item.Base64);
        }
    }

    void Agregar(string Nombre, string Id, string Base64)
        {
            btn = new BunifuFlatButton();
            btn.ButtonText = "Ver documentos";
            btn.Name = Id;
            btn.Iconimage = null;
            btn.Size = new System.Drawing.Size(500, 34);
            btn.Text = " " + Nombre;
            btn.Textcolor = System.Drawing.Color.White;
            FLow.Controls.Add(btn);
            btn.Click += new EventHandler(cliq);
            byte[] bytes = Convert.FromBase64String(Base64);
            btn.Tag = bytes;

        }
        private void cliq(object sender, EventArgs e)
        {
            btn = new BunifuFlatButton();
            btn = (BunifuFlatButton)sender;
            ImagenRequest.Nombre = btn.Text;
            byte[] bytes = (byte[])btn.Tag;
            ImagenRequest.Archivo_Byte = bytes;
            string pathDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folder = pathDirectory + "temp/";
            string fullfilepath = folder + "/" + ImagenRequest.Nombre;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            try
            {
                if (!File.Exists(fullfilepath))
                {
                    using (FileStream st = new FileStream(fullfilepath, FileMode.Create))
                    {
                        st.Write(ImagenRequest.Archivo_Byte, 0, ImagenRequest.Archivo_Byte.Length);
                        st.Close();
                    }
                }
                else
                {
                    File.WriteAllBytes(fullfilepath, ImagenRequest.Archivo_Byte);
                }

                Process.Start(fullfilepath);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se adjunto ningun archivo");
            }
        }

        private void Frm_Imagenes_Load(object sender, EventArgs e)
        {
            Lista_Documentos();
            int x = 0;
            int y = 0;
            ticketRepository = new TicketRepository();
            if(Persistentes.Tipo_tree == 1)
            {
                x = Persistentes.Numero_Ticket;
                y = 0;
                ImagenRequest = ticketRepository.GetDocumento(x, y);
                if (ImagenRequest != null)
                {
                    nombre_Documento = "Documento: " + ImagenRequest.Nombre;
                }
            }
            else
            {
                x = 0;
                y = Persistentes.Id_Tarea;
                ImagenRequest = ticketRepository.GetDocumento(x, y);
                if (ImagenRequest != null)
                {
                    nombre_Documento = "Documento: " + ImagenRequest.Nombre;
                }
            }
        }
        

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FLow_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
