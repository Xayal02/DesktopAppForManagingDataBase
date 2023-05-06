using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static LogForm.Program;
using static LogForm.InnerFunctions;
using static LogForm.SpeechRecognizer;
using System.IO;

namespace LogForm
{
    public partial class AddToWarehouse : Form
    {
        public string codeString;
        DataClasses2DataContext db = new DataClasses2DataContext();

        public AddToWarehouse()
        {
            InitializeComponent();
            AddToWarehouse_Load(this, default);

            btnChange.Visible = false;
        }

        public AddToWarehouse(object product, object amount, object measure, object date, object code)
        {
            InitializeComponent();

            AddToWarehouse_Load(this, default);

            comboBox1.SelectedItem = product;

            nmbrAmount.Value = (decimal)amount;

            txtMeasure.Text = measure.ToString();

            dateArrived.Value = (DateTime)date;

            txtCode.Text = code.ToString();

            codeString = code.ToString();

            btnAdd.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(TextBoxesError(txtCode,errorProvider1) && TextBoxesError(txtMeasure, errorProvider1))
            {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();

                try
                {
                    SqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "Update Warehouse " +
                        "Set ProductId = @id, Amount = @amount, Measure = @measure, ArrivedDate = @date, Code = @newCode Where Code = @code";

                    cmd.Parameters.AddWithValue("@id", GetId(comboBox1.SelectedItem.ToString()));

                    cmd.Parameters.AddWithValue("@amount", nmbrAmount.Value);

                    cmd.Parameters.AddWithValue("@measure", txtMeasure.Text);

                    cmd.Parameters.AddWithValue("@date", dateArrived.Value);

                    cmd.Parameters.AddWithValue("@newCode", txtCode.Text);

                    cmd.Parameters.AddWithValue("@code", codeString);

                    cmd.ExecuteNonQuery();

                    string message2 = "Продукт изменен!";
                    this.Close();
                    
                }
                catch(Exception exc)
                {
                    File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');
                }
                finally
                {
                    connection.Close();
                   

                }

            }

        }

        private void AddToWarehouse_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                StringBuilder sb = new StringBuilder();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "select Product.Name, Type.Name, Product.AdditionalNotes from Product \r\nleft join Type on Product.ProductType=Type.Id";
                
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sb.Append(reader.GetString(0));

                    if (!(reader.IsDBNull(1)))
                    {
                        sb.Append(" | " + reader.GetString(1));
                    }

                    if (!(reader.IsDBNull(2)))
                    {
                        sb.Append(" | " + reader.GetString(2));
                    }

                    comboBox1.Items.Add(sb.ToString());
                    sb.Clear();
                }
            }

        }
        private int GetId(string text)
        {
            int id = 0;

            if (!text.Contains('|'))
            {
                id = GetIdByProductName(text);
            }
            else
            {
                string[] strings = text.Split('|');
                if (strings.Length == 2)
                {
                    id = GetIdByProductNameAndType(strings[0].Trim(), strings[1].Trim());
                }
                else if (strings.Length == 3)
                {
                    id = GetIdByProductNameTypeAndNote(strings[0].Trim(), strings[1].Trim(), strings[2].Trim());
                }
            }

            return id;
        }

        private int GetIdByProductName(string name)
        {
            int id;

            using (var connection = new SqlConnection(sqlConnection))
            using (var command = new SqlCommand("select Id from VW_AddToWarehouse Where Name = @name", connection))
            {
                command.Parameters.AddWithValue("@name", name);
                connection.Open();
                id = (int?)command.ExecuteScalar() ?? 0;
            }

            return id;
        }

        private int GetIdByProductNameAndType(string name, string type)
        {
            int id = 0;

            using (var connection = new SqlConnection(sqlConnection))
            using (var command = new SqlCommand("select Id from VW_AddToWarehouse Where Name = @name and ProductType = @type", connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@type", type);
                connection.Open();
                id = (int?)command.ExecuteScalar() ?? 0;
            }

            return id;
        }

        private int GetIdByProductNameTypeAndNote(string name, string type, string note)
        {
            int id = 0;

            using (var connection = new SqlConnection(sqlConnection))
            using (var command = new SqlCommand("select Id from VW_AddToWarehouse Where Name = @name and ProductType = @type and AdditionalNotes = @note", connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@note", note);
                connection.Open();
                id = (int?)command.ExecuteScalar() ?? 0;
            }

            return id;
        }
        private DateTime GetTime(string text)
        {
            var st = (from s in db.Products where s.Id == GetId(text) select s).First();
            return  (dateArrived.Value.AddDays((double)st.KeepTime));            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ComboBoxError(comboBox1,errorProvider1) && TextBoxesError(txtMeasure, errorProvider1) && NumericError(nmbrAmount,errorProvider1))
            {
                if(string.IsNullOrEmpty(txtCode.Text))
                {
                    var code = Guid.NewGuid().ToString();
                    txtCode.Text = code.Substring(0, code.IndexOf("-"));

                }
                using (var connection = new SqlConnection(sqlConnection))
                {
                    connection.Open();
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandText = "Select ProductId from Warehouse Where Code=@code";
                    command1.Parameters.AddWithValue("@code", txtCode.Text);
                    var  id = command1.ExecuteScalar();

                    if (id != null)
                    {
                        string message1 = "This product has already been added\nDo you want to add another one?";
                        DialogResult result1 = MessageBox.Show(message1, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result1 == DialogResult.Yes)
                        {
                            ResetComponents(this);
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        command1.CommandText = "Insert into Warehouse (ProductId,Amount,Measure,ArrivedDate,ExpiredDate,Code)" +
                  "Values (@id,@amount,@measure,@arrived_date,@expire_date,@code)";
                        command1.Parameters.AddWithValue("@id", GetId(comboBox1.SelectedItem.ToString()));
                        command1.Parameters.AddWithValue("@amount", (double)nmbrAmount.Value);
                        command1.Parameters.AddWithValue("@measure", txtMeasure.Text);
                        command1.Parameters.AddWithValue("@arrived_date", dateArrived.Value);
                        command1.Parameters.AddWithValue("@expire_date", GetTime(comboBox1.SelectedItem.ToString()));
                        // cmd1.Parameters.Add("@code", richTextBox1.Text);
                        command1.ExecuteNonQuery();



                        string message2 = "Продукт добавлен!\nХотите добавить новый?";
                        DialogResult result = MessageBox.Show(message2, "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            ResetComponents(this);
                        }
                    }
                }
            }


        }
        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

    }
}

