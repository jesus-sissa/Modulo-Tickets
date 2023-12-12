
namespace Modulo_Tickets
{
    partial class Soporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soporte));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Filtro = new Bunifu.Framework.UI.BunifuTextbox();
            this.Dgv_Tickets = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolicitudCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Reporta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tck_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(52, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 100);
            this.panel3.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(788, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(86, 490);
            this.panel5.TabIndex = 42;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 490);
            this.panel4.TabIndex = 41;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar.png");
            this.imageList1.Images.SetKeyName(1, "cheque.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.Txt_Filtro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(52, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(17, 72);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(114, 25);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "Mis tickets";
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Filtro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Txt_Filtro.BackgroundImage")));
            this.Txt_Filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Txt_Filtro.ForeColor = System.Drawing.Color.White;
            this.Txt_Filtro.Icon = ((System.Drawing.Image)(resources.GetObject("Txt_Filtro.Icon")));
            this.Txt_Filtro.Location = new System.Drawing.Point(22, 12);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(430, 42);
            this.Txt_Filtro.TabIndex = 28;
            this.Txt_Filtro.text = "";
            this.Txt_Filtro.OnTextChange += new System.EventHandler(this.Txt_Filtro_OnTextChange);
            // 
            // Dgv_Tickets
            // 
            this.Dgv_Tickets.AllowUserToAddRows = false;
            this.Dgv_Tickets.AllowUserToDeleteRows = false;
            this.Dgv_Tickets.AllowUserToResizeColumns = false;
            this.Dgv_Tickets.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Dgv_Tickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Tickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Dgv_Tickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Tickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_Tickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Tickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.Numero,
            this.SolicitudCambio,
            this.Usuario_Reporta,
            this.Descripcion,
            this.Status,
            this.dataGridViewTextBoxColumn4,
            this.Id_Rubro,
            this.Tipo,
            this.Tck_P,
            this.T,
            this.S});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Tickets.DefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv_Tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Tickets.DoubleBuffered = true;
            this.Dgv_Tickets.EnableHeadersVisualStyles = false;
            this.Dgv_Tickets.GridColor = System.Drawing.Color.White;
            this.Dgv_Tickets.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Dgv_Tickets.HeaderForeColor = System.Drawing.Color.White;
            this.Dgv_Tickets.Location = new System.Drawing.Point(52, 100);
            this.Dgv_Tickets.Name = "Dgv_Tickets";
            this.Dgv_Tickets.ReadOnly = true;
            this.Dgv_Tickets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Tickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Dgv_Tickets.RowHeadersVisible = false;
            this.Dgv_Tickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Dgv_Tickets.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Dgv_Tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Tickets.Size = new System.Drawing.Size(736, 290);
            this.Dgv_Tickets.TabIndex = 46;
            this.Dgv_Tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellClick_1);
            this.Dgv_Tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 44.25298F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // Numero
            // 
            this.Numero.FillWeight = 110.6325F;
            this.Numero.HeaderText = "#Ticket";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // SolicitudCambio
            // 
            this.SolicitudCambio.HeaderText = "Solicitud de Cambio";
            this.SolicitudCambio.Name = "SolicitudCambio";
            this.SolicitudCambio.ReadOnly = true;
            this.SolicitudCambio.Visible = false;
            // 
            // Usuario_Reporta
            // 
            this.Usuario_Reporta.FillWeight = 110.6325F;
            this.Usuario_Reporta.HeaderText = "Usuario Reporta";
            this.Usuario_Reporta.Name = "Usuario_Reporta";
            this.Usuario_Reporta.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 221.2649F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 110.6325F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 110.6325F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha de asignacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Id_Rubro
            // 
            this.Id_Rubro.FillWeight = 21.3198F;
            this.Id_Rubro.HeaderText = "Id_rubro";
            this.Id_Rubro.Name = "Id_Rubro";
            this.Id_Rubro.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // Tck_P
            // 
            this.Tck_P.HeaderText = "Tck_P";
            this.Tck_P.Name = "Tck_P";
            this.Tck_P.ReadOnly = true;
            this.Tck_P.Visible = false;
            // 
            // T
            // 
            this.T.HeaderText = "T";
            this.T.Name = "T";
            this.T.ReadOnly = true;
            this.T.Visible = false;
            // 
            // S
            // 
            this.S.HeaderText = "S";
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Visible = false;
            // 
            // Soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(874, 490);
            this.Controls.Add(this.Dgv_Tickets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "Soporte";
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.Soporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Dgv_Tickets;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox Txt_Filtro;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolicitudCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Reporta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tck_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
    }
}