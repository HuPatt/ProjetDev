using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            pictureBox1.Location = new Point(x + 10, y);

            if (x > 750)
                timer1.Stop();
        }
    }
}