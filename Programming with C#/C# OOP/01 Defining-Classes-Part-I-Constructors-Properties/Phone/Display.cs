namespace Phone
{
    using System;

    public class Display
    {
        private readonly string size;
        private readonly string numberOfColors;

        public Display()
        {
        }

        public Display(string dispSize)
        {
            if (dispSize == string.Empty)
            {
                throw new ArgumentNullException("The size of the display can not be an empty string.");
            }

            this.size = dispSize;
        }

        public Display(string dispSize, string dispNumberOfColors)
            : this(dispSize)
        {
            if (dispNumberOfColors == string.Empty)
            {
                throw new ArgumentNullException("The number of colors of the display can not be an empty sting.");
            }

            this.numberOfColors = dispNumberOfColors;
        }

        public string Size
        {
            get { return this.size; }
        }

        public string NumberOfColors
        {
            get { return this.numberOfColors; }
        }

        public override string ToString()
        {
            string template = "Display size: {0}\nDisplay number of colors: {1}";
            string result = string.Format(template, size ?? "not available", numberOfColors ?? "not available");
            return result;
        }
    }
}
