namespace LogForm
{
    partial class MakeSize2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.NetworkProgressBar = new System.Windows.Forms.ProgressBar();
            this.DotNetCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // private async void button1_Click_1(object sender, RoutedEventArgs e)
            // 
            // NetworkProgressBar
            // 
            this.NetworkProgressBar.Location = new System.Drawing.Point(260, 323);
            this.NetworkProgressBar.Name = "NetworkProgressBar";
            this.NetworkProgressBar.Size = new System.Drawing.Size(482, 34);
            this.NetworkProgressBar.TabIndex = 1;
            // 
            // DotNetCountLabel
            // 
            this.DotNetCountLabel.AutoSize = true;
            this.DotNetCountLabel.Location = new System.Drawing.Point(514, 225);
            this.DotNetCountLabel.Name = "DotNetCountLabel";
            this.DotNetCountLabel.Size = new System.Drawing.Size(44, 16);
            this.DotNetCountLabel.TabIndex = 2;
            this.DotNetCountLabel.Text = "label1";
            // 
            // MakeSize2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.DotNetCountLabel);
            this.Controls.Add(this.NetworkProgressBar);
            this.Controls.Add(this.button1);
            this.Name = "MakeSize2";
            this.Text = "MakeSize2";
            this.MaximizedBoundsChanged += new System.EventHandler(this.MakeSize2_MaximizedBoundsChanged);
            this.MaximumSizeChanged += new System.EventHandler(this.MakeSize2_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MakeSize2_Shown);
            this.ResizeBegin += new System.EventHandler(this.MakeSize2_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.button1_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar NetworkProgressBar;
        private System.Windows.Forms.Label DotNetCountLabel;
    }
}