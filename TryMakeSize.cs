using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogForm
{
    public partial class TryMakeSize : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle formOriginalRectangle;
        public TryMakeSize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stringPath = Directory.GetCurrentDirectory();

            var pathToLogs = stringPath.Remove(stringPath.IndexOf("bin")) + "Logs\\Log.txt" ;



            File.AppendAllText(pathToLogs, "Hi");

            MessageBox.Show("Success");


            //txtbtn.Text = buttonOriginalRectangle.ToString();

        }

        private void TryMakeSize_Load(object sender, EventArgs e)
        {
            formOriginalRectangle = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            buttonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
        }

        private void ResizeControl(Rectangle rectangle, Control control)
        {
            //float differenceX = (float)(this.Width / formOriginalRectangle.Width);
            //float differenceY = (float)(this.Height / formOriginalRectangle.Height);

            //int newX = (int)(control.Location.X * differenceX);
            //int newY = (int)(control.Location.Y * differenceY);

            //int newWidth= (int)(control.Width * differenceX);
            //int newHeight= (int)(control.Height * differenceY);

            //control.Location = new Point(newX, newY);
            //control.Size = new Size(newWidth, newHeight);


        }

        private void TryMakeSize_Resize(object sender, EventArgs e)
        {
            ResizeControl(buttonOriginalRectangle, button1);
        }
    }
}
