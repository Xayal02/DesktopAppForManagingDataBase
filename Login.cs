using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogForm.Program;

namespace LogForm
{
    public partial class Login : Form
    {
        DataUsers data = new DataUsers();

        List<User> users = new List<User>();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select Login, Password, Name from Users;";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Log = reader.GetString(0);
                    user.Password = reader.GetString(1);
                    user.Name= reader.GetString(2);

                    users.Add(user);

                }

            }

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            foreach (var user in users)
            {
                if (user.Log == txtLog.Text.Trim() && user.Password == txtPassword.Text)
                {
                    this.Hide();

                    SelectProducts selectProducts = new SelectProducts($"Приветсвую Вас, {user} ");
                    selectProducts.ShowDialog();

                    this.Close();

                }
                else
                {
                    errorProvider.SetError(txtPassword, "Пользователя с таким именем или паролем не существует");
                }

            }
        }
        private async void txtLog_TextChangedAsync(object sender, EventArgs e)
        {
            pctLog.Image = Properties.Resources.user_login_icon_14;

            foreach (var employe in users)
            {
                if (txtLog.Text.Trim() == employe.Log)
                {
                    var user = (from u in data.Users where u.Login == txtLog.Text.Trim() select u).First();
                    if (user.UserPhoto != null)
                    {
                        pctLog.Image = await BytearrayToImageAsync(user.UserPhoto.ToArray());
                    }
                }
            }
        }

        private async Task<Image> BytearrayToImageAsync(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                Image image = await Task.Run(() => Image.FromStream(stream));
                return image;
            }
        }

      
        private void chShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chShowPass.Checked ? false : true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
        public class User
        {
            public string Log { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{this.Name}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (7 / numericUpDown1.Value).ToString();
        }
    }

}
