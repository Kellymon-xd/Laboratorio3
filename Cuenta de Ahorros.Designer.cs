namespace Laboratorio3
{
    partial class Cuenta_de_Ahorros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.ltbDepositos = new System.Windows.Forms.ListBox();
            this.ltbRetiros = new System.Windows.Forms.ListBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblRetiros = new System.Windows.Forms.Label();
            this.lblDepositos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDepositos = new System.Windows.Forms.RadioButton();
            this.rbRetiros = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.rbDepositos);
            this.panel1.Controls.Add(this.rbRetiros);
            this.panel1.Controls.Add(this.lblSaldoActual);
            this.panel1.Controls.Add(this.txtSaldoActual);
            this.panel1.Controls.Add(this.ltbDepositos);
            this.panel1.Controls.Add(this.ltbRetiros);
            this.panel1.Controls.Add(this.txtSaldo);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.lblRetiros);
            this.panel1.Controls.Add(this.lblDepositos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(138, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 388);
            this.panel1.TabIndex = 0;
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(401, 109);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(91, 16);
            this.lblSaldoActual.TabIndex = 11;
            this.lblSaldoActual.Text = "SaldoActual";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Location = new System.Drawing.Point(404, 137);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoActual.TabIndex = 10;
          
            // 
            // ltbDepositos
            // 
            this.ltbDepositos.FormattingEnabled = true;
            this.ltbDepositos.Location = new System.Drawing.Point(213, 94);
            this.ltbDepositos.Name = "ltbDepositos";
            this.ltbDepositos.Size = new System.Drawing.Size(120, 134);
            this.ltbDepositos.TabIndex = 9;
            
            this.ltbDepositos.DoubleClick += new System.EventHandler(this.ltbDepositos_DoubleClick);
            // 
            // ltbRetiros
            // 
            this.ltbRetiros.FormattingEnabled = true;
            this.ltbRetiros.Location = new System.Drawing.Point(30, 94);
            this.ltbRetiros.Name = "ltbRetiros";
            this.ltbRetiros.Size = new System.Drawing.Size(120, 134);
            this.ltbRetiros.TabIndex = 8;
           
            this.ltbRetiros.DoubleClick += new System.EventHandler(this.ltbRetiros_DoubleClick);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(404, 75);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 7;
       
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(388, 171);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(392, 35);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(112, 16);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Monto Apertura";
            // 
            // lblRetiros
            // 
            this.lblRetiros.AutoSize = true;
            this.lblRetiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiros.Location = new System.Drawing.Point(29, 75);
            this.lblRetiros.Name = "lblRetiros";
            this.lblRetiros.Size = new System.Drawing.Size(57, 16);
            this.lblRetiros.TabIndex = 2;
            this.lblRetiros.Text = "Retiros";
            // 
            // lblDepositos
            // 
            this.lblDepositos.AutoSize = true;
            this.lblDepositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositos.Location = new System.Drawing.Point(228, 75);
            this.lblDepositos.Name = "lblDepositos";
            this.lblDepositos.Size = new System.Drawing.Size(78, 16);
            this.lblDepositos.TabIndex = 1;
            this.lblDepositos.Text = "Depositos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta de Ahorros";
            // 
            // rbDepositos
            // 
            this.rbDepositos.AutoSize = true;
            this.rbDepositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositos.Location = new System.Drawing.Point(213, 278);
            this.rbDepositos.Name = "rbDepositos";
            this.rbDepositos.Size = new System.Drawing.Size(96, 20);
            this.rbDepositos.TabIndex = 15;
            this.rbDepositos.TabStop = true;
            this.rbDepositos.Text = "Depositos";
            this.rbDepositos.UseVisualStyleBackColor = true;
           
            this.rbDepositos.Click += new System.EventHandler(this.rbDepositos_Click);
            // 
            // rbRetiros
            // 
            this.rbRetiros.AutoSize = true;
            this.rbRetiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetiros.Location = new System.Drawing.Point(32, 278);
            this.rbRetiros.Name = "rbRetiros";
            this.rbRetiros.Size = new System.Drawing.Size(75, 20);
            this.rbRetiros.TabIndex = 14;
            this.rbRetiros.TabStop = true;
            this.rbRetiros.Text = "Retiros";
            this.rbRetiros.UseVisualStyleBackColor = true;
           
            this.rbRetiros.Click += new System.EventHandler(this.rbRetiros_Click);
            // 
            // Cuenta_de_Ahorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Cuenta_de_Ahorros";
            this.Text = "Cuenta_de_Ahorros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRetiros;
        private System.Windows.Forms.Label lblDepositos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ListBox ltbDepositos;
        private System.Windows.Forms.ListBox ltbRetiros;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.RadioButton rbDepositos;
        private System.Windows.Forms.RadioButton rbRetiros;
    }
}