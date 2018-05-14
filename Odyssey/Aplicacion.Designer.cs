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
            this.cmbBoxOrdena = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblCalif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgrega
            // 
            this.btnAgrega.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAgrega.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgrega.BackgroundImage")));
            this.btnAgrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrega.Location = new System.Drawing.Point(12, 32);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(65, 50);
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
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.Location = new System.Drawing.Point(83, 32);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(65, 50);
            this.btnBiblioteca.TabIndex = 4;
            this.btnBiblioteca.Text = "Biblioteca";
            this.toolTip1Biblioteca.SetToolTip(this.btnBiblioteca, "Mostrar Biblioteca Musical\r\n");
            this.btnBiblioteca.UseVisualStyleBackColor = true;
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
            // cmbBoxOrdena
            // 
            this.cmbBoxOrdena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxOrdena.FormattingEnabled = true;
            this.cmbBoxOrdena.Items.AddRange(new object[] {
            "Nombre",
            "Artista",
            "Álbum",
            "Género",
            "Calificación"});
            this.cmbBoxOrdena.Location = new System.Drawing.Point(12, 90);
            this.cmbBoxOrdena.Name = "cmbBoxOrdena";
            this.cmbBoxOrdena.Size = new System.Drawing.Size(136, 21);
            this.cmbBoxOrdena.TabIndex = 5;
            this.cmbBoxOrdena.SelectedIndexChanged += new System.EventHandler(this.cmbBoxOrdena_SelectedIndexChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(12, 117);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(61, 21);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstCanciones
            // 
            this.lstCanciones.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 17;
            this.lstCanciones.Location = new System.Drawing.Point(83, 139);
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
            this.lblNombre.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Red;
            this.lblNombre.Location = new System.Drawing.Point(118, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArtista.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.Color.Red;
            this.lblArtista.Location = new System.Drawing.Point(261, 116);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(64, 16);
            this.lblArtista.TabIndex = 13;
            this.lblArtista.Text = "Artista";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlbum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.Red;
            this.lblAlbum.Location = new System.Drawing.Point(399, 116);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(48, 16);
            this.lblAlbum.TabIndex = 14;
            this.lblAlbum.Text = "Álbum";
            this.lblAlbum.Click += new System.EventHandler(this.lblAlbum_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGenero.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Red;
            this.lblGenero.Location = new System.Drawing.Point(509, 116);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(56, 16);
            this.lblGenero.TabIndex = 15;
            this.lblGenero.Text = "Género";
            // 
            // lblCalif
            // 
            this.lblCalif.AutoSize = true;
            this.lblCalif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCalif.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalif.ForeColor = System.Drawing.Color.Red;
            this.lblCalif.Location = new System.Drawing.Point(610, 116);
            this.lblCalif.Name = "lblCalif";
            this.lblCalif.Size = new System.Drawing.Size(104, 16);
            this.lblCalif.TabIndex = 16;
            this.lblCalif.Text = "Calificación";
            // 
            // lblCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblCalif);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.cmbBoxOrdena);
            this.Controls.Add(this.btnBiblioteca);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.reproductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lblCalificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odyssey";
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgrega;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.ToolTip toolTipAgrega;
        private System.Windows.Forms.ToolTip toolTip1Biblioteca;
        private System.Windows.Forms.ComboBox cmbBoxOrdena;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblCalif;
    }
}