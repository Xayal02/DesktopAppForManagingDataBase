using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogForm.Program;

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
                            await tw.WriteAsync($"{dataGridView.Rows[i].Cells[j].Value.ToString(),-20}");
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
                switch (control)
                {
                    case TextBox textBox:
                        textBox.Text = null;
                        break;

                    case NumericUpDown numericUpDown:
                        numericUpDown.Value = numericUpDown.Minimum;
                        break;

                    case ComboBox comboBox:
                        comboBox.SelectedItem = null;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.Text = null;
                        break;

                    case RichTextBox richTextBox:
                        richTextBox.Text = null;
                        break;

                    case RadioButton radioButton:
                        radioButton.Checked = false;
                        break;

                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;

                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Value= DateTime.Now;
                        break;

                    case GroupBox groupBox:
                        ResetRadioButtonsAndCheckBoxes(groupBox.Controls);
                        break;
                }
            }
        }

        private static void ResetRadioButtonsAndCheckBoxes(Control.ControlCollection controls)
        {
            foreach (var control in controls)
            {
                switch (control)
                {
                    case RadioButton radioButton:
                        radioButton.Checked = false;
                        break;

                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                }
            }
        }
        public static void StringModifier(ref string str)
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
        public static bool ComboBoxError(ComboBox comboBox, ErrorProvider errorProvider)
        {
            while (comboBox.SelectedItem == null)
            {
                errorProvider.SetError(comboBox, "Выберите значение");
                return false;
            }

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
                errorProvider.SetError(textBox, "Введите значение");
                return false;
            }

            return true;
        }
        public static bool TextBoxesError(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            while (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Введите значение");
                return false;
            }

            return true;
        }
        public static bool MaskedTextNumberError(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (textBox.Text.Length != 11)
            { 
                errorProvider.SetError(textBox, "Введите действидельное  значение");
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

        public static string PhoneNumberToDisplay(ref string number)
        {
            return number.Substring(1);
        }
        public static string PhoneNumberToAdd(string number)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0");

            foreach (char c in number)
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static void PhoneNumberFixer( ref string number) //erase ( )
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    sb.Append(number[i]);
                }
            }
             number= sb.ToString();
        }

        public static string PhoneNumberToSendAsLink(ref string number) 
        {
            number.Substring(1); //for deleting zero

            number = "+994" + number;

            return number;
        }
           
        public static void LogException(Exception exc)
        {
            File.AppendAllText(pathToLogs, DateTime.Now.ToString() + '\n' + $"Message: {exc.Message}" + '\n' + '\n' + $"Source:{exc.Source}" + '\n' + '\n' + $"StackTrace: {exc.StackTrace}" + '\n' + '\n' + '\n');

        }

    }
}
