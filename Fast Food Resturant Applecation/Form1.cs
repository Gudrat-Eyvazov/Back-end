using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Resturant_Applecation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height=button1.Height;
            sidepanel.Top=button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            mySecondCustomControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            _3CustomControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            _4CustomControl1.BringToFront();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
            _5CustomControl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button7.Height;
            sidepanel.Top = button7.Top;
            _6CustomControl1.BringToFront();
        }

        private void _3CustomControl2_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _6CustomControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
