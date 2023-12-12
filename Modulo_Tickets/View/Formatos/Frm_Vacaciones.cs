using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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

namespace Modulo_Tickets.View.Formatos
{
    public partial class Frm_Vacaciones : Form
    {
        string Nombre;
        string Base64;
        string Nombre_archivo;
        public int Id_Flujo = 0;
        byte[] Huella;
        byte[] Firma_solicitante;
        int IdEmpleado;
        int dep = 0;
        int por = 0;
        int añoActual = DateTime.Now.Year;
        int DiasT = 0;
        int SaldoV = 0;
        public Frm_Vacaciones()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Btn_Guardar.Enabled = false;
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();

            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = ".pdf";
                savefile.FileName = string.Format("{0}.pdf", "Backup-" + DateTime.Now.ToString("ddMMyyyyHHmmss"));
                Nombre_archivo = savefile.FileName;
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nomina", txt_nomina.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nombre", Nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Departamento", txt_departamento.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fingreso", txt_fechaingreso.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Puesto", txt_puesto.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Pservicio", txt_puntodeservicio.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Periodo", cmb_periodoatomar.SelectedItem.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Diascorresponden", txt_diascorresponden.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Diasatomar", txt_diastomar.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Diasrestantes", txt_diasrestantes.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                decimal total = 0;
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
                using (MemoryStream ms = new MemoryStream())
                {
                    Document _pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter _pdf = PdfWriter.GetInstance(_pdfDoc, ms);
                    _pdfDoc.Open();
                    _pdfDoc.Add(new Phrase(""));
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.SISSA, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(_pdfDoc.LeftMargin, _pdfDoc.Top - 60);
                    _pdfDoc.Add(img);
                    iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance(Huella);
                    img1.ScaleToFit(70,70);
                    img1.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img1.SetAbsolutePosition(275, 530);
                    img1.Border = iTextSharp.text.Rectangle.BOX;
                    img1.BorderColor = iTextSharp.text.BaseColor.BLACK;
                    img1.BorderWidth = 5f;
                    _pdfDoc.Add(img1);
                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Firma_solicitante);
                    img2.ScaleToFit(150, 150);
                    img2.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img2.SetAbsolutePosition(30,510);
                    _pdfDoc.Add(img2);
                    iTextSharp.text.Image img3 = iTextSharp.text.Image.GetInstance(Persistentes.usuarioLogin_Firma);
                    img3.ScaleToFit(150, 150);
                    img3.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img3.SetAbsolutePosition(440,510);
                    _pdfDoc.Add(img3);
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(_pdf, _pdfDoc, sr);
                    }
                    _pdfDoc.Close();
                    if (txt_diastomar.Text == "" || txt_Regreso.Text =="")
                    {
                        Persistentes.Mensaje("Llenar toda la informacion solicitada");
                    }
                    else
                    {
                        if(Convert.ToInt32(txt_diastomar.Text) > Convert.ToInt32(txt_diasrestantes.Text))
                        {
                            Persistentes.Mensaje("No puedes tomar mas dias de los que tienes disponibles");
                        }
                        else
                        {
                            for (int año = 2018; año <= añoActual; año++)
                            {
                                SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = año };
                                SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                                solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                                DiasT = solicitud.DiasT;
                                SaldoV = solicitud.SaldoV;
                                if (año < Convert.ToInt32(cmb_periodoatomar.SelectedItem) && SaldoV != 0)
                                {
                                    Persistentes.Mensaje("Favor de usar los dias de periodos anteriores disponibles");
                                    Btn_Guardar.Enabled = true;
                                    return;
                                }
                            }
                            byte[] pdfBytes = ms.ToArray();
                            Base64 = Convert.ToBase64String(pdfBytes);
                            Guardarticket();
                            Guardar_EmpleadosVacaciones();
                            Actualizar_DiasVacaciones();
                            return;
                        }
                    }
                    Btn_Guardar.Enabled = true;
                    //string filePath = savefile.FileName; //para abrir el pdf sin necesidad de guardar nada
                    //File.WriteAllBytes(filePath, ms.ToArray());
                    //Process.Start(filePath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar generar el reporte", "Error");
                Btn_Guardar.Enabled = true;
            }
            
        }
        void Enviar_Correo(int Id_Flujo)
        {
            Persistentes.Id_Tarea_Flujo = Persistentes.Id_Tarea;
            CorreoResponseFlujo Seguimiento;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Id_Flujo };
            CorreoResponseFlujo correo;
            TicketFlujoRequest ticketFlujo = new TicketFlujoRequest { Id_Tareas = Persistentes.Id_Tarea, Id_Flujo = Id_Flujo };
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
        void Guardarticket()
        {
            int Numero_Flujo = 0;
            TareasRequest tareas = new TareasRequest();
            TareasRequest request = new TareasRequest();
            tareas = TareasRepository.Consultar_Status_Procedimiento(request);
            string status = tareas.Status == "S" ? "AC" : "IN";
            string Autorizacion = tareas.Autorizacion == "S" ? "P" : "NA";
            TicketFlujoRequest flujoRequest = new TicketFlujoRequest
            {
                Descripcion = "SOLICITUD DE VACACIONES " +
                " Fecha Inicio de Vacaciones:" + txt_inicio.Text + 
                " Fecha Regreso de Vacaciones:" + txt_Regreso.Text,
                Id_Flujo = Id_Flujo,
                UsuarioId = IdEmpleado,
                Status = status,
                Porcentaje = por,
                Autorizacion = Autorizacion
            };
            Numero_Flujo = TareasRepository.GuardarTicketFlujo(flujoRequest);
            TicketRepository.Guardar_Formatos(new ImagenRequest { Base64 = Base64, Id_Flujo = Numero_Flujo, Extension = ".pdf", Nombre = Nombre_archivo });
            TicketRepository.Guardar_Statuss(new TicketFlujoRequest { Id_Flujo = Numero_Flujo });
            flujoRequest = new TicketFlujoRequest { Id_Flujo = Numero_Flujo, UsuarioId = IdEmpleado, Descripcion = "NUEVA SOLICITUD" };
            TareasRepository.GuardarSprintFlujo(flujoRequest);
            Persistentes.Id_Flujo = Numero_Flujo;
            Enviar_Correo(Numero_Flujo);
            Mensaje("La Solicitud con # " + Numero_Flujo.ToString() + " se registro correctamente", 3);            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        void Mensaje(String Texto, int Time = 2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }
        private void Frm_Vacaciones_Load(object sender, EventArgs e)
        {
            for (int año = 2018; año <= añoActual; año++)
            {
                cmb_periodoatomar.Items.Add(año);
            }
            //cmb_periodoatomar.SelectedItem = añoActual;
            txt_diastomar.Text = "0";
            txt_inicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lsv_Descanso.Columns.Clear();
            lsv_Descanso.Columns.Add("Fecha", 85, HorizontalAlignment.Left);
            lsv_Descanso.Columns.Add("Tipo", 89, HorizontalAlignment.Left);
            if (Persistentes.Usuario_Login_Nombre == "ENRIQUE VILLANUEVA HERNANDEZ" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ MANAUTOU" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ GOMEZ JUNCO") 
            {
                List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado_Todos(new SolicitudVacacionesRequest());
                cmb_empleados.DisplayMember = "Nombre";
                cmb_empleados.ValueMember = "Id_Empleado";
                cmb_empleados.DataSource = Persistentes.Empleado;
                int seleccionar;
                if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                {
                    var datos = (from emp in Empleado_Datos
                                 where emp.Id_Empleado == seleccionar
                                 select emp).FirstOrDefault();

                    txt_nomina.Text = datos.Clave_Empleado.ToString();
                    txt_fechaingreso.Text = datos.Fecha_Ingreso;
                    txt_departamento.Text = datos.Departamento;
                    txt_puesto.Text = datos.Puesto;
                    Nombre = datos.Nombre;
                    Huella = datos.Huella;
                    Firma_solicitante = datos.Firma;
                    IdEmpleado = datos.Id_Empleado;
                    txt_puntodeservicio.Text = Persistentes.Nombre_Sucursal;
                }
                //SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = añoActual };
                //SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                //solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                //DiasT = solicitud.DiasT;
                //SaldoV = solicitud.SaldoV;
                //txt_diascorresponden.Text = Convert.ToString(DiasT);
                //txt_diasrestantes.Text = Convert.ToString(SaldoV);
                for(int año = 2018; año <= añoActual; año++)
                {
                    SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = año };
                    SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                    solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                    DiasT = solicitud.DiasT;
                    SaldoV = solicitud.SaldoV;
                    if (SaldoV >0)
                    {
                        cmb_periodoatomar.SelectedItem = año;
                        txt_diascorresponden.Text = Convert.ToString(DiasT);
                        txt_diasrestantes.Text = Convert.ToString(SaldoV);
                        return;
                    }
                }
            }
            else
            {
                foreach (var item in FormatosRepository.Consultar_Jefe(new FormatosRequest { UsuarioId = Persistentes.Usuario_Login }))
                {
                    dep = item.departamento;
                }
                if (dep == 0)
                {
                    Persistentes.Mensaje("Favor de acercarse a su jefe directo o gerente");
                    this.Close();
                }
                else
                {
                    List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado(new SolicitudVacacionesRequest { departamento = dep });
                    cmb_empleados.DisplayMember = "Nombre";
                    cmb_empleados.ValueMember = "Id_Empleado";
                    cmb_empleados.DataSource = Persistentes.Empleado;
                    int seleccionar;
                    if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                    {
                        var datos = (from emp in Empleado_Datos
                                     where emp.Id_Empleado == seleccionar
                                     select emp).FirstOrDefault();

                        txt_nomina.Text = datos.Clave_Empleado.ToString();
                        txt_fechaingreso.Text = datos.Fecha_Ingreso;
                        txt_departamento.Text = datos.Departamento;
                        txt_puesto.Text = datos.Puesto;
                        Nombre = datos.Nombre;
                        Huella = datos.Huella;
                        Firma_solicitante = datos.Firma;
                        IdEmpleado = datos.Id_Empleado;
                        txt_puntodeservicio.Text = Persistentes.Nombre_Sucursal;
                    }
                }
                //SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = añoActual };
                //SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                //solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                //DiasT = solicitud.DiasT;
                //SaldoV = solicitud.SaldoV;
                //txt_diascorresponden.Text = Convert.ToString(DiasT);
                //txt_diasrestantes.Text = Convert.ToString(SaldoV);
                for (int año = 2018; año <= añoActual; año++)
                {
                    SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = año };
                    SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                    solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                    DiasT = solicitud.DiasT;
                    SaldoV = solicitud.SaldoV;
                    if (SaldoV > 0)
                    {
                        cmb_periodoatomar.SelectedItem = año;
                        txt_diascorresponden.Text = Convert.ToString(DiasT);
                        txt_diasrestantes.Text = Convert.ToString(SaldoV);
                        return;
                    }
                }
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nomina_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Regreso.Clear();
            añoActual = DateTime.Now.Year;
            //cmb_periodoatomar.SelectedItem = añoActual;
            txt_diastomar.Text = "0";
            txt_inicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lsv_Descanso.Items.Clear();
            if (Persistentes.Usuario_Login_Nombre == "ENRIQUE VILLANUEVA HERNANDEZ" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ MANAUTOU" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ GOMEZ JUNCO")
            {
                List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado_Todos(new SolicitudVacacionesRequest());
                int seleccionar;
                if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                {
                    var datos = (from emp in Empleado_Datos
                                 where emp.Id_Empleado == seleccionar
                                 select emp).FirstOrDefault();
                    txt_nomina.Text = datos.Clave_Empleado.ToString();
                    txt_fechaingreso.Text = datos.Fecha_Ingreso;
                    txt_departamento.Text = datos.Departamento;
                    txt_puesto.Text = datos.Puesto;
                    Nombre = datos.Nombre;
                    Huella = datos.Huella;
                    Firma_solicitante = datos.Firma;
                    IdEmpleado = datos.Id_Empleado;
                    txt_puntodeservicio.Text = Persistentes.Nombre_Sucursal;
                }
                //SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = añoActual };
                //SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                //solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                //DiasT = solicitud.DiasT;
                //SaldoV = solicitud.SaldoV;
                //txt_diascorresponden.Text = Convert.ToString(DiasT);
                //txt_diasrestantes.Text = Convert.ToString(SaldoV);
                for (int año = 2018; año <= añoActual; año++)
                {
                    SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = año };
                    SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                    solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                    DiasT = solicitud.DiasT;
                    SaldoV = solicitud.SaldoV;
                    if (SaldoV > 0)
                    {
                        cmb_periodoatomar.SelectedItem = año;
                        txt_diascorresponden.Text = Convert.ToString(DiasT);
                        txt_diasrestantes.Text = Convert.ToString(SaldoV);
                        return;
                    }
                }
            }
            else
            {
                List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado(new SolicitudVacacionesRequest { departamento = dep });
                int seleccionar;
                if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                {
                    var datos = (from emp in Empleado_Datos
                                 where emp.Id_Empleado == seleccionar
                                 select emp).FirstOrDefault();
                    txt_nomina.Text = datos.Clave_Empleado.ToString();
                    txt_fechaingreso.Text = datos.Fecha_Ingreso;
                    txt_departamento.Text = datos.Departamento;
                    txt_puesto.Text = datos.Puesto;
                    Nombre = datos.Nombre;
                    Huella = datos.Huella;
                    Firma_solicitante = datos.Firma;
                    IdEmpleado = datos.Id_Empleado;
                    txt_puntodeservicio.Text = Persistentes.Nombre_Sucursal;
                }
                //SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = añoActual };
                //SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                //solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                //DiasT = solicitud.DiasT;
                //SaldoV = solicitud.SaldoV;
                //txt_diascorresponden.Text = Convert.ToString(DiasT);
                //txt_diasrestantes.Text = Convert.ToString(SaldoV);
                for (int año = 2018; año <= añoActual; año++)
                {
                    SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = año };
                    SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
                    solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
                    DiasT = solicitud.DiasT;
                    SaldoV = solicitud.SaldoV;
                    if (SaldoV > 0)
                    {
                        cmb_periodoatomar.SelectedItem = año;
                        txt_diascorresponden.Text = Convert.ToString(DiasT);
                        txt_diasrestantes.Text = Convert.ToString(SaldoV);
                        return;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_inicio.Text = monthCalendar1.SelectionStart.Date.ToString("dd/MM/yyyy");
            CalcularRegreso();
        }
        private void CalcularRegreso()
        {
            if(txt_diascorresponden.Text == "")
            {
                txt_Regreso.Text = monthCalendar1.SelectionStart.Date.ToString("dd/MM/yyyy");
            }
            else
            {
                if(txt_diastomar.Text == "0")
                {
                    Mensaje("Favor de ingresar la cantidad de dias a tomar");
                }
                else
                {
                    DateTime Fechainicio = monthCalendar1.SelectionStart.Date;
                    DateTime Fecharegreso = Fechainicio.AddDays(Convert.ToInt32(txt_diastomar.Text));
                    // Recorrer los días de descanso para sumarlos
                    foreach (ListViewItem elemento in lsv_Descanso.Items)
                    {
                        if (DateTime.Parse(elemento.Text) >= Fechainicio && DateTime.Parse(elemento.Text) <= Fecharegreso)
                        {
                            Fecharegreso = Fecharegreso.AddDays(1);
                        }
                    }
                    // Recorrer de nuevo para añadir cuando el día de regreso sea de descanso o festivo.
                    foreach (ListViewItem e in lsv_Descanso.Items)
                    {
                        if (DateTime.Parse(e.Text) == Fecharegreso)
                        {
                            Fecharegreso = Fecharegreso.AddDays(1);
                        }
                    }
                    txt_Regreso.Text = Fecharegreso.ToString("dd/MM/yyyy");
                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem elemento in lsv_Descanso.Items)
            {
                if (elemento.Text == monthCalendar2.SelectionStart.Date.ToString("d"))
                {
                    Mensaje("La fecha " + monthCalendar2.SelectionStart.ToString("d") + " ya se agregó anteriormente.");
                    return;
                }
            }
            ListViewItem elem = new ListViewItem();
            if (lsv_Descanso.Items.Count == 0)
            {
                lsv_Descanso.Items.Add(monthCalendar2.SelectionStart.Date.ToString("d"));
                lsv_Descanso.Items[lsv_Descanso.Items.Count - 1].SubItems.Add("DESCANSO");
            }
            else
            {
                // Insertar el nuevo elemento en el lugar que le corresponde
                for (int i = 0; i < lsv_Descanso.Items.Count; i++)
                {
                    if (monthCalendar2.SelectionStart.Date < DateTime.Parse(lsv_Descanso.Items[0].Text))
                    {
                        // Insertar el elemento al inicio
                        elem.Text = monthCalendar2.SelectionStart.Date.ToString("d");
                        elem.SubItems.Add("DESCANSO");
                        lsv_Descanso.Items.Insert(0, elem);
                        break;
                    }
                    else if ((i + 1) < lsv_Descanso.Items.Count)
                    {
                        if (monthCalendar2.SelectionStart.Date < DateTime.Parse(lsv_Descanso.Items[i + 1].Text))
                        {
                            // Insertar el elemento en la posición correspondiente
                            elem.Text = monthCalendar2.SelectionStart.Date.ToString("d");
                            elem.SubItems.Add("DESCANSO");
                            lsv_Descanso.Items.Insert(i + 1, elem);
                            break;
                        }
                    }
                    else
                    {
                        // Insertar al final
                        lsv_Descanso.Items.Add(monthCalendar2.SelectionStart.Date.ToString("d"));
                        lsv_Descanso.Items[lsv_Descanso.Items.Count - 1].SubItems.Add("DESCANSO");
                        break;
                    }
                }
            }

            CalcularRegreso();
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (lsv_Descanso.SelectedItems.Count > 0)
            {
                lsv_Descanso.Items.Remove(lsv_Descanso.SelectedItems[0]);
                btn_Quitar.Enabled = false;
                CalcularRegreso();
            }
        }

        private void lsv_Descanso_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Quitar.Enabled = false;
            if(lsv_Descanso.SelectedItems.Count > 0)
            {
                btn_Quitar.Enabled = true;
            }
        }

        private void cmb_periodoatomar_SelectedIndexChanged(object sender, EventArgs e)
        {
            añoActual = (int)cmb_periodoatomar.SelectedItem;
            SolicitudVacacionesRequest vacacionesRequest = new SolicitudVacacionesRequest { Clave_Empleado = txt_nomina.Text, Periodo = añoActual };
            SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
            solicitud = FormatosRepository.Consultar_Dias_Vacaciones(vacacionesRequest);
            DiasT = solicitud.DiasT;
            SaldoV = solicitud.SaldoV;
            txt_diascorresponden.Text = Convert.ToString(DiasT);
            txt_diasrestantes.Text = Convert.ToString(SaldoV);
            txt_diastomar.Text = "0";
            txt_Regreso.Clear();
            txt_inicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Guardar_EmpleadosVacaciones()
        {
            SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest
            {
                Id_Empleado = IdEmpleado,
                Fecha_Requerida = txt_inicio.Text,
                DiasT = Convert.ToInt32(txt_diastomar.Text),
                SaldoV = SaldoV,
                Comentario_Solicita = txt_Comentario.Text,
                Usuario_Registro = Persistentes.Usuario_Login,
                Usuario_Autoriza = Persistentes.Usuario_Login,
                Fecha_Regreso = txt_Regreso.Text
            };
            FormatosRepository.Guardar_EmpleadosVacaciones(solicitud);
        }
        private void Actualizar_DiasVacaciones()
        {
            int Dtomados = 0;
            int SaldoNuevo = 0;
            Dtomados = (DiasT - SaldoV) + Convert.ToInt32(txt_diastomar.Text);
            SaldoNuevo = SaldoV - Convert.ToInt32(txt_diastomar.Text);
            SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest
            {
                Clave_Empleado = txt_nomina.Text,
                Periodo = añoActual,
                DiasT = DiasT,
                DTomados = Dtomados,
                SaldoV = SaldoNuevo
            };
            FormatosRepository.Actualizar_DiasVacaciones(solicitud);
        }
    }
}
