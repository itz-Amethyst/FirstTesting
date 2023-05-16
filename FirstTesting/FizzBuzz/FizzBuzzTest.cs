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
    }
}
