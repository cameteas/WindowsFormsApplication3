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
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);

            //
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
