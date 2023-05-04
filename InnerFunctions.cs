using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogForm
{
    internal class InnerFunctions
    {
        public static async Task SaveToFileAsync(string path, DataGridView dataGridView)
        {
            var file = Path.Combine(path, $"{DateTime.Now.ToString("dd-MM (HH.mm.ss) ")}.txt");
            using (TextWriter tw = new StreamWriter(file))
            {
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (!dataGridView.Columns[j].Visible) continue;
                        else
                        {
                            await tw.WriteAsync($"{dataGridView.Rows[i].Cells[j].Value.ToString(),-15}");
                        }
                    }
                    await tw.WriteAsync("\n\n");
                }

                await tw.FlushAsync();
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
        public static void StringModifier(ref string str) //modify strings
        {
            if (!(string.IsNullOrEmpty(str)))
            {
                str = str.ToLower();
                StringBuilder sb = new StringBuilder();
                sb.Append(char.ToUpper(str[0]));
                for (int i = 1; i < str.Length; i++)
                {

                    sb.Append(str[i]);
                }
                str = sb.ToString();
            }
        }
        public static void Shrinker(ref string str) // artiq boshluglari yigihsdirir
        {
            StringBuilder sb = new StringBuilder();
            bool determiner = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    ;
                    sb.Append(str[i]);
                    determiner = true;
                }
                else if ((str[i] == ' ') && (determiner))
                {
                    sb.Append(str[i]);
                    determiner = false;
                }
            }
            str = sb.ToString();
        }

        public static bool ComboBoxError(ComboBox comboBox,ErrorProvider errorProvider)
        {
            while (comboBox.SelectedItem == null)
            {
                errorProvider.SetError(comboBox, "Вы не выбрали значение");
                return false;
            }
            errorProvider.Clear();
            return true;

        }
        public static bool TextBoxesError(RichTextBox textBox, ErrorProvider errorProvider)
        {
            while (string.IsNullOrEmpty(textBox.Text))
            {

                errorProvider.SetError(textBox, "Введите значение");
                return false;

            }
            return true;
        }
        public static bool TextBoxesError(TextBox textBox, ErrorProvider errorProvider)
        {
            while (string.IsNullOrEmpty(textBox.Text))
            {

                errorProvider.SetError(textBox, "Выберите значение");
                return false;

            }
            return true;
        }
        public static bool TextBoxesError(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            while (string.IsNullOrEmpty(textBox.Text))
            {

                errorProvider.SetError(textBox, "Выберите значение");
                return false;

            }
            return true;
        }
        public static bool NumericError(NumericUpDown numericUpDown, ErrorProvider errorProvider)
        {
            while (numericUpDown.Value == 0)
            {
                errorProvider.SetError(numericUpDown, "Введите число");
                return false;

            }
            return true;
        }

        public static bool NumericsDifferenceError(NumericUpDown numericUpDown1,NumericUpDown numericUpDown2, ErrorProvider errorProvider)
        {
            while (numericUpDown1.Value > numericUpDown2.Value)
            {
                errorProvider.SetError(numericUpDown1, "Оптовая цена больше розничной");

            }
            return true;
           
        }

    }
}
