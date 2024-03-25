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
    public partial class _4CustomControl : UserControl
    {
        public _4CustomControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _5CustomControl _5CustomControl = new _5CustomControl();
            _5CustomControl.Show();
            this.Hide();    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
