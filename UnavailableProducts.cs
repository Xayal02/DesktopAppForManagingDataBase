using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static LogForm.Program;
using static ColumnDeterminer.ProductList;
using System.IO;

namespace LogForm
{
    public partial class UnavailableProducts : Form
    {
        public UnavailableProducts()
        {
            InitializeComponent();
        }

        private void dataUnavailableProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {  
            dataUnavailableProducts.SelectedCells[0].ContextMenuStrip = contextMenuStrip1;
        }

        private void UnavailableProducts_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(sqlConnection);
            connection.Open();

            try
            {
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "select UnavailableProducts.Id,UnavailableProducts.KeepTime, UnavailableProducts.Name, Type.Name as 'Type', UnavailableProducts.AdditionalNotes,  UnavailableProducts.WholesalePrice, UnavailableProducts.SalePrice  from  UnavailableProducts Left Join Type on UnavailableProducts.ProductType=Type.Id\r\n";
                SqlDataAdapter adapter1 = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                adapter1.Fill(table);
                dataUnavailableProducts.DataSource = table;
                ColumnHeader();
            }
            catch(Exception exc)
            {
                //File.AppendAllText(path, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

            }
            finally
            {
                connection.Close();
            }
            
        }

        private void вернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы хотите довабить товар обратно?";

            string caption = "Предупреждение";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                using (var connection = new SqlConnection(sqlConnection))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "SET IDENTITY_INSERT Product ON";
                    cmd.ExecuteNonQuery();



                    cmd.CommandText = "Insert into Product (Id,Name,ProductType,WholesalePrice,SalePrice,KeepTime,AdditionalNotes)" +
                        "Values (@id,@name,@type,@wholeSalePrice,@salePrice,@keepTime,@notes)";

                    cmd.Parameters.AddWithValue("@id", ColumnValues(dataUnavailableProducts, Columns.Id));

                    cmd.Parameters.AddWithValue("@name", ColumnValues(dataUnavailableProducts, Columns.Name));

                    if (!TypeValueDeterminer(dataUnavailableProducts))
                    {

                        TypeDeterminer(dataUnavailableProducts);
                        cmd.Parameters.AddWithValue("@type", ++type);
                    }

                    else
                    {
                        cmd.Parameters.AddWithValue("@type", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@wholeSalePrice", ColumnValues(dataUnavailableProducts, Columns.WholesalePrice));

                    cmd.Parameters.AddWithValue("@salePrice", ColumnValues(dataUnavailableProducts, Columns.SalePrice));

                    cmd.Parameters.AddWithValue("@keepTime", ColumnValues(dataUnavailableProducts, Columns.KeepTime));

                    cmd.Parameters.AddWithValue("@notes", ColumnValues(dataUnavailableProducts, Columns.AdditionalNotes));

                    cmd.ExecuteNonQuery();



                    ////cmd.CommandText = "SET IDENTITY_INSERT Product OFF";
                    ////cmd.ExecuteNonQuery();




                    cmd.CommandText = "Delete from UnavailableProducts where Id=@id";
                    cmd.ExecuteNonQuery();

                    UnavailableProducts_Load(this, default);
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

                using (var connection = new SqlConnection(sqlConnection))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "Delete from UnavailableProducts Where Id=@id";
                    cmd.Parameters.AddWithValue("@id", ColumnValues(dataUnavailableProducts, Columns.Id));

                    cmd.ExecuteNonQuery();

                    UnavailableProducts_Load(this, default);

                }
            }

        }
        private void ColumnHeader()
        {
            dataUnavailableProducts.Columns[idIndex].Visible = false;

            dataUnavailableProducts.Columns[keepTimeIndex].Visible = false;

            dataUnavailableProducts.Columns[wholesalePriceIndex].Visible = false;

            dataUnavailableProducts.Columns[salePriceIndex].Visible = false;

        }
    }
}
