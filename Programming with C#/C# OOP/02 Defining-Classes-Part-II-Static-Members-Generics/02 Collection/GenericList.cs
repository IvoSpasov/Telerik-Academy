namespace Collection
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        private const int InitialSize = 16;
        private int listIndex;
        private T[] data;

        public GenericList()
            : this(InitialSize)
        {
        }

        public GenericList(int initialSize)
        {
            this.data = new T[initialSize];
            this.listIndex = 0;
        }

        public int Count
        {
            get
            {
                return this.listIndex;
            }
        }
        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        //indexer
        public T this[int index]
        {
            get
            {
                if (index >= this.listIndex || index < 0)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return this.data[index];
            }
            set
            {
                if (index >= this.listIndex || index < 0)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                this.data[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.listIndex == this.data.Length)
            {
                AutoGrow();
            }

            this.data[this.listIndex] = element;
            this.listIndex++;
        }

        public void RemoveAt(int index)
        {
            if (index >= this.listIndex || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            for (int i = index; i < this.listIndex - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.listIndex--;
        }

        public void Insert(int index, T element)
        {
            if (index > this.listIndex || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            for (int i = this.listIndex; i > index; i--)
            {
                this.data[i] = this.data[i - 1];
            }

            this.data[index] = element;
            this.listIndex++;
        }

        public void Clear()
        {
            this.listIndex = 0;
        }

        public int IndexOf(T element)
        {
            for (int index = 0; index < this.listIndex; index++)
            {
                if (this.data[index].Equals(element))
                {
                    return index;
                }
            }

            return -1;
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            if (this.listIndex == 0)
            {
                throw new ArgumentException("The list is empty");
            }

            dynamic maxValue = this.data[0];

            for (int i = 1; i < this.listIndex; i++)
            {
                if (maxValue.CompareTo(this.data[i]) < 0)
                {
                    maxValue = data[i];
                }
            }

            return maxValue;
        }

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            if (this.listIndex == 0)
            {
                throw new ArgumentException("The list is empty");
            }

            dynamic minValue = this.data[0];

            for (int i = 1; i < this.listIndex; i++)
            {
                if (minValue.CompareTo(this.data[0]) > 0)
                {
                    minValue = data[i];
                }
            }

            return minValue;
        }

        public override string ToString()
        {
            string finalResult = null;

            if (this.listIndex != 0)
            {
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < this.listIndex; i++)
                {
                    result.Append(this.data[i] + ", ");
                }

                result.Remove(result.Length - 2, 1);

                finalResult = result.ToString();
            }
            else
            {
                finalResult = "The list is empty.";
            }

            return finalResult;
        }

        private void AutoGrow()
        {

            T[] dataCopy = new T[this.data.Length * 2];

            // I think that both lines do the same thing right? Does it matter which one I'll choose?
            //Array.Copy(this.data, this.dataCopy, this.data.Length);
            this.data.CopyTo(dataCopy, 0);

            this.data = dataCopy;
        }
    }
}
