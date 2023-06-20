using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static LogForm.Program;
using static ColumnDeterminer.ProductList;
using static LogForm.SpeechRecognizer;
using System.IO;
using System.Threading.Tasks;

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
            dataUnavailableProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12F);

            dataUnavailableProducts.SelectedCells[0].ContextMenuStrip = contextMenuStrip1;

            
        }

        private async void UnavailableProducts_LoadAsync(object sender, EventArgs e)
        {

            using (var connection = new SqlConnection(sqlConnection))
            {
                await connection.OpenAsync();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "select UnavailableProducts.Id,UnavailableProducts.KeepTime, UnavailableProducts.Name, Types.Name as 'Type', UnavailableProducts.AdditionalNotes,  UnavailableProducts.WholesalePrice, UnavailableProducts.SalePrice  from  UnavailableProducts Left Join Types on UnavailableProducts.ProductType=Types.Id\r\n";
                SqlDataAdapter adapter1 = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                await Task.Run(() => adapter1.Fill(table));
                dataUnavailableProducts.DataSource = table;
                ColumnHeader();
            }
            ColumnsNameConfigurator(dataUnavailableProducts);
        }

        private async void вернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы хотите довабить товар обратно?";
            string caption = "Предупреждение";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (var connection = new SqlConnection(sqlConnection))
                {
                    await connection.OpenAsync();

                    try
                    {
                        SqlCommand cmd = connection.CreateCommand();

                        cmd.CommandText = "SET IDENTITY_INSERT Products ON";
                        await cmd.ExecuteNonQueryAsync();

                        cmd.CommandText = "Insert into Products (Id,Name,ProductType,WholesalePrice,SalePrice,KeepTime,AdditionalNotes)" +
                            "Values (@id,@name,@type,@wholeSalePrice,@salePrice,@keepTime,@notes)";

                        cmd.Parameters.AddWithValue("@id", ColumnValues(dataUnavailableProducts, Columns.Id));
                        cmd.Parameters.AddWithValue("@name", ColumnValues(dataUnavailableProducts, Columns.Name));

                        if (IsTypeValueEmpty(dataUnavailableProducts))
                        {
                            cmd.Parameters.AddWithValue("@type", DBNull.Value);
                        }
                        else
                        {
                            GetTypeValue(dataUnavailableProducts);
                            cmd.Parameters.AddWithValue("@type", ++type);
                        }

                        cmd.Parameters.AddWithValue("@wholeSalePrice", ColumnValues(dataUnavailableProducts, Columns.WholesalePrice));
                        cmd.Parameters.AddWithValue("@salePrice", ColumnValues(dataUnavailableProducts, Columns.SalePrice));
                        cmd.Parameters.AddWithValue("@keepTime", ColumnValues(dataUnavailableProducts, Columns.KeepTime));
                        cmd.Parameters.AddWithValue("@notes", ColumnValues(dataUnavailableProducts, Columns.AdditionalNotes));

                        await cmd.ExecuteNonQueryAsync();

                        cmd.CommandText = "Delete from UnavailableProducts where Id=@id";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", ColumnValues(dataUnavailableProducts, Columns.Id));

                        await cmd.ExecuteNonQueryAsync();

                         UnavailableProducts_LoadAsync(this, default);
                    }
                    catch (Exception exc)
                    {
                        File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');
                    }
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

                    cmd.CommandText = "Delete from UnavailableProducts Where Id=@id";
                    cmd.Parameters.AddWithValue("@id", ColumnValues(dataUnavailableProducts, Columns.Id));

                    cmd.ExecuteNonQuery();

                    UnavailableProducts_LoadAsync(this, default);
                }
                catch (Exception exc)
                {
                    File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

                }
                finally
                {
                    connection.Close();
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
