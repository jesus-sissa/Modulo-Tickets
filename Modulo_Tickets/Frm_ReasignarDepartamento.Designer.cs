
namespace Modulo_Tickets
{
    partial class Frm_ReasignarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReasignarDepartamento));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Rechazar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Regresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Salir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_CerrarTicket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Asignar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Descripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Rechazar);
            this.panel2.Controls.Add(this.Btn_Regresar);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.Btn_CerrarTicket);
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Controls.Add(this.Btn_Asignar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 88);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btn_Rechazar
            // 
            this.Btn_Rechazar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Rechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Rechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Rechazar.BorderRadius = 0;
            this.Btn_Rechazar.ButtonText = "Rechazar ticket";
            this.Btn_Rechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Rechazar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Rechazar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Rechazar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Rechazar.Iconimage")));
            this.Btn_Rechazar.Iconimage_right = null;
            this.Btn_Rechazar.Iconimage_right_Selected = null;
            this.Btn_Rechazar.Iconimage_Selected = null;
            this.Btn_Rechazar.IconMarginLeft = 0;
            this.Btn_Rechazar.IconMarginRight = 0;
            this.Btn_Rechazar.IconRightVisible = true;
            this.Btn_Rechazar.IconRightZoom = 0D;
            this.Btn_Rechazar.IconVisible = true;
            this.Btn_Rechazar.IconZoom = 90D;
            this.Btn_Rechazar.IsTab = true;
            this.Btn_Rechazar.Location = new System.Drawing.Point(115, 390);
            this.Btn_Rechazar.Name = "Btn_Rechazar";
            this.Btn_Rechazar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Rechazar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Rechazar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Rechazar.selected = false;
            this.Btn_Rechazar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Rechazar.TabIndex = 46;
            this.Btn_Rechazar.Text = "Rechazar ticket";
            this.Btn_Rechazar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Rechazar.Textcolor = System.Drawing.Color.White;
            this.Btn_Rechazar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rechazar.Visible = false;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Regresar.BorderRadius = 0;
            this.Btn_Regresar.ButtonText = "Regresar Ticket";
            this.Btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Regresar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Regresar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Regresar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Iconimage")));
            this.Btn_Regresar.Iconimage_right = null;
            this.Btn_Regresar.Iconimage_right_Selected = null;
            this.Btn_Regresar.Iconimage_Selected = null;
            this.Btn_Regresar.IconMarginLeft = 0;
            this.Btn_Regresar.IconMarginRight = 0;
            this.Btn_Regresar.IconRightVisible = true;
            this.Btn_Regresar.IconRightZoom = 0D;
            this.Btn_Regresar.IconVisible = true;
            this.Btn_Regresar.IconZoom = 90D;
            this.Btn_Regresar.IsTab = true;
            this.Btn_Regresar.Location = new System.Drawing.Point(115, 390);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Regresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Regresar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Regresar.selected = false;
            this.Btn_Regresar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Regresar.TabIndex = 45;
            this.Btn_Regresar.Text = "Regresar Ticket";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Regresar.Textcolor = System.Drawing.Color.White;
            this.Btn_Regresar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.BorderRadius = 0;
            this.Btn_Salir.ButtonText = "Salir";
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Salir.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Salir.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Iconimage")));
            this.Btn_Salir.Iconimage_right = null;
            this.Btn_Salir.Iconimage_right_Selected = null;
            this.Btn_Salir.Iconimage_Selected = null;
            this.Btn_Salir.IconMarginLeft = 0;
            this.Btn_Salir.IconMarginRight = 0;
            this.Btn_Salir.IconRightVisible = true;
            this.Btn_Salir.IconRightZoom = 0D;
            this.Btn_Salir.IconVisible = true;
            this.Btn_Salir.IconZoom = 90D;
            this.Btn_Salir.IsTab = true;
            this.Btn_Salir.Location = new System.Drawing.Point(545, 390);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Salir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Salir.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Salir.selected = false;
            this.Btn_Salir.Size = new System.Drawing.Size(196, 48);
            this.Btn_Salir.TabIndex = 44;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Textcolor = System.Drawing.Color.White;
            this.Btn_Salir.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_CerrarTicket
            // 
            this.Btn_CerrarTicket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_CerrarTicket.BorderRadius = 0;
            this.Btn_CerrarTicket.ButtonText = "Finalizar ticket";
            this.Btn_CerrarTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CerrarTicket.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_CerrarTicket.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_CerrarTicket.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_CerrarTicket.Iconimage")));
            this.Btn_CerrarTicket.Iconimage_right = null;
            this.Btn_CerrarTicket.Iconimage_right_Selected = null;
            this.Btn_CerrarTicket.Iconimage_Selected = null;
            this.Btn_CerrarTicket.IconMarginLeft = 0;
            this.Btn_CerrarTicket.IconMarginRight = 0;
            this.Btn_CerrarTicket.IconRightVisible = true;
            this.Btn_CerrarTicket.IconRightZoom = 0D;
            this.Btn_CerrarTicket.IconVisible = true;
            this.Btn_CerrarTicket.IconZoom = 90D;
            this.Btn_CerrarTicket.IsTab = true;
            this.Btn_CerrarTicket.Location = new System.Drawing.Point(330, 390);
            this.Btn_CerrarTicket.Name = "Btn_CerrarTicket";
            this.Btn_CerrarTicket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarTicket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_CerrarTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_CerrarTicket.selected = false;
            this.Btn_CerrarTicket.Size = new System.Drawing.Size(196, 48);
            this.Btn_CerrarTicket.TabIndex = 43;
            this.Btn_CerrarTicket.Text = "Finalizar ticket";
            this.Btn_CerrarTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CerrarTicket.Textcolor = System.Drawing.Color.White;
            this.Btn_CerrarTicket.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.BorderRadius = 0;
            this.Btn_Cerrar.ButtonText = "Cerrar";
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Cerrar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Iconimage")));
            this.Btn_Cerrar.Iconimage_right = null;
            this.Btn_Cerrar.Iconimage_right_Selected = null;
            this.Btn_Cerrar.Iconimage_Selected = null;
            this.Btn_Cerrar.IconMarginLeft = 0;
            this.Btn_Cerrar.IconMarginRight = 0;
            this.Btn_Cerrar.IconRightVisible = true;
            this.Btn_Cerrar.IconRightZoom = 0D;
            this.Btn_Cerrar.IconVisible = true;
            this.Btn_Cerrar.IconZoom = 90D;
            this.Btn_Cerrar.IsTab = true;
            this.Btn_Cerrar.Location = new System.Drawing.Point(407, 31);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 42;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Asignar
            // 
            this.Btn_Asignar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Asignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Asignar.BorderRadius = 0;
            this.Btn_Asignar.ButtonText = "Asignar";
            this.Btn_Asignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Asignar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Asignar.Enabled = false;
            this.Btn_Asignar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Asignar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Asignar.Iconimage")));
            this.Btn_Asignar.Iconimage_right = null;
            this.Btn_Asignar.Iconimage_right_Selected = null;
            this.Btn_Asignar.Iconimage_Selected = null;
            this.Btn_Asignar.IconMarginLeft = 0;
            this.Btn_Asignar.IconMarginRight = 0;
            this.Btn_Asignar.IconRightVisible = true;
            this.Btn_Asignar.IconRightZoom = 0D;
            this.Btn_Asignar.IconVisible = true;
            this.Btn_Asignar.IconZoom = 90D;
            this.Btn_Asignar.IsTab = true;
            this.Btn_Asignar.Location = new System.Drawing.Point(192, 31);
            this.Btn_Asignar.Name = "Btn_Asignar";
            this.Btn_Asignar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Asignar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Asignar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Asignar.selected = false;
            this.Btn_Asignar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Asignar.TabIndex = 41;
            this.Btn_Asignar.Text = "Asignar";
            this.Btn_Asignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Asignar.Textcolor = System.Drawing.Color.White;
            this.Btn_Asignar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asignar.Click += new System.EventHandler(this.Btn_Asignar_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_Descripcion);
            this.panel1.Controls.Add(this.Txt_Descripcion);
            this.panel1.Controls.Add(this.Flow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 362);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(12, 140);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(134, 24);
            this.Lbl_Descripcion.TabIndex = 50;
            this.Lbl_Descripcion.Text = "Descripcion.";
            this.Lbl_Descripcion.Visible = false;
            this.Lbl_Descripcion.Click += new System.EventHandler(this.Lbl_Descripcion_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(16, 167);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(763, 179);
            this.Txt_Descripcion.TabIndex = 49;
            this.Txt_Descripcion.Visible = false;
            this.Txt_Descripcion.TextChanged += new System.EventHandler(this.Txt_Descripcion_TextChanged);
            // 
            // Flow
            // 
            this.Flow.AutoScroll = true;
            this.Flow.Dock = System.Windows.Forms.DockStyle.Top;
            this.Flow.Location = new System.Drawing.Point(0, 0);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(800, 346);
            this.Flow.TabIndex = 0;
            this.Flow.Paint += new System.Windows.Forms.PaintEventHandler(this.Flow_Paint);
            // 
            // Frm_ReasignarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReasignarDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ReasignarDepartamento";
            this.Load += new System.EventHandler(this.Frm_ReasignarDepartamento_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Rechazar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Regresar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_CerrarTicket;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Asignar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.FlowLayoutPanel Flow;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Descripcion;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
    }
}