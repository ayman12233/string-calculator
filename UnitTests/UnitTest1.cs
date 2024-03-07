
namespace UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAdd_ValidInput()
        {
            string input = "2,3";

            int result = Calculator.Add(input);

            Assert.Equal(5, result);
        }

        [Fact]
        public void TestAdd_InvalidFormat()
        {
            string input = "1,abc";

            Assert.Throws<ArgumentException>(() => Calculator.Add(input));
        }

        [Fact]
        public void TestAdd_MissingValues()
        {
            string input = "1";

            Assert.Throws<ArgumentException>(() => Calculator.Add(input));
        }

        [Fact]
        public void TestAdd_TooManyValues()
        {
            string input = "1,2,3";

            Assert.Throws<ArgumentException>(() => Calculator.Add(input));
        }
    }
}