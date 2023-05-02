using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LogForm
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = StudentsDb; Integrated Security= True;"))
            {

                connection.Open();
                string cmd = "Select * from Staff";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table; ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
