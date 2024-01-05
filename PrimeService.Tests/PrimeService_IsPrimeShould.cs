using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsEven
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            int value = 1;
            bool result = primeService.IsPrime(1);

            Assert.False(result, $"{value} is not equal to 1");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(4)]
        public void IsPrime_InputIsEven_ReturnFalse(int value)
        {
            var primeService = new PrimeService();
            var result = primeService.IsEven(value);

            Assert.False(result, $"{value} should not be even");
        }

    }
}
