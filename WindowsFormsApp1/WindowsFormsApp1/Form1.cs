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
        ///Label Label31_Click;
        ///TextBox txt;
        private int _x;
        private int _y;

        public Form1()
        {
            InitializeComponent();
        }

        ///Label31_Click = new Label();
        ///labeltest.Text = "test";

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //int var2 = textBox36.Text;
            /*this.textBox36.Text = var2.ToString();
            */
            timer1.Start();
            timer1.Interval = 1000;
            
            MessageBox.Show("Démarage de la simulation du restaurant");

            this.textBox36.Visible = true;
            Console.WriteLine(textBox36);
            Console.Read();

            //int test = int.Parse(var2);

            /* List<TextBox> listTextBox = this.Controls.OfType<TextBox>().ToList();
             MessageBox.Show(listTextBox[listTextBox.Count - 1].Text);*/

            //System.Console.WriteLine(test);
            //Console.Read();
            //int intID = int.Parse(Var2.ToString());
            //int numVal = Int32.Parse(Var2);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string valeur_simulation = textBox36.Text;
            int int_simulation = Convert.ToInt32(valeur_simulation);
            timer1.Interval = int_simulation;

            MessageBox.Show("Démarage de la simulation du restaurant en mode simulation");
            


        }

        int sec = 0;
        int min = 0;
        int hour = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            textBox1.Text = "" + sec + " sec";
            textBox2.Text = "" + min + " min";
            textBox3.Text = "" + hour + " hour";
            if (sec > 59)
            {
                sec = 0;
                min++;
                textBox2.Text = "" + min;
            }

            else if (min > 59)
            {
                min = 0;
                hour++;
                textBox3.Text = "" + hour;
            }

            else if (hour == 1)
            {
                ///timer1.Stop();
                ///MessageBox.Show("Time is over");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {
            //this.textBox36.Text = var2.ToString();

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox36_TextChanged(object sender, EventArgs e)
        {
           /* int i;
            i = int.Parse(textBox36.Text);*/
        }

    }
}
