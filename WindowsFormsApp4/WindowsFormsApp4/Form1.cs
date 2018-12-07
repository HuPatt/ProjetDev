using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }
        private int _x;
        private int _y;
        private Position _objPosition;

        public Form1()
        {
            InitializeComponent();
            _x = 50;
            _y = 50;
            _objPosition = Position.Down;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (_objPosition == Position.Right)
            {
                _x += 8;
            }
            else if(_objPosition == Position.Left)
            {
                _x -= 8;
            }
            else if (_objPosition == Position.Up)
            {
                _y -= 8;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 8;
            }


            Invalidate();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ///e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 100, 100);
            e.Graphics.DrawImage(new Bitmap("personnage.png"), _x, _y, 50, 50);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }
    }
}

