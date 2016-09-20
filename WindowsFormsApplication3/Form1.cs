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
            //declare variables
            string[] num = new string[] { "3", "2", "1" };
            Font drawFont = new Font("Comic Sans MS", 16, FontStyle.Bold);
            Font C = new Font("Comic Sans MS", 60, FontStyle.Regular);
            Font CMA = new Font("Comic Sans MS", 8, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
            SolidBrush ramsBrush = new SolidBrush(Color.Red);
            SolidBrush CBrush = new SolidBrush(Color.Black);
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);
            Pen drawPen = new Pen(Color.Red, 10);
            Pen pacPen = new Pen(Color.Yellow, 10);
            Graphics formGraphics = this.CreateGraphics();

            Play.Width = 0;
            Title.Dispose();
            BackColor = Color.Black;
            for (int i = 0; i<3; i++)
            {
                formGraphics.DrawString(num[i], drawFont, drawBrush, 130, 100);
                Thread.Sleep(1000);
                formGraphics.Clear(Color.Black);
            }
            formGraphics.DrawString("Go", drawFont, drawBrush, 120, 100);
            Thread.Sleep(1000);
            formGraphics.DrawEllipse(drawPen, 40, 25, 200, 100);
            formGraphics.FillEllipse(ramsBrush, 40, 25, 200, 100);
            formGraphics.DrawString("C", C, CBrush, 90, 10);
            formGraphics.DrawString("rams", drawFont, drawBrush, 118, 56);
            formGraphics.TranslateTransform(250, 130);
            formGraphics.RotateTransform(270);
            formGraphics.DrawString("Central Rams Arcade", CMA, drawBrush, new Rectangle());
            formGraphics.ResetTransform();
            SoundPlayer player = new SoundPlayer(Properties.Resources.waka);
            player.Play();
            Thread.Sleep(6000);
            formGraphics.Clear(Color.Black);
            formGraphics.Dispose();
            for (int p = 0; p < 100; p++)
            {
                int q = 300;
                if (q == 300)
                {
                    q = q + 60;
                }
                else if (q == 360)
                {
                    q = q - 60;
                }
                Graphics pacman = this.CreateGraphics();
                pacman.DrawPie(pacPen, 20, 20, 50, 50, 30, q);
                pacman.FillPie(pacBrush, 20, 20, 50, 50, 30, q);
                Thread.Sleep(2000);
                pacman.Clear(Color.Black);

                //pacman.Clear(Color.Black)

            }


        }

        private void Play_MouseEnter_1(object sender, EventArgs e)
        {
            //button fade i
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
    }
}
