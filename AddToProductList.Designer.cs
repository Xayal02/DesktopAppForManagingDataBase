namespace LogForm
{
    partial class AddToProductList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToProductList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.nmbrOptom = new System.Windows.Forms.NumericUpDown();
            this.nmbrSale = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.txtSrok = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrOptom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя продукта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(18, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Оптовая цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Розничная цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип продукта";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Dondurulmus",
            "Teze",
            "Kaptit olunmus",
            "Diger"});
            this.cmbType.Location = new System.Drawing.Point(173, 75);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(150, 28);
            this.cmbType.TabIndex = 10;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.Value_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(18, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дополнительная информация:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 27);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.Value_Changed);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(13, 297);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(358, 74);
            this.txtNotes.TabIndex = 13;
            // 
            // nmbrOptom
            // 
            this.nmbrOptom.DecimalPlaces = 1;
            this.nmbrOptom.Location = new System.Drawing.Point(173, 124);
            this.nmbrOptom.Margin = new System.Windows.Forms.Padding(4);
            this.nmbrOptom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbrOptom.Name = "nmbrOptom";
            this.nmbrOptom.Size = new System.Drawing.Size(150, 27);
            this.nmbrOptom.TabIndex = 16;
            this.nmbrOptom.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // nmbrSale
            // 
            this.nmbrSale.DecimalPlaces = 1;
            this.nmbrSale.Location = new System.Drawing.Point(173, 164);
            this.nmbrSale.Margin = new System.Windows.Forms.Padding(4);
            this.nmbrSale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbrSale.Name = "nmbrSale";
            this.nmbrSale.Size = new System.Drawing.Size(150, 27);
            this.nmbrSale.TabIndex = 17;
            this.nmbrSale.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(18, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Срок хранения:";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "дня(ей)",
            "месяц(а)",
            "год(а)"});
            this.cmbPeriod.Location = new System.Drawing.Point(216, 211);
            this.cmbPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(107, 28);
            this.cmbPeriod.TabIndex = 19;
            this.cmbPeriod.SelectedIndexChanged += new System.EventHandler(this.Value_Changed);
            // 
            // txtSrok
            // 
            this.txtSrok.Location = new System.Drawing.Point(173, 211);
            this.txtSrok.Margin = new System.Windows.Forms.Padding(4);
            this.txtSrok.Mask = "099";
            this.txtSrok.Name = "txtSrok";
            this.txtSrok.Size = new System.Drawing.Size(35, 27);
            this.txtSrok.TabIndex = 20;
            this.txtSrok.TextChanged += new System.EventHandler(this.Value_Changed);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(394, 177);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 33);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnChange
            // 
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.Location = new System.Drawing.Point(394, 177);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(130, 36);
            this.btnChange.TabIndex = 23;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // AddToProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 394);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSrok);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmbrSale);
            this.Controls.Add(this.nmbrOptom);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddToProductList";
            this.Text = "Добавить Продукт";
            this.Load += new System.EventHandler(this.AddToProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbrOptom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.NumericUpDown nmbrOptom;
        private System.Windows.Forms.NumericUpDown nmbrSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.MaskedTextBox txtSrok;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChange;
    }
}