using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            int agent = 12;
            Random rnd = new Random();
            int pitrnd;
            int wumpusrnd;
            int goldrnd;
            do
            {
                pitrnd = rnd.Next(0, 16);
            }
            while (pitrnd == 12);
            printPit(pitrnd);
            do
            {
                wumpusrnd = rnd.Next(0, 16);
            }
            while (wumpusrnd == pitrnd || wumpusrnd == 12);
            printWumpus(wumpusrnd);
            do
            {
                goldrnd = rnd.Next(0, 16);
            }
            while (goldrnd == pitrnd || goldrnd == wumpusrnd || wumpusrnd == 12);
            printGold(goldrnd);

            while(agent != goldrnd)
            {
                agent = moveRight(agent);
                Thread.Sleep(2000);
            }
        }

        int moveDown(int agentPosition)
        {
            prevAgent(agentPosition);
            agentPosition = agentPosition + 4;
            moveAgent(agentPosition);
            return agentPosition;
        }

        int moveUp(int agentPosition)
        {
            prevAgent(agentPosition);
            agentPosition = agentPosition - 4;
            moveAgent(agentPosition);
            return agentPosition;
        }

        int moveLeft(int agentPosition)
        {
            prevAgent(agentPosition);
            agentPosition = agentPosition - 1;
            moveAgent(agentPosition);
            return agentPosition;
        }

        int moveRight(int agentPosition)
        {
            prevAgent(agentPosition);
            agentPosition = agentPosition + 1;
            moveAgent(agentPosition);
            return agentPosition;
        }

        void prevAgent(int agentprev)
        {
            switch (agentprev)
            {
                case 0:
                    pb0.Image = pb0.BackgroundImage;
                    break;
                case 1:
                    pb1.Image = pb1.BackgroundImage;
                    break;
                case 2:
                    pb2.Image = pb2.BackgroundImage;
                    break;
                case 3:
                    pb3.Image = pb3.BackgroundImage;
                    break;
                case 4:
                    pb4.Image = pb4.BackgroundImage;
                    break;
                case 5:
                    pb5.Image = pb5.BackgroundImage;
                    break;
                case 6:
                    pb6.Image = pb6.BackgroundImage;
                    break;
                case 7:
                    pb7.Image = pb7.BackgroundImage;
                    break;
                case 8:
                    pb8.Image = pb8.BackgroundImage;
                    break;
                case 9:
                    pb9.Image = pb9.BackgroundImage;
                    break;
                case 10:
                    pb10.Image = pb10.BackgroundImage;
                    break;
                case 11:
                    pb11.Image = pb11.BackgroundImage;
                    break;
                case 12:
                    pb12.Image = pb12.BackgroundImage;
                    break;
                case 13:
                    pb13.Image = pb13.BackgroundImage;
                    break;
                case 14:
                    pb14.Image = pb14.BackgroundImage;
                    break;
                case 15:
                    pb15.Image = pb15.BackgroundImage;
                    break;
                default:
                    break;
            }
        }

        void moveAgent(int agentMove)
        {
            switch (agentMove)
            {
                case 0:
                    if(pb0.Image == null)
                    {
                        pb0.Image = Properties.Resources.agent;
                    }
                    else if(pb0.Image!=null)
                    {
                        pb0.BackgroundImage = pb0.Image;
                        pb0.Image = Properties.Resources.agent;
                    }
                    break;
                case 1:
                    if (pb1.Image == null)
                    {
                        pb1.Image = Properties.Resources.agent;
                    }
                    else if (pb1.Image != null)
                    {
                        pb1.BackgroundImage = pb1.Image;
                        pb1.Image = Properties.Resources.agent;
                    }
                    break;
                case 2:
                    if (pb2.Image == null)
                    {
                        pb2.Image = Properties.Resources.agent;
                    }
                    else if (pb2.Image != null)
                    {
                        pb2.BackgroundImage = pb2.Image;
                        pb2.Image = Properties.Resources.agent;
                    }
                    break;
                case 3:
                    if (pb3.Image == null)
                    {
                        pb3.Image = Properties.Resources.agent;
                    }
                    else if (pb3.Image != null)
                    {
                        pb3.BackgroundImage = pb3.Image;
                        pb3.Image = Properties.Resources.agent;
                    }
                    break;
                case 4:
                    if (pb4.Image == null)
                    {
                        pb4.Image = Properties.Resources.agent;
                    }
                    else if (pb4.Image != null)
                    {
                        pb4.BackgroundImage = pb4.Image;
                        pb4.Image = Properties.Resources.agent;
                    }
                    break;
                case 5:
                    if (pb5.Image == null)
                    {
                        pb5.Image = Properties.Resources.agent;
                    }
                    else if (pb5.Image != null)
                    {
                        pb5.BackgroundImage = pb5.Image;
                        pb5.Image = Properties.Resources.agent;
                    }
                    break;
                case 6:
                    if (pb6.Image == null)
                    {
                        pb6.Image = Properties.Resources.agent;
                    }
                    else if (pb6.Image != null)
                    {
                        pb6.BackgroundImage = pb6.Image;
                        pb6.Image = Properties.Resources.agent;
                    }
                    break;
                case 7:
                    if (pb7.Image == null)
                    {
                        pb7.Image = Properties.Resources.agent;
                    }
                    else if (pb7.Image != null)
                    {
                        pb7.BackgroundImage = pb7.Image;
                        pb7.Image = Properties.Resources.agent;
                    }
                    break;
                case 8:
                    if (pb8.Image == null)
                    {
                        pb8.Image = Properties.Resources.agent;
                    }
                    else if (pb8.Image != null)
                    {
                        pb8.BackgroundImage = pb8.Image;
                        pb8.Image = Properties.Resources.agent;
                    }
                    break;
                case 9:
                    if (pb9.Image == null)
                    {
                        pb9.Image = Properties.Resources.agent;
                    }
                    else if (pb9.Image != null)
                    {
                        pb9.BackgroundImage = pb9.Image;
                        pb9.Image = Properties.Resources.agent;
                    }
                    break;
                case 10:
                    if (pb10.Image == null)
                    {
                        pb10.Image = Properties.Resources.agent;
                    }
                    else if (pb10.Image != null)
                    {
                        pb10.BackgroundImage = pb10.Image;
                        pb10.Image = Properties.Resources.agent;
                    }
                    break;
                case 11:
                    if (pb11.Image == null)
                    {
                        pb11.Image = Properties.Resources.agent;
                    }
                    else if (pb11.Image != null)
                    {
                        pb11.BackgroundImage = pb11.Image;
                        pb11.Image = Properties.Resources.agent;
                    }
                    break;
                case 12:
                    if (pb12.Image == null)
                    {
                        pb12.Image = Properties.Resources.agent;
                    }
                    else if (pb12.Image != null)
                    {
                        pb12.BackgroundImage = pb12.Image;
                        pb12.Image = Properties.Resources.agent;
                    }
                    break;
                case 13:
                    if (pb13.Image == null)
                    {
                        pb13.Image = Properties.Resources.agent;
                    }
                    else if (pb13.Image != null)
                    {
                        pb13.BackgroundImage = pb13.Image;
                        pb13.Image = Properties.Resources.agent;
                    }
                    break;
                case 14:
                    if (pb14.Image == null)
                    {
                        pb14.Image = Properties.Resources.agent;
                    }
                    else if (pb14.Image != null)
                    {
                        pb14.BackgroundImage = pb14.Image;
                        pb14.Image = Properties.Resources.agent;
                    }
                    break;
                case 15:
                    if (pb15.Image == null)
                    {
                        pb15.Image = Properties.Resources.agent;
                    }
                    else if (pb15.Image != null)
                    {
                        pb15.BackgroundImage = pb15.Image;
                        pb15.Image = Properties.Resources.agent;
                    }
                    break;
                default:
                    break;
            }
        }

        void printPit(int num)
        {
            switch (num)
            {
                case 0:
                    pb0.Image = Properties.Resources.pit;
                    extensions(0, 'p');
                    break;
                case 1:
                    pb1.Image = Properties.Resources.pit;
                    extensions(1, 'p');
                    break;
                case 2:
                    pb2.Image = Properties.Resources.pit;
                    extensions(2, 'p');
                    break;
                case 3:
                    pb3.Image = Properties.Resources.pit;
                    extensions(3, 'p');
                    break;
                case 4:
                    pb4.Image = Properties.Resources.pit;
                    extensions(4, 'p');
                    break;
                case 5:
                    pb5.Image = Properties.Resources.pit;
                    extensions(5, 'p');
                    break;
                case 6:
                    pb6.Image = Properties.Resources.pit;
                    extensions(6, 'p');
                    break;
                case 7:
                    pb7.Image = Properties.Resources.pit;
                    extensions(7, 'p');
                    break;
                case 8:
                    pb8.Image = Properties.Resources.pit;
                    extensions(8, 'p');
                    break;
                case 9:
                    pb9.Image = Properties.Resources.pit;
                    extensions(9, 'p');
                    break;
                case 10:
                    pb10.Image = Properties.Resources.pit;
                    extensions(10, 'p');
                    break;
                case 11:
                    pb11.Image = Properties.Resources.pit;
                    extensions(11, 'p');
                    break;
                case 13:
                    pb13.Image = Properties.Resources.pit;
                    extensions(13, 'p');
                    break;
                case 14:
                    pb14.Image = Properties.Resources.pit;
                    extensions(14, 'p');
                    break;
                case 15:
                    pb15.Image = Properties.Resources.pit;
                    extensions(15, 'p');
                    break;
                default:
                    pb10.Image = Properties.Resources.pit;
                    extensions(10, 'p');
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
                    pb10.Image = Properties.Resources.gold;
                    break;
                case 11:
                    pb11.Image = Properties.Resources.gold;
                    break;
                case 13:
                    pb13.Image = Properties.Resources.gold;
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
                    extensions(0, 'w');
                    break;
                case 1:
                    pb1.Image = Properties.Resources.wumpus;
                    extensions(1, 'w');
                    break;
                case 2:
                    pb2.Image = Properties.Resources.wumpus;
                    extensions(2, 'w');
                    break;
                case 3:
                    pb3.Image = Properties.Resources.wumpus;
                    extensions(3, 'w');
                    break;
                case 4:
                    pb4.Image = Properties.Resources.wumpus;
                    extensions(4, 'w');
                    break;
                case 5:
                    pb5.Image = Properties.Resources.wumpus;
                    extensions(5, 'w');
                    break;
                case 6:
                    pb6.Image = Properties.Resources.wumpus;
                    extensions(6, 'w');
                    break;
                case 7:
                    pb7.Image = Properties.Resources.wumpus;
                    extensions(7, 'w');
                    break;
                case 8:
                    pb8.Image = Properties.Resources.wumpus;
                    extensions(8, 'w');
                    break;
                case 9:
                    pb9.Image = Properties.Resources.wumpus;
                    extensions(9, 'w');
                    break;
                case 10:
                    pb10.Image = Properties.Resources.wumpus;
                    extensions(10, 'w');
                    break;
                case 11:
                    pb11.Image = Properties.Resources.wumpus;
                    extensions(11, 'w');
                    break;
                case 13:
                    pb13.Image = Properties.Resources.wumpus;
                    extensions(13, 'w');
                    break;
                case 14:
                    pb14.Image = Properties.Resources.wumpus;
                    extensions(14, 'w');
                    break;
                case 15:
                    pb15.Image = Properties.Resources.wumpus;
                    extensions(15, 'w');
                    break;
                default:
                    pb6.Image = Properties.Resources.wumpus;
                    extensions(6, 'w');
                    break;
            }
        }

        void extensions(int num, char c)
        {
            switch (num)
            {
                case 0:
                    if (c == 'w')
                    {
                        if (pb1.Image == null)
                        { pb1.Image = Properties.Resources.strench; }
                        if (pb4.Image == null)
                        { pb4.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb1.Image == null)
                        { pb1.Image = Properties.Resources.breze; }
                        if (pb4.Image == null)
                        { pb4.Image = Properties.Resources.breze; }
                    }
                    break;

                case 3:
                    if (c == 'w')
                    {
                        if (pb2.Image == null)
                        { pb2.Image = Properties.Resources.strench; }
                        if (pb7.Image == null)
                        { pb7.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb2.Image == null)
                        { pb2.Image = Properties.Resources.breze; }
                        if (pb7.Image == null)
                        { pb7.Image = Properties.Resources.breze; }
                    }
                    break;

                case 15:
                    if (c == 'w')
                    {
                        if (pb11.Image == null)
                        { pb11.Image = Properties.Resources.strench; }
                        if (pb14.Image == null)
                        { pb14.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb11.Image == null)
                        { pb11.Image = Properties.Resources.breze; }
                        if (pb14.Image == null)
                        { pb14.Image = Properties.Resources.breze; }
                    }
                    break;

                case 1:
                    if (c == 'w')
                    {
                        if (pb0.Image == null)
                        { pb0.Image = Properties.Resources.strench; }
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.strench; }
                        if (pb2.Image == null)
                        { pb2.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb0.Image == null)
                        { pb0.Image = Properties.Resources.breze; }
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.breze; }
                        if (pb2.Image == null)
                        { pb2.Image = Properties.Resources.breze; }
                    }
                    break;

                case 2:
                    if (c == 'w')
                    {
                        if (pb1.Image == null)
                        { pb1.Image = Properties.Resources.strench; }
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.strench; }
                        if (pb3.Image == null)
                        { pb3.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb1.Image == null)
                        { pb1.Image = Properties.Resources.breze; }
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.breze; }
                        if (pb3.Image == null)
                        { pb3.Image = Properties.Resources.breze; }
                    }
                    break;

                case 4:
                    if (c == 'w')
                    {
                        if (pb0.Image == null)
                        { pb0.Image = Properties.Resources.strench; }
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.strench; }
                        if (pb8.Image == null)
                        { pb8.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb0.Image == null)
                        { pb0.Image = Properties.Resources.breze; }
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.breze; }
                        if (pb8.Image == null)
                        { pb8.Image = Properties.Resources.breze; }
                    }
                    break;

                case 7:
                    if (c == 'w')
                    {
                        if (pb3.Image == null)
                        { pb3.Image = Properties.Resources.strench; }
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.strench; }
                        if (pb11.Image == null)
                        { pb11.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb3.Image == null)
                        { pb3.Image = Properties.Resources.breze; }
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.breze; }
                        if (pb11.Image == null)
                        { pb11.Image = Properties.Resources.breze; }
                    }
                    break;

                case 8:
                    if (c == 'w')
                    {
                        if (pb4.Image == null)
                        { pb4.Image = Properties.Resources.strench; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.strench; }
                        if (pb12.Image == null)
                        { pb12.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb4.Image == null)
                        { pb4.Image = Properties.Resources.breze; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.breze; }
                        if (pb12.Image == null)
                        { pb12.Image = Properties.Resources.breze; }
                    }
                    break;

                case 11:
                    if (c == 'w')
                    {
                        if (pb7.Image == null)
                        { pb7.Image = Properties.Resources.strench; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.strench; }
                        if (pb15.Image == null)
                        { pb15.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb7.Image == null)
                        { pb7.Image = Properties.Resources.breze; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.breze; }
                        if (pb15.Image == null)
                        { pb15.Image = Properties.Resources.breze; }
                    }
                    break;

                case 13:
                    if (c == 'w')
                    {
                        if (pb12.Image == null)
                        { pb12.Image = Properties.Resources.strench; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.strench; }
                        if (pb14.Image == null)
                        { pb14.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb12.Image == null)
                        { pb12.Image = Properties.Resources.breze; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.breze; }
                        if (pb14.Image == null)
                        { pb14.Image = Properties.Resources.breze; }
                    }
                    break;

                case 14:
                    if (c == 'w')
                    {
                        if (pb13.Image == null)
                        { pb13.Image = Properties.Resources.strench; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.strench; }
                        if (pb15.Image == null)
                        { pb15.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb13.Image == null)
                        { pb13.Image = Properties.Resources.breze; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.breze; }
                        if (pb15.Image == null)
                        { pb15.Image = Properties.Resources.breze; }
                    }
                    break;

                case 5:
                    if (c == 'w')
                    {
                        if (pb1.Image == null)
                        { pb1.Image = Properties.Resources.strench; }
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.strench; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.strench; }
                        if (pb4.Image == null)
                        { pb4.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb1.Image == null)
                        { pb1.Image = Properties.Resources.breze; }
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.breze; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.breze; }
                        if (pb4.Image == null)
                        { pb4.Image = Properties.Resources.breze; }
                    }
                    break;

                case 6:
                    if (c == 'w')
                    {
                        if (pb2.Image == null)
                        { pb2.Image = Properties.Resources.strench; }
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.strench; }
                        if (pb7.Image == null)
                        { pb7.Image = Properties.Resources.strench; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb2.Image == null)
                        { pb2.Image = Properties.Resources.breze; }
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.breze; }
                        if (pb7.Image == null)
                        { pb7.Image = Properties.Resources.breze; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.breze; }
                    }
                    break;

                case 9:
                    if (c == 'w')
                    {
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.strench; }
                        if (pb8.Image == null)
                        { pb8.Image = Properties.Resources.strench; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.strench; }
                        if (pb13.Image == null)
                        { pb13.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb5.Image == null)
                        { pb5.Image = Properties.Resources.breze; }
                        if (pb8.Image == null)
                        { pb8.Image = Properties.Resources.breze; }
                        if (pb10.Image == null)
                        { pb10.Image = Properties.Resources.breze; }
                        if (pb13.Image == null)
                        { pb13.Image = Properties.Resources.breze; }
                    }
                    break;

                case 10:
                    if (c == 'w')
                    {
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.strench; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.strench; }
                        if (pb11.Image == null)
                        { pb11.Image = Properties.Resources.strench; }
                        if (pb14.Image == null)
                        { pb14.Image = Properties.Resources.strench; }
                    }
                    else if (c == 'p')
                    {
                        if (pb6.Image == null)
                        { pb6.Image = Properties.Resources.breze; }
                        if (pb9.Image == null)
                        { pb9.Image = Properties.Resources.breze; }
                        if (pb11.Image == null)
                        { pb11.Image = Properties.Resources.breze; }
                        if (pb14.Image == null)
                        { pb14.Image = Properties.Resources.breze; }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
