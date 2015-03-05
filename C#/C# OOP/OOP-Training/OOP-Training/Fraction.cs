using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    class Fraction
    {
        private int numerator;

        private int denumerator;

        public Fraction(string fraction)
        {
            this.Parse(fraction);
        }

        public decimal DecimalValue
        {
            get { return (decimal)this.numerator / this.denumerator; }
        }

        private void Parse(string fraction)
        {
            if (!fraction.Contains('/'))
            {
                throw new InvalidCastException("The fraction is not valid because it does not contain \"/\" ");
            }

            string[] splittedFraction = fraction.Split('/');
            int num = int.Parse(splittedFraction[0]);
            int denum = int.Parse(splittedFraction[1]);

            if (num == 0)
            {
                throw new InvalidOperationException("The numerator must be different than 0");
            }
            if (denum == 0)
            {
                throw new InvalidOperationException("The denumerator must be different than 0");
            }

            this.numerator = num;
            this.denumerator = denum;
        }

        public void CancelFraction()
        {
            if (this.numerator == default(int))
            {
                throw new InvalidOperationException("The numerator must be different than 0");
            }
            if (this.denumerator == default(int))
            {
                throw new InvalidOperationException("The denumerator must be different than 0");
            }

            int num = this.numerator;
            int denum = this.denumerator;
            int resultFromDivision;
            int reminderFromDivision = num % denum;

            while (reminderFromDivision != 0)
            {
                resultFromDivision = num / denum;
                reminderFromDivision = num % denum;
                num = denum;
                denum = reminderFromDivision;
            }

            this.numerator /= num;
            this.denumerator /= num;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", this.numerator, this.denumerator);
        }
    }
}
