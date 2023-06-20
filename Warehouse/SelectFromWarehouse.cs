using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static LogForm.Program;
using static ColumnDeterminer.WarehouseList;
using static LogForm.SpeechRecognizer;
using static LogForm.InnerFunctions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LogForm
{
   
    public partial class SelectFromWarehouse : Form
    {
        private List<Workforce> _workforce;

        public SelectFromWarehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                connection.Open();
                string cmd = "Select Name, WholesalePrice from Products";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }


        private async void btnShow_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                await connection.OpenAsync();

                SqlCommand cmd = connection.CreateCommand();

                if (chOverall.Checked)
                {
                    cmd.CommandText = "select Products.Name,Types.Name as 'Type', Products.AdditionalNotes, Sum(Warehouse.Amount) as 'Overall', Warehouse.Measure from Products \r\nInner Join Warehouse on Warehouse.ProductId=Product.Id\r\nLeft Join Types on Product.ProductType=Type.Id\r\nGroup by Product.Name, Warehouse.Measure, Type.Name, Product.AdditionalNotes";

                }

                else
                {
                    cmd.CommandText = "select Products.Name, Types.Name as 'Type', Products.AdditionalNotes, Warehouse.Amount,Warehouse.Measure, Warehouse.ArrivedDate,Warehouse.ExpiredDate,Warehouse.Code from Products  \r\nInner Join Warehouse on Warehouse.ProductId=Products.Id\r\nLeft Join Types on Products.ProductType=Types.Id";

                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                await Task.Run(() => adapter.Fill(table)); // Fill the data table asynchronously
                dataGridView1.DataSource = table;

                ColumnsNameConfigurator(dataGridView1);
                ColorWarnings(chOverall.Checked);
            }
        }




        private void chOverall_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
                    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void вычестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeductFromWarehouse form4 = new DeductFromWarehouse(dataGridView1.SelectedCells[0].Value.ToString());
            form4.Show();
        }

        private void ColorWarnings(bool yesOrNo)
        {
            if (yesOrNo == false)
            {
                DateTime currentTime = DateTime.Now;
                DateTime expireTime = DateTime.Now;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    expireTime = (DateTime)dataGridView1.Rows[i].Cells[expireDateIndex].Value;

                    if ((expireTime - currentTime).Days <= 10)
                    {
                        dataGridView1.Rows[i].Cells[expireDateIndex].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                    }

                }
            }

        }

        private async void btnShowExpired_Click_1(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select Products.Name, Types.Name as 'Type', Products.AdditionalNotes, Warehouse.Amount,Warehouse.Measure, Warehouse.ArrivedDate,Warehouse.ExpiredDate,Warehouse.Code from Products Inner Join Warehouse on Warehouse.ProductId=Products.Id Left Join Types on Products.ProductType=Types.Id Where ExpiredDate<=GETDATE()";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Все нормально!");
                }
               
            }
        }



        private async void btnSend_Click_1(object sender, EventArgs e)
        {
            int index = cmbStaff.SelectedItem.ToString().IndexOf(' ');
            string name = cmbStaff.SelectedItem.ToString().Substring(0, index);

            var employeeNumber = _workforce.FirstOrDefault(x => x.Name == name).Number;

            await SaveToFileAsync(pathToWarehouseList, this.dataGridView1);

            Process.Start("msedge.exe", $"https://wa.me/{PhoneNumberToSendAsLink(ref employeeNumber)}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
            SelectProducts selectProducts = new SelectProducts("");
            selectProducts.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            AddToWarehouse addToWarehouse=  new AddToWarehouse();
            addToWarehouse.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!chOverall.Checked) dataGridView1.SelectedCells[0].ContextMenuStrip = cntxtCells;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToWarehouse warehouse = new AddToWarehouse();
            warehouse.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeductFromWarehouse form4 = new DeductFromWarehouse(dataGridView1.SelectedCells[0].Value.ToString());
            form4.Show();
        }


        private void изменитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddToWarehouse warehouse = new AddToWarehouse(ColumnValues(dataGridView1, Columns.Product), ColumnValues(dataGridView1,Columns.Amount), ColumnValues(dataGridView1,Columns.Measure),ColumnValues(dataGridView1,Columns.ArrivedDate),ColumnValues(dataGridView1,Columns.Code));
            warehouse.ShowDialog();
        }

        private void вычестиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeductFromWarehouse form4 = new DeductFromWarehouse(ColumnValues(dataGridView1,Columns.Code));
            form4.ShowDialog ();
        }

        private async void SelectFromWarehouse_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Georgia", 11F);

            try
            {
                SpeechRecognizerOn();
                Default_SpeechRecognized(this, default);
            }
            catch (Exception exc)
            {
                File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

            }


            _workforce = await GetWorkforceAsync();
            _workforce.ForEach(x => { cmbStaff.Items.Add(x.ToString()); });

            cmbStaff.SelectedIndex = 0;

            btnShow_Click(this, default);

        }
        public async Task<List<Workforce>> GetWorkforceAsync()
        {
            List<Workforce> workforce = new List<Workforce>();

            using (var connection = new SqlConnection(sqlConnection))
            {
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Name, Surname, Position, Number FROM WarehouseStaff";

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Workforce employee = new Workforce()
                            {
                                Name = reader["Name"].ToString().Trim(),
                                Surname = reader["Surname"].ToString().Trim(),
                                Position = reader["Position"].ToString().Trim(),
                                Number = reader["Number"].ToString().Trim()
                            };

                            workforce.Add(employee);
                        }
                    }
                }
            }

            return workforce;
        }

        


        private void SelectFromWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
        }

        private void lblProductList_Click(object sender, EventArgs e)
        {
            SelectProducts selectProducts = new SelectProducts();
            this.Hide();
            selectProducts.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(this, default);
        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            EmployeesList staff = new EmployeesList();
            staff.Show();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            using (var connection = new SqlConnection(sqlConnection))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"Select * from Warehouse Where Code Like @code";
                cmd.Parameters.AddWithValue("@code", "%" + code + "%");
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter1.Fill(table);
                dataGridView1.DataSource = table;



            }
        }
    }
    public class Workforce
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname} {this.Position}";
        }


    }
}

