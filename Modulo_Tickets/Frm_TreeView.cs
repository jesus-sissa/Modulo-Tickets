using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using Newtonsoft.Json;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_TreeView : Form
    {
        string Fecha = string.Empty;

        public Frm_TreeView()
        {
            InitializeComponent();
        }

        private void Frm_TreeView_Load(object sender, EventArgs e)
        {
            if(Persistentes.Tipo_tree == 1)
            {
                Tre_secuencia.Nodes.Add("Ticket #: " + Persistentes.Numero_Ticket.ToString());
                Llenar_arbol();
            }
            else
            {
                Tre_secuencia.Nodes.Add("Solicitud #: " + Persistentes.Id_Flujo.ToString());
                Llenar_arbolFlujo();
            }
        }
        //void Llenar_arbol(int Id_Ticket)
        //{

        //    WsCajeroInteligente.WsCashFlowSoapClient WsCajero = new WsCajeroInteligente.WsCashFlowSoapClient();
        //    string json = WsCajero.Consultar_Tickets_Sucursal_ID(Properties.Settings.Default.Plaza + "%" +Id_Ticket.ToString());
        //    DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
        //    Fecha = string.Empty;

        //    foreach (DataRow item in dt.Rows)
        //    {
        //        if (Fecha == string.Empty)
        //        {
        //            Fecha = item["Fecha"].ToString();
        //            Tre_secuencia.Nodes[0].Nodes.Add(Fecha);
        //        }
        //        else if (item["Fecha"].ToString() != Fecha)
        //        {
        //            Fecha = item["Fecha"].ToString();
        //            Tre_secuencia.Nodes[0].Nodes.Add(Fecha);
        //        }
        //    }

        //    foreach (TreeNode n in Tre_secuencia.Nodes[0].Nodes)
        //    {

        //        foreach (DataRow item in dt.Rows)
        //        {
        //            if (n.Text == item["Fecha"].ToString())
        //            {
        //                n.Nodes.Add(item["Hora"].ToString().Substring(0,8) + ":" + item["Descripcion"].ToString());
        //            }
        //        }

        //    }
        //    Tre_secuencia.Nodes[0].ExpandAll();
        //}
        void Llenar_arbol()
        {
            BaseRequest BaseRequest = new BaseRequest();
            Fecha = string.Empty;
            List<TicketDResponse> Sprint = new List<TicketDResponse>();
            Sprint = TicketRepository.ConsultarTicketD_Soporte(BaseRequest);

            foreach(var item in Sprint)
            {
                if (Fecha == string.Empty)
                {
                    Fecha = item.Fecha;
                    Tre_secuencia.Nodes[0].Nodes.Add(Fecha);                    
                }
                else if(item.Fecha!=Fecha)
                {
                    Fecha = item.Fecha;
                    Tre_secuencia.Nodes[0].Nodes.Add(Fecha);
                }
            }

            foreach (TreeNode n in Tre_secuencia.Nodes[0].Nodes)
            {
              
                foreach (var item in Sprint)
                {
                    if(n.Text==item.Fecha)
                    {
                        n.Nodes.Add(item.Hora.Substring(0,8)+":"+ item.Descripcion);
                    }
                }
                
            }
           Tre_secuencia.Nodes[0].ExpandAll();
        }
        void Llenar_arbolFlujo()
        {
            BaseRequest BaseRequest = new BaseRequest();
            Fecha = string.Empty;
            List<FlujoDResponse> flujoDs = new List<FlujoDResponse>();
            flujoDs = TareasRepository.ConsultarFlujoD_Soporte(BaseRequest);
            foreach (var item in flujoDs)
            {
                if (Fecha == string.Empty)
                {
                    Fecha = item.Fecha;
                    Tre_secuencia.Nodes[0].Nodes.Add(Fecha);
                }
                else if (item.Fecha != Fecha)
                {
                    Fecha = item.Fecha;
                    Tre_secuencia.Nodes[0].Nodes.Add(Fecha);
                }
            }

            foreach (TreeNode n in Tre_secuencia.Nodes[0].Nodes)
            {

                foreach (var item in flujoDs)
                {
                    if (n.Text == item.Fecha)
                    {
                        n.Nodes.Add(item.Hora.Substring(0, 8) + ":" + item.Descripcion);
                    }
                }

            }
            Tre_secuencia.Nodes[0].ExpandAll();
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tre_secuencia_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
