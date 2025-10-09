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
            E1 e1 = new E1();
            e1.MdiParent = this;
            e1.WindowState = FormWindowState.Maximized;
            e1.Show();
        }

        private void enunciado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E2 e2 = new E2();
            e2.MdiParent = this;
            e2.WindowState = FormWindowState.Maximized;
            e2.Show();
        }

        private void enunciado3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E3 e3 = new E3();
            e3.MdiParent = this;
            e3.WindowState = FormWindowState.Maximized;
            e3.Show();
        }

        private void enunciado4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E4 e4 = new E4();
            e4.MdiParent = this;
            e4.WindowState = FormWindowState.Maximized;
            e4.Show();
        }
    }
}
