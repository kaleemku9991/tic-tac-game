using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;




        public void ChangeColor(PictureBox pic)
        {
            if (a % 2 == 0)
            {
                a += 1;
                pic.BackColor = Color.Black;
            }
            else
            {
                a += 1;
                pic.BackColor = Color.Red;
            }

            checkWin();
            
        }

        bool a1, a2, a3, a4, a5, a6, a7, a8, a9;

        private void p1_Click(object sender, EventArgs e)
        {

            if (a1 == false )
            {
                ChangeColor(p1);
                a1 = true;
            }
            else
            {
                ChangeColor(p1);
                a1 = false;
            }
        }

        private void p2_Click(object sender, EventArgs e)
        {
            if (a2 == false)
            {
                ChangeColor(p2);
                a2 = true;
            }
            else
            {
                ChangeColor(p2);
                a2 = false;
            }

        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (a3 == false)
            {
                ChangeColor(p3);
                a3 = true;
            }
            else
            {
                ChangeColor(p3);
                a3 = false;
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {
            if (a4 == false)
            {
                ChangeColor(p4);
                a4 = true;
            }
            else
            {
                ChangeColor(p4);
                a4 = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void p5_Click(object sender, EventArgs e)
        {
            if (a5 == false)
            {
                ChangeColor(p5);
                a5 = true;
            }
            else
            {
                ChangeColor(p5);
                a5 = false;
            }
        }

        private void p6_Click(object sender, EventArgs e)
        {
            if (a6 == false)
            {
                ChangeColor(p6);
                a6 = true;
            }
            else
            {
                ChangeColor(p6);
                a6 = false;
            }

        }

        private void p7_Click(object sender, EventArgs e)
        {
            if (a7 == false)
            {
                ChangeColor(p7);
                a7 = true;
            }
            else
            {
                ChangeColor(p7);
                a7 = false;
            }
        }

        private void p8_Click(object sender, EventArgs e)
        {
            if (a8 == false)
            {
                ChangeColor(p8);
                a8 = true;
            }
            else
            {
                ChangeColor(p8);
                a8 = false;
            }

        }

        private void p9_Click(object sender, EventArgs e)
        {
            if (a9 == false)
            {
                ChangeColor(p9);
                a9 = true;
            }
            else
            {
                ChangeColor(p9);
                a9 = false;
            }

        }



        public void checkWin()
        {

            if (p1.BackColor == p2.BackColor && p2.BackColor == p3.BackColor && p1.BackColor != SystemColors.Control)
            {

                WhoWon();



            }
            else if (p2.BackColor==p5.BackColor &&p2.BackColor==p8.BackColor&&p2.BackColor!=SystemColors.Control)
            {
                WhoWon();
            }

            else if (p1.BackColor == p4.BackColor && p4.BackColor == p7.BackColor && p1.BackColor != SystemColors.Control)
            {

                WhoWon();



            }

            else if (a == 9)
            {

                MessageBox.Show("Tie");
                d = d + 1;
                label6.Text = d.ToString();
                Nextgame();
                a = 0;
            }


            else if (p7.BackColor == p8.BackColor && p7.BackColor == p9.BackColor && p7.BackColor != SystemColors.Control)
            {
                WhoWon();

            }
            else if (p4.BackColor==p5.BackColor && p6.BackColor==p4.BackColor && p4.BackColor !=SystemColors.Control)
            {
                WhoWon();
            }



            else if (p7.BackColor == p5.BackColor && p7.BackColor == p3.BackColor && p7.BackColor != SystemColors.Control)
            {
                WhoWon();

            }



            else if (p9.BackColor == p5.BackColor && p9.BackColor == p1.BackColor && p9.BackColor != SystemColors.Control)
            {
                WhoWon();
            }
            else if (p9.BackColor == p6.BackColor && p9.BackColor == p3.BackColor && p9.BackColor != SystemColors.Control)
            {
                WhoWon();
            }

        }

        public void WhoWon()
        {
            if (a % 2 != 0)
            {
                MessageBox.Show("Hurryyy! Player 1 Won");


                b = b + 1;
                label3.Text = b.ToString();
                Nextgame();
                a = 0;
            }
            else if (a%2==0)
            {
                MessageBox.Show("Hurryyy! Player 2 won");

                c = c + 1;
                label4.Text = c.ToString();
                Nextgame();
                a = 0;
            }

            


        }



        public void Nextgame()
        {
            MessageBox.Show("RESTART GAME");
            
            p1.BackColor = SystemColors.Control;
            p2.BackColor = SystemColors.Control;
            p3.BackColor = SystemColors.Control;
            p4.BackColor = SystemColors.Control;
            p5.BackColor = SystemColors.Control;
            p6.BackColor = SystemColors.Control;
            p7.BackColor = SystemColors.Control;
            p8.BackColor = SystemColors.Control;
            p9.BackColor = SystemColors.Control;


        }
        
        
    }
}
