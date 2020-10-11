using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansör
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "1";
            label5.BackColor = Color.Violet;
            label6.BackColor = Color.Violet;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text= "0";
            label3.BackColor = Color.Violet;
            label4.BackColor = Color.Violet;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(label8.Text=="1")
            {
                pictureBox1.Top -= 5;
                if(pictureBox1.Location.Y==73)
                {
                    timer1.Stop();
                    button1.Enabled = false;
                    button2.Enabled = true;
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Red;

                }
            }
           if(label8.Text== "0")
            {
                pictureBox1.Top += 5;
                if(pictureBox1.Location.Y==273)
                {
                    timer1.Stop();
                    button2.Enabled = false;
                    button1.Enabled = true;
                    label5.BackColor = Color.Red;
                    label6.BackColor = Color.Red;
                   
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
