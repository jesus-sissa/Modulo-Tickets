
namespace Modulo_Tickets
{
    partial class Frm_AdminGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdminGeneral));
            this.Flow_Rubros = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Tickets = new Bunifu.Framework.UI.BunifuTileButton();
            this.Btn_Proyectos = new Bunifu.Framework.UI.BunifuTileButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pnl_Centro = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Flow_Rubros.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flow_Rubros
            // 
            this.Flow_Rubros.Controls.Add(this.Btn_Tickets);
            this.Flow_Rubros.Controls.Add(this.Btn_Proyectos);
            this.Flow_Rubros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow_Rubros.Location = new System.Drawing.Point(0, 0);
            this.Flow_Rubros.Name = "Flow_Rubros";
            this.Flow_Rubros.Size = new System.Drawing.Size(1127, 224);
            this.Flow_Rubros.TabIndex = 0;
            // 
            // Btn_Tickets
            // 
            this.Btn_Tickets.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Tickets.color = System.Drawing.Color.SeaGreen;
            this.Btn_Tickets.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Tickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Tickets.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Tickets.ForeColor = System.Drawing.Color.White;
            this.Btn_Tickets.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Tickets.Image")));
            this.Btn_Tickets.ImagePosition = 20;
            this.Btn_Tickets.ImageZoom = 50;
            this.Btn_Tickets.LabelPosition = 41;
            this.Btn_Tickets.LabelText = "TICKETS";
            this.Btn_Tickets.Location = new System.Drawing.Point(6, 6);
            this.Btn_Tickets.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Tickets.Name = "Btn_Tickets";
            this.Btn_Tickets.Size = new System.Drawing.Size(229, 186);
            this.Btn_Tickets.TabIndex = 2;
            this.Btn_Tickets.Click += new System.EventHandler(this.Btn_Tickets_Click);
            // 
            // Btn_Proyectos
            // 
            this.Btn_Proyectos.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Proyectos.color = System.Drawing.Color.SeaGreen;
            this.Btn_Proyectos.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Proyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Proyectos.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Proyectos.ForeColor = System.Drawing.Color.White;
            this.Btn_Proyectos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Proyectos.Image")));
            this.Btn_Proyectos.ImagePosition = 20;
            this.Btn_Proyectos.ImageZoom = 50;
            this.Btn_Proyectos.LabelPosition = 41;
            this.Btn_Proyectos.LabelText = "PROYECTOS";
            this.Btn_Proyectos.Location = new System.Drawing.Point(247, 6);
            this.Btn_Proyectos.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Proyectos.Name = "Btn_Proyectos";
            this.Btn_Proyectos.Size = new System.Drawing.Size(229, 186);
            this.Btn_Proyectos.TabIndex = 3;
            this.Btn_Proyectos.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar.png");
            this.imageList1.Images.SetKeyName(1, "cheque.png");
            // 
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.filtroToolStripMenuItem.Text = "Filtro de busqueda";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 34);
            // 
            // Pnl_Centro
            // 
            this.Pnl_Centro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Pnl_Centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Centro.Location = new System.Drawing.Point(0, 224);
            this.Pnl_Centro.Name = "Pnl_Centro";
            this.Pnl_Centro.Size = new System.Drawing.Size(1127, 331);
            this.Pnl_Centro.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Flow_Rubros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 224);
            this.panel1.TabIndex = 4;
            // 
            // Frm_AdminGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1127, 555);
            this.Controls.Add(this.Pnl_Centro);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_AdminGeneral";
            this.Text = "Frm_AdminGeneral";
            this.Load += new System.EventHandler(this.Frm_AdminGeneral_Load);
            this.Flow_Rubros.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow_Rubros;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Tickets;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Proyectos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem filtroToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel Pnl_Centro;
        private System.Windows.Forms.Panel panel1;
    }
}