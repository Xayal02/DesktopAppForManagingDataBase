namespace LogForm
{
    partial class UnavailableProducts
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
            this.dataUnavailableProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataUnavailableProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataUnavailableProducts
            // 
            this.dataUnavailableProducts.AllowUserToAddRows = false;
            this.dataUnavailableProducts.AllowUserToDeleteRows = false;
            this.dataUnavailableProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUnavailableProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataUnavailableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUnavailableProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUnavailableProducts.Location = new System.Drawing.Point(0, 0);
            this.dataUnavailableProducts.MultiSelect = false;
            this.dataUnavailableProducts.Name = "dataUnavailableProducts";
            this.dataUnavailableProducts.ReadOnly = true;
            this.dataUnavailableProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataUnavailableProducts.RowTemplate.Height = 24;
            this.dataUnavailableProducts.Size = new System.Drawing.Size(1135, 554);
            this.dataUnavailableProducts.TabIndex = 0;
            this.dataUnavailableProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUnavailableProducts_CellClick);
            this.dataUnavailableProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUnavailableProducts_CellClick);
            this.dataUnavailableProducts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUnavailableProducts_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 52);
            // 
            // вернутьToolStripMenuItem
            // 
            this.вернутьToolStripMenuItem.Name = "вернутьToolStripMenuItem";
            this.вернутьToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.вернутьToolStripMenuItem.Text = "Восстановить";
            this.вернутьToolStripMenuItem.Click += new System.EventHandler(this.вернутьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // UnavailableProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 554);
            this.Controls.Add(this.dataUnavailableProducts);
            this.Name = "UnavailableProducts";
            this.Text = "UnavailableProducts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnavailableProducts_FormClosing);
            this.Load += new System.EventHandler(this.UnavailableProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUnavailableProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUnavailableProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}