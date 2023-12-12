using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_FlujoNuevo : Form
    {
        List<ImagenRequest> _Files = new List<ImagenRequest>();
        string Base64;
        public int Id_Flujo = 0;
        int _Id_Tarea = 0;
        List<TareasDptosResponse> _Departamentos;
        int _Id_Dptos = 0;
        int por = 0;
        public Frm_FlujoNuevo()
        {
            InitializeComponent();
        }
        private void Frm_FlujoNuevo_Load(object sender, EventArgs e)
        {
            Lbl_Nombre.Text = Persistentes.Nombre_Tarea;
        }
        
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
            //    string titulo = "El Archivo Adjuntado es: ";
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
                    if (path_doc_solicitud.Length > 0)
                    {
                        label1.Text = "Se han adjuntado " + path_doc_solicitud.Length + " archivos.";
                    }
                }
            }
        }
        //private bool EsImagen(string extension)
        //{
        //    string[] extensionesImagenes = { ".jpg", ".jpeg", ".png", ".gif" };
        //    return extensionesImagenes.Contains(extension.ToLower());
        //}

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Mensaje(String Texto, int Time = 2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }
        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Btn_Enviar.Enabled = false;
            int Numero_Flujo = 0;
            if (Txt_Descripcion.Text == string.Empty || Txt_Descripcion.Text.Length < 5)
            {
                Mensaje("Ingrese una descripción mas completa.", 3);
                //Lbl_Alerta.Text = "*Ingrese una descripción.";
                Txt_Descripcion.Focus();
            }
            else 
            {
                TareasRequest tareas = new TareasRequest();
                TareasRequest request = new TareasRequest();
                tareas = TareasRepository.Consultar_Status_Procedimiento(request);
                string status = tareas.Status == "S" ? "AC" : "IN";
                string Autorizacion = tareas.Autorizacion == "S" ? "P" : "NA";
                TicketFlujoRequest flujoRequest = new TicketFlujoRequest
                {
                    Descripcion = Txt_Descripcion.Text.Trim(),
                    Id_Flujo = Id_Flujo,
                    Status = status,
                    Porcentaje = por,
                    Autorizacion = Autorizacion
                };
                var path_doc_solicitud = openFileDialog.FileName;
                var extension = Path.GetExtension(path_doc_solicitud);
                var nombre = Path.GetFileName(path_doc_solicitud);
                Numero_Flujo = TareasRepository.GuardarTicketFlujo(flujoRequest);
                TicketRepository.Guardar_Archivos(_Files, 0, Numero_Flujo);
                //TicketRepository.Guardar_Archivos(new ImagenRequest { Base64 = Base64, Id_Flujo = Numero_Flujo, Extension = extension, Nombre = nombre });
                TicketRepository.Guardar_Statuss(new TicketFlujoRequest { Id_Flujo = Numero_Flujo });
                flujoRequest = new TicketFlujoRequest { Id_Flujo = Numero_Flujo, UsuarioId = Persistentes.Usuario_Login, Descripcion = "NUEVA SOLICITUD" };
                TareasRepository.GuardarSprintFlujo(flujoRequest);
                Persistentes.Id_Flujo = Numero_Flujo;
                Enviar_Correo(Numero_Flujo);
                Mensaje("La Solicitud con # " + Numero_Flujo.ToString() + " se registro correctamente", 3);
                Btn_Enviar.Enabled = true;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        void Enviar_Correo(int Id_Flujo)
        {
            Persistentes.Id_Tarea_Flujo = Persistentes.Id_Tarea;
            CorreoResponseFlujo Seguimiento;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Id_Flujo };
            CorreoResponseFlujo correo;
            TicketFlujoRequest ticketFlujo = new TicketFlujoRequest {Id_Tareas = Persistentes.Id_Tarea, Id_Flujo = Id_Flujo };
            try
            {
                Seguimiento = TareasRepository.Correo_Seguimiento(Ticket);
                correo = TareasRepository.Correo_Seguimiento_Involucrados(ticketFlujo);
                Correo.MailFlujo_UsuarioNotificacion(Seguimiento);
                Correo.Mail_ProcedimientoNotificacion(correo);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }
        }
        private void Txt_Descripcion_Leave(object sender, EventArgs e)
        {
            if(Txt_Descripcion.Text == string.Empty)
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
        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Descripcion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lbl_Alerta_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Externo_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
