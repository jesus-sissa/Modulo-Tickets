
namespace Modulo_Tickets
{
    partial class Frm_Admin
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.Pnl_Pie = new System.Windows.Forms.Panel();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.sideMen = new System.Windows.Forms.Panel();
            this.Pnl_Blocs = new System.Windows.Forms.Panel();
            this.Btn_Tareas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Reportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Seguimiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Proyectos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Soporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Staff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Rubros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Tickets = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Salir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Pnl_Contenedor = new System.Windows.Forms.Panel();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_Pie.SuspendLayout();
            this.sideMen.SuspendLayout();
            this.Pnl_Blocs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Pie
            // 
            this.Pnl_Pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Pnl_Pie.Controls.Add(this.Lbl_Nombre);
            this.LogoTransition.SetDecoration(this.Pnl_Pie, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Pnl_Pie, BunifuAnimatorNS.DecorationType.None);
            this.Pnl_Pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Pie.Location = new System.Drawing.Point(273, 594);
            this.Pnl_Pie.Name = "Pnl_Pie";
            this.Pnl_Pie.Size = new System.Drawing.Size(872, 48);
            this.Pnl_Pie.TabIndex = 22;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.PanelTransition.SetDecoration(this.Lbl_Nombre, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Lbl_Nombre, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nombre.Location = new System.Drawing.Point(6, 3);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(202, 39);
            this.Lbl_Nombre.TabIndex = 71;
            this.Lbl_Nombre.Text = "Bienvenido:";
            this.Lbl_Nombre.Visible = false;
            this.Lbl_Nombre.Click += new System.EventHandler(this.Lbl_Nombre_Click);
            this.Lbl_Nombre.DoubleClick += new System.EventHandler(this.Lbl_Nombre_DoubleClick);
            // 
            // sideMen
            // 
            this.sideMen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMen.Controls.Add(this.Pnl_Blocs);
            this.sideMen.Controls.Add(this.panel1);
            this.LogoTransition.SetDecoration(this.sideMen, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.sideMen, BunifuAnimatorNS.DecorationType.None);
            this.sideMen.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMen.Location = new System.Drawing.Point(0, 0);
            this.sideMen.Name = "sideMen";
            this.sideMen.Size = new System.Drawing.Size(273, 642);
            this.sideMen.TabIndex = 21;
            // 
            // Pnl_Blocs
            // 
            this.Pnl_Blocs.Controls.Add(this.Btn_Tareas);
            this.Pnl_Blocs.Controls.Add(this.Btn_Reportes);
            this.Pnl_Blocs.Controls.Add(this.Btn_Seguimiento);
            this.Pnl_Blocs.Controls.Add(this.Btn_Proyectos);
            this.Pnl_Blocs.Controls.Add(this.Btn_Soporte);
            this.Pnl_Blocs.Controls.Add(this.Btn_Staff);
            this.Pnl_Blocs.Controls.Add(this.Btn_Rubros);
            this.Pnl_Blocs.Controls.Add(this.Btn_Tickets);
            this.Pnl_Blocs.Controls.Add(this.Btn_Salir);
            this.Pnl_Blocs.Controls.Add(this.Btn_Logout);
            this.LogoTransition.SetDecoration(this.Pnl_Blocs, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Pnl_Blocs, BunifuAnimatorNS.DecorationType.None);
            this.Pnl_Blocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Blocs.Location = new System.Drawing.Point(0, 150);
            this.Pnl_Blocs.Name = "Pnl_Blocs";
            this.Pnl_Blocs.Size = new System.Drawing.Size(273, 492);
            this.Pnl_Blocs.TabIndex = 33;
            // 
            // Btn_Tareas
            // 
            this.Btn_Tareas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Tareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Tareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Tareas.BorderRadius = 0;
            this.Btn_Tareas.ButtonText = "                   Mas Opciones ...";
            this.Btn_Tareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Tareas, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Tareas, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Tareas.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Tareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Tareas.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Tareas.Iconimage = null;
            this.Btn_Tareas.Iconimage_right = null;
            this.Btn_Tareas.Iconimage_right_Selected = null;
            this.Btn_Tareas.Iconimage_Selected = null;
            this.Btn_Tareas.IconMarginLeft = 0;
            this.Btn_Tareas.IconMarginRight = 0;
            this.Btn_Tareas.IconRightVisible = true;
            this.Btn_Tareas.IconRightZoom = 0D;
            this.Btn_Tareas.IconVisible = true;
            this.Btn_Tareas.IconZoom = 90D;
            this.Btn_Tareas.IsTab = true;
            this.Btn_Tareas.Location = new System.Drawing.Point(0, 336);
            this.Btn_Tareas.Name = "Btn_Tareas";
            this.Btn_Tareas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Tareas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Tareas.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Tareas.selected = false;
            this.Btn_Tareas.Size = new System.Drawing.Size(273, 48);
            this.Btn_Tareas.TabIndex = 40;
            this.Btn_Tareas.Tag = "";
            this.Btn_Tareas.Text = "                   Mas Opciones ...";
            this.Btn_Tareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Tareas.Textcolor = System.Drawing.Color.White;
            this.Btn_Tareas.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tareas.Visible = false;
            this.Btn_Tareas.Click += new System.EventHandler(this.Btn_Tareas_Click);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Reportes.BorderRadius = 0;
            this.Btn_Reportes.ButtonText = "          REPORTES";
            this.Btn_Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Reportes, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Reportes, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Reportes.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Reportes.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Reportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Reportes.Iconimage")));
            this.Btn_Reportes.Iconimage_right = null;
            this.Btn_Reportes.Iconimage_right_Selected = null;
            this.Btn_Reportes.Iconimage_Selected = null;
            this.Btn_Reportes.IconMarginLeft = 0;
            this.Btn_Reportes.IconMarginRight = 0;
            this.Btn_Reportes.IconRightVisible = true;
            this.Btn_Reportes.IconRightZoom = 0D;
            this.Btn_Reportes.IconVisible = true;
            this.Btn_Reportes.IconZoom = 90D;
            this.Btn_Reportes.IsTab = true;
            this.Btn_Reportes.Location = new System.Drawing.Point(0, 288);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Reportes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Reportes.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Reportes.selected = false;
            this.Btn_Reportes.Size = new System.Drawing.Size(273, 48);
            this.Btn_Reportes.TabIndex = 38;
            this.Btn_Reportes.Tag = "GESTION DE REPORTES";
            this.Btn_Reportes.Text = "          REPORTES";
            this.Btn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reportes.Textcolor = System.Drawing.Color.White;
            this.Btn_Reportes.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reportes.Visible = false;
            this.Btn_Reportes.Click += new System.EventHandler(this.Btn_Reportes_Click);
            // 
            // Btn_Seguimiento
            // 
            this.Btn_Seguimiento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Seguimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Seguimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Seguimiento.BorderRadius = 0;
            this.Btn_Seguimiento.ButtonText = "          PROYECTOS";
            this.Btn_Seguimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Seguimiento, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Seguimiento, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Seguimiento.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Seguimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Seguimiento.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Seguimiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Seguimiento.Iconimage")));
            this.Btn_Seguimiento.Iconimage_right = null;
            this.Btn_Seguimiento.Iconimage_right_Selected = null;
            this.Btn_Seguimiento.Iconimage_Selected = null;
            this.Btn_Seguimiento.IconMarginLeft = 0;
            this.Btn_Seguimiento.IconMarginRight = 0;
            this.Btn_Seguimiento.IconRightVisible = true;
            this.Btn_Seguimiento.IconRightZoom = 0D;
            this.Btn_Seguimiento.IconVisible = true;
            this.Btn_Seguimiento.IconZoom = 90D;
            this.Btn_Seguimiento.IsTab = true;
            this.Btn_Seguimiento.Location = new System.Drawing.Point(0, 240);
            this.Btn_Seguimiento.Name = "Btn_Seguimiento";
            this.Btn_Seguimiento.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Seguimiento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Seguimiento.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Seguimiento.selected = false;
            this.Btn_Seguimiento.Size = new System.Drawing.Size(273, 48);
            this.Btn_Seguimiento.TabIndex = 37;
            this.Btn_Seguimiento.Tag = "SEGUIMIENTO PROYECTOS";
            this.Btn_Seguimiento.Text = "          PROYECTOS";
            this.Btn_Seguimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Seguimiento.Textcolor = System.Drawing.Color.White;
            this.Btn_Seguimiento.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Seguimiento.Visible = false;
            this.Btn_Seguimiento.Click += new System.EventHandler(this.Btn_Seguimiento_Click);
            // 
            // Btn_Proyectos
            // 
            this.Btn_Proyectos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Proyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Proyectos.BorderRadius = 0;
            this.Btn_Proyectos.ButtonText = "          DEPTOS";
            this.Btn_Proyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Proyectos, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Proyectos, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Proyectos.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Proyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Proyectos.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Proyectos.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Proyectos.Iconimage")));
            this.Btn_Proyectos.Iconimage_right = null;
            this.Btn_Proyectos.Iconimage_right_Selected = null;
            this.Btn_Proyectos.Iconimage_Selected = null;
            this.Btn_Proyectos.IconMarginLeft = 0;
            this.Btn_Proyectos.IconMarginRight = 0;
            this.Btn_Proyectos.IconRightVisible = true;
            this.Btn_Proyectos.IconRightZoom = 0D;
            this.Btn_Proyectos.IconVisible = true;
            this.Btn_Proyectos.IconZoom = 90D;
            this.Btn_Proyectos.IsTab = true;
            this.Btn_Proyectos.Location = new System.Drawing.Point(0, 192);
            this.Btn_Proyectos.Name = "Btn_Proyectos";
            this.Btn_Proyectos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Proyectos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Proyectos.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Proyectos.selected = false;
            this.Btn_Proyectos.Size = new System.Drawing.Size(273, 48);
            this.Btn_Proyectos.TabIndex = 36;
            this.Btn_Proyectos.Tag = "PROYECTOS";
            this.Btn_Proyectos.Text = "          DEPTOS";
            this.Btn_Proyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Proyectos.Textcolor = System.Drawing.Color.White;
            this.Btn_Proyectos.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proyectos.Visible = false;
            this.Btn_Proyectos.Click += new System.EventHandler(this.Btn_Proyectos_Click);
            // 
            // Btn_Soporte
            // 
            this.Btn_Soporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Soporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Soporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Soporte.BorderRadius = 0;
            this.Btn_Soporte.ButtonText = "          ASIGNACIONES";
            this.Btn_Soporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Soporte, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Soporte, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Soporte.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Soporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Soporte.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Soporte.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Soporte.Iconimage")));
            this.Btn_Soporte.Iconimage_right = null;
            this.Btn_Soporte.Iconimage_right_Selected = null;
            this.Btn_Soporte.Iconimage_Selected = null;
            this.Btn_Soporte.IconMarginLeft = 0;
            this.Btn_Soporte.IconMarginRight = 0;
            this.Btn_Soporte.IconRightVisible = true;
            this.Btn_Soporte.IconRightZoom = 0D;
            this.Btn_Soporte.IconVisible = true;
            this.Btn_Soporte.IconZoom = 90D;
            this.Btn_Soporte.IsTab = true;
            this.Btn_Soporte.Location = new System.Drawing.Point(0, 144);
            this.Btn_Soporte.Name = "Btn_Soporte";
            this.Btn_Soporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Soporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Soporte.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Soporte.selected = false;
            this.Btn_Soporte.Size = new System.Drawing.Size(273, 48);
            this.Btn_Soporte.TabIndex = 35;
            this.Btn_Soporte.Tag = "ASIGNACIONES";
            this.Btn_Soporte.Text = "          ASIGNACIONES";
            this.Btn_Soporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Soporte.Textcolor = System.Drawing.Color.White;
            this.Btn_Soporte.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Soporte.Visible = false;
            this.Btn_Soporte.Click += new System.EventHandler(this.Btn_Soporte_Click);
            // 
            // Btn_Staff
            // 
            this.Btn_Staff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Staff.BorderRadius = 0;
            this.Btn_Staff.ButtonText = "          ADMIN";
            this.Btn_Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Staff, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Staff, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Staff.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Staff.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Staff.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Staff.Iconimage")));
            this.Btn_Staff.Iconimage_right = null;
            this.Btn_Staff.Iconimage_right_Selected = null;
            this.Btn_Staff.Iconimage_Selected = null;
            this.Btn_Staff.IconMarginLeft = 0;
            this.Btn_Staff.IconMarginRight = 0;
            this.Btn_Staff.IconRightVisible = true;
            this.Btn_Staff.IconRightZoom = 0D;
            this.Btn_Staff.IconVisible = true;
            this.Btn_Staff.IconZoom = 90D;
            this.Btn_Staff.IsTab = true;
            this.Btn_Staff.Location = new System.Drawing.Point(0, 96);
            this.Btn_Staff.Name = "Btn_Staff";
            this.Btn_Staff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Staff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Staff.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Staff.selected = false;
            this.Btn_Staff.Size = new System.Drawing.Size(273, 48);
            this.Btn_Staff.TabIndex = 34;
            this.Btn_Staff.Tag = "ADMIN";
            this.Btn_Staff.Text = "          ADMIN";
            this.Btn_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Staff.Textcolor = System.Drawing.Color.White;
            this.Btn_Staff.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Staff.Visible = false;
            this.Btn_Staff.Click += new System.EventHandler(this.Btn_Staff_Click);
            // 
            // Btn_Rubros
            // 
            this.Btn_Rubros.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Rubros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Rubros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Rubros.BorderRadius = 0;
            this.Btn_Rubros.ButtonText = "          RUBROS";
            this.Btn_Rubros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Rubros, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Rubros, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Rubros.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Rubros.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Rubros.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Rubros.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Rubros.Iconimage")));
            this.Btn_Rubros.Iconimage_right = null;
            this.Btn_Rubros.Iconimage_right_Selected = null;
            this.Btn_Rubros.Iconimage_Selected = null;
            this.Btn_Rubros.IconMarginLeft = 0;
            this.Btn_Rubros.IconMarginRight = 0;
            this.Btn_Rubros.IconRightVisible = true;
            this.Btn_Rubros.IconRightZoom = 0D;
            this.Btn_Rubros.IconVisible = true;
            this.Btn_Rubros.IconZoom = 90D;
            this.Btn_Rubros.IsTab = true;
            this.Btn_Rubros.Location = new System.Drawing.Point(0, 48);
            this.Btn_Rubros.Name = "Btn_Rubros";
            this.Btn_Rubros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Rubros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Rubros.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Rubros.selected = false;
            this.Btn_Rubros.Size = new System.Drawing.Size(273, 48);
            this.Btn_Rubros.TabIndex = 33;
            this.Btn_Rubros.Tag = "NUEVO RUBRO";
            this.Btn_Rubros.Text = "          RUBROS";
            this.Btn_Rubros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Rubros.Textcolor = System.Drawing.Color.White;
            this.Btn_Rubros.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rubros.Visible = false;
            this.Btn_Rubros.Click += new System.EventHandler(this.Btn_Rubros_Click);
            // 
            // Btn_Tickets
            // 
            this.Btn_Tickets.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Tickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Tickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Tickets.BorderRadius = 0;
            this.Btn_Tickets.ButtonText = "          TICKETS";
            this.Btn_Tickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Tickets, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Tickets, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Tickets.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Tickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Tickets.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Tickets.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Tickets.Iconimage")));
            this.Btn_Tickets.Iconimage_right = null;
            this.Btn_Tickets.Iconimage_right_Selected = null;
            this.Btn_Tickets.Iconimage_Selected = null;
            this.Btn_Tickets.IconMarginLeft = 0;
            this.Btn_Tickets.IconMarginRight = 0;
            this.Btn_Tickets.IconRightVisible = true;
            this.Btn_Tickets.IconRightZoom = 0D;
            this.Btn_Tickets.IconVisible = true;
            this.Btn_Tickets.IconZoom = 90D;
            this.Btn_Tickets.IsTab = true;
            this.Btn_Tickets.Location = new System.Drawing.Point(0, 0);
            this.Btn_Tickets.Name = "Btn_Tickets";
            this.Btn_Tickets.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Tickets.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Tickets.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Tickets.selected = false;
            this.Btn_Tickets.Size = new System.Drawing.Size(273, 48);
            this.Btn_Tickets.TabIndex = 32;
            this.Btn_Tickets.Tag = "NUEVO TICKET";
            this.Btn_Tickets.Text = "          TICKETS";
            this.Btn_Tickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Tickets.Textcolor = System.Drawing.Color.White;
            this.Btn_Tickets.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tickets.Visible = false;
            this.Btn_Tickets.Click += new System.EventHandler(this.Btn_Tickets_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.BorderRadius = 0;
            this.Btn_Salir.ButtonText = "          Minimizar";
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Salir.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.Btn_Salir.Location = new System.Drawing.Point(0, 396);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Salir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Salir.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Salir.selected = false;
            this.Btn_Salir.Size = new System.Drawing.Size(273, 48);
            this.Btn_Salir.TabIndex = 28;
            this.Btn_Salir.Tag = "0";
            this.Btn_Salir.Text = "          Minimizar";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Textcolor = System.Drawing.Color.White;
            this.Btn_Salir.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Logout.BorderRadius = 0;
            this.Btn_Logout.ButtonText = "          Salir";
            this.Btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.Btn_Logout, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btn_Logout, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Logout.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Logout.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Logout.Iconimage")));
            this.Btn_Logout.Iconimage_right = null;
            this.Btn_Logout.Iconimage_right_Selected = null;
            this.Btn_Logout.Iconimage_Selected = null;
            this.Btn_Logout.IconMarginLeft = 0;
            this.Btn_Logout.IconMarginRight = 0;
            this.Btn_Logout.IconRightVisible = true;
            this.Btn_Logout.IconRightZoom = 0D;
            this.Btn_Logout.IconVisible = true;
            this.Btn_Logout.IconZoom = 90D;
            this.Btn_Logout.IsTab = true;
            this.Btn_Logout.Location = new System.Drawing.Point(0, 444);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Logout.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Logout.selected = false;
            this.Btn_Logout.Size = new System.Drawing.Size(273, 48);
            this.Btn_Logout.TabIndex = 31;
            this.Btn_Logout.Tag = "0";
            this.Btn_Logout.Text = "          Salir";
            this.Btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Logout.Textcolor = System.Drawing.Color.White;
            this.Btn_Logout.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.Logo);
            this.LogoTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 150);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(125, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 7;
            this.label1.Tag = "0";
            this.label1.Text = "Tickets";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(220, 111);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Tag = "0";
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Logo
            // 
            this.PanelTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(107, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Tag = "0";
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // contextMenuStrip1
            // 
            this.LogoTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation1;
            // 
            // Pnl_Contenedor
            // 
            this.Pnl_Contenedor.AutoScroll = true;
            this.Pnl_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.LogoTransition.SetDecoration(this.Pnl_Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Pnl_Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.Pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contenedor.Location = new System.Drawing.Point(273, 0);
            this.Pnl_Contenedor.Name = "Pnl_Contenedor";
            this.Pnl_Contenedor.Size = new System.Drawing.Size(872, 594);
            this.Pnl_Contenedor.TabIndex = 23;
            this.Pnl_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Contenedor_Paint);
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation2;
            // 
            // timer1
            // 
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 642);
            this.Controls.Add(this.Pnl_Contenedor);
            this.Controls.Add(this.Pnl_Pie);
            this.Controls.Add(this.sideMen);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo_Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.Pnl_Pie.ResumeLayout(false);
            this.Pnl_Pie.PerformLayout();
            this.sideMen.ResumeLayout(false);
            this.Pnl_Blocs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Pnl_Pie;
        private System.Windows.Forms.Panel sideMen;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Salir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_Blocs;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Proyectos;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Soporte;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Staff;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Rubros;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Tickets;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Seguimiento;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Reportes;
        internal System.Windows.Forms.Panel Pnl_Contenedor;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Tareas;
    }
}