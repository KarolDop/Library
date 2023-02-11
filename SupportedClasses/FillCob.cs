namespace Library.SupportedClasses
{
    public class FillCob<T>
    {
        public static void FillDataComboTextBox(ComboBox box ,string display, string value, List<T> data)
        {
            box.DisplayMember = display;
            box.ValueMember = value;
            box.DataSource = data;
        }
    }
}
