
namespace Modulo_Tickets
{
    partial class Frm_FlujoStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FlujoStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_Rubro = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Chk_Todos = new System.Windows.Forms.RadioButton();
            this.Rdb_Actuando = new System.Windows.Forms.RadioButton();
            this.Rdb_Terminados = new System.Windows.Forms.RadioButton();
            this.Rdb_Cerrados = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Dgv_Tickets = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel5 = new System.Windows.Forms.Panel();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Flujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Cerrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar.png");
            this.imageList1.Images.SetKeyName(1, "cheque.png");
            this.imageList1.Images.SetKeyName(2, "Rechazado.png");
            this.imageList1.Images.SetKeyName(3, "Terminado.png");
            // 
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.filtroToolStripMenuItem.Text = "Filtro de busqueda";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1216, 43);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Lbl_Rubro
            // 
            this.Lbl_Rubro.AutoSize = true;
            this.Lbl_Rubro.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rubro.ForeColor = System.Drawing.Color.White;
            this.Lbl_Rubro.Location = new System.Drawing.Point(23, 9);
            this.Lbl_Rubro.Name = "Lbl_Rubro";
            this.Lbl_Rubro.Size = new System.Drawing.Size(282, 39);
            this.Lbl_Rubro.TabIndex = 70;
            this.Lbl_Rubro.Text = "Mis Asignaciones";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.Lbl_Rubro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1236, 64);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel6.Controls.Add(this.Chk_Todos);
            this.panel6.Controls.Add(this.Rdb_Actuando);
            this.panel6.Controls.Add(this.Rdb_Terminados);
            this.panel6.Controls.Add(this.Rdb_Cerrados);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(614, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(622, 64);
            this.panel6.TabIndex = 72;
            // 
            // Chk_Todos
            // 
            this.Chk_Todos.AutoSize = true;
            this.Chk_Todos.Checked = true;
            this.Chk_Todos.Dock = System.Windows.Forms.DockStyle.Right;
            this.Chk_Todos.ForeColor = System.Drawing.Color.White;
            this.Chk_Todos.Location = new System.Drawing.Point(357, 0);
            this.Chk_Todos.Name = "Chk_Todos";
            this.Chk_Todos.Size = new System.Drawing.Size(55, 64);
            this.Chk_Todos.TabIndex = 5;
            this.Chk_Todos.TabStop = true;
            this.Chk_Todos.Text = "Todos";
            this.Chk_Todos.UseVisualStyleBackColor = true;
            this.Chk_Todos.CheckedChanged += new System.EventHandler(this.Chk_Todos_CheckedChanged);
            // 
            // Rdb_Actuando
            // 
            this.Rdb_Actuando.AutoSize = true;
            this.Rdb_Actuando.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rdb_Actuando.ForeColor = System.Drawing.Color.White;
            this.Rdb_Actuando.Location = new System.Drawing.Point(412, 0);
            this.Rdb_Actuando.Name = "Rdb_Actuando";
            this.Rdb_Actuando.Size = new System.Drawing.Size(71, 64);
            this.Rdb_Actuando.TabIndex = 2;
            this.Rdb_Actuando.TabStop = true;
            this.Rdb_Actuando.Text = "Actuando";
            this.Rdb_Actuando.UseVisualStyleBackColor = true;
            this.Rdb_Actuando.CheckedChanged += new System.EventHandler(this.Rdb_Actuando_CheckedChanged);
            // 
            // Rdb_Terminados
            // 
            this.Rdb_Terminados.AutoSize = true;
            this.Rdb_Terminados.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rdb_Terminados.ForeColor = System.Drawing.Color.White;
            this.Rdb_Terminados.Location = new System.Drawing.Point(483, 0);
            this.Rdb_Terminados.Name = "Rdb_Terminados";
            this.Rdb_Terminados.Size = new System.Drawing.Size(72, 64);
            this.Rdb_Terminados.TabIndex = 1;
            this.Rdb_Terminados.TabStop = true;
            this.Rdb_Terminados.Text = "Resueltos";
            this.Rdb_Terminados.UseVisualStyleBackColor = true;
            this.Rdb_Terminados.CheckedChanged += new System.EventHandler(this.Rdb_Terminados_CheckedChanged);
            // 
            // Rdb_Cerrados
            // 
            this.Rdb_Cerrados.AutoSize = true;
            this.Rdb_Cerrados.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rdb_Cerrados.ForeColor = System.Drawing.Color.White;
            this.Rdb_Cerrados.Location = new System.Drawing.Point(555, 0);
            this.Rdb_Cerrados.Name = "Rdb_Cerrados";
            this.Rdb_Cerrados.Size = new System.Drawing.Size(67, 64);
            this.Rdb_Cerrados.TabIndex = 0;
            this.Rdb_Cerrados.TabStop = true;
            this.Rdb_Cerrados.Text = "Cerrados";
            this.Rdb_Cerrados.UseVisualStyleBackColor = true;
            this.Rdb_Cerrados.CheckedChanged += new System.EventHandler(this.Rdb_Cerrados_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 452);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 452);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Dgv_Tickets
            // 
            this.Dgv_Tickets.AllowUserToAddRows = false;
            this.Dgv_Tickets.AllowUserToDeleteRows = false;
            this.Dgv_Tickets.AllowUserToResizeColumns = false;
            this.Dgv_Tickets.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.Dgv_Tickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Tickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Dgv_Tickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Tickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_Tickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Tickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.Numero,
            this.dataGridViewTextBoxColumn2,
            this.Nombre_Flujo,
            this.Descripcion,
            this.Status,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.Fecha_Cerrado,
            this.Porcentaje,
            this.Autorizado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Tickets.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Tickets.DoubleBuffered = true;
            this.Dgv_Tickets.EnableHeadersVisualStyles = false;
            this.Dgv_Tickets.GridColor = System.Drawing.Color.White;
            this.Dgv_Tickets.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Dgv_Tickets.HeaderForeColor = System.Drawing.Color.White;
            this.Dgv_Tickets.Location = new System.Drawing.Point(0, 64);
            this.Dgv_Tickets.MultiSelect = false;
            this.Dgv_Tickets.Name = "Dgv_Tickets";
            this.Dgv_Tickets.ReadOnly = true;
            this.Dgv_Tickets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Tickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Tickets.RowHeadersVisible = false;
            this.Dgv_Tickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Green;
            this.Dgv_Tickets.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Tickets.Size = new System.Drawing.Size(1236, 388);
            this.Dgv_Tickets.TabIndex = 84;
            this.Dgv_Tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellClick);
            this.Dgv_Tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.Dgv_Tickets);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1236, 452);
            this.panel5.TabIndex = 14;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // img
            // 
            this.img.FillWeight = 49.60001F;
            this.img.HeaderText = "";
            this.img.Name = "img";
            this.img.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.FillWeight = 124.0001F;
            this.Numero.HeaderText = "#Solicitudes";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 124.0001F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuario Reporta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Nombre_Flujo
            // 
            this.Nombre_Flujo.FillWeight = 112.0829F;
            this.Nombre_Flujo.HeaderText = "Nombre de la Solicitud";
            this.Nombre_Flujo.Name = "Nombre_Flujo";
            this.Nombre_Flujo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 138.2813F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 124.0001F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 124.0001F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Reporta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 112.0829F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha Resuelto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Fecha_Cerrado
            // 
            this.Fecha_Cerrado.HeaderText = "Fecha Cerrado";
            this.Fecha_Cerrado.Name = "Fecha_Cerrado";
            this.Fecha_Cerrado.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // Autorizado
            // 
            this.Autorizado.HeaderText = "Autorizado";
            this.Autorizado.Name = "Autorizado";
            this.Autorizado.ReadOnly = true;
            // 
            // Frm_FlujoStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 452);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "Frm_FlujoStaff";
            this.Text = "Frm_FlujoStaff";
            this.Load += new System.EventHandler(this.Frm_FlujoStaff_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem filtroToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_Rubro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton Chk_Todos;
        private System.Windows.Forms.RadioButton Rdb_Actuando;
        private System.Windows.Forms.RadioButton Rdb_Terminados;
        private System.Windows.Forms.RadioButton Rdb_Cerrados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Dgv_Tickets;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Flujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Cerrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autorizado;
    }
}