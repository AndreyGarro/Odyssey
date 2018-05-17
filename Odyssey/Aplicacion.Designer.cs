namespace Odyssey
{
    partial class lblCalificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblCalificacion));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.miniLogo = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelBiblioteca = new System.Windows.Forms.Panel();
            this.btnCalificacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGenero = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlbum = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnArtista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNombre = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btnAgregaCancion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vlcPlayer = new AxAXVLC.AxVLCPlugin2();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelEntra = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelFuera = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarAmigo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Odyssey";
            this.notifyIcon1.Visible = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.logoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(982, 38);
            this.header.TabIndex = 21;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // bunifuImageButton2
            // 
            this.logoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(951, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(28, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 23;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.panelFuera.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.panelFuera.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(164, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Odyssey Player - Music";
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.bunifuFlatButton5);
            this.sideMenu.Controls.Add(this.miniLogo);
            this.sideMenu.Controls.Add(this.bunifuFlatButton3);
            this.sideMenu.Controls.Add(this.bunifuFlatButton2);
            this.sideMenu.Controls.Add(this.bunifuFlatButton1);
            this.sideMenu.Controls.Add(this.btnMenu);
            this.sideMenu.Controls.Add(this.logo);
            this.logoAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 38);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(200, 523);
            this.sideMenu.TabIndex = 22;
            // 
            // miniLogo
            // 
            this.panelFuera.SetDecoration(this.miniLogo, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.miniLogo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.miniLogo, BunifuAnimatorNS.DecorationType.None);
            this.miniLogo.Image = ((System.Drawing.Image)(resources.GetObject("miniLogo.Image")));
            this.miniLogo.Location = new System.Drawing.Point(12, 58);
            this.miniLogo.Name = "miniLogo";
            this.miniLogo.Size = new System.Drawing.Size(27, 24);
            this.miniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.miniLogo.TabIndex = 25;
            this.miniLogo.TabStop = false;
            this.miniLogo.Visible = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "      Notificaciones";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 70D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 201);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(200, 48);
            this.bunifuFlatButton3.TabIndex = 24;
            this.bunifuFlatButton3.Text = "      Notificaciones";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      Amigos";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 326);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton2.TabIndex = 23;
            this.bunifuFlatButton2.Text = "      Amigos";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      Biblioteca";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 263);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 48);
            this.bunifuFlatButton1.TabIndex = 22;
            this.bunifuFlatButton1.Text = "      Biblioteca";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(172, 49);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 21;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logo
            // 
            this.panelFuera.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(36, 19);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 104);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 20;
            this.logo.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelBiblioteca
            // 
            this.panelBiblioteca.Controls.Add(this.btnAgregarAmigo);
            this.panelBiblioteca.Controls.Add(this.lstFriends);
            this.panelBiblioteca.Controls.Add(this.btnCalificacion);
            this.panelBiblioteca.Controls.Add(this.btnGenero);
            this.panelBiblioteca.Controls.Add(this.btnAlbum);
            this.panelBiblioteca.Controls.Add(this.btnArtista);
            this.panelBiblioteca.Controls.Add(this.btnNombre);
            this.panelBiblioteca.Controls.Add(this.lstCanciones);
            this.panelBiblioteca.Controls.Add(this.btnAgregaCancion);
            this.panelBiblioteca.Controls.Add(this.vlcPlayer);
            this.logoAnimator.SetDecoration(this.panelBiblioteca, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.panelBiblioteca, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.panelBiblioteca, BunifuAnimatorNS.DecorationType.None);
            this.panelBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBiblioteca.Location = new System.Drawing.Point(200, 38);
            this.panelBiblioteca.Name = "panelBiblioteca";
            this.panelBiblioteca.Size = new System.Drawing.Size(782, 523);
            this.panelBiblioteca.TabIndex = 23;
            this.panelBiblioteca.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnCalificacion
            // 
            this.btnCalificacion.Active = false;
            this.btnCalificacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCalificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalificacion.BorderRadius = 0;
            this.btnCalificacion.ButtonText = "Calificación";
            this.btnCalificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnCalificacion, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnCalificacion, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnCalificacion, BunifuAnimatorNS.DecorationType.None);
            this.btnCalificacion.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalificacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalificacion.Iconimage = null;
            this.btnCalificacion.Iconimage_right = null;
            this.btnCalificacion.Iconimage_right_Selected = null;
            this.btnCalificacion.Iconimage_Selected = null;
            this.btnCalificacion.IconMarginLeft = 0;
            this.btnCalificacion.IconMarginRight = 0;
            this.btnCalificacion.IconRightVisible = true;
            this.btnCalificacion.IconRightZoom = 0D;
            this.btnCalificacion.IconVisible = true;
            this.btnCalificacion.IconZoom = 40D;
            this.btnCalificacion.IsTab = true;
            this.btnCalificacion.Location = new System.Drawing.Point(590, 49);
            this.btnCalificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalificacion.Name = "btnCalificacion";
            this.btnCalificacion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalificacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalificacion.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCalificacion.selected = false;
            this.btnCalificacion.Size = new System.Drawing.Size(102, 24);
            this.btnCalificacion.TabIndex = 31;
            this.btnCalificacion.Text = "Calificación";
            this.btnCalificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificacion.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnCalificacion.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGenero
            // 
            this.btnGenero.Active = false;
            this.btnGenero.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenero.BorderRadius = 0;
            this.btnGenero.ButtonText = "Género";
            this.btnGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnGenero, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnGenero, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnGenero, BunifuAnimatorNS.DecorationType.None);
            this.btnGenero.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGenero.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenero.Iconimage = null;
            this.btnGenero.Iconimage_right = null;
            this.btnGenero.Iconimage_right_Selected = null;
            this.btnGenero.Iconimage_Selected = null;
            this.btnGenero.IconMarginLeft = 0;
            this.btnGenero.IconMarginRight = 0;
            this.btnGenero.IconRightVisible = true;
            this.btnGenero.IconRightZoom = 0D;
            this.btnGenero.IconVisible = true;
            this.btnGenero.IconZoom = 40D;
            this.btnGenero.IsTab = true;
            this.btnGenero.Location = new System.Drawing.Point(501, 49);
            this.btnGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGenero.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGenero.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGenero.selected = false;
            this.btnGenero.Size = new System.Drawing.Size(71, 24);
            this.btnGenero.TabIndex = 30;
            this.btnGenero.Text = "Género";
            this.btnGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenero.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnGenero.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAlbum
            // 
            this.btnAlbum.Active = false;
            this.btnAlbum.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlbum.BorderRadius = 0;
            this.btnAlbum.ButtonText = "Álbum";
            this.btnAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnAlbum, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnAlbum, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnAlbum, BunifuAnimatorNS.DecorationType.None);
            this.btnAlbum.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAlbum.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlbum.Iconimage = null;
            this.btnAlbum.Iconimage_right = null;
            this.btnAlbum.Iconimage_right_Selected = null;
            this.btnAlbum.Iconimage_Selected = null;
            this.btnAlbum.IconMarginLeft = 0;
            this.btnAlbum.IconMarginRight = 0;
            this.btnAlbum.IconRightVisible = true;
            this.btnAlbum.IconRightZoom = 0D;
            this.btnAlbum.IconVisible = true;
            this.btnAlbum.IconZoom = 40D;
            this.btnAlbum.IsTab = true;
            this.btnAlbum.Location = new System.Drawing.Point(365, 49);
            this.btnAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAlbum.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAlbum.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAlbum.selected = false;
            this.btnAlbum.Size = new System.Drawing.Size(71, 24);
            this.btnAlbum.TabIndex = 29;
            this.btnAlbum.Text = "Álbum";
            this.btnAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbum.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnAlbum.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.Click += new System.EventHandler(this.bunifuFlatButton6_Click_1);
            // 
            // btnArtista
            // 
            this.btnArtista.Active = false;
            this.btnArtista.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnArtista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArtista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnArtista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArtista.BorderRadius = 0;
            this.btnArtista.ButtonText = "Artista";
            this.btnArtista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnArtista, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnArtista, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnArtista, BunifuAnimatorNS.DecorationType.None);
            this.btnArtista.DisabledColor = System.Drawing.Color.Empty;
            this.btnArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnArtista.Iconcolor = System.Drawing.Color.Transparent;
            this.btnArtista.Iconimage = null;
            this.btnArtista.Iconimage_right = null;
            this.btnArtista.Iconimage_right_Selected = null;
            this.btnArtista.Iconimage_Selected = null;
            this.btnArtista.IconMarginLeft = 0;
            this.btnArtista.IconMarginRight = 0;
            this.btnArtista.IconRightVisible = true;
            this.btnArtista.IconRightZoom = 0D;
            this.btnArtista.IconVisible = true;
            this.btnArtista.IconZoom = 40D;
            this.btnArtista.IsTab = true;
            this.btnArtista.Location = new System.Drawing.Point(211, 49);
            this.btnArtista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnArtista.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnArtista.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnArtista.selected = false;
            this.btnArtista.Size = new System.Drawing.Size(57, 24);
            this.btnArtista.TabIndex = 28;
            this.btnArtista.Text = "Artista";
            this.btnArtista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtista.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnArtista.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtista.Click += new System.EventHandler(this.bunifuFlatButton5_Click_1);
            // 
            // btnNombre
            // 
            this.btnNombre.Active = false;
            this.btnNombre.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNombre.BorderRadius = 0;
            this.btnNombre.ButtonText = "Nombre";
            this.btnNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnNombre, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnNombre, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnNombre, BunifuAnimatorNS.DecorationType.None);
            this.btnNombre.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnNombre.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNombre.Iconimage = null;
            this.btnNombre.Iconimage_right = null;
            this.btnNombre.Iconimage_right_Selected = null;
            this.btnNombre.Iconimage_Selected = null;
            this.btnNombre.IconMarginLeft = 0;
            this.btnNombre.IconMarginRight = 0;
            this.btnNombre.IconRightVisible = true;
            this.btnNombre.IconRightZoom = 0D;
            this.btnNombre.IconVisible = true;
            this.btnNombre.IconZoom = 40D;
            this.btnNombre.IsTab = true;
            this.btnNombre.Location = new System.Drawing.Point(44, 49);
            this.btnNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnNombre.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnNombre.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNombre.selected = false;
            this.btnNombre.Size = new System.Drawing.Size(71, 24);
            this.btnNombre.TabIndex = 27;
            this.btnNombre.Text = "Nombre";
            this.btnNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNombre.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnNombre.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // lstCanciones
            // 
            this.lstCanciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lstCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelEntra.SetDecoration(this.lstCanciones, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.lstCanciones, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.lstCanciones, BunifuAnimatorNS.DecorationType.None);
            this.lstCanciones.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCanciones.ForeColor = System.Drawing.Color.Transparent;
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 17;
            this.lstCanciones.Location = new System.Drawing.Point(44, 78);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(639, 374);
            this.lstCanciones.TabIndex = 0;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged_1);
            // 
            // btnAgregaCancion
            // 
            this.btnAgregaCancion.Active = false;
            this.btnAgregaCancion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAgregaCancion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregaCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregaCancion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregaCancion.BorderRadius = 0;
            this.btnAgregaCancion.ButtonText = "Agregar";
            this.btnAgregaCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnAgregaCancion, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnAgregaCancion, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnAgregaCancion, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregaCancion.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAgregaCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAgregaCancion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregaCancion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregaCancion.Iconimage")));
            this.btnAgregaCancion.Iconimage_right = null;
            this.btnAgregaCancion.Iconimage_right_Selected = null;
            this.btnAgregaCancion.Iconimage_Selected = null;
            this.btnAgregaCancion.IconMarginLeft = 0;
            this.btnAgregaCancion.IconMarginRight = 0;
            this.btnAgregaCancion.IconRightVisible = true;
            this.btnAgregaCancion.IconRightZoom = 0D;
            this.btnAgregaCancion.IconVisible = true;
            this.btnAgregaCancion.IconZoom = 40D;
            this.btnAgregaCancion.IsTab = true;
            this.btnAgregaCancion.Location = new System.Drawing.Point(659, 9);
            this.btnAgregaCancion.Name = "btnAgregaCancion";
            this.btnAgregaCancion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregaCancion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregaCancion.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAgregaCancion.selected = false;
            this.btnAgregaCancion.Size = new System.Drawing.Size(111, 34);
            this.btnAgregaCancion.TabIndex = 26;
            this.btnAgregaCancion.Text = "Agregar";
            this.btnAgregaCancion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaCancion.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnAgregaCancion.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaCancion.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // vlcPlayer
            // 
            this.logoAnimator.SetDecoration(this.vlcPlayer, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.vlcPlayer, BunifuAnimatorNS.DecorationType.None);
            this.vlcPlayer.Enabled = true;
            this.vlcPlayer.Location = new System.Drawing.Point(0, 473);
            this.vlcPlayer.Name = "vlcPlayer";
            this.vlcPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vlcPlayer.OcxState")));
            this.vlcPlayer.Size = new System.Drawing.Size(782, 47);
            this.vlcPlayer.TabIndex = 21;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation1;
            // 
            // panelEntra
            // 
            this.panelEntra.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelEntra.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelEntra.DefaultAnimation = animation2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelFuera
            // 
            this.panelFuera.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelFuera.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.panelFuera.DefaultAnimation = animation3;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = false;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "      Buscar";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 80D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(-1, 389);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(201, 48);
            this.bunifuFlatButton5.TabIndex = 26;
            this.bunifuFlatButton5.Text = "      Buscar";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregarAmigo
            // 
            this.btnAgregarAmigo.Active = false;
            this.btnAgregarAmigo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAgregarAmigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarAmigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarAmigo.BorderRadius = 0;
            this.btnAgregarAmigo.ButtonText = "Agregar";
            this.btnAgregarAmigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnAgregarAmigo, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.btnAgregarAmigo, BunifuAnimatorNS.DecorationType.None);
            this.panelEntra.SetDecoration(this.btnAgregarAmigo, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregarAmigo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAgregarAmigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAgregarAmigo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarAmigo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarAmigo.Iconimage")));
            this.btnAgregarAmigo.Iconimage_right = null;
            this.btnAgregarAmigo.Iconimage_right_Selected = null;
            this.btnAgregarAmigo.Iconimage_Selected = null;
            this.btnAgregarAmigo.IconMarginLeft = 0;
            this.btnAgregarAmigo.IconMarginRight = 0;
            this.btnAgregarAmigo.IconRightVisible = true;
            this.btnAgregarAmigo.IconRightZoom = 0D;
            this.btnAgregarAmigo.IconVisible = true;
            this.btnAgregarAmigo.IconZoom = 40D;
            this.btnAgregarAmigo.IsTab = true;
            this.btnAgregarAmigo.Location = new System.Drawing.Point(597, 117);
            this.btnAgregarAmigo.Name = "btnAgregarAmigo";
            this.btnAgregarAmigo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarAmigo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarAmigo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAgregarAmigo.selected = false;
            this.btnAgregarAmigo.Size = new System.Drawing.Size(111, 34);
            this.btnAgregarAmigo.TabIndex = 33;
            this.btnAgregarAmigo.Text = "Agregar";
            this.btnAgregarAmigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAmigo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.btnAgregarAmigo.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lstFriends
            // 
            this.lstFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lstFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelEntra.SetDecoration(this.lstFriends, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.lstFriends, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this.lstFriends, BunifuAnimatorNS.DecorationType.None);
            this.lstFriends.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.ItemHeight = 20;
            this.lstFriends.Location = new System.Drawing.Point(74, 91);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(455, 340);
            this.lstFriends.TabIndex = 32;
            // 
            // lblCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(982, 561);
            this.Controls.Add(this.panelBiblioteca);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.header);
            this.panelEntra.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelFuera.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lblCalificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odyssey";
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelBiblioteca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlcPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox miniLogo;
        private System.Windows.Forms.Panel panelBiblioteca;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private BunifuAnimatorNS.BunifuTransition panelEntra;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private AxAXVLC.AxVLCPlugin2 vlcPlayer;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregaCancion;
        private BunifuAnimatorNS.BunifuTransition panelFuera;
        private Bunifu.Framework.UI.BunifuFlatButton btnNombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnArtista;
        private System.Windows.Forms.ListBox lstCanciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlbum;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenero;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalificacion;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarAmigo;
        private System.Windows.Forms.ListBox lstFriends;
    }
}