namespace _01_Substring_task
{
    using System.Text;

    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder originalStr, int index, int lenght)
        {
            var result = new StringBuilder();
            result.Append(originalStr.ToString().ToCharArray(), index, lenght);
            return result;
        }
    }
}
