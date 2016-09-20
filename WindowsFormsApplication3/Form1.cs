using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare variables, fonts and other tools that I will need
            string[] num = new string[] { "3", "2", "1" };

            Font drawFont = new Font("Comic Sans MS", 16, FontStyle.Bold);
            Font C = new Font("Comic Sans MS", 60, FontStyle.Regular);
            Font CRA = new Font("Comic Sans MS", 8, FontStyle.Regular);

            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
            SolidBrush ramsBrush = new SolidBrush(Color.Red);
            SolidBrush CBrush = new SolidBrush(Color.Black);
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);

            Pen drawPen = new Pen(Color.Red, 10);
            Pen pacPen = new Pen(Color.Yellow, 10);

            Graphics formGraphics = this.CreateGraphics();

            //hiding the button and title after button press
            Play.Width = 0;
            Title.Dispose();
            BackColor = Color.Black;

            //loop for drawing the numbers before the logo
            for (int i = 0; i<3; i++)
            {
                formGraphics.DrawString(num[i], drawFont, drawBrush, 130, 100);
                Thread.Sleep(1000);
                formGraphics.Clear(Color.Black);
            }

            //drawing the go command
            formGraphics.DrawString("Go", drawFont, drawBrush, 120, 100);
            Thread.Sleep(1000);

            //drawing tehh logo
            formGraphics.DrawEllipse(drawPen, 40, 25, 200, 100);
            formGraphics.FillEllipse(ramsBrush, 40, 25, 200, 100);
            formGraphics.DrawString("C", C, CBrush, 90, 10);
            formGraphics.DrawString("rams", drawFont, drawBrush, 118, 56);
            formGraphics.TranslateTransform(250, 130);
            formGraphics.RotateTransform(270);
            formGraphics.DrawString("Central Rams Arcade", CRA, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            //playing the logo sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.waka);
            player.Play();
            Thread.Sleep(3700);

            //getting rid of the logo
            formGraphics.Clear(Color.Black);
            formGraphics.Dispose();

            //declaring values for mouth open/closed animation, mValue stands for mouth value, dontknowbool is working as a honorary bool that really isn't a bool because I know how they work I just don't know how to use them in c#
            int mValue = 300;
            int xValue =-40;
            int yValue = 30;
            int dontknowbool = 0;
            int pacrot = 30;

            //play sound
            player.Play();

            //loop to draw pacman
            for (int p = 0; p < 1000; p++)
            {
                Graphics pacman = this.CreateGraphics();

                //method to tell if mValue should increment by + or -
                if (mValue == 270)
                {
                    dontknowbool = 1;
                }
                if (mValue == 340)
                {
                    dontknowbool = 0;
                }
                if (dontknowbool == 1)
                {
                    mValue++;
                }
                if (dontknowbool == 0)
                {
                    mValue--;
                }

                //animating movement
                if(p < 100)
                {
                    xValue = xValue + 1;
                } 
                if(p >= 100 && p < 200)
                {
                    yValue++;
                    pacrot = 120;
                }
                if(p >= 200 && p < 300)
                {
                    xValue++;
                    pacrot = 30;
                }
                if(p >= 300 && p < 400)
                {
                    yValue--;
                    pacrot = 300;
                }
                if(p >= 400 )
                {
                    xValue--;
                    pacrot = 220;
 
                }
                //drawing pacman
                pacman.DrawPie(pacPen, xValue, yValue, 50, 50, pacrot, mValue);
                pacman.FillPie(pacBrush, xValue, yValue, 50, 50, pacrot, mValue);
                Thread.Sleep(3);
                Refresh();
                pacman.Dispose();
                

            }

            //endgame
            Graphics endgame = this.CreateGraphics();
            endgame.DrawString("You Win?", drawFont, drawBrush, 90, 90);
            endgame.DrawString("But Where was the space? and why didn't I get to play?", CRA, drawBrush, 1, 140);
            Thread.Sleep(10000);
        }

        private void Play_MouseEnter_1(object sender, EventArgs e)
        {
            //button fade in
            for (int i = 0; i < 254; i = i + 8)
            {
                this.Refresh();
                Play.ForeColor = Color.FromArgb(255, 0, i, 0);
                Play.BackColor = Color.FromArgb(255, 0, 255 - i, 0);
                Thread.Sleep(1);
            }
        }

        private void Play_MouseLeave_1(object sender, EventArgs e)
        {
            //button fade out
            int a =0;
            string b = "";
            for (int i = 246; i >2; i = i-8)
            {
                a = a + 8;
                this.Refresh();
                b = Convert.ToString(a);
                Play.ForeColor = Color.FromArgb(255, 0, i, 0);
                Play.BackColor = Color.FromArgb(255, 0, a, 0);
                Thread.Sleep(1);
                
            }
        }

        private void numcount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
