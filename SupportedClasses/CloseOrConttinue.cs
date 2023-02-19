namespace Library.SupportedClasses
{
    public class CloseOrContinue
    {
        public static void valid(DialogResult result, Form form, TextBox textBox = null, ComboBox comboBox = null)
        {
            if (result == DialogResult.No)
            {
                form.Close();
            }
            else
            {
                if(textBox != null)
                    textBox.Focus();
                else
                    comboBox.Focus();
            }
        }
    }
}
