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

        private void button3_Click(object sender, EventArgs e)
        {
            E3 e3 = new E3();
            e3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            E4 e4 = new E4();
            e4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            E2 e2 = new E2();
            e2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            E1 e1 = new E1();
            e1.Show();
        }
    }
}
