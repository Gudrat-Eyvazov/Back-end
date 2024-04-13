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
    public partial class BurgersUserControl : UserControl
    {
        public BurgersUserControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ordermaestro_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void orderbigmuck_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void orderfilet_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }
    }
}
