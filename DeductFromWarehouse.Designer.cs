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
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(109, 145);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // nmbrAmount
            // 
            this.nmbrAmount.DecimalPlaces = 3;
            this.nmbrAmount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbrAmount.Location = new System.Drawing.Point(178, 144);
            this.nmbrAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbrAmount.Name = "nmbrAmount";
            this.nmbrAmount.Size = new System.Drawing.Size(62, 22);
            this.nmbrAmount.TabIndex = 3;
            this.nmbrAmount.ValueChanged += new System.EventHandler(this.nmbrAmount_ValueChanged);
            // 
            // chAll
            // 
            this.chAll.AutoSize = true;
            this.chAll.Location = new System.Drawing.Point(246, 145);
            this.chAll.Name = "chAll";
            this.chAll.Size = new System.Drawing.Size(44, 20);
            this.chAll.TabIndex = 4;
            this.chAll.Text = "All";
            this.chAll.UseVisualStyleBackColor = true;
            this.chAll.CheckedChanged += new System.EventHandler(this.chAll_CheckedChanged);
            // 
            // Extract
            // 
            this.Extract.Image = ((System.Drawing.Image)(resources.GetObject("Extract.Image")));
            this.Extract.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Extract.Location = new System.Drawing.Point(84, 172);
            this.Extract.Name = "Extract";
            this.Extract.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Extract.Size = new System.Drawing.Size(252, 46);
            this.Extract.TabIndex = 5;
            this.Extract.Text = "Extract";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 265);
            this.Controls.Add(this.Extract);
            this.Controls.Add(this.chAll);
            this.Controls.Add(this.nmbrAmount);
            this.Controls.Add(this.lblAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeductFromWarehouse";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.nmbrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nmbrAmount;
        private System.Windows.Forms.CheckBox chAll;
        private System.Windows.Forms.Button Extract;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}