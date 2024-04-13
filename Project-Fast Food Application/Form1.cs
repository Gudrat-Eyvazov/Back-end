using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Project_Fast_Food_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kecid.Height = home.Height;
            kecid.Top = home.Top;
            homeUserControl1.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void emeliyyatlar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            kecid.Height = home.Height;
            kecid.Top = home.Top;
            homeUserControl1.BringToFront();
        }

        private void breakfast_Click(object sender, EventArgs e)
        {
            kecid.Height = breakfast.Height;
            kecid.Top = breakfast.Top;
            breakfastUserCntrol1.BringToFront();
        }

        private void burger_Click(object sender, EventArgs e)
        {
            kecid.Height = burger.Height;
            kecid.Top = burger.Top;
            burgersUserControl1.BringToFront();
        }

        private void snack_Click(object sender, EventArgs e)
        {
            kecid.Height = snack.Height;
            kecid.Top = snack.Top;
            snackUserControl1.BringToFront();

        }

        private void fries_Click(object sender, EventArgs e)
        {
            kecid.Height = fries.Height;
            kecid.Top = fries.Top;
            friesUserControl1.BringToFront();
        }

        private void drink_Click(object sender, EventArgs e)
        {

            kecid.Height = drink.Height;
            kecid.Top = drink.Top;
            drinksUserControl1.BringToFront();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            kecid.Height = btnpayment.Height;
            kecid.Top = btnpayment.Top;
            paymentUserControl1.BringToFront();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            kecid.Height = btnCategory.Height;
            kecid.Top = btnCategory.Top;
            categoryUserControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // string connectionString= ConfigurationManager.ConnectionStrings["dbmekteb"];
            //string connectionString = "Server=NITRO-5;database=mekteb;Integrated Security =true";

            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();
            //string command = "insert into  Product";

            //SqlCommand sqlCommand = new SqlCommand(command, sqlConnection); 

            


        }
    }
}
