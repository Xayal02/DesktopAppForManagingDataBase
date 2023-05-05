namespace LogForm
{
    partial class SelectFromWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFromWarehouse));
            this.cntxtAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShow = new System.Windows.Forms.Button();
            this.chOverall = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnShowExpired = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cntxtCells = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProductList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cntxtAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.cntxtCells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cntxtAdd
            // 
            this.cntxtAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.cntxtAdd.Name = "contextMenuStrip1";
            this.cntxtAdd.Size = new System.Drawing.Size(148, 52);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.Location = new System.Drawing.Point(845, 230);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(202, 44);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Амбар";
            this.toolTip1.SetToolTip(this.btnShow, "Показывает что в данное время хранится в амбаре");
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // chOverall
            // 
            this.chOverall.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chOverall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chOverall.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chOverall.Location = new System.Drawing.Point(1067, 238);
            this.chOverall.Name = "chOverall";
            this.chOverall.Size = new System.Drawing.Size(222, 31);
            this.chOverall.TabIndex = 6;
            this.chOverall.Text = "Общее количество";
            this.chOverall.UseVisualStyleBackColor = false;
            this.chOverall.CheckedChanged += new System.EventHandler(this.chOverall_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnShowExpired
            // 
            this.btnShowExpired.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowExpired.BackColor = System.Drawing.Color.LightCoral;
            this.btnShowExpired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowExpired.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowExpired.Location = new System.Drawing.Point(845, 303);
            this.btnShowExpired.Name = "btnShowExpired";
            this.btnShowExpired.Size = new System.Drawing.Size(202, 36);
            this.btnShowExpired.TabIndex = 7;
            this.btnShowExpired.Text = "Показать список просроченных продуктов";
            this.toolTip1.SetToolTip(this.btnShowExpired, "Показывает, какие продукты не подлежат хранению");
            this.btnShowExpired.UseVisualStyleBackColor = false;
            this.btnShowExpired.Click += new System.EventHandler(this.btnShowExpired_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cmbStaff
            // 
            this.cmbStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbStaff.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(845, 458);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(328, 32);
            this.cmbStaff.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(845, 403);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(202, 31);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Отправить список:";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // cntxtCells
            // 
            this.cntxtCells.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cntxtCells.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtCells.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.вычестиToolStripMenuItem});
            this.cntxtCells.Name = "contextMenuStrip2";
            this.cntxtCells.Size = new System.Drawing.Size(159, 60);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click_1);
            // 
            // вычестиToolStripMenuItem
            // 
            this.вычестиToolStripMenuItem.Name = "вычестиToolStripMenuItem";
            this.вычестиToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.вычестиToolStripMenuItem.Text = "Вычести";
            this.вычестиToolStripMenuItem.Click += new System.EventHandler(this.вычестиToolStripMenuItem_Click_1);
            // 
            // lblProductList
            // 
            this.lblProductList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductList.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductList.Location = new System.Drawing.Point(30, -1);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(131, 39);
            this.lblProductList.TabIndex = 21;
            this.lblProductList.Text = "Ассортимент";
            this.lblProductList.Click += new System.EventHandler(this.lblProductList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cntxtAdd;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 612);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LogForm.Properties.Resources._71273bbcd166cb4c95fc0839a3cfafaf3;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.lblProductList_Click);
            // 
            // SelectFromWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1331, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProductList);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.btnShowExpired);
            this.Controls.Add(this.chOverall);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectFromWarehouse";
            this.Text = "Амбар";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectFromWarehouse_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.SelectFromWarehouse_Load);
            this.cntxtAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.cntxtCells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox chOverall;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnShowExpired;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ContextMenuStrip cntxtAdd;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntxtCells;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычестиToolStripMenuItem;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
    }
}