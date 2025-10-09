namespace Laboratorio3
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enunciado1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enunciado1ToolStripMenuItem,
            this.enunciado2ToolStripMenuItem,
            this.enunciado3ToolStripMenuItem,
            this.enunciado4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(841, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enunciado1ToolStripMenuItem
            // 
            this.enunciado1ToolStripMenuItem.Name = "enunciado1ToolStripMenuItem";
            this.enunciado1ToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.enunciado1ToolStripMenuItem.Text = "Enunciado 1";
            this.enunciado1ToolStripMenuItem.Click += new System.EventHandler(this.enunciado1ToolStripMenuItem_Click);
            // 
            // enunciado2ToolStripMenuItem
            // 
            this.enunciado2ToolStripMenuItem.Name = "enunciado2ToolStripMenuItem";
            this.enunciado2ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.enunciado2ToolStripMenuItem.Text = "Enunciado 2";
            this.enunciado2ToolStripMenuItem.Click += new System.EventHandler(this.enunciado2ToolStripMenuItem_Click);
            // 
            // enunciado3ToolStripMenuItem
            // 
            this.enunciado3ToolStripMenuItem.Name = "enunciado3ToolStripMenuItem";
            this.enunciado3ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.enunciado3ToolStripMenuItem.Text = "Enunciado 3";
            this.enunciado3ToolStripMenuItem.Click += new System.EventHandler(this.enunciado3ToolStripMenuItem_Click);
            // 
            // enunciado4ToolStripMenuItem
            // 
            this.enunciado4ToolStripMenuItem.Name = "enunciado4ToolStripMenuItem";
            this.enunciado4ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.enunciado4ToolStripMenuItem.Text = "Enunciado 4";
            this.enunciado4ToolStripMenuItem.Click += new System.EventHandler(this.enunciado4ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(841, 504);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enunciado1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado4ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

