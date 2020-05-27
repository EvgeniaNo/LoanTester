using Loans.Domain.Applications;
using NUnit.Framework;

namespace Loans.Test
{
    [TestFixture]
    public class LoanTermShould
    {
        [Test]
        public void ReturnTermsInMonths()
        {
            var sut = new LoanTerm(4);

            Assert.That(sut.ToMonths(), Is.EqualTo(48));
        }
    }
}