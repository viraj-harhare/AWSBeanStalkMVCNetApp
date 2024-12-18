namespace AWSBeanStalkMVCNetApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData("https://www.google.com")]
        [InlineData("vhvh")]
        public void TestMalformedUrl(string uri)
        {
            new Uri(uri);
        }
    }
}