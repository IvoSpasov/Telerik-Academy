namespace _01_Substring_task
{
    using System;
    using System.Text;

    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder originalStr, int index, int length)
        {
            if (index >= originalStr.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            int endIndex = index + length;

            if (endIndex > originalStr.Length)
            {
                throw new IndexOutOfRangeException("Index and length must refer to a location within the string.");
            }

            var result = new StringBuilder();
            result.Append(originalStr.ToString(), index, length);
            return result;
        }

        // second variant
        //public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        //{
        //    if (index >= originalStr.Length || index < 0)
        //    {
        //        throw new IndexOutOfRangeException("Invalid index");
        //    }
        //    int endIndex = index + length;

        //    if (endIndex > builder.Length)
        //    {
        //        throw new IndexOutOfRangeException("Index and length must refer to a location within the string.");
        //    }

        //    StringBuilder result = new StringBuilder();

        //    for (int i = index; i < endIndex; i++)
        //    {
        //        result.Append(builder[i]);
        //    }

        //    return result;
        //}

        public static StringBuilder Substring(this StringBuilder builder, int index)
        {
            int length = builder.Length - index;

            return Substring(builder, index, length);
        }
    }
}
