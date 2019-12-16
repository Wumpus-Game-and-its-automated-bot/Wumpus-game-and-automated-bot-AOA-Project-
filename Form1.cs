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

        int[] pieces = { 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z', 'z' };
        int pitrnd;
        int wumpusrnd;
        int goldrnd;
        int agent = 12;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            do
            {
                pitrnd = rnd.Next(0, 16);
            }
            while (pitrnd == agent);
            pieces[pitrnd] = 'p';
            extensions(pitrnd, 'p');
            do
            {
                wumpusrnd = rnd.Next(0, 16);
            }
            while (wumpusrnd == pitrnd || wumpusrnd == agent);
            pieces[wumpusrnd] = 'w';
            extensions(wumpusrnd, 'w');
            do
            {
                goldrnd = rnd.Next(0, 16);
            }
            while (goldrnd == pitrnd || goldrnd == wumpusrnd || goldrnd == agent);
            pieces[goldrnd] = 'g';

            enableButtons(agent);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            showPic(0);
            checkPic(0);
            enableButtons(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            showPic(1);
            checkPic(1);
            enableButtons(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            showPic(2);
            checkPic(2);
            enableButtons(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            showPic(3);
            checkPic(3);
            enableButtons(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            showPic(4);
            checkPic(4);
            enableButtons(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            showPic(5);
            checkPic(5);
            enableButtons(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            showPic(6);
            checkPic(6);
            enableButtons(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            showPic(7);
            checkPic(7);
            enableButtons(7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            showPic(8);
            checkPic(8);
            enableButtons(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            showPic(9);
            checkPic(9);
            enableButtons(9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            showPic(10);
            checkPic(10);
            enableButtons(10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            showPic(11);
            checkPic(11);
            enableButtons(11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            showPic(12);
            checkPic(12);
            enableButtons(12);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            showPic(13);
            checkPic(13);
            enableButtons(13);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            showPic(14);
            checkPic(14);
            enableButtons(14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            showPic(15);
            checkPic(15);
            enableButtons(15);
        }

        void checkPic(int value)
        {
            if(pieces[value] == 'w')
            {
                MessageBox.Show("You lost! A giant Wumpus ate you!");
                this.Close();
            }
            else if(pieces[value] == 'p')
            {
                MessageBox.Show("You lost! You fell in deep pit!");
                this.Close();
            }
            else if(pieces[value] == 'g')
            {
                MessageBox.Show("Gold Found! You won!");
                this.Close();
            }
        }

        void showPic(int value)
        {
            switch(value)
            {
                case 0:
                    switch(pieces[value])
                    {
                        case 'w':
                            btn0.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn0.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn0.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn0.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn0.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn1.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn1.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn1.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn1.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn1.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn2.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn2.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn2.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn2.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn2.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn3.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn3.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn3.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn3.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn3.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn4.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn4.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn4.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn4.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn4.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn5.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn5.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn5.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn5.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn5.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn6.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn6.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn6.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn6.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn6.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn7.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn7.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn7.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn7.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn7.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 8:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn8.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn8.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn8.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn8.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn8.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 9:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn9.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn9.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn9.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn9.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn9.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 10:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn10.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn10.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn10.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn10.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn10.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 11:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn11.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn11.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn11.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn11.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn11.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 12:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn12.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn12.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn12.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn12.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn12.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 13:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn13.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn13.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn13.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn13.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn13.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 14:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn14.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn14.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn14.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn14.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn14.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
                    break;
                case 15:
                    switch (pieces[value])
                    {
                        case 'w':
                            btn15.Image = Properties.Resources.wumpus;
                            break;
                        case 'p':
                            btn15.Image = Properties.Resources.pit;
                            break;
                        case 'g':
                            btn15.Image = Properties.Resources.gold;
                            break;
                        case 's':
                            btn15.Image = Properties.Resources.strench;
                            break;
                        case 'b':
                            btn15.Image = Properties.Resources.breze;
                            break;
                        default:
                            break;
                    }
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
                        if (pieces[1] == 'z')
                        { pieces[1] = 's'; }
                        if (pieces[4] == 'z')
                        { pieces[4] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[1] == 'z')
                        { pieces[1] = 'b'; }
                        if (pieces[4] == 'z')
                        { pieces[4] = 'b'; }
                    }
                    break;

                case 3:
                    if (c == 'w')
                    {
                        if (pieces[2] == 'z')
                        { pieces[2] = 's'; }
                        if (pieces[7] == 'z')
                        { pieces[7] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[2] == 'z')
                        { pieces[2] = 'b'; }
                        if (pieces[7] == 'z')
                        { pieces[7] = 'b'; }
                    }
                    break;

                case 15:
                    if (c == 'w')
                    {
                        if (pieces[11] == 'z')
                        { pieces[11] = 's'; }
                        if (pieces[14] == 'z')
                        { pieces[14] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[11] == 'z')
                        { pieces[11] = 'b'; }
                        if (pieces[14] == 'z')
                        { pieces[14] = 'b'; }
                    }
                    break;

                case 1:
                    if (c == 'w')
                    {
                        if (pieces[0] == 'z')
                        { pieces[0] = 's'; }
                        if (pieces[5] == 'z')
                        { pieces[5] = 's'; }
                        if (pieces[2] == 'z')
                        { pieces[2] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[0] == 'z')
                        { pieces[0] = 'b'; }
                        if (pieces[5] == 'z')
                        { pieces[5] = 'b'; }
                        if (pieces[2] == 'z')
                        { pieces[2] = 'b'; }
                    }
                    break;

                case 2:
                    if (c == 'w')
                    {
                        if (pieces[1] == 'z')
                        { pieces[1] = 's'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 's'; }
                        if (pieces[3] == 'z')
                        { pieces[3] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[1] == 'z')
                        { pieces[1] = 'b'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 'b'; }
                        if (pieces[3] == 'z')
                        { pieces[3] = 'b'; }
                    }
                    break;

                case 4:
                    if (c == 'w')
                    {
                        if (pieces[0] == 'z')
                        { pieces[0] = 's'; }
                        if (pieces[5] == 'z')
                        { pieces[5] = 's'; }
                        if (pieces[8] == 'z')
                        { pieces[8] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[0] == 'z')
                        { pieces[0] = 'b'; }
                        if (pieces[5] == 'z')
                        { pieces[5] = 'b'; }
                        if (pieces[8] == 'z')
                        { pieces[8] = 'b'; }
                    }
                    break;

                case 7:
                    if (c == 'w')
                    {
                        if (pieces[3] == 'z')
                        { pieces[3] = 's'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 's'; }
                        if (pieces[11] == 'z')
                        { pieces[11] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[3] == 'z')
                        { pieces[3] = 'b'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 'b'; }
                        if (pieces[11] == 'z')
                        { pieces[11] = 'b'; }
                    }
                    break;

                case 8:
                    if (c == 'w')
                    {
                        if (pieces[4] == 'z')
                        { pieces[4] = 's'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 's'; }
                        if (pieces[12] == 'z')
                        { pieces[12] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[4] == 'z')
                        { pieces[4] = 'b'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 'b'; }
                        if (pieces[12] == 'z')
                        { pieces[12] = 'b'; }
                    }
                    break;

                case 11:
                    if (c == 'w')
                    {
                        if (pieces[7] == 'z')
                        { pieces[7] = 's'; }
                        if (pieces[10] == 'z')
                        { pieces[10] = 's'; }
                        if (pieces[15] == 'z')
                        { pieces[15] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[7] == 'z')
                        { pieces[7] = 'b'; }
                        if (pieces[10] == 'z')
                        { pieces[10] = 'b'; }
                        if (pieces[15] == 'z')
                        { pieces[15] = 'b'; }
                    }
                    break;

                case 13:
                    if (c == 'w')
                    {
                        if (pieces[12] == 'z')
                        { pieces[12] = 's'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 's'; }
                        if (pieces[14] == 'z')
                        { pieces[14] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[12] == 'z')
                        { pieces[12] = 'b'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 'b'; }
                        if (pieces[14] == 'z')
                        { pieces[14] = 'b'; }
                    }
                    break;

                case 14:
                    if (c == 'w')
                    {
                        if (pieces[13] == 'z')
                        { pieces[13] = 's'; }
                        if (pieces[10] == 'z')
                        { pieces[10] = 's'; }
                        if (pieces[15] == 'z')
                        { pieces[15] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[13] == 'z')
                        { pieces[13] = 'b'; }
                        if (pieces[10] == 'z')
                        { pieces[10] = 'b'; }
                        if (pieces[15] == 'z')
                        { pieces[15] = 'b'; }
                    }
                    break;

                case 5:
                    if (c == 'w')
                    {
                        if (pieces[1] == 'z')
                        { pieces[1] = 's'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 's'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 's'; }
                        if (pieces[4] == 'z')
                        { pieces[4] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[1] == 'z')
                        { pieces[1] = 'b'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 'b'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 'b'; }
                        if (pieces[4] == 'z')
                        { pieces[4] = 'b'; }
                    }
                    break;

                case 6:
                    if (c == 'w')
                    {
                        if (pieces[2] == 'z')
                        { pieces[2] = 's'; }
                        if (pieces[5] == 'z')
                        { pieces[5] = 's'; }
                        if (pieces[7] == 'z')
                        { pieces[7] = 's'; }
                        if (pieces[10] == 'z')
                        { pieces[10] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[2] == 'z')
                        { pieces[2] = 'b'; }
                        if (pieces[5] == 'z')
                        { pieces[5] = 'b'; }
                        if (pieces[7] == 'z')
                        { pieces[7] = 'b'; }
                        if (pieces[10] == 'z')
                        { pieces[10] = 'b'; }
                    }
                    break;

                case 9:
                    if (c == 'w')
                    {
                        if (pieces[10] == 'z')
                        { pieces[10] = 's'; }
                        if (pieces[5] == 'z')
                        { pieces[5] = 's'; }
                        if (pieces[8] == 'z')
                        { pieces[8] = 's'; }
                        if (pieces[13] == 'z')
                        { pieces[13] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[5] == 'z')
                        { pieces[5] = 'b'; }
                        if (pieces[8] == 'z')
                        { pieces[8] = 'b'; }
                        if (pieces[10] == 'z')
                        { pieces[10] = 'b'; }
                        if (pieces[13] == 'z')
                        { pieces[13] = 'b'; }
                    }
                    break;

                case 10:
                    if (c == 'w')
                    {
                        if (pieces[11] == 'z')
                        { pieces[11] = 's'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 's'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 's'; }
                        if (pieces[14] == 'z')
                        { pieces[14] = 's'; }
                    }
                    else if (c == 'p')
                    {
                        if (pieces[11] == 'z')
                        { pieces[11] = 'b'; }
                        if (pieces[6] == 'z')
                        { pieces[6] = 'b'; }
                        if (pieces[9] == 'z')
                        { pieces[9] = 'b'; }
                        if (pieces[14] == 'z')
                        { pieces[14] = 'b'; }
                    }
                    break;
                default:
                    break;
            }
        }


        void enableButtons(int temp)
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn14.Enabled = false;
            btn15.Enabled = false;
            switch (temp)
            {
                case 0:
                    btn1.Enabled = true;
                    btn4.Enabled = true;
                    break;
                case 1:
                    btn0.Enabled = true;
                    btn5.Enabled = true;
                    btn2.Enabled = true;
                    break;
                case 2:
                    btn1.Enabled = true;
                    btn6.Enabled = true;
                    btn3.Enabled = true;
                    break;
                case 3:
                    btn2.Enabled = true;
                    btn7.Enabled = true;
                    break;
                case 4:
                    btn0.Enabled = true;
                    btn5.Enabled = true;
                    btn8.Enabled = true;
                    break;
                case 5:
                    btn1.Enabled = true;
                    btn4.Enabled = true;
                    btn9.Enabled = true;
                    btn6.Enabled = true;
                    break;
                case 6:
                    btn2.Enabled = true;
                    btn5.Enabled = true;
                    btn10.Enabled = true;
                    btn7.Enabled = true;
                    break;
                case 7:
                    btn3.Enabled = true;
                    btn6.Enabled = true;
                    btn11.Enabled = true;
                    break;
                case 8:
                    btn4.Enabled = true;
                    btn9.Enabled = true;
                    btn12.Enabled = true;
                    break;
                case 9:
                    btn5.Enabled = true;
                    btn8.Enabled = true;
                    btn13.Enabled = true;
                    btn10.Enabled = true;
                    break;
                case 10:
                    btn14.Enabled = true;
                    btn9.Enabled = true;
                    btn6.Enabled = true;
                    btn11.Enabled = true;
                    break;
                case 11:
                    btn7.Enabled = true;
                    btn10.Enabled = true;
                    btn15.Enabled = true;
                    break;
                case 12:
                    btn8.Enabled = true;
                    btn13.Enabled = true;
                    break;
                case 13:
                    btn12.Enabled = true;
                    btn9.Enabled = true;
                    btn14.Enabled = true;
                    break;
                case 14:
                    btn13.Enabled = true;
                    btn10.Enabled = true;
                    btn15.Enabled = true;
                    break;
                case 15:
                    btn11.Enabled = true;
                    btn14.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
