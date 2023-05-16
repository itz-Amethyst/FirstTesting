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

        [Theory]
        [InlineData("Fizz" , 2)]
        [InlineData("Buzz" , 4)]
        [InlineData("FizzBuzz" , 14)]
        public void Start_ShouldReturnAListWithProperValuesAtGivenElements(string expected , int element)
        {
            const int rounds = 100;

            var actual = FizzBuzz.Start(rounds);

           Assert.Equal(expected , actual[element]);
        }

        //[Fact]
        //public void Start_ShouldReturnAListWithBuzzValue()
        //{
        //    const int rounds = 100;

        //    var actual = FizzBuzz.Start(rounds);

        //    Assert.Equal("Buzz", actual[4]);
        //    Assert.Equal("Buzz", actual[9]);
        //}

        //[Fact]
        //public void Start_ShouldReturnAListWithFizzBuzzValue()
        //{
        //    const int rounds = 100;

        //    var actual = FizzBuzz.Start(rounds);

        //    Assert.Equal("FizzBuzz", actual[14]);
        //    Assert.Equal("FizzBuzz", actual[29]);
        //}
    }
}
