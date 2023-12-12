
namespace Modulo_Tickets
{
    partial class Frm_Estrellas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estrellas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Rat_Estrellas = new Bunifu.Framework.UI.BunifuRating();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Lbl_Status = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.SeaGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Descripcion.Location = new System.Drawing.Point(12, 48);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(380, 116);
            this.Txt_Descripcion.TabIndex = 0;
            this.Txt_Descripcion.TextChanged += new System.EventHandler(this.Txt_Descripcion_TextChanged);
            // 
            // Rat_Estrellas
            // 
            this.Rat_Estrellas.BackColor = System.Drawing.Color.Transparent;
            this.Rat_Estrellas.ForeColor = System.Drawing.Color.Goldenrod;
            this.Rat_Estrellas.Location = new System.Drawing.Point(22, 192);
            this.Rat_Estrellas.Name = "Rat_Estrellas";
            this.Rat_Estrellas.Size = new System.Drawing.Size(357, 31);
            this.Rat_Estrellas.TabIndex = 1;
            this.Rat_Estrellas.Value = 0;
            this.Rat_Estrellas.onValueChanged += new System.EventHandler(this.Rat_Estrellas_onValueChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Modulo_Tickets.Properties.Resources.icons8_cancel_25px1;
            this.pictureBox2.Location = new System.Drawing.Point(366, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Enviar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(105, 231);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(187, 41);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Status.ForeColor = System.Drawing.Color.White;
            this.Lbl_Status.Location = new System.Drawing.Point(116, 12);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(141, 24);
            this.Lbl_Status.TabIndex = 32;
            this.Lbl_Status.Text = "Comentarios";
            // 
            // Frm_Estrellas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(404, 283);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Rat_Estrellas);
            this.Controls.Add(this.Txt_Descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Estrellas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Estrellas";
            this.Load += new System.EventHandler(this.Frm_Estrellas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        private Bunifu.Framework.UI.BunifuRating Rat_Estrellas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Status;
    }
}