using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static LogForm.Program;

namespace LogForm
{
    public partial class Login : Form
    {
        private Rectangle panelOriginalS;
        private Rectangle formOrigianlS;

        DataUsers data = new DataUsers();

        List<Employee> employees = new List<Employee>();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            using (var connection = new SqlConnection(sqlConnection))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "Select Login, Password from Users;";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Log = reader.GetString(0);
                    employee.Password = reader.GetString(1);

                    employees.Add(employee);

                }

            }

        }

        //private void SizeDeterminer(Rectangle rectangle, Control control)
        //{
        //    float differenceX = (float)(this.Width / formOrigianlS.Width);
        //    float differenceY = (float)(this.Height / formOrigianlS.Height);

        //    int newX = (int)(control.Location.X * differenceX);
        //    int newY = (int)(control.Location.Y * differenceY);

        //    int newWidth = (int)(control.Width * differenceX);
        //    int newHeight = (int)(control.Height * differenceY);

        //    control.Location = new Point(newX, newY);
        //    control.Size = new Size(newWidth, newHeight);
        //}

        private void Login_Resize(object sender, EventArgs e)
        {
            //SizeDeterminer(panelOriginalS, panel1);
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            foreach (var employe in employees)
            {
                if (employe.Log == txtLog.Text.Trim() && employe.Password == txtPassword.Text)
                {
                    this.Hide();

                    SelectFromWarehouse form2 = new SelectFromWarehouse();
                    form2.ShowDialog();

                }

            }

        }
        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            pctLog.Image = Properties.Resources.user_login_icon_14;

            foreach (var employe in employees)
            {
                if (txtLog.Text.Trim() == employe.Log)
                {
                    var user = (from u in data.Users where u.Login == txtLog.Text.Trim() select u).First();
                    if (user.UserPhoto != null)
                    {
                        pctLog.Image = BytearrayToImage(user.UserPhoto.ToArray());

                    }
                }
            }
        }
        private Image BytearrayToImage(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                Image image = Image.FromStream(stream);

                return image;

            }
        }
        private void chShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPass.Checked)
            {

                txtPassword.UseSystemPasswordChar = false;

            }

            else txtPassword.UseSystemPasswordChar = true;

        }

       
    }
    public class Employee
    {
        public string Log { get; set; }
        public string Password { get; set; }
    }

}
