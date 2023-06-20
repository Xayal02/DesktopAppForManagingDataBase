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
    public partial class AddAndChangeProductList : Form
    {
        private int _productId;
        private string _productName;
        private int type;


        public AddAndChangeProductList()
        {
            InitializeComponent();

            this.Text = "Добавить Продукт";
            btnChange.Visible = false;

        }
        public AddAndChangeProductList(object id, object name, int  type, object wholesalaPrice, object salePrice, object keepTime, object notes)
        {
            InitializeComponent();

            this._productId= (int)id;
            this.txtName.Text = (string)name;
            this.cmbType.SelectedIndex = type;
            this.nmbrOptom.Value = (decimal)wholesalaPrice;
            this.nmbrSale.Value = (decimal)salePrice;
            this.txtSrok.Text = (string)keepTime;
            this.cmbPeriod.SelectedIndex = 0;
            this.txtNotes.Text = (string)notes;
            this.btnChange.Visible = true;
            this.btnAdd.Visible = false;
            this.Text = "Изменить Продукт";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToProductList_Load(object sender, EventArgs e)
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productName = txtName.Text;

            StringModifier(ref _productName);

            if (TextBoxesError(txtName,errorProvider1) && TextBoxesError(txtSrok,errorProvider1) && ComboBoxError(cmbType,errorProvider1) && ComboBoxError(cmbPeriod,errorProvider1) && NumericError(nmbrOptom,errorProvider1)  && NumericError(nmbrSale,errorProvider1))
            {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();

                try
                {
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Select Id from Products Where Name=@name And ProductType = @type And AdditionalNotes=@notes";
                    cmd.Parameters.AddWithValue("@name", _productName);

                    TypeDeterminer();
                    if (type == 4)
                    {
                        cmd.Parameters.AddWithValue("@type", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@type", type);
                    }

                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text.Trim());

                    var id = cmd.ExecuteScalar();

                    if (id != null)
                    {
                        MessageBox.Show("Продукт с таким именем, типом и заметками уже существует");
                    }
                    else
                    {
                        cmd.CommandText = "Insert into Products (Name,ProductType,WholesalePrice,SalePrice,KeepTime,AdditionalNotes)" +
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

        private void  TypeDeterminer()
        {
            if (cmbType.SelectedItem.ToString() == "Dondurulmus")
            {
                type = 1;
            }
            else if (cmbType.SelectedItem.ToString() == "Teze")
            {
                type = 2;
            }
            else if (cmbType.SelectedItem.ToString() =="Kaptit olunmus")
            {
                type = 3;
            }
            else type = 4;
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
        
        private void Value_Changed(object sender, EventArgs e)
        {
            errorProvider1.Clear();
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

       

        private void btnChange_Click(object sender, EventArgs e)
        {
            _productName = txtName.Text;

            StringModifier(ref _productName);

            if (TextBoxesError(txtName, errorProvider1) && TextBoxesError(txtSrok, errorProvider1) && ComboBoxError(cmbPeriod, errorProvider1) && ComboBoxError(cmbPeriod, errorProvider1) && NumericError(nmbrOptom, errorProvider1) && NumericError(nmbrSale, errorProvider1))
            {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();

                try
                {
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "update Product Set Name = @name, ProductType = @type , WholesalePrice = @optPrice, SalePrice = @salePrice, KeepTime = @keepTime , AdditionalNotes = @notes Where Id = @id";
                    cmd.Parameters.AddWithValue("@name", _productName);

                    TypeDeterminer();
                    if(type==4)
                    {
                        cmd.Parameters.AddWithValue("@type", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@type",type);
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
