using NUnit.Framework;

namespace WordWrap
{
    public class WrapperTests
    {
        [Test]
        public void EmtpyString()
        {
            Assert.AreEqual("", Wrapper.Wrap("", 0));
        }
    }

    public class Wrapper
    {
        public static string Wrap(string text, int columns)
        {
            return "";
        }
    }
}
