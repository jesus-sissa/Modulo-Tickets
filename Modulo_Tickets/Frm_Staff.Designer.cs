
namespace Modulo_Tickets
{
    partial class Frm_Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Staff));
            this.panel5 = new System.Windows.Forms.Panel();
            this.Dgv_Tickets = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Actuando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolicitudCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_Rubro = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_Filtro = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Chk_Todos = new System.Windows.Forms.RadioButton();
            this.Rdb_Nuevos = new System.Windows.Forms.RadioButton();
            this.Rdb_Asignados = new System.Windows.Forms.RadioButton();
            this.Rdb_Actuando = new System.Windows.Forms.RadioButton();
            this.Rdb_Terminados = new System.Windows.Forms.RadioButton();
            this.Rdb_Cerrados = new System.Windows.Forms.RadioButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.Dgv_Tickets);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1189, 343);
            this.panel5.TabIndex = 9;
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
            this.Descripcion,
            this.dataGridViewTextBoxColumn4,
            this.AsignadoA,
            this.dataGridViewTextBoxColumn6,
            this.Fecha_Actuando,
            this.dataGridViewTextBoxColumn7,
            this.Categoria,
            this.SubCategoria,
            this.Nivel_Servicio,
            this.Status,
            this.Id_Rubro,
            this.Id_Usuario,
            this.Tipo,
            this.SolicitudCambio});
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
            this.Dgv_Tickets.Location = new System.Drawing.Point(0, 0);
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
            this.Dgv_Tickets.Size = new System.Drawing.Size(1189, 343);
            this.Dgv_Tickets.TabIndex = 84;
            this.Dgv_Tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellClick_1);
            this.Dgv_Tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellContentClick);
            // 
            // img
            // 
            this.img.FillWeight = 44.25298F;
            this.img.HeaderText = "";
            this.img.Name = "img";
            this.img.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.FillWeight = 110.6325F;
            this.Numero.HeaderText = "#Ticket";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 110.6325F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuario Reporta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 221.2649F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 110.6325F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Reporta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // AsignadoA
            // 
            this.AsignadoA.FillWeight = 110.6325F;
            this.AsignadoA.HeaderText = "Asignado a";
            this.AsignadoA.Name = "AsignadoA";
            this.AsignadoA.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha Asignacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Fecha_Actuando
            // 
            this.Fecha_Actuando.HeaderText = "Fecha Actuando";
            this.Fecha_Actuando.Name = "Fecha_Actuando";
            this.Fecha_Actuando.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha Resuelto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // SubCategoria
            // 
            this.SubCategoria.HeaderText = "SubCategoria";
            this.SubCategoria.Name = "SubCategoria";
            this.SubCategoria.ReadOnly = true;
            // 
            // Nivel_Servicio
            // 
            this.Nivel_Servicio.HeaderText = "Prioridad";
            this.Nivel_Servicio.Name = "Nivel_Servicio";
            this.Nivel_Servicio.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 110.6325F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Id_Rubro
            // 
            this.Id_Rubro.FillWeight = 21.3198F;
            this.Id_Rubro.HeaderText = "Id_rubro";
            this.Id_Rubro.Name = "Id_Rubro";
            this.Id_Rubro.ReadOnly = true;
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.HeaderText = "Id_Usuario";
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            this.Id_Usuario.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // SolicitudCambio
            // 
            this.SolicitudCambio.HeaderText = "Solicitud de Cambio";
            this.SolicitudCambio.Name = "SolicitudCambio";
            this.SolicitudCambio.ReadOnly = true;
            this.SolicitudCambio.Visible = false;
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
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.filtroToolStripMenuItem.Text = "Filtro de busqueda";
            this.filtroToolStripMenuItem.Click += new System.EventHandler(this.filtroToolStripMenuItem_Click_1);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1189, 43);
            this.panel4.TabIndex = 8;
            // 
            // Lbl_Rubro
            // 
            this.Lbl_Rubro.AutoSize = true;
            this.Lbl_Rubro.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rubro.ForeColor = System.Drawing.Color.White;
            this.Lbl_Rubro.Location = new System.Drawing.Point(83, 12);
            this.Lbl_Rubro.Name = "Lbl_Rubro";
            this.Lbl_Rubro.Size = new System.Drawing.Size(89, 39);
            this.Lbl_Rubro.TabIndex = 70;
            this.Lbl_Rubro.Text = "Total";
            this.Lbl_Rubro.Click += new System.EventHandler(this.Lbl_Rubro_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Txt_Filtro);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Controls.Add(this.Lbl_Rubro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1189, 64);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Filtro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Txt_Filtro.BackgroundImage")));
            this.Txt_Filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Txt_Filtro.ForeColor = System.Drawing.Color.White;
            this.Txt_Filtro.Icon = ((System.Drawing.Image)(resources.GetObject("Txt_Filtro.Icon")));
            this.Txt_Filtro.Location = new System.Drawing.Point(395, 12);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(189, 39);
            this.Txt_Filtro.TabIndex = 75;
            this.Txt_Filtro.text = "";
            this.Txt_Filtro.OnTextChange += new System.EventHandler(this.Txt_Filtro_OnTextChange);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Chk_Todos);
            this.panel6.Controls.Add(this.Rdb_Nuevos);
            this.panel6.Controls.Add(this.Rdb_Asignados);
            this.panel6.Controls.Add(this.Rdb_Actuando);
            this.panel6.Controls.Add(this.Rdb_Terminados);
            this.panel6.Controls.Add(this.radioButton1);
            this.panel6.Controls.Add(this.Rdb_Cerrados);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(590, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(599, 64);
            this.panel6.TabIndex = 72;
            // 
            // Chk_Todos
            // 
            this.Chk_Todos.AutoSize = true;
            this.Chk_Todos.Checked = true;
            this.Chk_Todos.Dock = System.Windows.Forms.DockStyle.Right;
            this.Chk_Todos.ForeColor = System.Drawing.Color.White;
            this.Chk_Todos.Location = new System.Drawing.Point(105, 0);
            this.Chk_Todos.Name = "Chk_Todos";
            this.Chk_Todos.Size = new System.Drawing.Size(55, 64);
            this.Chk_Todos.TabIndex = 5;
            this.Chk_Todos.TabStop = true;
            this.Chk_Todos.Text = "Todos";
            this.Chk_Todos.UseVisualStyleBackColor = true;
            this.Chk_Todos.CheckedChanged += new System.EventHandler(this.Chk_Todos_CheckedChanged);
            // 
            // Rdb_Nuevos
            // 
            this.Rdb_Nuevos.AutoSize = true;
            this.Rdb_Nuevos.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rdb_Nuevos.ForeColor = System.Drawing.Color.White;
            this.Rdb_Nuevos.Location = new System.Drawing.Point(160, 0);
            this.Rdb_Nuevos.Name = "Rdb_Nuevos";
            this.Rdb_Nuevos.Size = new System.Drawing.Size(62, 64);
            this.Rdb_Nuevos.TabIndex = 4;
            this.Rdb_Nuevos.TabStop = true;
            this.Rdb_Nuevos.Text = "Nuevos";
            this.Rdb_Nuevos.UseVisualStyleBackColor = true;
            this.Rdb_Nuevos.CheckedChanged += new System.EventHandler(this.Rdb_Nuevos_CheckedChanged);
            // 
            // Rdb_Asignados
            // 
            this.Rdb_Asignados.AutoSize = true;
            this.Rdb_Asignados.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rdb_Asignados.ForeColor = System.Drawing.Color.White;
            this.Rdb_Asignados.Location = new System.Drawing.Point(222, 0);
            this.Rdb_Asignados.Name = "Rdb_Asignados";
            this.Rdb_Asignados.Size = new System.Drawing.Size(74, 64);
            this.Rdb_Asignados.TabIndex = 3;
            this.Rdb_Asignados.TabStop = true;
            this.Rdb_Asignados.Text = "Asignados";
            this.Rdb_Asignados.UseVisualStyleBackColor = true;
            this.Rdb_Asignados.CheckedChanged += new System.EventHandler(this.Rdb_Asignados_CheckedChanged);
            // 
            // Rdb_Actuando
            // 
            this.Rdb_Actuando.AutoSize = true;
            this.Rdb_Actuando.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rdb_Actuando.ForeColor = System.Drawing.Color.White;
            this.Rdb_Actuando.Location = new System.Drawing.Point(296, 0);
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
            this.Rdb_Terminados.Location = new System.Drawing.Point(367, 0);
            this.Rdb_Terminados.Name = "Rdb_Terminados";
            this.Rdb_Terminados.Size = new System.Drawing.Size(80, 64);
            this.Rdb_Terminados.TabIndex = 1;
            this.Rdb_Terminados.TabStop = true;
            this.Rdb_Terminados.Text = "Terminados";
            this.Rdb_Terminados.UseVisualStyleBackColor = true;
            this.Rdb_Terminados.CheckedChanged += new System.EventHandler(this.Rdb_Terminados_CheckedChanged);
            // 
            // Rdb_Cerrados
            // 
            this.Rdb_Cerrados.AutoSize = true;
            this.Rdb_Cerrados.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rdb_Cerrados.ForeColor = System.Drawing.Color.White;
            this.Rdb_Cerrados.Location = new System.Drawing.Point(532, 0);
            this.Rdb_Cerrados.Name = "Rdb_Cerrados";
            this.Rdb_Cerrados.Size = new System.Drawing.Size(67, 64);
            this.Rdb_Cerrados.TabIndex = 0;
            this.Rdb_Cerrados.TabStop = true;
            this.Rdb_Cerrados.Text = "Cerrados";
            this.Rdb_Cerrados.UseVisualStyleBackColor = true;
            this.Rdb_Cerrados.CheckedChanged += new System.EventHandler(this.Rdb_Cerrados_CheckedChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(11, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(66, 43);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 71;
            this.btnMenu.TabStop = false;
            this.btnMenu.Tag = "0";
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 450);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 450);
            this.panel1.TabIndex = 5;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(447, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 64);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rechazados";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1209, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Staff";
            this.Text = "Frm_Staff";
            this.Load += new System.EventHandler(this.Frm_Staff_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_Rubro;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtroToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Dgv_Tickets;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton Rdb_Nuevos;
        private System.Windows.Forms.RadioButton Rdb_Asignados;
        private System.Windows.Forms.RadioButton Rdb_Actuando;
        private System.Windows.Forms.RadioButton Rdb_Terminados;
        private System.Windows.Forms.RadioButton Rdb_Cerrados;
        private System.Windows.Forms.RadioButton Chk_Todos;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignadoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Actuando;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolicitudCambio;
        private Bunifu.Framework.UI.BunifuTextbox Txt_Filtro;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}