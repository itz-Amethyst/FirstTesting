using Xunit;

namespace FirstTesting.EvenOrOdd
{
    public class EvaluatorTest
    {
        [Fact]
        public void Evaluate_Should_Return_Even()
        {
            const int input = 6;

            var actual = Evaluator.Evaluate(input);

            Assert.Equal("Even", actual);
        }

        [Fact]
        public void Evaluate_Should_Return_Odd()
        {
            const int input = 10;

            var actual = Evaluator.Evaluate(input);

            Assert.Equal("Odd", actual);
        }
    }
}
