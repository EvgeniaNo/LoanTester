using System;
using System.Collections.Generic;

namespace Loans.Domain.Applications
{
    public class LoanTerm : ValueObject

    {
        public virtual void Calculate(object arg)
        {
            throw new NotImplementedException();
        }

        public LoanTerm(int years)
        {
            if (years < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(years), "Please specify a value greater than 0.");
            }

            Years = years;
        }

        // Explicitly stating to hide dealt constructor to indicate immutability
        private LoanTerm()
        {
        }

        public int Years { get; }

        public int ToMonths() => Years * 12;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Years;
        }
    }
}