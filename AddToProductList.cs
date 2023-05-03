using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static LogForm.InnerFunctions;
using static LogForm.Program;
using static LogForm.SpeechRecognizer;

namespace LogForm
{
    public partial class AddToProductList : Form
    {
        private int _productId;
        private string _productName;
        public AddToProductList()
        {
            InitializeComponent();
        }
        public AddToProductList(object id, object name, int  type, object wholesalaPrice, object salePrice, object keepTime, object notes)
        {
            InitializeComponent();

            this._productId= (int)id;

            this.txtName.Text = (string)name;

            this.cmbType.SelectedIndex = type;

            this.nmbrOptom.Value = (decimal)wholesalaPrice;

            this.nmbrSale.Value = (decimal)salePrice;

            this.txtSrok.Text = keepTime.ToString();

            this.cmbPeriod.SelectedIndex = 0;

            this.txtNotes.Text = (string)notes;

            this.btnChange.Visible = true;

            this.btnAdd.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToProductList_Load(object sender, EventArgs e)
        {

            SpeechRecognizerOn();
            Default_SpeechRecognized(this, default);
            //using (var connection = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = StudentsDb; Integrated Security= True;"))
            //{
            //    StringBuilder sb = new StringBuilder();

            //    connection.Open();
            //    SqlCommand cmd = connection.CreateCommand();
            //    cmd.CommandText = "Select Name from Type";
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        cmbType.Items.Add(reader.GetString(0));
            //    }

            //}
            //cmbType.Items.Add("Diger");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            _productName = txtName.Text;

            StringModifier(ref _productName);

            Shrinker(ref _productName);

            if (Checker())
            {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();

                try
                {
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Select Id from Product Where Name=@name And ProductType = @type And AdditionalNotes=@notes";
                    cmd.Parameters.AddWithValue("@name", _productName);
                    if (cmbType.SelectedIndex == 3)
                    {
                        cmd.Parameters.AddWithValue("@type", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@type", TypeDeterminer());
                    }

                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text.Trim());

                    var id = cmd.ExecuteScalar();

                    if (id != null)
                    {
                        MessageBox.Show("Продукт с таким именем, типом и заметками уже существует");
                    }
                    else
                    {
                        cmd.CommandText = "Insert into Product (Name,ProductType,WholesalePrice,SalePrice,KeepTime,AdditionalNotes)" +
                        "Values (@name,@type,@optPrice,@salePrice,@keepTime,@notes)";
                        cmd.Parameters.AddWithValue("@optPrice", SqlDbType.Decimal).Value = nmbrOptom.Value;
                        cmd.Parameters.AddWithValue("@salePrice", SqlDbType.Decimal).Value = nmbrSale.Value;
                        cmd.Parameters.AddWithValue("@keepTime", KeepTime());
                        cmd.ExecuteNonQuery();
                        string message = "Продукт добавлен!\nХотите добавить новый продукт?";
                        string caption = "Уведомление";
                        Notifier(message, caption);

                       
                    }
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

        private int TypeDeterminer()
        {
            cmbType.SelectedItem.ToString();
            int type;
            if (cmbType.SelectedIndex == 0)
            {
                type = 1;
            }
            else if (cmbType.SelectedIndex == 1)
            {
                type = 2;
            }
            else
            {
                type = 3;
            }
            return type;
        }
        private int KeepTime()
        {
            int srok = Convert.ToInt32(txtSrok.Text);
            if (cmbPeriod.SelectedIndex == 1)
            {
                srok *= 30;
            }
            else if (cmbPeriod.SelectedIndex == 2)
            {
                srok *= 365;
            }
            return srok;
        }

        private bool Checker()
        {
            bool determiner = false;

            if (string.IsNullOrWhiteSpace(_productName))
            {
                errorProvider1.SetError(txtName, "Ввведите имя продукта");
            }
            else if (cmbType.SelectedItem == null)
            {
                errorProvider1.SetError(cmbType, "Выберите тип продукта");
            }
            else if (nmbrOptom.Value == 0)
            {
                errorProvider1.SetError(nmbrOptom, "Введите оптовую цену");
            }
            else if (nmbrSale.Value == 0)
            {
                errorProvider1.SetError(nmbrSale, "Введите розничную цену");
            }
            else if (nmbrOptom.Value > nmbrSale.Value)
            {
                errorProvider1.SetError(nmbrOptom, "Оптовая цена больше розничной");
                errorProvider1.SetError(nmbrSale, "Оптовая цена больше розничной");
            }

            else if (string.IsNullOrWhiteSpace(txtSrok.Text))
            {
                errorProvider1.SetError(txtSrok, "Введите срок хранения");
            }
            else if (cmbPeriod.SelectedItem == null)
            {
                errorProvider1.SetError(cmbPeriod, "Укажите интервал хранения ");
            }
            else
            {
                determiner = true;
            }

            return determiner;
        }
        private void Value_Changed(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void StringModifier(ref string str) //modify strings
        {
            if (!(string.IsNullOrEmpty(str)))
            {
                str = str.ToLower();
                StringBuilder sb = new StringBuilder();
                sb.Append(char.ToUpper(str[0]));
                for (int i = 1; i < str.Length; i++)
                {

                    sb.Append(str[i]);
                }
                str = sb.ToString();
            }
        }
        public static void Shrinker(ref string str) // artiq boshluglari yigihsdirir
        {
            StringBuilder sb = new StringBuilder();
            bool determiner = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    ;
                    sb.Append(str[i]);
                    determiner = true;
                }
                else if ((str[i] == ' ') && (determiner))
                {
                    sb.Append(str[i]);
                    determiner = false;
                }
            }
            str = sb.ToString();
        }
        private void Notifier(string message,string caption)
        {
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                ResetComponents(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cmbType.SelectedIndex = 1;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _productName = txtName.Text;

            StringModifier(ref _productName);
            Shrinker(ref _productName);

            if (Checker())
            {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();

                try
                {
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "update Product Set Name = @name, ProductType = @type , WholesalePrice = @optPrice, SalePrice = @salePrice, KeepTime = @keepTime , AdditionalNotes = @notes Where Id = @id";
                    cmd.Parameters.AddWithValue("@name", _productName);

                    if (cmbType.SelectedIndex == 3)
                    {
                        cmd.Parameters.AddWithValue("@type", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@type", TypeDeterminer());
                    }

                    cmd.Parameters.AddWithValue("@optPrice", SqlDbType.Decimal).Value = nmbrOptom.Value;
                    cmd.Parameters.AddWithValue("@salePrice", SqlDbType.Decimal).Value = nmbrSale.Value;
                    cmd.Parameters.AddWithValue("@keepTime", KeepTime());
                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text);
                    cmd.Parameters.AddWithValue("@id", _productId);
                    cmd.ExecuteNonQuery();
                    string message = "Продукт изменен";
                    MessageBox.Show(message);
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
    }
}
