using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Fast_Food_Application
{
    public partial class FriesUserControl : UserControl
    {
        public FriesUserControl()
        {
            InitializeComponent();
        }

        private void FriesUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ordermfree_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }
    }
}
