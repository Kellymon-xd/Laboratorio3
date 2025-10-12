namespace Laboratorio3
{
    partial class frmE4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmE4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlReq = new System.Windows.Forms.Panel();
            this.grpCor = new System.Windows.Forms.GroupBox();
            this.lblReqCor3 = new System.Windows.Forms.Label();
            this.lblReqCor1 = new System.Windows.Forms.Label();
            this.lblReqCor2 = new System.Windows.Forms.Label();
            this.grpPass = new System.Windows.Forms.GroupBox();
            this.lblReqPass4 = new System.Windows.Forms.Label();
            this.lblReqPass2 = new System.Windows.Forms.Label();
            this.lblReqPass3 = new System.Windows.Forms.Label();
            this.lblReqPass1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.pnlReq.SuspendLayout();
            this.grpCor.SuspendLayout();
            this.grpPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // picProfile
            // 
            this.picProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProfile.BackgroundImage")));
            this.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProfile.Location = new System.Drawing.Point(190, 82);
            this.picProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(92, 89);
            this.picProfile.TabIndex = 16;
            this.picProfile.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblTitle.Location = new System.Drawing.Point(144, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "REGISTRO";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(84, 210);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 33);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.lblApellido.Location = new System.Drawing.Point(70, 243);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(107, 33);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.lblCorreo.Location = new System.Drawing.Point(81, 272);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(96, 33);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.lblContraseña.Location = new System.Drawing.Point(39, 308);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(138, 33);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRegistro
            // 
            this.btnRegistro.AutoSize = true;
            this.btnRegistro.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegistro.Location = new System.Drawing.Point(190, 383);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(138, 39);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "REGISTRARSE";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(189, 217);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 22);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(189, 250);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 22);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(189, 283);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(208, 22);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCorreo_KeyUp);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(189, 315);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(208, 22);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            this.txtContraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyUp);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // erpError
            // 
            this.erpError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpError.ContainerControl = this;
            // 
            // pnlReq
            // 
            this.pnlReq.Controls.Add(this.grpCor);
            this.pnlReq.Controls.Add(this.grpPass);
            this.pnlReq.Location = new System.Drawing.Point(26, 426);
            this.pnlReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReq.Name = "pnlReq";
            this.pnlReq.Size = new System.Drawing.Size(467, 132);
            this.pnlReq.TabIndex = 15;
            // 
            // grpCor
            // 
            this.grpCor.BackColor = System.Drawing.Color.Ivory;
            this.grpCor.Controls.Add(this.lblReqCor3);
            this.grpCor.Controls.Add(this.lblReqCor1);
            this.grpCor.Controls.Add(this.lblReqCor2);
            this.grpCor.Location = new System.Drawing.Point(7, 13);
            this.grpCor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCor.Name = "grpCor";
            this.grpCor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCor.Size = new System.Drawing.Size(445, 92);
            this.grpCor.TabIndex = 5;
            this.grpCor.TabStop = false;
            this.grpCor.Text = "Requisitos para el correo:";
            // 
            // lblReqCor3
            // 
            this.lblReqCor3.AutoSize = true;
            this.lblReqCor3.Location = new System.Drawing.Point(13, 49);
            this.lblReqCor3.Name = "lblReqCor3";
            this.lblReqCor3.Size = new System.Drawing.Size(345, 16);
            this.lblReqCor3.TabIndex = 3;
            this.lblReqCor3.Text = "Terminar en: @gmail.com, @hotmail.com, @utp.ac.pa";
            // 
            // lblReqCor1
            // 
            this.lblReqCor1.AutoSize = true;
            this.lblReqCor1.Location = new System.Drawing.Point(13, 18);
            this.lblReqCor1.Name = "lblReqCor1";
            this.lblReqCor1.Size = new System.Drawing.Size(77, 16);
            this.lblReqCor1.TabIndex = 1;
            this.lblReqCor1.Text = "Solo un \'@\'.";
            // 
            // lblReqCor2
            // 
            this.lblReqCor2.AutoSize = true;
            this.lblReqCor2.Location = new System.Drawing.Point(13, 33);
            this.lblReqCor2.Name = "lblReqCor2";
            this.lblReqCor2.Size = new System.Drawing.Size(221, 16);
            this.lblReqCor2.TabIndex = 2;
            this.lblReqCor2.Text = "Al menos un carácter antes del \'@\'.";
            // 
            // grpPass
            // 
            this.grpPass.BackColor = System.Drawing.Color.Ivory;
            this.grpPass.Controls.Add(this.lblReqPass4);
            this.grpPass.Controls.Add(this.lblReqPass2);
            this.grpPass.Controls.Add(this.lblReqPass3);
            this.grpPass.Controls.Add(this.lblReqPass1);
            this.grpPass.Location = new System.Drawing.Point(7, 17);
            this.grpPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPass.Name = "grpPass";
            this.grpPass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPass.Size = new System.Drawing.Size(451, 92);
            this.grpPass.TabIndex = 0;
            this.grpPass.TabStop = false;
            this.grpPass.Text = "Requisitos para la contraseña:";
            // 
            // lblReqPass4
            // 
            this.lblReqPass4.AutoSize = true;
            this.lblReqPass4.Location = new System.Drawing.Point(27, 66);
            this.lblReqPass4.Name = "lblReqPass4";
            this.lblReqPass4.Size = new System.Drawing.Size(299, 16);
            this.lblReqPass4.TabIndex = 4;
            this.lblReqPass4.Text = "Mínimo 1 carácter especial (!, @, #, $, %, ^, &, *) ";
            // 
            // lblReqPass2
            // 
            this.lblReqPass2.AutoSize = true;
            this.lblReqPass2.Location = new System.Drawing.Point(25, 18);
            this.lblReqPass2.Name = "lblReqPass2";
            this.lblReqPass2.Size = new System.Drawing.Size(88, 16);
            this.lblReqPass2.TabIndex = 2;
            this.lblReqPass2.Text = "1 mayúscula.";
            // 
            // lblReqPass3
            // 
            this.lblReqPass3.AutoSize = true;
            this.lblReqPass3.Location = new System.Drawing.Point(27, 50);
            this.lblReqPass3.Name = "lblReqPass3";
            this.lblReqPass3.Size = new System.Drawing.Size(108, 16);
            this.lblReqPass3.TabIndex = 3;
            this.lblReqPass3.Text = "Mínimo 1 dígito.";
            // 
            // lblReqPass1
            // 
            this.lblReqPass1.AutoSize = true;
            this.lblReqPass1.Location = new System.Drawing.Point(27, 34);
            this.lblReqPass1.Name = "lblReqPass1";
            this.lblReqPass1.Size = new System.Drawing.Size(145, 16);
            this.lblReqPass1.TabIndex = 1;
            this.lblReqPass1.Text = "Mínimo 12 carácteres.";
            // 
            // frmE4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(505, 581);
            this.Controls.Add(this.pnlReq);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picProfile);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmE4";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.E4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.pnlReq.ResumeLayout(false);
            this.grpCor.ResumeLayout(false);
            this.grpCor.PerformLayout();
            this.grpPass.ResumeLayout(false);
            this.grpPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Panel pnlReq;
        private System.Windows.Forms.GroupBox grpCor;
        private System.Windows.Forms.Label lblReqCor3;
        private System.Windows.Forms.Label lblReqCor1;
        private System.Windows.Forms.Label lblReqCor2;
        private System.Windows.Forms.GroupBox grpPass;
        private System.Windows.Forms.Label lblReqPass4;
        private System.Windows.Forms.Label lblReqPass2;
        private System.Windows.Forms.Label lblReqPass3;
        private System.Windows.Forms.Label lblReqPass1;
    }
}