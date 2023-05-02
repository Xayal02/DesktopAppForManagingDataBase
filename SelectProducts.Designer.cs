namespace LogForm
{
    partial class SelectProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProducts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allRBtn = new System.Windows.Forms.RadioButton();
            this.smokedRBtn = new System.Windows.Forms.RadioButton();
            this.frozenRBtn = new System.Windows.Forms.RadioButton();
            this.otherRBtn = new System.Windows.Forms.RadioButton();
            this.freshRBtn = new System.Windows.Forms.RadioButton();
            this.chCurrent = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокНедоступныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nmbrMin = new System.Windows.Forms.NumericUpDown();
            this.nmbrMax = new System.Windows.Forms.NumericUpDown();
            this.Цена = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optomRBtn = new System.Windows.Forms.RadioButton();
            this.saleRBtn = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.chOverall = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.убратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMax)).BeginInit();
            this.Цена.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 584);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Location = new System.Drawing.Point(903, 427);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 48);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Location = new System.Drawing.Point(903, 481);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 48);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send as file";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "+994";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maskedTextBox1.Location = new System.Drawing.Point(1074, 494);
            this.maskedTextBox1.Mask = "(00)0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.allRBtn);
            this.groupBox1.Controls.Add(this.smokedRBtn);
            this.groupBox1.Controls.Add(this.frozenRBtn);
            this.groupBox1.Controls.Add(this.otherRBtn);
            this.groupBox1.Controls.Add(this.freshRBtn);
            this.groupBox1.Location = new System.Drawing.Point(893, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 156);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид:";
            // 
            // allRBtn
            // 
            this.allRBtn.AutoSize = true;
            this.allRBtn.Location = new System.Drawing.Point(6, 23);
            this.allRBtn.Name = "allRBtn";
            this.allRBtn.Size = new System.Drawing.Size(52, 20);
            this.allRBtn.TabIndex = 4;
            this.allRBtn.TabStop = true;
            this.allRBtn.Text = "Все";
            this.allRBtn.UseVisualStyleBackColor = true;
            this.allRBtn.CheckedChanged += new System.EventHandler(this.allRBtn_CheckedChanged);
            // 
            // smokedRBtn
            // 
            this.smokedRBtn.AutoSize = true;
            this.smokedRBtn.Location = new System.Drawing.Point(6, 101);
            this.smokedRBtn.Name = "smokedRBtn";
            this.smokedRBtn.Size = new System.Drawing.Size(93, 20);
            this.smokedRBtn.TabIndex = 3;
            this.smokedRBtn.TabStop = true;
            this.smokedRBtn.Text = "Капченые";
            this.smokedRBtn.UseVisualStyleBackColor = true;
            this.smokedRBtn.CheckedChanged += new System.EventHandler(this.smokedRBtn_CheckedChanged);
            // 
            // frozenRBtn
            // 
            this.frozenRBtn.AutoSize = true;
            this.frozenRBtn.Location = new System.Drawing.Point(6, 75);
            this.frozenRBtn.Name = "frozenRBtn";
            this.frozenRBtn.Size = new System.Drawing.Size(128, 20);
            this.frozenRBtn.TabIndex = 2;
            this.frozenRBtn.TabStop = true;
            this.frozenRBtn.Text = "Замороженные";
            this.frozenRBtn.UseVisualStyleBackColor = true;
            this.frozenRBtn.CheckedChanged += new System.EventHandler(this.frozenRBtn_CheckedChanged);
            // 
            // otherRBtn
            // 
            this.otherRBtn.AutoSize = true;
            this.otherRBtn.Location = new System.Drawing.Point(6, 127);
            this.otherRBtn.Name = "otherRBtn";
            this.otherRBtn.Size = new System.Drawing.Size(75, 20);
            this.otherRBtn.TabIndex = 1;
            this.otherRBtn.TabStop = true;
            this.otherRBtn.Text = "Другое";
            this.otherRBtn.UseVisualStyleBackColor = true;
            this.otherRBtn.CheckedChanged += new System.EventHandler(this.otherRBtn_CheckedChanged);
            // 
            // freshRBtn
            // 
            this.freshRBtn.AutoSize = true;
            this.freshRBtn.Location = new System.Drawing.Point(6, 49);
            this.freshRBtn.Name = "freshRBtn";
            this.freshRBtn.Size = new System.Drawing.Size(78, 20);
            this.freshRBtn.TabIndex = 0;
            this.freshRBtn.TabStop = true;
            this.freshRBtn.Text = "Свежие";
            this.freshRBtn.UseVisualStyleBackColor = true;
            this.freshRBtn.CheckedChanged += new System.EventHandler(this.freshRBtn_CheckedChanged);
            // 
            // chCurrent
            // 
            this.chCurrent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chCurrent.AutoSize = true;
            this.chCurrent.Location = new System.Drawing.Point(1173, 300);
            this.chCurrent.Name = "chCurrent";
            this.chCurrent.Size = new System.Drawing.Size(175, 20);
            this.chCurrent.TabIndex = 9;
            this.chCurrent.Text = "Имеющиеся в наличии";
            this.chCurrent.UseVisualStyleBackColor = true;
            this.chCurrent.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктToolStripMenuItem,
            this.ценаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.списокНедоступныхToolStripMenuItem});
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.продуктToolStripMenuItem.Text = "Продукт";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить новый";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // списокНедоступныхToolStripMenuItem
            // 
            this.списокНедоступныхToolStripMenuItem.Name = "списокНедоступныхToolStripMenuItem";
            this.списокНедоступныхToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.списокНедоступныхToolStripMenuItem.Text = "Список недоступных";
            this.списокНедоступныхToolStripMenuItem.Click += new System.EventHandler(this.списокНедоступныхToolStripMenuItem_Click);
            // 
            // ценаToolStripMenuItem
            // 
            this.ценаToolStripMenuItem.Name = "ценаToolStripMenuItem";
            this.ценаToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.ценаToolStripMenuItem.Text = "Цена";
            // 
            // nmbrMin
            // 
            this.nmbrMin.DecimalPlaces = 2;
            this.nmbrMin.Location = new System.Drawing.Point(56, 22);
            this.nmbrMin.Name = "nmbrMin";
            this.nmbrMin.Size = new System.Drawing.Size(69, 22);
            this.nmbrMin.TabIndex = 11;
            this.nmbrMin.ValueChanged += new System.EventHandler(this.nmbrMin_ValueChanged);
            // 
            // nmbrMax
            // 
            this.nmbrMax.Location = new System.Drawing.Point(56, 58);
            this.nmbrMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbrMax.Name = "nmbrMax";
            this.nmbrMax.Size = new System.Drawing.Size(69, 22);
            this.nmbrMax.TabIndex = 12;
            this.nmbrMax.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmbrMax.ValueChanged += new System.EventHandler(this.nmbrMax_ValueChanged);
            // 
            // Цена
            // 
            this.Цена.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Цена.Controls.Add(this.label3);
            this.Цена.Controls.Add(this.label2);
            this.Цена.Controls.Add(this.nmbrMin);
            this.Цена.Controls.Add(this.nmbrMax);
            this.Цена.Location = new System.Drawing.Point(893, 282);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(163, 109);
            this.Цена.TabIndex = 13;
            this.Цена.TabStop = false;
            this.Цена.Text = "Цена";
            this.Цена.Enter += new System.EventHandler(this.Цена_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "От:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.optomRBtn);
            this.groupBox2.Controls.Add(this.saleRBtn);
            this.groupBox2.Location = new System.Drawing.Point(1165, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 75);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Продажа";
            // 
            // optomRBtn
            // 
            this.optomRBtn.AutoSize = true;
            this.optomRBtn.Location = new System.Drawing.Point(8, 21);
            this.optomRBtn.Name = "optomRBtn";
            this.optomRBtn.Size = new System.Drawing.Size(84, 20);
            this.optomRBtn.TabIndex = 15;
            this.optomRBtn.TabStop = true;
            this.optomRBtn.Text = "Оптовая";
            this.optomRBtn.UseVisualStyleBackColor = true;
            this.optomRBtn.CheckedChanged += new System.EventHandler(this.optomRBtn_CheckedChanged);
            // 
            // saleRBtn
            // 
            this.saleRBtn.AutoSize = true;
            this.saleRBtn.Location = new System.Drawing.Point(8, 45);
            this.saleRBtn.Name = "saleRBtn";
            this.saleRBtn.Size = new System.Drawing.Size(100, 20);
            this.saleRBtn.TabIndex = 16;
            this.saleRBtn.TabStop = true;
            this.saleRBtn.Text = "Розничная";
            this.saleRBtn.UseVisualStyleBackColor = true;
            this.saleRBtn.CheckedChanged += new System.EventHandler(this.saleRBtn_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.Location = new System.Drawing.Point(1165, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 50);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chOverall
            // 
            this.chOverall.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chOverall.AutoSize = true;
            this.chOverall.Enabled = false;
            this.chOverall.Location = new System.Drawing.Point(1175, 345);
            this.chOverall.Name = "chOverall";
            this.chOverall.Size = new System.Drawing.Size(72, 20);
            this.chOverall.TabIndex = 18;
            this.chOverall.Text = "Сумма";
            this.chOverall.UseVisualStyleBackColor = true;
            this.chOverall.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.убратьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 76);
            // 
            // убратьToolStripMenuItem
            // 
            this.убратьToolStripMenuItem.Name = "убратьToolStripMenuItem";
            this.убратьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.убратьToolStripMenuItem.Text = "Убрать";
            this.убратьToolStripMenuItem.Click += new System.EventHandler(this.убратьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // SelectProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 641);
            this.Controls.Add(this.chOverall);
            this.Controls.Add(this.chCurrent);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Цена);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectProducts";
            this.Text = " ";
            this.Load += new System.EventHandler(this.SelectProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMax)).EndInit();
            this.Цена.ResumeLayout(false);
            this.Цена.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton smokedRBtn;
        private System.Windows.Forms.RadioButton frozenRBtn;
        private System.Windows.Forms.RadioButton otherRBtn;
        private System.Windows.Forms.CheckBox chCurrent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem продуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nmbrMin;
        private System.Windows.Forms.NumericUpDown nmbrMax;
        private System.Windows.Forms.GroupBox Цена;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ценаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton allRBtn;
        private System.Windows.Forms.RadioButton freshRBtn;
        private System.Windows.Forms.RadioButton optomRBtn;
        private System.Windows.Forms.RadioButton saleRBtn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chOverall;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem убратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокНедоступныхToolStripMenuItem;
    }
}