/*****

References: https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test

***/


using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        
        public void ShouldReturnFalse_WhenPassedNotPrime_IsPrime(int value)
        {
            var _primeService = new PrimeService();

            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        public void ShouldReturnTrue_WhenPassedPrime_IsPrime(int value)
        {
            //Given
            var _primeService = new PrimeService();
            //When
            var result = _primeService.IsPrime(value);
            //Then
            Assert.True(result, $"{value} should not be prime");
        }
    }
}