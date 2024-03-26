
using System.Data;
using System.Data.SqlClient;
namespace StudentAdd
{
    public partial class Form1 : Form
    {
        SqlConnection SqlConnection;
        SqlCommand SqlCommand;
        SqlDataAdapter SqlDataAdapter;

        void DataGetAll()
        {
            SqlConnection = new SqlConnection("server=.;Initial Catalog=mekteb; Integrated Security=SSPI");
            SqlConnection.Open();
            SqlDataAdapter = new SqlDataAdapter("Select*from student", SqlConnection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter.Fill(dataTable);
            studentview.DataSource = dataTable;
            SqlConnection.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string query = "insert into student (surname,name) VALUES (@surname,@name)";
            SqlCommand = new SqlCommand(query, SqlConnection);
            SqlConnection.Open();
            SqlCommand.Parameters.AddWithValue("@name", textBox3.Text);
            SqlCommand.Parameters.AddWithValue("@surname", textBox1.Text);
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            DataGetAll();

        }

        private void studentview_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            DataGetAll();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "Delete from student where id=@id";
            SqlCommand = new SqlCommand(query, SqlConnection);
            SqlConnection.Open();
            SqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textBox2.Text));
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            DataGetAll();

        }

        private void studentview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = studentview.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = studentview.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = studentview.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
