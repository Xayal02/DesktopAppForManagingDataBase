namespace LogForm
{
    partial class Login
    {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctPasswordIcon = new System.Windows.Forms.PictureBox();
            this.pctLogIcon = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.chShowPass = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pctLog = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLog.Location = new System.Drawing.Point(349, 272);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(220, 30);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChangedAsync);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pctPasswordIcon);
            this.panel1.Controls.Add(this.pctLogIcon);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.chShowPass);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.pctLog);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Location = new System.Drawing.Point(30, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 552);
            this.panel1.TabIndex = 3;
            // 
            // pctPasswordIcon
            // 
            this.pctPasswordIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("pctPasswordIcon.Image")));
            this.pctPasswordIcon.Location = new System.Drawing.Point(290, 318);
            this.pctPasswordIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pctPasswordIcon.Name = "pctPasswordIcon";
            this.pctPasswordIcon.Size = new System.Drawing.Size(52, 39);
            this.pctPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPasswordIcon.TabIndex = 7;
            this.pctPasswordIcon.TabStop = false;
            // 
            // pctLogIcon
            // 
            this.pctLogIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctLogIcon.Image = ((System.Drawing.Image)(resources.GetObject("pctLogIcon.Image")));
            this.pctLogIcon.Location = new System.Drawing.Point(289, 263);
            this.pctLogIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pctLogIcon.Name = "pctLogIcon";
            this.pctLogIcon.Size = new System.Drawing.Size(52, 39);
            this.pctLogIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogIcon.TabIndex = 6;
            this.pctLogIcon.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.Location = new System.Drawing.Point(336, 380);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(233, 69);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Войти";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // chShowPass
            // 
            this.chShowPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chShowPass.AutoSize = true;
            this.chShowPass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chShowPass.Location = new System.Drawing.Point(586, 329);
            this.chShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.chShowPass.Name = "chShowPass";
            this.chShowPass.Size = new System.Drawing.Size(204, 28);
            this.chShowPass.TabIndex = 4;
            this.chShowPass.Text = "Показать Пароль";
            this.chShowPass.UseVisualStyleBackColor = true;
            this.chShowPass.CheckedChanged += new System.EventHandler(this.chShowPass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(351, 327);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // pctLog
            // 
            this.pctLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctLog.Location = new System.Drawing.Point(367, 91);
            this.pctLog.Margin = new System.Windows.Forms.Padding(4);
            this.pctLog.Name = "pctLog";
            this.pctLog.Size = new System.Drawing.Size(156, 138);
            this.pctLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLog.TabIndex = 2;
            this.pctLog.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(982, 721);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = " Вход";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.PictureBox pctLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chShowPass;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pctPasswordIcon;
        private System.Windows.Forms.PictureBox pctLogIcon;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

