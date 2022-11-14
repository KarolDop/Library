namespace Library
{
    public class CustomMessageBox
    {
        public static DialogResult YesOrNoMessegeBoxInformation(string message, string title)

        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult YesOrNoMessegeBoxWarning(string message, string title)

        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }
    }
}