namespace Laboratorio3
{
    partial class frmE3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmE3));
            this.dgvVentasF = new System.Windows.Forms.DataGridView();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.txtVentasRealizadas = new System.Windows.Forms.TextBox();
            this.lblCentasF = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasF
            // 
            this.dgvVentasF.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentasF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentasF.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentasF.Location = new System.Drawing.Point(41, 120);
            this.dgvVentasF.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentasF.Name = "dgvVentasF";
            this.dgvVentasF.Size = new System.Drawing.Size(364, 319);
            this.dgvVentasF.TabIndex = 0;
            // 
            // dgvVentas
            // 
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.Location = new System.Drawing.Point(428, 120);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(364, 319);
            this.dgvVentas.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(38, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Ventas realizadas duante el año";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEmpezar.Location = new System.Drawing.Point(692, 38);
            this.btnEmpezar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(100, 28);
            this.btnEmpezar.TabIndex = 3;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // txtVentasRealizadas
            // 
            this.txtVentasRealizadas.BackColor = System.Drawing.Color.FloralWhite;
            this.txtVentasRealizadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVentasRealizadas.Enabled = false;
            this.txtVentasRealizadas.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentasRealizadas.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtVentasRealizadas.Location = new System.Drawing.Point(333, 41);
            this.txtVentasRealizadas.Margin = new System.Windows.Forms.Padding(4);
            this.txtVentasRealizadas.Name = "txtVentasRealizadas";
            this.txtVentasRealizadas.ReadOnly = true;
            this.txtVentasRealizadas.Size = new System.Drawing.Size(133, 25);
            this.txtVentasRealizadas.TabIndex = 4;
            // 
            // lblCentasF
            // 
            this.lblCentasF.AutoSize = true;
            this.lblCentasF.Location = new System.Drawing.Point(142, 100);
            this.lblCentasF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCentasF.Name = "lblCentasF";
            this.lblCentasF.Size = new System.Drawing.Size(152, 16);
            this.lblCentasF.TabIndex = 5;
            this.lblCentasF.Text = "Ventas entre $75-$215";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(584, 100);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(50, 16);
            this.lblVentas.TabIndex = 6;
            this.lblVentas.Text = "Ventas";
            // 
            // frmE3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(843, 469);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblCentasF);
            this.Controls.Add(this.txtVentasRealizadas);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dgvVentasF);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmE3";
            this.Text = "Ventas realizadas en el año";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasF;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.TextBox txtVentasRealizadas;
        private System.Windows.Forms.Label lblCentasF;
        private System.Windows.Forms.Label lblVentas;
    }
}