namespace LogForm
{
    partial class RusSpeechRecognizer
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
            this.lff = new System.Windows.Forms.Label();
            this.txtSpeech = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lff
            // 
            this.lff.AutoSize = true;
            this.lff.Location = new System.Drawing.Point(295, 50);
            this.lff.Name = "lff";
            this.lff.Size = new System.Drawing.Size(44, 16);
            this.lff.TabIndex = 0;
            this.lff.Text = "label1";
            // 
            // txtSpeech
            // 
            this.txtSpeech.Location = new System.Drawing.Point(152, 123);
            this.txtSpeech.Name = "txtSpeech";
            this.txtSpeech.Size = new System.Drawing.Size(130, 22);
            this.txtSpeech.TabIndex = 1;
            // 
            // RusSpeechRecognizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSpeech);
            this.Controls.Add(this.lff);
            this.Name = "RusSpeechRecognizer";
            this.Text = "RusSpeechRecognizer";
            this.Load += new System.EventHandler(this.RusSpeechRecognizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lff;
        private System.Windows.Forms.TextBox txtSpeech;
    }
}