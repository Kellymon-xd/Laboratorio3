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
            this.btnRetiros = new System.Windows.Forms.RadioButton();
            this.btnDepositos = new System.Windows.Forms.RadioButton();
            this.lblTransacciones = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblTransacciones);
            this.panel1.Controls.Add(this.btnDepositos);
            this.panel1.Controls.Add(this.btnRetiros);
            this.panel1.Location = new System.Drawing.Point(101, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 90);
            this.panel1.TabIndex = 0;
            // 
            // btnRetiros
            // 
            this.btnRetiros.AutoSize = true;
            this.btnRetiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiros.Location = new System.Drawing.Point(321, 45);
            this.btnRetiros.Name = "btnRetiros";
            this.btnRetiros.Size = new System.Drawing.Size(75, 20);
            this.btnRetiros.TabIndex = 0;
            this.btnRetiros.TabStop = true;
            this.btnRetiros.Text = "Retiros";
            this.btnRetiros.UseVisualStyleBackColor = true;
            // 
            // btnDepositos
            // 
            this.btnDepositos.AutoSize = true;
            this.btnDepositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositos.Location = new System.Drawing.Point(29, 45);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(96, 20);
            this.btnDepositos.TabIndex = 1;
            this.btnDepositos.TabStop = true;
            this.btnDepositos.Text = "Depositos";
            this.btnDepositos.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.RadioButton btnDepositos;
        private System.Windows.Forms.RadioButton btnRetiros;
    }
}