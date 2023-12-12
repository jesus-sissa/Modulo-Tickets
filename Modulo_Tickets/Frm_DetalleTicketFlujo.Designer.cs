
namespace Modulo_Tickets
{
    partial class Frm_DetalleTicketFlujo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetalleTicketFlujo));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Lbl_Status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Lbl_Ticket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tp_descargar = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Avances = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Status.Location = new System.Drawing.Point(96, 63);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(74, 24);
            this.Lbl_Status.TabIndex = 82;
            this.Lbl_Status.Text = "Status:";
            this.Lbl_Status.Click += new System.EventHandler(this.Lbl_Status_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Salir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(399, 389);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(155, 48);
            this.bunifuFlatButton1.TabIndex = 81;
            this.bunifuFlatButton1.Text = "Salir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 96);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(134, 24);
            this.bunifuCustomLabel2.TabIndex = 78;
            this.bunifuCustomLabel2.Text = "Descripcion:";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Enabled = false;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(40, 123);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(724, 248);
            this.Txt_Descripcion.TabIndex = 79;
            this.Txt_Descripcion.TextChanged += new System.EventHandler(this.Txt_Descripcion_TextChanged);
            // 
            // Lbl_Ticket
            // 
            this.Lbl_Ticket.AutoSize = true;
            this.Lbl_Ticket.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Ticket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Ticket.Location = new System.Drawing.Point(83, 27);
            this.Lbl_Ticket.Name = "Lbl_Ticket";
            this.Lbl_Ticket.Size = new System.Drawing.Size(113, 24);
            this.Lbl_Ticket.TabIndex = 77;
            this.Lbl_Ticket.Text = "#Solicitud:";
            this.Lbl_Ticket.Click += new System.EventHandler(this.Lbl_Ticket_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Btn_Avances
            // 
            this.Btn_Avances.ActiveBorderThickness = 1;
            this.Btn_Avances.ActiveCornerRadius = 20;
            this.Btn_Avances.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Avances.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Avances.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Avances.BackgroundImage")));
            this.Btn_Avances.ButtonText = "Ver historial";
            this.Btn_Avances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Avances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Avances.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.IdleBorderThickness = 1;
            this.Btn_Avances.IdleCornerRadius = 20;
            this.Btn_Avances.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Avances.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.Location = new System.Drawing.Point(40, 389);
            this.Btn_Avances.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Avances.Name = "Btn_Avances";
            this.Btn_Avances.Size = new System.Drawing.Size(146, 48);
            this.Btn_Avances.TabIndex = 84;
            this.Btn_Avances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Avances.Click += new System.EventHandler(this.Btn_Avances_Click);
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Enviar.BorderRadius = 0;
            this.Btn_Enviar.ButtonText = "Cerrar";
            this.Btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Enviar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Enviar.Enabled = false;
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
            this.Btn_Enviar.Location = new System.Drawing.Point(204, 389);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Enviar.selected = false;
            this.Btn_Enviar.Size = new System.Drawing.Size(167, 48);
            this.Btn_Enviar.TabIndex = 80;
            this.Btn_Enviar.Text = "Cerrar";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.Btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Frm_DetalleTicketFlujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_Ticket);
            this.Controls.Add(this.Btn_Avances);
            this.Controls.Add(this.Btn_Enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DetalleTicketFlujo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DetalleTicketFlujo";
            this.Load += new System.EventHandler(this.Frm_DetalleTicketFlujo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Status;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Ticket;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip tp_descargar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avances;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
    }
}