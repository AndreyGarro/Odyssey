namespace Odyssey
{
    partial class vtnPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vtnPrincipal));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.linkNew = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.InitialImage = null;
            this.imgLogo.Location = new System.Drawing.Point(143, 40);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(205, 107);
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            this.imgLogo.Tag = "imgLogo";
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(381, 530);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 12;
            this.txtIP.Tag = "txtIP";
            this.txtIP.Text = "Dirección IP";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // linkNew
            // 
            this.linkNew.AutoSize = true;
            this.linkNew.Location = new System.Drawing.Point(179, 377);
            this.linkNew.Name = "linkNew";
            this.linkNew.Size = new System.Drawing.Size(116, 13);
            this.linkNew.TabIndex = 8;
            this.linkNew.TabStop = true;
            this.linkNew.Tag = "linkNew";
            this.linkNew.Text = "¿No tiene una cuenta?";
            this.linkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNew_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(277, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 20);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Tag = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(60, 236);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 20);
            this.txtUser.TabIndex = 13;
            this.txtUser.Tag = "txtUser";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(303, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 22);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Tag = "lblPassword";
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(88, 208);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(68, 22);
            this.lblUser.TabIndex = 9;
            this.lblUser.Tag = "lblUser";
            this.lblUser.Text = "Usuario";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.Location = new System.Drawing.Point(2, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 33);
            this.btnExit.TabIndex = 11;
            this.btnExit.Tag = "btnExit";
            this.btnExit.Text = "Salir";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Window;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnEnter.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.Red;
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnter.Location = new System.Drawing.Point(191, 324);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 33);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Tag = "btnEnter";
            this.btnEnter.Text = "Ingresar";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Debe ser mayor o igual a 8 dígitos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // vtnPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.linkNew);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vtnPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.vtnPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.LinkLabel linkNew;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

