using NUnit.Framework;

namespace Katas
{
    public class ReverseAStringTests
    {
        [TestCase("abc", "cba")]
        [TestCase("a", "a")]
        [TestCase(" ", " ")]
        [TestCase("ABC!", "!CBA")]
        public void GivenAStringThenReverseIt(string input, string expectedResult)
        {
            ReverseAString rev = new ReverseAString();
            Assert.AreEqual(expectedResult, rev.Reverse(input));
        }
    }
    public class ReverseAString
    {
        public string Reverse(string str)
        {
            string reverse = "";
            for (int i = str.Length; i > 0; i--)
            {
                reverse = reverse + str[i - 1];
            }

            return reverse;
        }
    }
}