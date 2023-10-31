namespace MagicalRevert.nUnitTests
{
    [TestFixture]
    public class StringSpecialReverseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Hello, World!", "olleH, dlroW!")]
        [TestCase("12345", "12345")]
        [TestCase("a b c d e", "a b c d e")]
        [TestCase("Test", "tseT")]
        [TestCase("Test my nutt1 dreadl0cks", "tseT ym ttun1 skclda0erd")]
        [TestCase("", "")]
        public void Reverse_EqualTest(string input, string expectedOutput)
        {
            string res = MyClasses.StringSpecialReverse.Reverse(input);
            Assert.AreEqual(expectedOutput,res);
        }
    }
}