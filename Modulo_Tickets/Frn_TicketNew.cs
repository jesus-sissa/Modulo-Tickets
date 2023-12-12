using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;
using static Modulo_Tickets.Model.Correo;
using System.IO;

namespace Modulo_Tickets
{
    public partial class Frn_TicketNew : Form
    {
        List<ImagenRequest> _Files = new List<ImagenRequest>();
        string Base64;
        public int Id_Rubro = 0;
        int numdoc;
        //string _categoria;
        //Image _img;
        public Frn_TicketNew()
        {
            InitializeComponent();
        }
        //public Frn_TicketNew(string Categoria, Image img)
        //{
        //    _categoria = Categoria;
        //    _img = img;
        //    InitializeComponent();
        //}
        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
                int Numero_Ticket = 0;
                if (Txt_Descripcion.Text == string.Empty || Txt_Descripcion.Text.Length<5) 
                {
                Mensaje("Ingrese una descripción mas completa.", 3);
                //Lbl_Alerta.Text = "*Ingrese una descripción.";
                Txt_Descripcion.Focus();
                }
                else
                {
                if (Persistentes.Id_ClienteExterno != 0)
                {
                    Btn_Enviar.Enabled = false;
                    Lbl_Alerta.Text = string.Empty;
                    TicketRequest ticketRequest = new TicketRequest
                    {
                        Clave_Modulo = "",
                        Opcion = "TICKET EXTERNO",
                        Descripcion = Txt_Descripcion.Text.Trim(),
                        Tipo = 2,
                        Id_Opcion = 0,
                        Id_Reporte = 0,
                        Id_Rubro = Id_Rubro,
                        Id_Cliente=Persistentes.Id_ClienteExterno
                        //Id_Rubro = Persistentes.Id_RubroSeleccionado
                    };
                    var path_doc_solicitud = openFileDialog.FileName;
                    var extension = Path.GetExtension(path_doc_solicitud);
                    var nombre = Path.GetFileName(path_doc_solicitud);
                    Numero_Ticket = TicketRepository.GuardarTicket(ticketRequest);
                    TicketRepository.Guardar_Archivos(_Files, Numero_Ticket, 0);
                    //TicketRepository.Guardar_Archivos(new ImagenRequest { Base64 = Base64, Id_Ticket = Numero_Ticket, Extension = extension, Nombre = nombre });
                    //TicketRepository.Guardar_Archivos(new ImagenRequest { Base64 = Base64, Id_Ticket = Numero_Ticket });
                    ticketRequest = new TicketRequest { Id_Ticket = Numero_Ticket, UsuarioId = Persistentes.Usuario_Login, Descripcion = "NUEVO TICKET" };
                    TicketRepository.GuardarSprint(ticketRequest);
                    Enviar_Correo(Numero_Ticket);
                    Mensaje("El ticket con # " + Numero_Ticket.ToString() + " se registró correctamente.", 3);
                }
                else
                {
                    Btn_Enviar.Enabled = false;
                    Lbl_Alerta.Text = string.Empty;
                    TicketRequest ticketRequest = new TicketRequest
                    {
                        Clave_Modulo = "",
                        Opcion = "TICKET INTERNO",
                        Descripcion = Txt_Descripcion.Text.Trim(),
                        Tipo = 3,
                        Id_Opcion = 0,
                        Id_Reporte = 0,
                        Id_Rubro = Id_Rubro,
                        Id_Cliente=0

                        //Id_Rubro = Persistentes.Id_RubroSeleccionado
                    };
                    var path_doc_solicitud = openFileDialog.FileName;
                    var extension = Path.GetExtension(path_doc_solicitud);
                    var nombre = Path.GetFileName(path_doc_solicitud);
                    Numero_Ticket = TicketRepository.GuardarTicket(ticketRequest);
                    TicketRepository.Guardar_Archivos(_Files, Numero_Ticket, 0);
                    //TicketRepository.Guardar_Archivos(new ImagenRequest { Base64 = Base64, Id_Ticket = Numero_Ticket, Extension = extension, Nombre = nombre });
                    ticketRequest = new TicketRequest { Id_Ticket = Numero_Ticket, UsuarioId = Persistentes.Usuario_Login, Descripcion = "NUEVO TICKET" };
                    TicketRepository.GuardarSprint(ticketRequest);
                    Enviar_Correo(Numero_Ticket);
                    Mensaje("El ticket con # " + Numero_Ticket.ToString() + " se registró correctamente.", 3);
                }

                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }            
        }
        void Enviar_Correo(int Id_Ticket)
        {
            CorreoResponse Seguimiento;
            TicketRequest Ticket = new TicketRequest {Id_Ticket = Id_Ticket};
            try
            {
                Seguimiento = TicketRepository.Mail_Seguimiento(Ticket);
                Correo.Mail_UsuarioNotificacion(Seguimiento);
                Correo.Mail_RubroNotificacion(Seguimiento);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }
        }
        void Nuevo_Ticket()
        {
            Txt_Descripcion.Text = string.Empty;
            Txt_Descripcion.Focus();
        }
        void Mensaje(String Texto,int Time=2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Txt_Descripcion_Leave(object sender, EventArgs e)
        {
            if (Txt_Descripcion.Text == string.Empty)
            {
                Txt_Descripcion.Text = "Agregue aqui una descripción . . .";
                Txt_Descripcion.ForeColor = Color.DimGray;
            }
        }

        private void Txt_Descripcion_Enter(object sender, EventArgs e)
        {
            if (Txt_Descripcion.Text == "Agregue aqui una descripción . . .")
            {
                Txt_Descripcion.Text = string.Empty;
                Txt_Descripcion.ForeColor = Color.Black;

            }
        }

        private void Frn_TicketNew_Load(object sender, EventArgs e)
        {
            var q = RubroRepository.ConsultarRubrosU(new RubroRequest(), Persistentes.numdoc);
            numdoc = q.Num_Documento;
            //Btn_Rubro.Image = _img;
            Lbl_Nombre.Text = Btn_Rubro.LabelText;
            //Lbl_Categoria.Text =">"+ _categoria;
            if(Persistentes.Controles("EXTERNO"))
            {
                Btn_Externo.Visible = true;
            }
            else
            {
                Btn_Externo.Visible = false;
            }
            var p = RubroRepository.ConsultarRubrosU(new RubroRequest(), Persistentes.Id_Rubro);
            if (p.Num_Documento == 0 && numdoc == 0)
            {
                btn_Captura.Enabled = false;
            }
            else
            {
                btn_Captura.Enabled = true;
            }

        }
        //bool Controles(string Control)
        //{

        //    if (Persistentes.CadenaPermisosControles.IndexOf(Control) != -1)
        //    {
        //        Btn_Externo.Visible = true;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //private void btn_Captura_Click(object sender, EventArgs e)
        //{
        //    string path_doc_solicitud = null;
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        path_doc_solicitud = openFileDialog.FileName;
        //        Stream st = openFileDialog.OpenFile();
        //        BinaryReader br = new BinaryReader(st);
        //        Base64 = Convert.ToBase64String(br.ReadBytes((Int32)st.Length));
        //        //using (MemoryStream ms = new MemoryStream())
        //        //{
        //        //    st.CopyTo(ms);
        //        //    file = ms.ToArray();
        //        //}
        //        var extension = Path.GetExtension(path_doc_solicitud);
        //        pic_Img.Image = Base64ToImage(Base64);
        //        Txt_Descripcion.Size = new System.Drawing.Size(530, 293);
        //        div_Divider.Visible = true;
        //        gbx_Imagen.Visible = true;
        //    }
        //}
    private void btn_Captura_Click(object sender, EventArgs e)
    {
            string[] path_doc_solicitud = null;
            path_doc_solicitud = new string[0];
            _Files.Clear();
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    path_doc_solicitud = openFileDialog.FileName;
            //    var extension = Path.GetExtension(path_doc_solicitud);
            //    var nombre = Path.GetFileName(path_doc_solicitud);
            //    string titulo = "El Archivo Adjuntado es: " ;
            //    if (EsImagen(extension))
            //    {
            //        Stream st = openFileDialog.OpenFile();
            //        BinaryReader br = new BinaryReader(st);
            //        Base64 = Convert.ToBase64String(br.ReadBytes((int)st.Length));
            //        label1.Text = titulo + nombre;
            //    }
            //    else
            //    {
            //        Stream fs = openFileDialog.OpenFile();
            //        BinaryReader br = new BinaryReader(fs);
            //        Base64 = Convert.ToBase64String(br.ReadBytes((int)fs.Length));
            //        byte[] fileBytes;
            //        fileBytes = new byte[fs.Length];
            //        fs.Read(fileBytes, 0, fileBytes.Length);
            //        label1.Text = titulo + nombre;
            //    }
            //}
            openFileDialog.ShowDialog();
            path_doc_solicitud = openFileDialog.FileNames;
            for (int file = 0; file <= path_doc_solicitud.Length - 1; file++)
            {
                if (path_doc_solicitud[file].ToString() == "openFileDialog1")
                {
                    Persistentes.Mensaje("No se selecciono ningun archivo");
                }
                else
                {
                    StreamReader sr = new StreamReader(path_doc_solicitud[file].ToString());
                    if (file <= numdoc - 1)
                    {
                        using (var ms = new MemoryStream())
                        {
                            sr.BaseStream.CopyTo(ms);

                            _Files.Add(new ImagenRequest
                            {
                                Nombre = Path.GetFileName(path_doc_solicitud[file].ToString()),
                                Extension = Path.GetExtension(path_doc_solicitud[file].ToString()),
                                Base64 = Convert.ToBase64String(ms.ToArray())
                            }
                            );

                        }
                    }
                    else
                    {
                        Persistentes.Mensaje("No puede agregar mas de " + numdoc + " documentos");
                        path_doc_solicitud = new string[0];
                    }
                    if (path_doc_solicitud.Length > 0)
                    {
                        label1.Text = "Se han adjuntado " + path_doc_solicitud.Length + " archivos.";
                    }
                }
            }
        }
    //    private bool EsImagen(string extension)
    //{
    //    string[] extensionesImagenes = { ".jpg", ".jpeg", ".png", ".gif" };
    //    return extensionesImagenes.Contains(extension.ToLower());
    //}

    //public Image Base64ToImage(string base64String)
    //    {
    //        // Convert Base64 String to byte[]
    //        byte[] imageBytes = Convert.FromBase64String(base64String);
    //        MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

    //        // Convert byte[] to Image
    //        ms.Write(imageBytes, 0, imageBytes.Length);
    //        Image image = Image.FromStream(ms, true);

    //        return image;
    //    }
    private void Btn_Externo_Click(object sender, EventArgs e)
        {
            Persistentes.Id_ClienteExterno = 0;
            Frm_Clientes _frm = new Frm_Clientes();
            _frm.ShowDialog();
            if(Persistentes.Id_ClienteExterno!=0)
            {
                Lbl_Externo.Text =">"+ Persistentes.Nombre_ClienteExterno;
            }
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Rubro_Click(object sender, EventArgs e)
        {

        }

        private void div_Divider_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Externo_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Alerta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Rubro_Click_1(object sender, EventArgs e)
        {

        }
    }
}
