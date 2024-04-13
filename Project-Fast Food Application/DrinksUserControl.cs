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
    public partial class DrinksUserControl : UserControl
    {
        public DrinksUserControl()
        {
            InitializeComponent();
        }

        private void orderlemonade_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void ordersparkling_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void orderwater_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void ordercappy_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void orderbonaqua_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void ordermilk_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }
    }
}
