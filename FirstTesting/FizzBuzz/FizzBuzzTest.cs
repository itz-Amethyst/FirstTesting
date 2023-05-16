using Xunit;

namespace FirstTesting.FizzBuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Start_ShouldReturnAListWithGivenRoundsLength()
        {
            const int rounds = 100;

            var actualResult = FizzBuzz.Start(rounds);

            Assert.Equal(rounds , actualResult.Count);
        }

        [Fact]
        public void Start_ShouldReturnAListWithFizzValue()
        {
            const int rounds = 100;

            var actual = FizzBuzz.Start(rounds);

            Assert.Equal("Fizz" , actual[2]);
            Assert.Equal("Fizz", actual[8]);
        }

        [Fact]
        public void Start_ShouldReturnAListWithBuzzValue()
        {
            const int rounds = 100;

            var actual = FizzBuzz.Start(rounds);

            Assert.Equal("Buzz", actual[4]);
            Assert.Equal("Buzz", actual[9]);
        }

        [Fact]
        public void Start_ShouldReturnAListWithFizzBuzzValue()
        {
            const int rounds = 100;

            var actual = FizzBuzz.Start(rounds);

            Assert.Equal("FizzBuzz", actual[14]);
            Assert.Equal("FizzBuzz", actual[29]);
        }
    }
}
