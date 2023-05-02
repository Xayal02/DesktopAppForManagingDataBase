using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LogForm
{
    public partial class MakeSize2 : Form
    {
        Rectangle initialFormSize;
        Rectangle initialButtonSize;
        private readonly HttpClient _httpClient = new HttpClient();


        public MakeSize2()
        {

            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private async void OnSeeTheDotNetsButtonClick(object sender, RoutedEventArgs e)
        {
            // Capture the task handle here so we can await the background task later.
            var getDotNetFoundationHtmlTask = _httpClient.GetStringAsync("https://dotnetfoundation.org");

            // Any other work on the UI thread can be done here, such as enabling a Progress Bar.
            // This is important to do here, before the "await" call, so that the user
            // sees the progress bar before execution of this method is yielded.
            NetworkProgressBar.Enabled = true;
            NetworkProgressBar.Visible = true;

            // The await operator suspends OnSeeTheDotNetsButtonClick(), returning control to its caller.
            // This is what allows the app to be responsive and not block the UI thread.
            var html = await getDotNetFoundationHtmlTask;
            int count = Regex.Matches(html, @"\.NET").Count;

            DotNetCountLabel.Text = $"Number of .NETs on dotnetfoundation.org: {count}";

            NetworkProgressBar.Enabled = false;
            NetworkProgressBar.Visible = false;
        }

        private async void button1_Click_1(object sender, EventHandler e)
        {
            var getDotNetFoundationHtmlTask = _httpClient.GetStringAsync("https://dotnetfoundation.org");

            // Any other work on the UI thread can be done here, such as enabling a Progress Bar.
            // This is important to do here, before the "await" call, so that the user
            // sees the progress bar before execution of this method is yielded.
            NetworkProgressBar.Enabled = true;
            NetworkProgressBar.Visible = true;

            // The await operator suspends OnSeeTheDotNetsButtonClick(), returning control to its caller.
            // This is what allows the app to be responsive and not block the UI thread.
            var html = await getDotNetFoundationHtmlTask;
            int count = Regex.Matches(html, @"\.NET").Count;

            DotNetCountLabel.Text = $"Number of .NETs on dotnetfoundation.org: {count}";

            NetworkProgressBar.Enabled = false;
            NetworkProgressBar.Visible = false;
        }

        private void resizeControl(Rectangle r, Control c)
        {
            //if (initialFormSize.Width != 0 && initialFormSize.Height != 0)
            //{
            //    float differenceX = (float)(this.Width / initialFormSize.Width);
            //    float differenceY = (float)(this.Height / initialFormSize.Height);

            //    int newX = (int)(c.Width * differenceX);
            //    int newY = (int)(c.Height * differenceY);

            //    int newWidth = (int)(c.Width * differenceX);
            //    int newHeight = (int)(c.Height * differenceY);

            //    c.Location = new Point(newX, newY);
            //    c.Size = new Size(newWidth, newHeight);
            //}
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //resizeControl(initialButtonSize, button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MakeSize2_Shown(object sender, EventArgs e)
        {
        }

        private void MakeSize2_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void MakeSize2_MaximumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");
        }

        private void MakeSize2_ResizeBegin(object sender, EventArgs e)
        {
            //initialFormSize = new Rectangle(this.Location.X,this.Location.Y, this.Width,this.Height);
            //initialButtonSize = new Rectangle(button1.Location.X, Location.Y, button1.Width, button1.Height);
        }

      
    }
}