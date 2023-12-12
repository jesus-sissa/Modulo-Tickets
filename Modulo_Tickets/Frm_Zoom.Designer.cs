
namespace Modulo_Tickets
{
    partial class Frm_Zoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Zoom));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.brn_Rotar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_Zoom = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.brn_Rotar);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 735);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 38;
            // 
            // brn_Rotar
            // 
            this.brn_Rotar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brn_Rotar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brn_Rotar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.brn_Rotar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brn_Rotar.BorderRadius = 0;
            this.brn_Rotar.ButtonText = "Rotar";
            this.brn_Rotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_Rotar.DisabledColor = System.Drawing.Color.Gray;
            this.brn_Rotar.Iconcolor = System.Drawing.Color.Transparent;
            this.brn_Rotar.Iconimage = ((System.Drawing.Image)(resources.GetObject("brn_Rotar.Iconimage")));
            this.brn_Rotar.Iconimage_right = null;
            this.brn_Rotar.Iconimage_right_Selected = null;
            this.brn_Rotar.Iconimage_Selected = null;
            this.brn_Rotar.IconMarginLeft = 0;
            this.brn_Rotar.IconMarginRight = 0;
            this.brn_Rotar.IconRightVisible = true;
            this.brn_Rotar.IconRightZoom = 0D;
            this.brn_Rotar.IconVisible = true;
            this.brn_Rotar.IconZoom = 90D;
            this.brn_Rotar.IsTab = true;
            this.brn_Rotar.Location = new System.Drawing.Point(223, 6);
            this.brn_Rotar.Name = "brn_Rotar";
            this.brn_Rotar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.brn_Rotar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.brn_Rotar.OnHoverTextColor = System.Drawing.Color.White;
            this.brn_Rotar.selected = false;
            this.brn_Rotar.Size = new System.Drawing.Size(122, 48);
            this.brn_Rotar.TabIndex = 33;
            this.brn_Rotar.Text = "Rotar";
            this.brn_Rotar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brn_Rotar.Textcolor = System.Drawing.Color.White;
            this.brn_Rotar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Rotar.Click += new System.EventHandler(this.brn_Rotar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.BorderRadius = 0;
            this.Btn_Cerrar.ButtonText = "Salir";
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(12, 6);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 32;
            this.Btn_Cerrar.Text = "Salir";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_Zoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 735);
            this.panel2.TabIndex = 39;
            // 
            // pic_Zoom
            // 
            this.pic_Zoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Zoom.Location = new System.Drawing.Point(0, 0);
            this.pic_Zoom.Name = "pic_Zoom";
            this.pic_Zoom.Size = new System.Drawing.Size(800, 735);
            this.pic_Zoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Zoom.TabIndex = 0;
            this.pic_Zoom.TabStop = false;
            // 
            // Frm_Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Zoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Zoom";
            this.Load += new System.EventHandler(this.Frm_Zoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Zoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_Zoom;
        private Bunifu.Framework.UI.BunifuFlatButton brn_Rotar;
    }
}