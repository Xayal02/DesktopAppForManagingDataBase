using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ColumnDeterminer.WarehouseList;
using static LogForm.SpeechRecognizer;
using static LogForm.Program;

namespace LogForm
{
   
    public partial class SelectFromWarehouse : Form
    {
        
        string number;

        public SelectFromWarehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                connection.Open();
                string cmd = "Select Name, WholesalePrice from Product";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }

       
        private void btnShow_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {

                connection.Open();
                string cmd;

                if (chOverall.Checked)
                {
                    cmd = "select Product.Name,Type.Name as 'Type', Product.AdditionalNotes, Sum(Warehouse.Amount) as 'Overall', Warehouse.Measure from Product \r\nInner Join Warehouse on Warehouse.ProductId=Product.Id\r\nLeft Join Type on Product.ProductType=Type.Id\r\nGroup by Product.Name, Warehouse.Measure, Type.Name, Product.AdditionalNotes";

                }

                else
                {
                    cmd = "select Product.Name, Type.Name as 'Type', Product.AdditionalNotes, Warehouse.Amount,Warehouse.Measure, Warehouse.ArrivedDate,Warehouse.ExpiredDate,Warehouse.Code from Product  \r\nInner Join Warehouse on Warehouse.ProductId=Product.Id\r\nLeft Join Type on Product.ProductType=Type.Id";

                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                ColorWarnings(chOverall.Checked);

            }
        }

      

        private void chOverall_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
                    

        }



        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        { 
            Application.Exit();
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

        private void btnShowExpired_Click_1(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {

                connection.Open();
                string cmd = "select Product.Name, Type.Name as 'Type', Product.AdditionalNotes, Warehouse.Amount,Warehouse.Measure, Warehouse.ArrivedDate,Warehouse.ExpiredDate,Warehouse.Code from Product Inner Join Warehouse on Warehouse.ProductId=Product.Id Left Join Type on Product.ProductType=Type.Id Where ExpiredDate<=GETDATE()";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                
                if(dataGridView1.Rows.Count==1)
                {
                    MessageBox.Show("Все нормально!");
                }
                else
                {
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = "select Name,Surname,Position,Number from Staff";
                    SqlDataReader reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbStaff.Items.Add(reader.GetString(0).Trim() + " " + reader.GetString(1).Trim() + reader.GetString(2).Trim() );
                        number = reader.GetString(3).Trim();
                       
                    }
                    reader.Close();
                }
            }
        }
        

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            if (cmbStaff.SelectedItem != null)
            {
                const string path = "D:\\VisualStudio\\Projects\\LogForm";
                var file = Path.Combine(path, $"{DateTime.Now.ToString("dd-MM (HH.mm.ss) ")}.txt");
                File.Create(file).Dispose();
                using (TextWriter tw = new StreamWriter(file))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridView1.Columns.Count - 1)
                            {
                                tw.Write("-");
                            }
                        }
                        tw.WriteLine();
                    }
                }
                number = number.Substring(1, number.Length - 1);
                Process.Start("msedge.exe", $"https://wa.me/{number}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
            SelectProducts selectProducts = new SelectProducts();
            selectProducts.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
            AddToWarehouse addToWarehouse=  new AddToWarehouse();
            addToWarehouse.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!chOverall.Checked) dataGridView1.SelectedCells[0].ContextMenuStrip = cntxtCells;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
            AddToWarehouse warehouse = new AddToWarehouse();
            warehouse.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
            DeductFromWarehouse form4 = new DeductFromWarehouse(dataGridView1.SelectedCells[0].Value.ToString());
            form4.Show();
        }


        private void изменитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
            AddToWarehouse warehouse = new AddToWarehouse(ColumnValues(dataGridView1, Columns.Product), ColumnValues(dataGridView1,Columns.Amount), ColumnValues(dataGridView1,Columns.Measure),ColumnValues(dataGridView1,Columns.ArrivedDate),ColumnValues(dataGridView1,Columns.Code));
            warehouse.ShowDialog();
        }

        private void вычестиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
            DeductFromWarehouse form4 = new DeductFromWarehouse(ColumnValues(dataGridView1,Columns.Code));
            form4.ShowDialog ();
        }

        private void SelectFromWarehouse_Load(object sender, EventArgs e)
        {
            try
            {
                SpeechRecognizerOn();
                Default_SpeechRecognized(this, default);
            }
            catch(Exception exc)
            {
                File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

            }

        }

        private void SelectFromWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();
        }
    }
}
