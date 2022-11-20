namespace Library.SupportedClasses
{
    public class EmptyField
    {
        public static (string , bool)  EmptyFieldMessage(string[] message, bool[] check)
        {
            var returnMesage = "";
            var emptyAnyField = false;

            for (int i = 0; i < check.Length; i++)
            {
                if (check[i])
                {
                    returnMesage += message[i];
                    emptyAnyField = true;
                }
            }

            return (returnMesage, emptyAnyField);
        }
    }
}
