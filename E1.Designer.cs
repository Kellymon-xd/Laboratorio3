namespace Laboratorio3
{
    partial class E1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E1));
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnAbrirCuenta = new System.Windows.Forms.Button();
            this.lblMontoInicial = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDepositos = new System.Windows.Forms.RadioButton();
            this.rbRetiros = new System.Windows.Forms.RadioButton();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.ltbDepositos = new System.Windows.Forms.ListBox();
            this.ltbRetiros = new System.Windows.Forms.ListBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblRetiros = new System.Windows.Forms.Label();
            this.lblDepositos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Location = new System.Drawing.Point(201, 144);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(132, 26);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonto_Validating);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(201, 53);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(132, 26);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating);
            // 
            // btnAbrirCuenta
            // 
            this.btnAbrirCuenta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbrirCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCuenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCuenta.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCuenta.Location = new System.Drawing.Point(456, 47);
            this.btnAbrirCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrirCuenta.Name = "btnAbrirCuenta";
            this.btnAbrirCuenta.Size = new System.Drawing.Size(137, 33);
            this.btnAbrirCuenta.TabIndex = 2;
            this.btnAbrirCuenta.Text = "Abrir Cuenta";
            this.btnAbrirCuenta.UseVisualStyleBackColor = false;
            this.btnAbrirCuenta.Click += new System.EventHandler(this.btnAbrirCuenta_Click);
            // 
            // lblMontoInicial
            // 
            this.lblMontoInicial.AutoSize = true;
            this.lblMontoInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoInicial.ForeColor = System.Drawing.Color.Black;
            this.lblMontoInicial.Location = new System.Drawing.Point(63, 150);
            this.lblMontoInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoInicial.Name = "lblMontoInicial";
            this.lblMontoInicial.Size = new System.Drawing.Size(94, 17);
            this.lblMontoInicial.TabIndex = 1;
            this.lblMontoInicial.Text = "Monto Inicial:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(110, 55);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 17);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.lblMontoInicial);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.btnAbrirCuenta);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(660, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // rbDepositos
            // 
            this.rbDepositos.AutoSize = true;
            this.rbDepositos.BackColor = System.Drawing.Color.SteelBlue;
            this.rbDepositos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDepositos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDepositos.Location = new System.Drawing.Point(177, 61);
            this.rbDepositos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbDepositos.Name = "rbDepositos";
            this.rbDepositos.Size = new System.Drawing.Size(85, 21);
            this.rbDepositos.TabIndex = 15;
            this.rbDepositos.TabStop = true;
            this.rbDepositos.Text = "Depositar";
            this.rbDepositos.UseVisualStyleBackColor = false;
            // 
            // rbRetiros
            // 
            this.rbRetiros.AutoSize = true;
            this.rbRetiros.BackColor = System.Drawing.Color.SteelBlue;
            this.rbRetiros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRetiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRetiros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetiros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbRetiros.Location = new System.Drawing.Point(398, 61);
            this.rbRetiros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbRetiros.Name = "rbRetiros";
            this.rbRetiros.Size = new System.Drawing.Size(66, 21);
            this.rbRetiros.TabIndex = 14;
            this.rbRetiros.TabStop = true;
            this.rbRetiros.Text = "Retirar";
            this.rbRetiros.UseVisualStyleBackColor = false;
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.ForeColor = System.Drawing.Color.Black;
            this.lblSaldoActual.Location = new System.Drawing.Point(28, 101);
            this.lblSaldoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(81, 17);
            this.lblSaldoActual.TabIndex = 11;
            this.lblSaldoActual.Text = "SaldoActual";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoActual.Enabled = false;
            this.txtSaldoActual.Location = new System.Drawing.Point(276, 100);
            this.txtSaldoActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(132, 26);
            this.txtSaldoActual.TabIndex = 10;
            // 
            // ltbDepositos
            // 
            this.ltbDepositos.BackColor = System.Drawing.Color.AliceBlue;
            this.ltbDepositos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbDepositos.FormattingEnabled = true;
            this.ltbDepositos.ItemHeight = 17;
            this.ltbDepositos.Location = new System.Drawing.Point(294, 178);
            this.ltbDepositos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ltbDepositos.Name = "ltbDepositos";
            this.ltbDepositos.Size = new System.Drawing.Size(159, 123);
            this.ltbDepositos.TabIndex = 9;
            this.ltbDepositos.DoubleClick += new System.EventHandler(this.ltbDepositos_DoubleClick);
            // 
            // ltbRetiros
            // 
            this.ltbRetiros.BackColor = System.Drawing.Color.AliceBlue;
            this.ltbRetiros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbRetiros.FormattingEnabled = true;
            this.ltbRetiros.ItemHeight = 17;
            this.ltbRetiros.Location = new System.Drawing.Point(37, 178);
            this.ltbRetiros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ltbRetiros.Name = "ltbRetiros";
            this.ltbRetiros.Size = new System.Drawing.Size(159, 123);
            this.ltbRetiros.TabIndex = 8;
            this.ltbRetiros.DoubleClick += new System.EventHandler(this.ltbRetiros_DoubleClick);
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(276, 54);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(132, 26);
            this.txtSaldo.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(487, 75);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 27);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(19, 58);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(107, 17);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Monto Apertura";
            // 
            // lblRetiros
            // 
            this.lblRetiros.AutoSize = true;
            this.lblRetiros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiros.ForeColor = System.Drawing.Color.Black;
            this.lblRetiros.Location = new System.Drawing.Point(35, 147);
            this.lblRetiros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetiros.Name = "lblRetiros";
            this.lblRetiros.Size = new System.Drawing.Size(51, 17);
            this.lblRetiros.TabIndex = 2;
            this.lblRetiros.Text = "Retiros";
            // 
            // lblDepositos
            // 
            this.lblDepositos.AutoSize = true;
            this.lblDepositos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositos.ForeColor = System.Drawing.Color.Black;
            this.lblDepositos.Location = new System.Drawing.Point(300, 147);
            this.lblDepositos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositos.Name = "lblDepositos";
            this.lblDepositos.Size = new System.Drawing.Size(70, 17);
            this.lblDepositos.TabIndex = 1;
            this.lblDepositos.Text = "Depositos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rbRetiros);
            this.groupBox2.Controls.Add(this.rbDepositos);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(15, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(660, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transacciones";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblSaldoActual);
            this.groupBox3.Controls.Add(this.lblSaldo);
            this.groupBox3.Controls.Add(this.txtSaldoActual);
            this.groupBox3.Controls.Add(this.lblDepositos);
            this.groupBox3.Controls.Add(this.ltbDepositos);
            this.groupBox3.Controls.Add(this.lblRetiros);
            this.groupBox3.Controls.Add(this.ltbRetiros);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(15, 396);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(660, 338);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta de Ahorros";
            // 
            // E1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(688, 755);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "E1";
            this.Text = "Gestión de cuentas de ahorro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbrirCuenta;
        private System.Windows.Forms.Label lblMontoInicial;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDepositos;
        private System.Windows.Forms.RadioButton rbRetiros;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.ListBox ltbDepositos;
        private System.Windows.Forms.ListBox ltbRetiros;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblRetiros;
        private System.Windows.Forms.Label lblDepositos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}