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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProducts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrMax)).BeginInit();
            this.Цена.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 682);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.Location = new System.Drawing.Point(963, 430);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(254, 48);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Показать список";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(993, 505);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(292, 48);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Отправить список";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1291, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "+994";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Location = new System.Drawing.Point(1345, 514);
            this.txtNumber.Mask = "(00)0000000";
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(180, 30);
            this.txtNumber.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.groupBox1.Controls.Add(this.allRBtn);
            this.groupBox1.Controls.Add(this.smokedRBtn);
            this.groupBox1.Controls.Add(this.frozenRBtn);
            this.groupBox1.Controls.Add(this.otherRBtn);
            this.groupBox1.Controls.Add(this.freshRBtn);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(957, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 209);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид:";
            // 
            // allRBtn
            // 
            this.allRBtn.AutoSize = true;
            this.allRBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allRBtn.Location = new System.Drawing.Point(6, 23);
            this.allRBtn.Name = "allRBtn";
            this.allRBtn.Size = new System.Drawing.Size(63, 28);
            this.allRBtn.TabIndex = 4;
            this.allRBtn.TabStop = true;
            this.allRBtn.Text = "Все";
            this.allRBtn.UseVisualStyleBackColor = true;
            this.allRBtn.CheckedChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // smokedRBtn
            // 
            this.smokedRBtn.AutoSize = true;
            this.smokedRBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smokedRBtn.Location = new System.Drawing.Point(6, 127);
            this.smokedRBtn.Name = "smokedRBtn";
            this.smokedRBtn.Size = new System.Drawing.Size(125, 28);
            this.smokedRBtn.TabIndex = 3;
            this.smokedRBtn.TabStop = true;
            this.smokedRBtn.Text = "Капченые";
            this.smokedRBtn.UseVisualStyleBackColor = true;
            this.smokedRBtn.CheckedChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // frozenRBtn
            // 
            this.frozenRBtn.AutoSize = true;
            this.frozenRBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frozenRBtn.Location = new System.Drawing.Point(6, 92);
            this.frozenRBtn.Name = "frozenRBtn";
            this.frozenRBtn.Size = new System.Drawing.Size(175, 28);
            this.frozenRBtn.TabIndex = 2;
            this.frozenRBtn.TabStop = true;
            this.frozenRBtn.Text = "Замороженные";
            this.frozenRBtn.UseVisualStyleBackColor = true;
            this.frozenRBtn.CheckedChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // otherRBtn
            // 
            this.otherRBtn.AutoSize = true;
            this.otherRBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherRBtn.Location = new System.Drawing.Point(6, 161);
            this.otherRBtn.Name = "otherRBtn";
            this.otherRBtn.Size = new System.Drawing.Size(96, 28);
            this.otherRBtn.TabIndex = 1;
            this.otherRBtn.TabStop = true;
            this.otherRBtn.Text = "Другое";
            this.otherRBtn.UseVisualStyleBackColor = true;
            this.otherRBtn.CheckedChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // freshRBtn
            // 
            this.freshRBtn.AutoSize = true;
            this.freshRBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freshRBtn.Location = new System.Drawing.Point(6, 58);
            this.freshRBtn.Name = "freshRBtn";
            this.freshRBtn.Size = new System.Drawing.Size(102, 28);
            this.freshRBtn.TabIndex = 0;
            this.freshRBtn.TabStop = true;
            this.freshRBtn.Text = "Свежие";
            this.freshRBtn.UseVisualStyleBackColor = true;
            this.freshRBtn.CheckedChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // chCurrent
            // 
            this.chCurrent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chCurrent.AutoSize = true;
            this.chCurrent.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chCurrent.Location = new System.Drawing.Point(32, 17);
            this.chCurrent.Name = "chCurrent";
            this.chCurrent.Size = new System.Drawing.Size(247, 28);
            this.chCurrent.TabIndex = 9;
            this.chCurrent.Text = "Имеющиеся в наличии";
            this.chCurrent.UseVisualStyleBackColor = true;
            this.chCurrent.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1545, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.списокНедоступныхToolStripMenuItem});
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.продуктToolStripMenuItem.Text = "Продукт";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(267, 30);
            this.добавитьToolStripMenuItem.Text = "Добавить новый";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // списокНедоступныхToolStripMenuItem
            // 
            this.списокНедоступныхToolStripMenuItem.Name = "списокНедоступныхToolStripMenuItem";
            this.списокНедоступныхToolStripMenuItem.Size = new System.Drawing.Size(267, 30);
            this.списокНедоступныхToolStripMenuItem.Text = "Список недоступных";
            this.списокНедоступныхToolStripMenuItem.Click += new System.EventHandler(this.списокНедоступныхToolStripMenuItem_Click);
            // 
            // nmbrMin
            // 
            this.nmbrMin.DecimalPlaces = 2;
            this.nmbrMin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmbrMin.Location = new System.Drawing.Point(56, 30);
            this.nmbrMin.Name = "nmbrMin";
            this.nmbrMin.Size = new System.Drawing.Size(81, 30);
            this.nmbrMin.TabIndex = 11;
            this.nmbrMin.ValueChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // nmbrMax
            // 
            this.nmbrMax.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmbrMax.Location = new System.Drawing.Point(56, 73);
            this.nmbrMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbrMax.Name = "nmbrMax";
            this.nmbrMax.Size = new System.Drawing.Size(81, 30);
            this.nmbrMax.TabIndex = 12;
            this.nmbrMax.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmbrMax.ValueChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // Цена
            // 
            this.Цена.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Цена.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.Цена.Controls.Add(this.label3);
            this.Цена.Controls.Add(this.label2);
            this.Цена.Controls.Add(this.nmbrMin);
            this.Цена.Controls.Add(this.nmbrMax);
            this.Цена.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Цена.Location = new System.Drawing.Point(1388, 118);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(163, 108);
            this.Цена.TabIndex = 13;
            this.Цена.TabStop = false;
            this.Цена.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "От:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.groupBox2.Controls.Add(this.optomRBtn);
            this.groupBox2.Controls.Add(this.saleRBtn);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(1170, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 108);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Продажа";
            // 
            // optomRBtn
            // 
            this.optomRBtn.AutoSize = true;
            this.optomRBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optomRBtn.Location = new System.Drawing.Point(6, 26);
            this.optomRBtn.Name = "optomRBtn";
            this.optomRBtn.Size = new System.Drawing.Size(109, 28);
            this.optomRBtn.TabIndex = 15;
            this.optomRBtn.TabStop = true;
            this.optomRBtn.Text = "Оптовая";
            this.optomRBtn.UseVisualStyleBackColor = true;
            this.optomRBtn.CheckedChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // saleRBtn
            // 
            this.saleRBtn.AutoSize = true;
            this.saleRBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleRBtn.Location = new System.Drawing.Point(6, 58);
            this.saleRBtn.Name = "saleRBtn";
            this.saleRBtn.Size = new System.Drawing.Size(131, 28);
            this.saleRBtn.TabIndex = 16;
            this.saleRBtn.TabStop = true;
            this.saleRBtn.Text = "Розничная";
            this.saleRBtn.UseVisualStyleBackColor = true;
            this.saleRBtn.CheckedChanged += new System.EventHandler(this.btnShow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(1288, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(237, 48);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Очистить фильтр";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chOverall
            // 
            this.chOverall.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chOverall.AutoSize = true;
            this.chOverall.Enabled = false;
            this.chOverall.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chOverall.Location = new System.Drawing.Point(32, 48);
            this.chOverall.Name = "chOverall";
            this.chOverall.Size = new System.Drawing.Size(97, 28);
            this.chOverall.TabIndex = 18;
            this.chOverall.Text = "Сумма";
            this.chOverall.UseVisualStyleBackColor = true;
            this.chOverall.CheckedChanged += new System.EventHandler(this.btnShow_Click);
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
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.groupBox3.Controls.Add(this.chCurrent);
            this.groupBox3.Controls.Add(this.chOverall);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1170, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 82);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWarehouse.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblWarehouse.Location = new System.Drawing.Point(1417, 5);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(80, 27);
            this.lblWarehouse.TabIndex = 18;
            this.lblWarehouse.Text = "Амбар";
            this.lblWarehouse.Click += new System.EventHandler(this.lblWarehouse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::LogForm.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(1503, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lblWarehouse_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtProductName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductName.Location = new System.Drawing.Point(989, 67);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 30);
            this.txtProductName.TabIndex = 23;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::LogForm.Properties.Resources.Снимок_экрана_2023_05_12_220132;
            this.pictureBox1.Location = new System.Drawing.Point(950, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // SelectProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::LogForm.Properties.Resources.photo_1518837695005_2083093ee35b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1545, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Цена);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectProducts";
            this.Text = " Ассортимент";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectProducts_FormClosing);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNumber;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}