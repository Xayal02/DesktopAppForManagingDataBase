using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using static LogForm.Program;
using static LogForm.InnerFunctions;
using static LogForm.SpeechRecognizer;


namespace LogForm
{
    public partial class DeductFromWarehouse : Form
    {
        private  string _code;

        decimal totalAmount;

        decimal deductedAmount;

        string measure;

        public DeductFromWarehouse(object code)
        {
            InitializeComponent();

            _code = code.ToString();
        }

        private void Extract_Click2(object sender, EventArgs e)
        {
            if (NumericError(nmbrAmount, errorProvider1))
            {

                using (var connection = new SqlConnection(sqlConnection))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();

                   

                    if (chAll.Checked || (totalAmount == nmbrAmount.Value))
                    {
                        cmd.CommandText = "Delete from Warehouse Where code = @code";
                        cmd.Parameters.AddWithValue("@code", _code);

                    }

                    else
                    {
                        cmd.CommandText = "Update Warehouse Set Amount = @amount Where Code=@code";
                        cmd.Parameters.AddWithValue("@code", _code);
                        cmd.Parameters.AddWithValue("@amount", (totalAmount - nmbrAmount.Value));
                    }

                    if (ValueChecker())
                    {
                        cmd.ExecuteNonQuery();

                        deductedAmount = chAll.Checked ? totalAmount : nmbrAmount.Value;

                        string message = $"{deductedAmount} {MeasureAdjuster()} товара было выписано";
                        MessageBox.Show(message);
                        this.Close();
                    }
                }
            }

        }

        private void chAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chAll.Checked) nmbrAmount.Value = totalAmount;
            
           // nmbrAmount.Visible = chAll.Checked ? false : true;

        }

        private string  MeasureAdjuster()
        {
            if (measure == "kg")
            {
                measure = "килограмм";
            }

            else if (measure == "qr")
            {
                measure = "грамм";
            }

            else if (char.IsDigit(measure[0]))
            {
                measure = "коробок " + measure;
            }

            return measure;
        }

        private void nmbrAmount_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private bool ValueChecker()
        {
            if(nmbrAmount.Value>totalAmount)
            {
                errorProvider1.SetError(nmbrAmount, $"Вычитаемое  количество превосходит общее количество ({totalAmount} {measure})");
                
                return false;

            }

            return true;
        }

        private void DeductFromWarehouse_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select Amount, Measure from Warehouse Where Code = @code";
                cmd.Parameters.AddWithValue("@code", _code);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    totalAmount = reader.GetDecimal(0);
                    measure = reader.IsDBNull(1) ? "kg" : reader.GetString(1);
                }
                reader.Close();
            }
        }
    }
}
