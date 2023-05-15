using Xunit;

namespace FirstTesting
{
    public class EvaluatorTest
    {
        [Fact]
        public void Evaluate_Should_Return_Even() {
            const int input = 6;

            var evaluator = new Evaluator();

            var actual = evaluator.Evaluate(input);

            Assert.Equal("Even", actual);
        }

        [Fact]
        public void Evaluate_Should_Return_Odd()
        {
            const int input = 10;

            var evaluator = new Evaluator();

            var actual = evaluator.Evaluate(input);

            Assert.Equal("Odd", actual);
        }
    }
}
