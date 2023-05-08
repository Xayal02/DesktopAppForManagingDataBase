using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static ColumnDeterminer.Staff;
using static LogForm.Program;

namespace LogForm
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12F);

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
            dataGridView1.SelectedCells[0].ContextMenuStrip = contextMenuStrip1;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(ColumnValues(dataGridView1,Columns.Id),ColumnValues(dataGridView1, Columns.Name), ColumnValues(dataGridView1, Columns.Surname), ColumnValues(dataGridView1, Columns.Position), ColumnValues(dataGridView1, Columns.Number));

            addEmployee.ShowDialog();

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены что хотите удалить работника из списка?";
            string caption = "Предупреждение";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();
                try
                {
                    SqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "Delete From Staff Where id = @id";
                    cmd.Parameters.AddWithValue("@id", ColumnValues(dataGridView1, Columns.Id));

                    cmd.ExecuteNonQuery();

                    Staff_Load(this, default);

                }
                catch (Exception exc) { File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n'); }
                
                finally { connection.Close(); }
            }
        }
    }
}
