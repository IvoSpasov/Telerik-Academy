namespace _05.Task_bit_array
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BitArray64 : IEnumerable<ulong>
    {
        public ulong[] arrayOfValues { get; set; }


        // implementing IEnumerable
        public IEnumerator<ulong> GetEnumerator()
        {
            for (int i = 0; i < this.arrayOfValues.Length; i++)
            {
                yield return this.arrayOfValues[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //implementing indexer
        public ulong this[int index]
        {
            get
            {
                return this.arrayOfValues[index];
            }
            set
            {
                this.arrayOfValues[index] = value;
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 resultArr = obj as BitArray64;

            if (resultArr == null)
            {
                throw new ArgumentException("The passed object is not from type Student.");
            }

            if (resultArr.Count() != this.arrayOfValues.Count())
            {
                return false;
            }

            for (int i = 0; i < this.arrayOfValues.Count(); i++)
            {
                if (this.arrayOfValues[i] != resultArr[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !object.Equals(first, second);
        }

        public override int GetHashCode()
        {
            int result = this.arrayOfValues.GetHashCode();

            foreach (var item in this.arrayOfValues)
            {
                result ^= item.GetHashCode();
            }

            return result;

            // P.S. I have no idea why I'm doing it this way.
        }
    }
}
