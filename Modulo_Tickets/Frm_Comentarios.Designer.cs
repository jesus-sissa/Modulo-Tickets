
namespace Modulo_Tickets
{
    partial class Frm_Comentarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Comentarios));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Cometarios = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Salir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(440, 24);
            this.bunifuCustomLabel1.TabIndex = 54;
            this.bunifuCustomLabel1.Text = "Agregue aqui sus avances o comentarios:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // Txt_Cometarios
            // 
            this.Txt_Cometarios.BackColor = System.Drawing.Color.White;
            this.Txt_Cometarios.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Cometarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cometarios.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Cometarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Cometarios.Location = new System.Drawing.Point(31, 68);
            this.Txt_Cometarios.Multiline = true;
            this.Txt_Cometarios.Name = "Txt_Cometarios";
            this.Txt_Cometarios.Size = new System.Drawing.Size(735, 270);
            this.Txt_Cometarios.TabIndex = 53;
            this.Txt_Cometarios.TextChanged += new System.EventHandler(this.Txt_Cometarios_TextChanged);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.BorderRadius = 0;
            this.Btn_Guardar.ButtonText = "Guardar";
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Iconimage")));
            this.Btn_Guardar.Iconimage_right = null;
            this.Btn_Guardar.Iconimage_right_Selected = null;
            this.Btn_Guardar.Iconimage_Selected = null;
            this.Btn_Guardar.IconMarginLeft = 0;
            this.Btn_Guardar.IconMarginRight = 0;
            this.Btn_Guardar.IconRightVisible = true;
            this.Btn_Guardar.IconRightZoom = 0D;
            this.Btn_Guardar.IconVisible = true;
            this.Btn_Guardar.IconZoom = 90D;
            this.Btn_Guardar.IsTab = true;
            this.Btn_Guardar.Location = new System.Drawing.Point(330, 390);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Guardar.selected = false;
            this.Btn_Guardar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Guardar.TabIndex = 55;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.Btn_Guardar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
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
            this.Btn_Salir.TabIndex = 56;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Textcolor = System.Drawing.Color.White;
            this.Btn_Salir.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Comentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 505);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Txt_Cometarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Comentarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Comentarios";
            this.Load += new System.EventHandler(this.Frm_Comentarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Cometarios;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Guardar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Salir;
    }
}