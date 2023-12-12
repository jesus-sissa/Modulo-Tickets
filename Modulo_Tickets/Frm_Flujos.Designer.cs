
namespace Modulo_Tickets
{
    partial class Frm_Flujos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Flujos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgv_Tickets = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 591);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Dgv_Tickets);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 591);
            this.panel2.TabIndex = 28;
            // 
            // Dgv_Tickets
            // 
            this.Dgv_Tickets.AllowUserToAddRows = false;
            this.Dgv_Tickets.AllowUserToDeleteRows = false;
            this.Dgv_Tickets.AllowUserToResizeColumns = false;
            this.Dgv_Tickets.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
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
            this.Column1,
            this.Numero,
            this.Column5,
            this.Descripcion,
            this.Status,
            this.Porcentaje,
            this.Autorizacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Tickets.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Tickets.DoubleBuffered = true;
            this.Dgv_Tickets.EnableHeadersVisualStyles = false;
            this.Dgv_Tickets.GridColor = System.Drawing.Color.White;
            this.Dgv_Tickets.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Dgv_Tickets.HeaderForeColor = System.Drawing.Color.White;
            this.Dgv_Tickets.Location = new System.Drawing.Point(74, 67);
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
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Dgv_Tickets.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Tickets.Size = new System.Drawing.Size(784, 524);
            this.Dgv_Tickets.TabIndex = 30;
            this.Dgv_Tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellClick);
            this.Dgv_Tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tickets_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Btn_Enviar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(74, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 67);
            this.panel5.TabIndex = 31;
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Enviar.BorderRadius = 0;
            this.Btn_Enviar.ButtonText = "Nuevo";
            this.Btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Enviar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Enviar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Enviar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Enviar.Iconimage")));
            this.Btn_Enviar.Iconimage_right = null;
            this.Btn_Enviar.Iconimage_right_Selected = null;
            this.Btn_Enviar.Iconimage_Selected = null;
            this.Btn_Enviar.IconMarginLeft = 0;
            this.Btn_Enviar.IconMarginRight = 0;
            this.Btn_Enviar.IconRightVisible = true;
            this.Btn_Enviar.IconRightZoom = 0D;
            this.Btn_Enviar.IconVisible = true;
            this.Btn_Enviar.IconZoom = 90D;
            this.Btn_Enviar.IsTab = true;
            this.Btn_Enviar.Location = new System.Drawing.Point(6, 12);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Enviar.selected = false;
            this.Btn_Enviar.Size = new System.Drawing.Size(196, 42);
            this.Btn_Enviar.TabIndex = 27;
            this.Btn_Enviar.Text = "Nuevo";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.Btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(858, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 591);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 591);
            this.panel4.TabIndex = 28;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancelar.png");
            this.imageList1.Images.SetKeyName(1, "cheque.png");
            // 
            // Column1
            // 
            this.Column1.FillWeight = 45.07614F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.FillWeight = 112.6904F;
            this.Numero.HeaderText = "#Solicitudes";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 112.6904F;
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 225.3807F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 112.6904F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // Autorizacion
            // 
            this.Autorizacion.HeaderText = "Autorizacion";
            this.Autorizacion.Name = "Autorizacion";
            this.Autorizacion.ReadOnly = true;
            // 
            // Frm_Flujos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 591);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Flujos";
            this.Text = "Frm_Flujos";
            this.Load += new System.EventHandler(this.Frm_Flujos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tickets)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Dgv_Tickets;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autorizacion;
    }
}