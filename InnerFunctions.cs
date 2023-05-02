using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogForm
{
    internal class InnerFunctions
    {
        public static void  SaveToFile(string path,DataGridView dataGridView)
        {
            var file = Path.Combine(path, $"{DateTime.Now.ToString("dd-MM (HH.mm.ss) ")}.txt");
            File.Create(file).Dispose();

            using (TextWriter tw = new StreamWriter(file))
            {

                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (!dataGridView.Columns[j].Visible) continue;
                        else
                        {
                            tw.WriteAsync($"{dataGridView.Rows[i].Cells[j].Value.ToString(),-15}");

                        }
                    }

                    tw.WriteAsync("\n\n");

                }
                //await task1;
            }
            
        }
        public static void ResetComponents(Form form)
        {
            foreach (var control in form.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = control as System.Windows.Forms.TextBox;
                    textBox.Text = null;

                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = control as NumericUpDown;
                    numericUpDown.Value = numericUpDown.Minimum;

                }
                else if (control is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox comboBox = control as System.Windows.Forms.ComboBox;
                    comboBox.SelectedItem = null;

                }
                else if (control is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = control as MaskedTextBox;
                    maskedTextBox.Text = null;
                }
                else if (control is RichTextBox)
                {
                    RichTextBox richTextBox = control as RichTextBox;
                    richTextBox.Text = null;
                }
                else if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        radioButton.Checked = false;
                    }
                }
                else if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    if (checkBox.Checked)
                    {
                        checkBox.Checked = false;
                    }
                }
                else if (control is GroupBox)
                {
                    GroupBox groupBox = control as GroupBox;
                    foreach (var group in groupBox.Controls)
                    {
                        if (group is RadioButton)
                        {
                            RadioButton radioButton = group as RadioButton;
                            if (radioButton.Checked)
                            {
                                radioButton.Checked = false;
                            }
                        }
                    }
                }

            }
        }
    }
}
