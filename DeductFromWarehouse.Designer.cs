namespace LogForm
{
    partial class DeductFromWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeductFromWarehouse));
            this.lblAmount = new System.Windows.Forms.Label();
            this.nmbrAmount = new System.Windows.Forms.NumericUpDown();
            this.chAll = new System.Windows.Forms.CheckBox();
            this.Extract = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmbrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmount.Location = new System.Drawing.Point(61, 67);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(120, 27);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Количество";
            // 
            // nmbrAmount
            // 
            this.nmbrAmount.DecimalPlaces = 3;
            this.nmbrAmount.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmbrAmount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbrAmount.Location = new System.Drawing.Point(201, 67);
            this.nmbrAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nmbrAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbrAmount.Name = "nmbrAmount";
            this.nmbrAmount.Size = new System.Drawing.Size(108, 28);
            this.nmbrAmount.TabIndex = 3;
            this.nmbrAmount.ValueChanged += new System.EventHandler(this.nmbrAmount_ValueChanged);
            // 
            // chAll
            // 
            this.chAll.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chAll.Location = new System.Drawing.Point(333, 65);
            this.chAll.Margin = new System.Windows.Forms.Padding(4);
            this.chAll.Name = "chAll";
            this.chAll.Size = new System.Drawing.Size(90, 28);
            this.chAll.TabIndex = 4;
            this.chAll.Text = "Всё";
            this.chAll.UseVisualStyleBackColor = true;
            this.chAll.CheckedChanged += new System.EventHandler(this.chAll_CheckedChanged);
            // 
            // Extract
            // 
            this.Extract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Extract.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Extract.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Extract.Location = new System.Drawing.Point(54, 107);
            this.Extract.Margin = new System.Windows.Forms.Padding(4);
            this.Extract.Name = "Extract";
            this.Extract.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Extract.Size = new System.Drawing.Size(369, 58);
            this.Extract.TabIndex = 5;
            this.Extract.Text = "Вычесть";
            this.Extract.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Extract.UseVisualStyleBackColor = true;
            this.Extract.Click += new System.EventHandler(this.Extract_Click2);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeductFromWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogForm.Properties.Resources.загрузка;
            this.ClientSize = new System.Drawing.Size(486, 227);
            this.Controls.Add(this.Extract);
            this.Controls.Add(this.chAll);
            this.Controls.Add(this.nmbrAmount);
            this.Controls.Add(this.lblAmount);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeductFromWarehouse";
            this.Text = "Вычести продукцию";
            this.Load += new System.EventHandler(this.DeductFromWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nmbrAmount;
        private System.Windows.Forms.CheckBox chAll;
        private System.Windows.Forms.Button Extract;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}