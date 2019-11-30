using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wumpus_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn00.Image = Properties.Resources.agent;
        }

        private void btn00_Click(object sender, EventArgs e)
        {

        }

        private void btn30_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Properties.Resources.strgd;
        }

        private void btn01_Click(object sender, EventArgs e)
        {

        }

        private void btn02_Click(object sender, EventArgs e)
        {

        }
    }
}
