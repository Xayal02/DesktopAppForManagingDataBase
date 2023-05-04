using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static LogForm.Program;
using static ColumnDeterminer.ProductList;
using static LogForm.InnerFunctions;
using static LogForm.SpeechRecognizer;

namespace LogForm
{
    public partial class SelectProducts : Form
    {
         
        string view = "";

        string conditionPrice = "";

       

        public SelectProducts()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
           
            using (var connection = new SqlConnection(sqlConnection))
            {
                
                connection.Open();

                ViewDeterminer(ref view);

                ConditionDeterminer(ref conditionPrice);

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"Select * from {view} where {conditionPrice}";

                sqlCommand.Parameters.Add("@min", SqlDbType.Decimal).Value = nmbrMin.Value;
                sqlCommand.Parameters.Add("@max", SqlDbType.Decimal).Value = nmbrMax.Value;

                SqlDataAdapter adapter1 = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                adapter1.Fill(table);
                dataGridView1.DataSource = table;

                ColumnHeader();

            }

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SaveToFileAsync(pathToProductList, this.dataGridView1);

            string number = "994" + Fixer(maskedTextBox1.Text);
            Process.Start("msedge.exe", $"https://wa.me/{number}");
        }
        private static string Fixer(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return (sb.ToString());
        }

        private void изСпискаНедоступныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();

            UnavailableProducts unavailableProducts= new UnavailableProducts();
            unavailableProducts.ShowDialog();
        }

        private void ColumnHeader()
        {
            dataGridView1.Columns[idIndex].Visible = false;
            dataGridView1.Columns[keepTimeIndex].Visible = false;

            dataGridView1.Columns[salePriceIndex].Visible= optomRBtn.Checked ? false : true;
            dataGridView1.Columns[wholesalePriceIndex].Visible = saleRBtn.Checked ? false : true;

            if (chCurrent.Checked)
            {

                if (chOverall.Checked)
                {
                    dataGridView1.Columns[overallIndex].Visible = true;
                }

                else
                {
                    dataGridView1.Columns[overallIndex].Visible = false;
                }

            }
        }


        private void SelectProducts_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12F);
            try
            {
                SpeechRecognizerOn();
                Default_SpeechRecognized(this, default);
            }
            catch (Exception exc)
            {
                File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

            }

            chOverall.Enabled = (optomRBtn.Checked || saleRBtn.Checked) ? true : false;

            ToolStripMenuItem toolStripMenu1 = new ToolStripMenuItem("Убрать");
            ToolStripMenuItem toolStripMenu2 = new ToolStripMenuItem("Удалить");
            ToolStripMenuItem toolStripMenu3 = new ToolStripMenuItem("Изменить");

        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetComponents(this);
            nmbrMin.Value = nmbrMin.Minimum;
            nmbrMax.Value=nmbrMax.Maximum;
        }
        private void ViewDeterminer(ref string view)
        {
            if (chCurrent.Checked)
            {
                if (freshRBtn.Checked) view = "VW_CurrentFresh";
                else if (frozenRBtn.Checked) view = "VW_CurrentFrozen";
                else if (smokedRBtn.Checked) view = "VW_CurrentSmoked";
                else if (otherRBtn.Checked) view = "VW_CurrentOther";
                else view = "VW_CurrentProducts";

            }
            else
            {
                if (freshRBtn.Checked) view = "VW_FreshProduct";
                else if (frozenRBtn.Checked) view = "VW_FrozenProducts";
                else if (smokedRBtn.Checked) view = "VW_SmokedProducts";
                else if (otherRBtn.Checked) view = "VW_OtherProducts";
                else view = "VW_ProductsPrice";
            }
        }
        private void ConditionDeterminer(ref string condition)
        {
            if (optomRBtn.Checked) condition = "WholesalePrice Between @min and @max";
           
            else if (saleRBtn.Checked) condition = "SalePrice Between @min and @max";

            else condition = $"SalePrice Between @min and @max  AND WholesalePrice Between @min and @max ";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }
        private void optomRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void saleRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
            chOverall.Enabled = chCurrent.Checked ? true : false;

        }

        private void новыйПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();

            AddToProductList add= new AddToProductList();
            add.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectedCells[0].ContextMenuStrip = contextMenuStrip1;

        }

        private void убратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы действительно хотите временно убрать товар из списка?";
            string caption = "Предупреждение";
            var result= MessageBox.Show(message, caption,MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result==DialogResult.OK)
            {
                var connection = new SqlConnection(sqlConnection);
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Delete from Product Where Id = @id";
                    cmd.Parameters.AddWithValue("@id", ColumnValues(dataGridView1, Columns.Id));
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "Insert into UnavailableProducts (Id,Name,ProductType,WholesalePrice,SalePrice,KeepTime,AdditionalNotes)" +
                    "Values (@id,@name,@type,@optPrice,@salePrice,@keepTime,@notes)";
                    cmd.Parameters.AddWithValue("@name", ColumnValues(dataGridView1, Columns.Name));
                    if (TypeValueDeterminer(dataGridView1))
                    {
                        cmd.Parameters.AddWithValue("@type", DBNull.Value);
                      
                    }
                    else
                    {
                        TypeDeterminer(dataGridView1);
                        cmd.Parameters.AddWithValue("@type", ++type);
                    }
                    cmd.Parameters.AddWithValue("@optPrice", ColumnValues(dataGridView1, Columns.WholesalePrice));
                    cmd.Parameters.AddWithValue("@salePrice", ColumnValues(dataGridView1, Columns.SalePrice));
                    cmd.Parameters.AddWithValue("@keepTime", ColumnValues(dataGridView1, Columns.KeepTime));
                    cmd.Parameters.AddWithValue("@notes", ColumnValues(dataGridView1, Columns.AdditionalNotes));
                    cmd.ExecuteNonQuery();
                    this.btnShow_Click(this, default);
                }
                catch(System.Data.SqlClient.SqlException exc)
                {
                    MessageBox.Show("Невозможно убрать этот продукт так как в амбаре  ");
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены что хотите удалить товар из списка?";
            string caption = "Предупреждение";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                var connection = new SqlConnection(sqlConnection);
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Delete from Product Where Id = @id";
                    cmd.Parameters.AddWithValue("@id", ColumnValues(dataGridView1, Columns.Id));
                    cmd.ExecuteNonQuery();
                }
                catch(System.Data.SqlClient.SqlException exc)
                {
                    MessageBox.Show("Невозможно убрать этот продукт так как в амбаре  ");
                }
                finally
                {
                    connection.Close();
                    this.btnShow_Click(this, default);
                }

            }
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();

            AddToProductList addToProduct = new AddToProductList(ColumnValues(dataGridView1, Columns.Id),ColumnValues(dataGridView1, Columns.Name),TypeDeterminer(dataGridView1), ColumnValues(dataGridView1, Columns.WholesalePrice), ColumnValues(dataGridView1, Columns.SalePrice), ColumnValues(dataGridView1, Columns.KeepTime), ColumnValues(dataGridView1, Columns.AdditionalNotes));
            addToProduct.Show();

        }

        private void allRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void freshRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void frozenRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void smokedRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void otherRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void nmbrMin_ValueChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void nmbrMax_ValueChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(this, default);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();

            AddToProductList add = new AddToProductList();
            add.ShowDialog();
        }

        private void списокНедоступныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncCancel();

            UnavailableProducts unavailableProducts = new UnavailableProducts();
            unavailableProducts.ShowDialog();
        }

        private void SelectProducts_FormClosing(object sender, FormClosingEventArgs e)
        {

            _recognizer.RecognizeAsyncCancel();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
