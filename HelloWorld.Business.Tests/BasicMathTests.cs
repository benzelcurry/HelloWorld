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
    }
}
