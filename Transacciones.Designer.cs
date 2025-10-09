namespace Laboratorio3
{
    partial class Transacciones
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
            this.lblTransacciones = new System.Windows.Forms.Label();
            this.rbDepositos = new System.Windows.Forms.RadioButton();
            this.rbRetiros = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.lblTransacciones);
            this.panel1.Controls.Add(this.rbDepositos);
            this.panel1.Controls.Add(this.rbRetiros);
            this.panel1.Location = new System.Drawing.Point(101, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 101);
            this.panel1.TabIndex = 0;
            // 
            // lblTransacciones
            // 
            this.lblTransacciones.AutoSize = true;
            this.lblTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransacciones.Location = new System.Drawing.Point(3, 10);
            this.lblTransacciones.Name = "lblTransacciones";
            this.lblTransacciones.Size = new System.Drawing.Size(110, 16);
            this.lblTransacciones.TabIndex = 2;
            this.lblTransacciones.Text = "Transacciones";
            // 
            // rbDepositos
            // 
            this.rbDepositos.AutoSize = true;
            this.rbDepositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositos.Location = new System.Drawing.Point(29, 45);
            this.rbDepositos.Name = "rbDepositos";
            this.rbDepositos.Size = new System.Drawing.Size(96, 20);
            this.rbDepositos.TabIndex = 1;
            this.rbDepositos.TabStop = true;
            this.rbDepositos.Text = "Depositos";
            this.rbDepositos.UseVisualStyleBackColor = true;
            this.rbDepositos.CheckedChanged += new System.EventHandler(this.rbDepositos_CheckedChanged);
            // 
            // rbRetiros
            // 
            this.rbRetiros.AutoSize = true;
            this.rbRetiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetiros.Location = new System.Drawing.Point(321, 45);
            this.rbRetiros.Name = "rbRetiros";
            this.rbRetiros.Size = new System.Drawing.Size(75, 20);
            this.rbRetiros.TabIndex = 0;
            this.rbRetiros.TabStop = true;
            this.rbRetiros.Text = "Retiros";
            this.rbRetiros.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(181, 75);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 254);
            this.Controls.Add(this.panel1);
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTransacciones;
        private System.Windows.Forms.RadioButton rbDepositos;
        private System.Windows.Forms.RadioButton rbRetiros;
        private System.Windows.Forms.Button btnConfirmar;
    }
}