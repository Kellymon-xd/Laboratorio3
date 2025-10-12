using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            SoundPlayer player = new SoundPlayer(@"img/Super Mario 3D World 8 Bit Remix.wav");
            player.PlayLooping();
            InitializeComponent();
        }

        private void enunciado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmE1());
        }

        private void enunciado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmE2());
        }

        private void enunciado3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmE3());
        }

        private void enunciado4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmE4());
        }

        private void AbrirFormulario(Form formHijo)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();

            formHijo.MdiParent = this;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.StartPosition = FormStartPosition.Manual;
            formHijo.Show();

            int menuHeight = 0;
            foreach (Control c in this.Controls)
            {
                if (c is MenuStrip)
                {
                    menuHeight = c.Height;
                    break;
                }
            }

            int widthDiff = this.Width - this.ClientSize.Width;
            int heightDiff = this.Height - this.ClientSize.Height;

            this.Width = formHijo.Width + widthDiff;
            this.Height = formHijo.Height + heightDiff + menuHeight;

            formHijo.Dock = DockStyle.Fill;
        }
    }
}
