using Project_Fast_Food_Application.Repository;
using Project_Fast_Food_Application.Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Fast_Food_Application
{
    public partial class CategoryUserControl : UserControl
    {
        
        public CategoryUserControl()
        {
            InitializeComponent();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            string  ctname= txtcategoryname.Text;
            string connectionString = "Server=NITRO-5;database=FastFood;Integrated Security=true;TrustServerCertificate=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string command = $"insert into Category Values ('{ctname}')";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            sqlcommand.ExecuteNonQuery();
            MessageBox.Show("ADDED");
            sqlConnection.Close();
            //FastFoodDbContext dbfastfoodcontetx = new FastFoodDbContext();
            //var category = new Category()

            //{
            //    Name = txtcategoryname.Text
            //};
            //dbfastfoodcontetx.Categories.Add(category);
            //dbfastfoodcontetx.SaveChanges();
            //MessageBox.Show("Category was add.");

        }
        //public static void Categorylist()
        //{
            
        //}

        private void dqvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FastFoodDbContext dbfastfoodcontetx = new FastFoodDbContext();

            //dqvcategory.DataSource = dbfastfoodcontetx.Categories.ToList();

        }
    }
}
