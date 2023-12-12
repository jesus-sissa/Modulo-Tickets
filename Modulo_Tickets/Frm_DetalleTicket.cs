using Bunifu.Framework.UI;
using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_DetalleTicket : Form
    {
        int numdoc;
        public string vSolicitudCambio = null;
        private string nombre_solicitud = null;
        public bool active_solicitud = false;
        string status;
        private string path_doc_solicitud = null;
        string Base64;
        private SolicitudCambio _solicitudCambio;
        private SolicitudCambioRepository _repositorySolicitud;
        private ImagenRequest ImagenRequest;
        int _Id_Ticket = 0;
        DateTime Fecha_Resuelto;
        DateTime hora_actual;
        DateTime hora_limite;
        bool IsAdmin;
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();

        public Frm_DetalleTicket()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DetalleTicket_Load(object sender, EventArgs e)
        {
            ActualizarDatosSolicitud();
            //if(Lbl_Status.Text == "Status:RESUELTO")
            //{
            //    btn_RegresarTicket.Visible = true;
            //    TicketRequest ticket = new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket };
            //    ticket = TicketRepository.Consultar_FechaResuelto(ticket);
            //    Fecha_Resuelto = ticket.Fecha_Fin;
            //    hora_limite = Fecha_Resuelto.AddHours(2);
            //    hora_actual = DateTime.Now;
            //    if (hora_actual <= hora_limite)
            //    {
            //        btn_RegresarTicket.Enabled = true;
            //    }
            //}
            //TicketRequest ticket = new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket };
            //ticket = TicketRepository.Consultar_NivelSeguridad(ticket);
            //var q = RubroRepository.ConsultarRubrosU(new RubroRequest(),Convert.ToInt32(ticket.Id_Rubro));
            //numdoc = q.Num_Documento;
            //var p = RubroRepository.ConsultarRubrosU(new RubroRequest(), Persistentes.Id_Rubro);
            //if (p.Num_Documento == 0 && numdoc == 0)
            //{
            //    btn_Captura.Enabled = false;
            //}
            //else
            //{
            //    btn_Captura.Enabled = true;
            //}

        }

        public void ActualizarDatosSolicitud() 
        {
            _repositorySolicitud = new SolicitudCambioRepository();

            if (vSolicitudCambio != null && vSolicitudCambio != "")
            {
                gb_Solicitud.Visible = true;
                //tp_descargar.SetToolTip(btn_Descargar_Solicitud)
                _solicitudCambio = _repositorySolicitud.Get_Solicitud(vSolicitudCambio);
                if (_solicitudCambio != null)
                {
                    nombre_solicitud = _solicitudCambio.Nombre_Doc_Solicitud;
                }

                if (_solicitudCambio.Status_Solicitud != "AU")
                {

                    Btn_Upload.Visible = true;
                }
                else {
                    Btn_Upload.Visible = false;
                }

            }

            if (vSolicitudCambio != null && vSolicitudCambio != "")
            {
                lbl_numero_solicitud.Text = vSolicitudCambio;
            }
            if (nombre_solicitud != null)
            {
                lbl_nom_doc_solicitud.Text = nombre_solicitud;
            }
            else
            {
                lbl_nom_doc_solicitud.Text = "--";
            }

            


        }
        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            //Persistentes.Estrellas = 0;
            //Frm_Estrellas frm = new Frm_Estrellas();
            //frm.ShowDialog();
            //if(Persistentes.Estrellas!=0)
            //{
            //    TicketRequest Ticket = new TicketRequest
            //    {
            //        Id_Ticket = Persistentes.Numero_Ticket,
            //        Descripcion = "El ticket ha sido cerrado por el usuario."

            //    };
            //    TicketRepository.GuardarSprint(Ticket);
            //    Ticket = new TicketRequest
            //    {
            //        Id_Ticket = Persistentes.Numero_Ticket,
            //        Estrellas=Persistentes.Estrellas,
            //        Comentarios_Estrellas=Persistentes.Comentarios_Estrellas

            //    };
            //    TicketRepository.Ticket_Finalizar(Ticket);
            //    Persistentes.Estrellas = 0;
            //    Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se ha cerrado correctamente.", 2);
            //    this.Close();
            //}
            Persistentes.Tipo_tree = 1;
            Frm_Estrellas frm = new Frm_Estrellas(false);
            DialogResult dr= frm.ShowDialog();
            if(dr==DialogResult.OK)
            {
                this.Close();
            }
        }
        void Mensaje(String Texto, int Time = 2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }

        private void btn_Cargar_DocumentoSolicitud_Click(object sender, EventArgs e)
        {


           
        }

        private void btn_descargar_formato_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Avances_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Persistentes.Numero_Ticket = Convert.ToInt32(Persistentes.Numero_Ticket);
            Frm_TreeView frm = new Frm_TreeView();
            frm.ShowDialog();
        }

        private void Btn_Dowload_Click(object sender, EventArgs e)
        {
            string pathDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folder = pathDirectory + "temp/";
            string fullfilepath = folder + "/" + _solicitudCambio.Nombre_Doc_Solicitud;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            _solicitudCambio.Doc_Solicitud = _repositorySolicitud.Actualizar_Doc_Solicitud(_solicitudCambio).Doc_Solicitud;

            if (!File.Exists(fullfilepath))
            {
                using (FileStream st = new FileStream(fullfilepath, FileMode.Create))
                {
                    st.Write(_solicitudCambio.Doc_Solicitud, 0, _solicitudCambio.Doc_Solicitud.Length);
                    st.Close();
                }
                //File.WriteAllBytes(fullfilepath, _solicitudCambio.Doc_Solicitud);
            }
            else
            {
                File.WriteAllBytes(fullfilepath, _solicitudCambio.Doc_Solicitud);
            }

            Process.Start(fullfilepath);
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path_doc_solicitud = openFileDialog.FileName;

                byte[] file = null;
                Stream st = openFileDialog.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    st.CopyTo(ms);
                    file = ms.ToArray();
                }
                var extension = Path.GetExtension(path_doc_solicitud);
                if (_solicitudCambio.Status_Solicitud != "AU")
                {
                    if (_repositorySolicitud.Agregar_Documento_Solicitud_Usuario(_solicitudCambio.Id_Solicitud, "FO-SGI-25-SC(" + vSolicitudCambio + ")" + extension, file))
                    {

                        ActualizarDatosSolicitud();
                        Mensaje("Archivo guardado correctamente!");
                        Btn_Upload.Visible = false;
                    }
                }


            }
        }

        private void Btn_Dowload_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void Btn_Dowload_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(Btn_Dowload, "Descargar documento.");
        }

        private void Btn_Upload_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(Btn_Upload, "Subir documento.");
        }

        private void btn_Captura_Click(object sender, EventArgs e)
        {
            //var ticket = Persistentes.Numero_Ticket;
            //string path_doc_solicitud = null;
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    path_doc_solicitud = openFileDialog.FileName;
            //    var extension = Path.GetExtension(path_doc_solicitud);
            //    var nombre = Path.GetFileName(path_doc_solicitud);
            //    if (EsImagen(extension))
            //    {
            //        Stream st = openFileDialog.OpenFile();
            //        BinaryReader br = new BinaryReader(st);
            //        Base64 = Convert.ToBase64String(br.ReadBytes((int)st.Length));
            //        GuardarArchivo(ticket, extension, nombre);
            //    }
            //    else
            //    {
            //        Stream fs = openFileDialog.OpenFile();
            //        BinaryReader br = new BinaryReader(fs);
            //        Base64 = Convert.ToBase64String(br.ReadBytes((int)fs.Length));
            //        byte[] fileBytes;
            //        fileBytes = new byte[fs.Length];
            //        fs.Read(fileBytes, 0, fileBytes.Length);
            //        GuardarArchivo(ticket, extension, nombre);
            //    }
            //}
        }
        //private void GuardarArchivo(int ticket, string extension, string nombre)
        //{
            //TicketRequest tickets = new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket };
            //tickets = TicketRepository.Consultar_NivelSeguridad(tickets);
            //var q = RubroRepository.ConsultarRubrosU(new RubroRequest(), Convert.ToInt32(tickets.Id_Rubro));
            //numdoc = q.Num_Documento;
            //var p = RubroRepository.ConsultarRubrosU(new RubroRequest(), Persistentes.Id_Rubro);
            //List<ArchivosResponse> archivos = ArchivosRepository.ConsultarArchivos(new ArchivosRequest());
            //ArchivosRequest archivosRequest = new ArchivosRequest { Id_Ticket = Persistentes.Numero_Ticket };
            //var archivo = ArchivosRepository.ConsultarArchivos(archivosRequest).FirstOrDefault();
            //if (archivo != null)
            //{
            //    status = archivo.Status;
            //}
            //int numeroArchivos = NumeroArchivos(archivos);
            //var numDocumentoLimite = p.Num_Documento;
            //if (numeroArchivos >= numDocumentoLimite || numeroArchivos >= numdoc || (/*status == "R" || */status == "F" || status == "CE"))
            //{
            //    if(numeroArchivos < numdoc && (status == "AC" || status == "AS" || status == "A"))
            //    {
            //        TicketRepository.Guardar_Archivos(new ImagenRequest { Base64 = Base64, Id_Ticket = ticket, Extension = extension, Nombre = nombre });
            //        Persistentes.Mensaje("Se guardó " + nombre + " correctamente");
            //    }
            //    else
            //    {
            //        Persistentes.Mensaje("No es posible adjuntar mas documento");
            //    }
            //    return;
            //}
            //TicketRepository.Guardar_Archivos(new ImagenRequest { Base64 = Base64, Id_Ticket = ticket, Extension = extension, Nombre = nombre});
            //Persistentes.Mensaje("Se guardó " + nombre + " correctamente");
        //}

        //private int NumeroArchivos(List<ArchivosResponse> archivos)
        //{
        //    return archivos.Count;
        //}
        //private bool EsImagen(string extension)
        //{
        //    string[] extensionesImagenes = { ".jpg", ".jpeg", ".png", ".gif" };
        //    return extensionesImagenes.Contains(extension.ToLower());
        //}

        //public Image Base64ToImage(string base64String)
        //{
        //    // Convert Base64 String to byte[]
        //    byte[] imageBytes = Convert.FromBase64String(base64String);
        //    MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

        //    // Convert byte[] to Image
        //    ms.Write(imageBytes, 0, imageBytes.Length);
        //    Image image = Image.FromStream(ms, true);

        //    return image;
        //}

        private void Lbl_Ticket_Click(object sender, EventArgs e)
        {

        }

        private void btn_RegresarTicket_Click(object sender, EventArgs e)
        {
            //Persistentes.Tipo_tree = 1;
            //Frm_Comentarios frm = new Frm_Comentarios(10, IsAdmin);
            //frm.Size = new Size(806, 505);
            //DialogResult dr = frm.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
        }
    }
}
