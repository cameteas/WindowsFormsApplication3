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
            
        }//

        private void Play_MouseEnter(object sender, EventArgs e)
        {
            Play.ForeColor = Color.LimeGreen;
        }
        private void play_MouseLeave(object sender, EventArgs e)
        {
            Play.ForeColor = Color.Black;
        }

        private void Play_MouseEnter_1(object sender, EventArgs e)
        {
            //button fade in
            for (int i = 0; i < 254; i++)
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
            int a = 0;
            string b = "";
            for (int i = 254; i > 5; i--)
            {
                a = a + 2;
                this.Refresh();
                b = Convert.ToString(a);
                numcount.Text = b;
                Play.ForeColor = Color.FromArgb(255, 0, i, 0);
                Play.BackColor = Color.FromArgb(255, 0, a, 0);
                Thread.Sleep(1);
                
            }
        }
    }
}
