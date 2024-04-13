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
    public partial class SnackUserControl : UserControl
    {
        public SnackUserControl()
        {
            InitializeComponent();
        }

        private void orderchickenbox_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void orderonionrings_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void ordershrimps_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }
    }
}
