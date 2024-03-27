namespace HelloWorld.Business.Tests
{
    public class BasicMathTests
    {
        [Fact]
        public void Should_Be2_When_Adding1And1()
        {
            int a = 1;
            int b = 1;

            int c = a + b;

            Assert.True(c == 2);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(7, 9, 16)]
        [InlineData(5, 5, 11)]
        public void Should_SumUpNumbers(int a, int b, int expected)
        {
            int result = a + b;
            Assert.Equal(expected, result);
        }
    }
}
