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
        private string _name;
        private string _surname;
        private string _position;
        private string _phoneNumber;
        public AddEmployee()
        {
            InitializeComponent();
            this.Text = "Добавить Работника";
            btnChange.Visible = false;
        }

        public AddEmployee(object name, object surname, object position, object number)
        {
            InitializeComponent();

            this.txtName.Text = name.ToString().Trim();
            this.txtSurname.Text = surname.ToString().Trim();
            this.txtPosition.Text = position.ToString().Trim();

            string phoneNumber = number.ToString();
            this.txtNumber.Text = PhoneNumberToDisplay(ref phoneNumber);


            this.Text = "Изменить данные работника";
            btnAdd.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = "+994558110081";
            string stringNumber = number.Substring(number.IndexOf('4') +1);

           txtNumber.Text = stringNumber;  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (TextBoxesError(txtName, errorProvider) && TextBoxesError(txtSurname, errorProvider) && MaskedTextNumberError(txtNumber, errorProvider) && TextBoxesError(txtPosition, errorProvider))
                {
                var connection = new SqlConnection(sqlConnection);
                connection.Open();

                try
                {

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Insert into Staff(Name,Surname,Position,Number) Values(@name,@surname,@position,@number)";

                    

                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@number", PhoneNumberToAdd(txtNumber.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Работник добавлен!");
                    this.Close();

                }
                catch (Exception exc)
                {
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
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "Update Staff Set Name = @name, Surname = @surname, Position = @position, Number = @number";
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@number", txtNumber.Text);



                }
                catch
                {

                }

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

            errorProvider.Clear();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();

        }

        private void txtNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
