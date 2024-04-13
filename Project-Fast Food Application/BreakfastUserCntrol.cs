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
    public partial class BreakfastUserCntrol : UserControl
    {
        public BreakfastUserCntrol()
        {
            InitializeComponent();
        }

        private void ordermuffin_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }

        private void orderbigbreakfast_Click(object sender, EventArgs e)
        {

            PaymentUserControl paymentUserControl = new PaymentUserControl();
            paymentUserControl.Show();
            this.Hide();
        }
    }
}
