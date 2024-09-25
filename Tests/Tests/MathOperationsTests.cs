using Methods;

namespace Tests
{
    public class MathOperationsTests
    {
        
        [TestCase(2, 0, 1)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 3, 8)]
        [TestCase(0, 0, 1)]   
        [TestCase(0, 5, 0)]
        [TestCase(-2, 0, 1)]
        [TestCase(-2, 1, -2)]
        [TestCase(-2, 3, -8)]
        [TestCase(10, 2, 100)]
        public void Power_ShouldReturnExpectedResult(int x, int n, int expected)
        {
            int result = MathOperations.Power(x, n);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2, -1)]
        [TestCase(5, -10)]
        public void Power_WhenExponentIsNegative_ShouldThrowArgumentException(int x, int n)
        {
            Assert.Throws<ArgumentException>(() => MathOperations.Power(x, n));
        }

    }
}