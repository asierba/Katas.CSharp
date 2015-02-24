using NUnit.Framework;

namespace WordWrap
{
    public class WrapperShould
    {
        [Test]
        public void NotWrap_EmtpyString()
        {
            Assert.AreEqual("", Wrapper.Wrap("", 0));
        }

        [Test]
        public void NotWrap_WhenColumnsBiggerThanText()
        {
            Assert.AreEqual("this is a test", Wrapper.Wrap("this is a test", 20));
        }

        [Test]
        public void Wrap_WhenColumnsSmallerThanText()
        {
            Assert.AreEqual("very\nlong", Wrapper.Wrap("verylong", 4));
        }

        [Test]
        public void WrapMultipleWords()
        {
            Assert.AreEqual("very\nlong\ntext", Wrapper.Wrap("verylongtext", 4));
            Assert.AreEqual("very\nvery\nlong\ntext", Wrapper.Wrap("veryverylongtext", 4));
        }
    }

    public class Wrapper
    {
        public static string Wrap(string text, int columns)
        {
            if(text.Length > columns) 
                return text.Substring(0, columns) + '\n' + Wrap(text.Substring(columns), columns);
            return text;
        }
    }
}
