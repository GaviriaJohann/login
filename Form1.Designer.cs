namespace datosPersonales
{
    partial class frmFormulario
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
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lablEmail = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.grpPersonales = new System.Windows.Forms.GroupBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.grpSociales = new System.Windows.Forms.GroupBox();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.lblEps = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLogin = new System.Windows.Forms.Label();
            this.grpGenero.SuspendLayout();
            this.grpPersonales.SuspendLayout();
            this.grpSociales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(16, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(19, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(257, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(254, 29);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lablEmail
            // 
            this.lablEmail.AutoSize = true;
            this.lablEmail.BackColor = System.Drawing.Color.Transparent;
            this.lablEmail.ForeColor = System.Drawing.Color.Black;
            this.lablEmail.Location = new System.Drawing.Point(16, 109);
            this.lablEmail.Name = "lablEmail";
            this.lablEmail.Size = new System.Drawing.Size(35, 13);
            this.lablEmail.TabIndex = 6;
            this.lablEmail.Text = "Email:";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdoFemenino);
            this.grpGenero.Controls.Add(this.rdoMasculino);
            this.grpGenero.Location = new System.Drawing.Point(504, 54);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(200, 109);
            this.grpGenero.TabIndex = 10;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemenino.ForeColor = System.Drawing.Color.Black;
            this.rdoFemenino.Location = new System.Drawing.Point(123, 51);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdoFemenino.TabIndex = 1;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = false;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rdoMasculino.ForeColor = System.Drawing.Color.Black;
            this.rdoMasculino.Location = new System.Drawing.Point(16, 51);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoMasculino.TabIndex = 0;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = false;
            // 
            // grpPersonales
            // 
            this.grpPersonales.BackColor = System.Drawing.Color.Transparent;
            this.grpPersonales.Controls.Add(this.lblContraseña);
            this.grpPersonales.Controls.Add(this.txtContraseña);
            this.grpPersonales.Controls.Add(this.grpGenero);
            this.grpPersonales.Controls.Add(this.txtNombre);
            this.grpPersonales.Controls.Add(this.txtApellido);
            this.grpPersonales.Controls.Add(this.lablEmail);
            this.grpPersonales.Controls.Add(this.lblApellido);
            this.grpPersonales.Controls.Add(this.txtEmail);
            this.grpPersonales.Controls.Add(this.lblNombre);
            this.grpPersonales.Location = new System.Drawing.Point(12, 12);
            this.grpPersonales.Name = "grpPersonales";
            this.grpPersonales.Size = new System.Drawing.Size(721, 269);
            this.grpPersonales.TabIndex = 11;
            this.grpPersonales.TabStop = false;
            this.grpPersonales.Text = "Datos Personales";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(254, 109);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(257, 143);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(158, 20);
            this.txtContraseña.TabIndex = 12;
            // 
            // grpSociales
            // 
            this.grpSociales.Controls.Add(this.txtEps);
            this.grpSociales.Controls.Add(this.lblEps);
            this.grpSociales.Location = new System.Drawing.Point(12, 301);
            this.grpSociales.Name = "grpSociales";
            this.grpSociales.Size = new System.Drawing.Size(721, 152);
            this.grpSociales.TabIndex = 12;
            this.grpSociales.TabStop = false;
            this.grpSociales.Text = "Datos Sociales";
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(33, 55);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(158, 20);
            this.txtEps.TabIndex = 12;
            // 
            // lblEps
            // 
            this.lblEps.AutoSize = true;
            this.lblEps.BackColor = System.Drawing.Color.Transparent;
            this.lblEps.ForeColor = System.Drawing.Color.Black;
            this.lblEps.Location = new System.Drawing.Point(30, 29);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(31, 13);
            this.lblEps.TabIndex = 11;
            this.lblEps.Text = "EPS:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 469);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 32);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(237, 487);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(178, 13);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Ya tienes Cuenta? Inicia sesion aqui";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 513);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpSociales);
            this.Controls.Add(this.grpPersonales);
            this.Name = "frmFormulario";
            this.Text = "Formulario";
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpPersonales.ResumeLayout(false);
            this.grpPersonales.PerformLayout();
            this.grpSociales.ResumeLayout(false);
            this.grpSociales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lablEmail;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.GroupBox grpPersonales;
        private System.Windows.Forms.GroupBox grpSociales;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.Label lblEps;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblLogin;
    }
}

