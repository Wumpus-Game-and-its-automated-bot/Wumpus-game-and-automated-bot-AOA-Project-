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
            pb12.Image = Properties.Resources.agent;
            Random rnd = new Random();
            int pitrnd = rnd.Next(0, 16);
            int wumpusrnd;
            int goldrnd;
            printPit(pitrnd);
            do
            {
                wumpusrnd = rnd.Next(0, 16);
            }
            while (wumpusrnd == pitrnd);
            printWumpus(wumpusrnd);
            do
            {
                goldrnd = rnd.Next(0, 16);
            }
            while (goldrnd == pitrnd || goldrnd == wumpusrnd);
            printGold(goldrnd);
        }


        void printPit(int num)
        {
            switch (num)
            {
                case 0:
                    pb0.Image = Properties.Resources.pit;
                    break;
                case 1:
                    pb1.Image = Properties.Resources.pit;
                    break;
                case 2:
                    pb2.Image = Properties.Resources.pit;
                    break;
                case 3:
                    pb3.Image = Properties.Resources.pit;
                    break;
                case 4:
                    pb4.Image = Properties.Resources.pit;
                    break;
                case 5:
                    pb5.Image = Properties.Resources.pit;
                    break;
                case 6:
                    pb6.Image = Properties.Resources.pit;
                    break;
                case 7:
                    pb7.Image = Properties.Resources.pit;
                    break;
                case 8:
                    pb8.Image = Properties.Resources.pit;
                    break;
                case 9:
                    pb9.Image = Properties.Resources.pit;
                    break;
                case 10:
                    pb13.Image = Properties.Resources.pit;
                    break;
                case 11:
                    pb9.Image = Properties.Resources.pit;
                    break;
                case 13:
                    pb1.Image = Properties.Resources.pit;
                    break;
                case 14:
                    pb14.Image = Properties.Resources.pit;
                    break;
                case 15:
                    pb15.Image = Properties.Resources.pit;
                    break;
                default:
                    pb10.Image = Properties.Resources.pit;
                    break;
            }

        }

        void printGold(int num)
        {
            switch (num)
            {
                case 0:
                    pb0.Image = Properties.Resources.gold;
                    break;
                case 1:
                    pb1.Image = Properties.Resources.gold;
                    break;
                case 2:
                    pb2.Image = Properties.Resources.gold;
                    break;
                case 3:
                    pb3.Image = Properties.Resources.gold;
                    break;
                case 4:
                    pb4.Image = Properties.Resources.gold;
                    break;
                case 5:
                    pb5.Image = Properties.Resources.gold;
                    break;
                case 6:
                    pb6.Image = Properties.Resources.gold;
                    break;
                case 7:
                    pb7.Image = Properties.Resources.gold;
                    break;
                case 8:
                    pb8.Image = Properties.Resources.gold;
                    break;
                case 9:
                    pb9.Image = Properties.Resources.gold;
                    break;
                case 10:
                    pb13.Image = Properties.Resources.gold;
                    break;
                case 11:
                    pb9.Image = Properties.Resources.gold;
                    break;
                case 13:
                    pb1.Image = Properties.Resources.gold;
                    break;
                case 14:
                    pb14.Image = Properties.Resources.gold;
                    break;
                case 15:
                    pb15.Image = Properties.Resources.gold;
                    break;
                default:
                    pb2.Image = Properties.Resources.gold;
                    break;
            }

        }

        void printWumpus(int num)
        {
            switch (num)
            {
                case 0:
                    pb0.Image = Properties.Resources.wumpus;
                    break;
                case 1:
                    pb1.Image = Properties.Resources.wumpus;
                    break;
                case 2:
                    pb2.Image = Properties.Resources.wumpus;
                    break;
                case 3:
                    pb3.Image = Properties.Resources.wumpus;
                    break;
                case 4:
                    pb4.Image = Properties.Resources.wumpus;
                    break;
                case 5:
                    pb5.Image = Properties.Resources.wumpus;
                    break;
                case 6:
                    pb6.Image = Properties.Resources.wumpus;
                    break;
                case 7:
                    pb7.Image = Properties.Resources.wumpus;
                    break;
                case 8:
                    pb8.Image = Properties.Resources.wumpus;
                    break;
                case 9:
                    pb9.Image = Properties.Resources.wumpus;
                    break;
                case 10:
                    pb13.Image = Properties.Resources.wumpus;
                    break;
                case 11:
                    pb9.Image = Properties.Resources.wumpus;
                    break;
                case 13:
                    pb1.Image = Properties.Resources.wumpus;
                    break;
                case 14:
                    pb14.Image = Properties.Resources.wumpus;
                    break;
                case 15:
                    pb15.Image = Properties.Resources.wumpus;
                    break;
                default:
                    pb6.Image = Properties.Resources.wumpus;
                    break;
            }

        }
    }
}
