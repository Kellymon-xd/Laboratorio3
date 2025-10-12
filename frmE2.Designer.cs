namespace Laboratorio3
{
    partial class frmE2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmE2));
            this.dgvNumbers = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.grpModalidad = new System.Windows.Forms.GroupBox();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.rdbAleatorio = new System.Windows.Forms.RadioButton();
            this.rdbAgregarNumero = new System.Windows.Forms.RadioButton();
            this.lblNumeroIndividual = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCantidadAleatoria = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumbers)).BeginInit();
            this.grpModalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNumbers
            // 
            this.dgvNumbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumbers.Location = new System.Drawing.Point(81, 75);
            this.dgvNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNumbers.Name = "dgvNumbers";
            this.dgvNumbers.ReadOnly = true;
            this.dgvNumbers.Size = new System.Drawing.Size(713, 207);
            this.dgvNumbers.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(330, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Números Enteros";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.LightGray;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(186, 366);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(132, 43);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.Visible = false;
            // 
            // grpModalidad
            // 
            this.grpModalidad.BackColor = System.Drawing.Color.Transparent;
            this.grpModalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpModalidad.Controls.Add(this.rdbManual);
            this.grpModalidad.Controls.Add(this.rdbAleatorio);
            this.grpModalidad.Controls.Add(this.rdbAgregarNumero);
            this.grpModalidad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModalidad.Location = new System.Drawing.Point(357, 310);
            this.grpModalidad.Margin = new System.Windows.Forms.Padding(4);
            this.grpModalidad.Name = "grpModalidad";
            this.grpModalidad.Padding = new System.Windows.Forms.Padding(4);
            this.grpModalidad.Size = new System.Drawing.Size(199, 130);
            this.grpModalidad.TabIndex = 3;
            this.grpModalidad.TabStop = false;
            this.grpModalidad.Text = "Modalidad";
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbManual.Location = new System.Drawing.Point(8, 60);
            this.rdbManual.Margin = new System.Windows.Forms.Padding(4);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(93, 27);
            this.rdbManual.TabIndex = 2;
            this.rdbManual.TabStop = true;
            this.rdbManual.Text = "Manual";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // rdbAleatorio
            // 
            this.rdbAleatorio.AutoSize = true;
            this.rdbAleatorio.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAleatorio.Location = new System.Drawing.Point(8, 27);
            this.rdbAleatorio.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAleatorio.Name = "rdbAleatorio";
            this.rdbAleatorio.Size = new System.Drawing.Size(106, 27);
            this.rdbAleatorio.TabIndex = 1;
            this.rdbAleatorio.TabStop = true;
            this.rdbAleatorio.Text = "Aleatorio";
            this.rdbAleatorio.UseVisualStyleBackColor = true;
            this.rdbAleatorio.CheckedChanged += new System.EventHandler(this.rdbAleatorio_CheckedChanged);
            // 
            // rdbAgregarNumero
            // 
            this.rdbAgregarNumero.AutoSize = true;
            this.rdbAgregarNumero.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAgregarNumero.Location = new System.Drawing.Point(8, 95);
            this.rdbAgregarNumero.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAgregarNumero.Name = "rdbAgregarNumero";
            this.rdbAgregarNumero.Size = new System.Drawing.Size(171, 27);
            this.rdbAgregarNumero.TabIndex = 0;
            this.rdbAgregarNumero.TabStop = true;
            this.rdbAgregarNumero.Text = "Agregar Numero";
            this.rdbAgregarNumero.UseVisualStyleBackColor = true;
            this.rdbAgregarNumero.CheckedChanged += new System.EventHandler(this.rdbAgregarNumero_CheckedChanged);
            // 
            // lblNumeroIndividual
            // 
            this.lblNumeroIndividual.AutoSize = true;
            this.lblNumeroIndividual.Enabled = false;
            this.lblNumeroIndividual.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIndividual.Location = new System.Drawing.Point(54, 372);
            this.lblNumeroIndividual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroIndividual.Name = "lblNumeroIndividual";
            this.lblNumeroIndividual.Size = new System.Drawing.Size(96, 25);
            this.lblNumeroIndividual.TabIndex = 4;
            this.lblNumeroIndividual.Text = "Numero:";
            this.lblNumeroIndividual.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(621, 316);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(171, 34);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(623, 358);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 34);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCantidadAleatoria
            // 
            this.lblCantidadAleatoria.AutoSize = true;
            this.lblCantidadAleatoria.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAleatoria.Location = new System.Drawing.Point(54, 303);
            this.lblCantidadAleatoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadAleatoria.Name = "lblCantidadAleatoria";
            this.lblCantidadAleatoria.Size = new System.Drawing.Size(117, 50);
            this.lblCantidadAleatoria.TabIndex = 7;
            this.lblCantidadAleatoria.Text = "Cantidad a \r\ningresar:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.LightGray;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(184, 310);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(132, 43);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(558, 466);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(259, 46);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(95, 430);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 34);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // E2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(844, 554);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidadAleatoria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblNumeroIndividual);
            this.Controls.Add(this.grpModalidad);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvNumbers);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "E2";
            this.Text = "Números enteros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumbers)).EndInit();
            this.grpModalidad.ResumeLayout(false);
            this.grpModalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumbers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox grpModalidad;
        private System.Windows.Forms.RadioButton rdbAleatorio;
        private System.Windows.Forms.RadioButton rdbAgregarNumero;
        private System.Windows.Forms.Label lblNumeroIndividual;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCantidadAleatoria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.Button btnAgregar;
    }
}