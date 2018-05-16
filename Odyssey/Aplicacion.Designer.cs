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
            this.btnAgrega = new System.Windows.Forms.Button();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.toolTipAgrega = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1Biblioteca = new System.Windows.Forms.ToolTip(this.components);
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblCalif = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgrega
            // 
            this.btnAgrega.BackColor = System.Drawing.Color.Gray;
            this.btnAgrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrega.Location = new System.Drawing.Point(3, 3);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(147, 35);
            this.btnAgrega.TabIndex = 0;
            this.btnAgrega.Text = "Agregar Canción";
            this.toolTipAgrega.SetToolTip(this.btnAgrega, "Agregar Nueva Canción");
            this.btnAgrega.UseVisualStyleBackColor = false;
            this.btnAgrega.Click += new System.EventHandler(this.button1_Click);
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(-4, 517);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(889, 44);
            this.reproductor.TabIndex = 2;
            this.reproductor.Enter += new System.EventHandler(this.reproductor_Enter);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.BackColor = System.Drawing.Color.Gray;
            this.btnBiblioteca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.Location = new System.Drawing.Point(156, 3);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(147, 35);
            this.btnBiblioteca.TabIndex = 4;
            this.btnBiblioteca.Text = "Biblioteca";
            this.toolTip1Biblioteca.SetToolTip(this.btnBiblioteca, "Mostrar Biblioteca Musical\r\n");
            this.btnBiblioteca.UseVisualStyleBackColor = false;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // toolTipAgrega
            // 
            this.toolTipAgrega.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipAgrega_Popup);
            // 
            // toolTip1Biblioteca
            // 
            this.toolTip1Biblioteca.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1Biblioteca_Popup);
            // 
            // lstCanciones
            // 
            this.lstCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstCanciones.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 17;
            this.lstCanciones.Location = new System.Drawing.Point(43, 94);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(659, 344);
            this.lstCanciones.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Odyssey";
            this.notifyIcon1.Visible = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombre.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNombre.Location = new System.Drawing.Point(67, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArtista.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.Color.DarkGray;
            this.lblArtista.Location = new System.Drawing.Point(210, 73);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(78, 18);
            this.lblArtista.TabIndex = 13;
            this.lblArtista.Text = "Artista";
            this.lblArtista.Click += new System.EventHandler(this.lblArtista_Click);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlbum.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAlbum.Location = new System.Drawing.Point(338, 73);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(58, 18);
            this.lblAlbum.TabIndex = 14;
            this.lblAlbum.Text = "Álbum";
            this.lblAlbum.Click += new System.EventHandler(this.lblAlbum_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGenero.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGenero.Location = new System.Drawing.Point(458, 73);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(68, 18);
            this.lblGenero.TabIndex = 15;
            this.lblGenero.Text = "Género";
            // 
            // lblCalif
            // 
            this.lblCalif.AutoSize = true;
            this.lblCalif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCalif.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalif.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCalif.Location = new System.Drawing.Point(559, 73);
            this.lblCalif.Name = "lblCalif";
            this.lblCalif.Size = new System.Drawing.Size(128, 18);
            this.lblCalif.TabIndex = 16;
            this.lblCalif.Text = "Calificación";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCalif);
            this.panel1.Controls.Add(this.lstCanciones);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.lblAlbum);
            this.panel1.Controls.Add(this.lblArtista);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.btnBiblioteca);
            this.panel1.Controls.Add(this.btnAgrega);
            this.panel1.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 512);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reproductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lblCalificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odyssey";
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgrega;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.ToolTip toolTipAgrega;
        private System.Windows.Forms.ToolTip toolTip1Biblioteca;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblCalif;
        private System.Windows.Forms.Panel panel1;
    }
}