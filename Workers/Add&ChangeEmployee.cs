using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogForm.Program;
using static ColumnDeterminer.Staff;
using static LogForm.InnerFunctions;


namespace LogForm
{
    public partial class AddEmployee : Form
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _position;
        private string _number;
        public AddEmployee()
        {
            InitializeComponent();

            this.Text = "Добавить Работника";
            btnChange.Visible = false;
        }

        public AddEmployee(object id,object name, object surname, object position, object number)
        {
            InitializeComponent();
            this._id = (int)id;
            this.txtName.Text = name.ToString().Trim();
            this.txtSurname.Text = surname.ToString().Trim();
            this.txtPosition.Text = position.ToString().Trim();
            this._number = number.ToString();
            this.txtNumber.Text = PhoneNumberToDisplay(ref _number);

            this.Text = "Изменить данные работника";
            btnAdd.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (TextBoxesError(txtName, errorProvider) && TextBoxesError(txtSurname, errorProvider) && MaskedTextNumberError(txtNumber, errorProvider) && TextBoxesError(txtPosition, errorProvider))
            {

                _name = txtName.Text;
                _surname = txtSurname.Text;
                _position = txtPosition.Text;

                StringModifier(ref _name);
                StringModifier(ref _surname);
                StringModifier(ref _position);

                var connection = new SqlConnection(sqlConnection);
                connection.Open();

                try
                {

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Insert into WarehouseStaff(Name,Surname,Position,Number) Values(@name,@surname,@position,@number)";

                    

                    cmd.Parameters.AddWithValue("@name",_name);
                    cmd.Parameters.AddWithValue("@surname", _surname);
                    cmd.Parameters.AddWithValue("@position", _position);
                    cmd.Parameters.AddWithValue("@number", PhoneNumberToAdd(txtNumber.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Работник добавлен!");
                    this.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Произошла ошибка");
                    File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

                }
                finally { connection.Close(); }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (TextBoxesError(txtName, errorProvider) && TextBoxesError(txtSurname, errorProvider) && MaskedTextNumberError(txtNumber, errorProvider) && TextBoxesError(txtPosition, errorProvider))
            {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();
                try
                {
                    _name = txtName.Text;
                    _surname = txtSurname.Text;
                    _position = txtPosition.Text;

                    StringModifier(ref _name);
                    StringModifier(ref _surname);
                    StringModifier(ref _position);

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Update WarehouseStaff Set Name = @name, Surname = @surname, Position = @position, Number = @number Where id=@id";
                    cmd.Parameters.AddWithValue("@id",_id);
                    cmd.Parameters.AddWithValue("@name", _name);
                    cmd.Parameters.AddWithValue("@surname", _surname);
                    cmd.Parameters.AddWithValue("@position", _position);
                    cmd.Parameters.AddWithValue("@number", PhoneNumberToAdd(txtNumber.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные изменены!");
                    this.Close();

                }
                catch(Exception exc)
                {
                    MessageBox.Show("Произошла ошибка");
                    File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

                }
                finally { connection.Close(); }


            }
        }
        private void Value_Changed(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
