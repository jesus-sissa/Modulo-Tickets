using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
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

namespace Modulo_Tickets
{
    public partial class Frm_NivelServicio : Form
    {
        int Prioridad_Proyecto = 0;
        int _IdTicket = 0;
        int _IdCategoria = 0;
        int _IdSubCategoria = 0;
        string _Categoria;
        string _SubCategoria;
        bool IsAdmin;
        public Frm_NivelServicio(int Id_Ticket,int Id_Categoria,int Id_SubCategoria,string Categoria,string SubCategoria)
        {
            InitializeComponent();
            _IdTicket = Id_Ticket;
            _IdCategoria = Id_Categoria;
            _IdSubCategoria = Id_SubCategoria;
            _Categoria = Categoria;
            _SubCategoria = SubCategoria;
        }

        private void Sli_Nivel_ValueChanged(object sender, EventArgs e)
        {
            //if (Sli_Nivel.Value < 1)
            //{
                
            //    Prioridad_Proyecto = 1;
            //    Lbl_Nivel.Text = "BAJO";
            //    Sli_Nivel.IndicatorColor = Color.SeaGreen;
            //}
            //else if (Sli_Nivel.Value < 2)
            //{
            //    Prioridad_Proyecto = 2;
            //    Lbl_Nivel.Text = "MEDIO";
            //    Sli_Nivel.IndicatorColor = Color.Orange;
            //}
            //else if (Sli_Nivel.Value < 3)
            //{
            //    Prioridad_Proyecto = 3;
            //    Lbl_Nivel.Text = "ALTO";
            //    Sli_Nivel.IndicatorColor = Color.Red;
            //}
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Frm_NivelServicio_Load(object sender, EventArgs e)
        {
            // DataTable tbl;
            // RubroRequest _Rubro = new RubroRequest { Id_Rubro = Persistentes.Id_RubroSeleccionado };
            // tbl=RubroRepository.ConsultarCategorias(_Rubro);
            // //foreach(DataRow Row in tbl.Rows)
            // //{
            //     Cmb_Categoria.DisplayMember="Nombre";
            //     Cmb_Categoria.ValueMember = "Id_Categoria";
            //     Cmb_Categoria.DataSource = tbl;
            //// }
            TicketRequest ticket = new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket };
            ticket = TicketRepository.Consultar_NivelSeguridad(ticket);
            if (ticket.Nivel_Servicio != 0)
            {
                Prioridad_Proyecto = ticket.Nivel_Servicio;
                Cmb_Prioridad.Visible = false;
                if (ticket.Nivel_Servicio == 1)
                {
                    label2.Text = "BAJA";
                }
                else if (ticket.Nivel_Servicio == 2)
                {
                    label2.Text = "MEDIA";
                }
                else
                {
                    label2.Text = "ALTA";
                }
            }
            Lbl_Categoria.Text = _Categoria;
            Lbl_SubCategoria.Text = _SubCategoria;
            
        }

        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if(Prioridad_Proyecto == 0)
            {
                if (Cmb_Prioridad.SelectedIndex != 0)
                {
                    if (Cmb_Prioridad.Text == "BAJA")
                    {
                        Prioridad_Proyecto = 1;
                    }
                    else if (Cmb_Prioridad.Text == "MEDIA")
                    {
                        Prioridad_Proyecto = 2;
                    }
                    else if (Cmb_Prioridad.Text == "ALTA")
                    {
                        Prioridad_Proyecto = 3;
                    }

                    TicketRequest _Ticket = new TicketRequest
                    {
                        Id_Ticket = _IdTicket,
                        Nivel_Servicio = Prioridad_Proyecto,
                        Id_Categoria = _IdCategoria,
                        Id_SubCategoria = _IdSubCategoria
                    };
                    TicketRepository.GuardarNivelServicio(_Ticket);
                    Persistentes.Mensaje("Prioridad guardada correctamente.", 1);

                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    Persistentes.Mensaje("Seleccione una prioridad.", 1);
                }
            }
            else
            {
                Persistentes.Tipo_tree = 1;
                Frm_Comentarios frm = new Frm_Comentarios(9, IsAdmin);
                frm.Size = new Size(806, 505);
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    TicketRequest _Ticket = new TicketRequest
                    {
                        Id_Ticket = _IdTicket,
                        Nivel_Servicio = Prioridad_Proyecto,
                        Id_Categoria = _IdCategoria,
                        Id_SubCategoria = _IdSubCategoria
                    };
                    TicketRepository.GuardarNivelServicio(_Ticket);
                    Persistentes.Mensaje("Recategorizacion guardada correctamente.", 1);
                }
                else
                {
                    Persistentes.Mensaje("No se guardaron los cambios");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Cmb_Prioridad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
