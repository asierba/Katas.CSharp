using NUnit.Framework;

namespace WordWrap
{
    public class WrapperShould
    {
        [Test]
        public void NotSplit_EmtpyString()
        {
            Assert.AreEqual("", Wrapper.Wrap("", 0));
        }

        [Test]
        public void NotSplit_WhenColumnsBiggerThanText()
        {
            Assert.AreEqual("this is a test", Wrapper.Wrap("this is a test", 20));
        }

        [Test]
        public void SplitSingleWord_WhenColumnsSmallerThanText()
        {
            Assert.AreEqual("very\nlong", Wrapper.Wrap("verylong", 4));
            Assert.AreEqual("very\nlong\ntext", Wrapper.Wrap("verylongtext", 4));
            Assert.AreEqual("very\nvery\nlong\ntext", Wrapper.Wrap("veryverylongtext", 4));
        }

        [Test]
        public void SplitSentenceFromSpaces()
        {
            Assert.AreEqual("two\nwords", Wrapper.Wrap("two words", 3));
        }
    }

    public class Wrapper
    {
        public static string Wrap(string text, int columns)
        {
            if (text.Length > columns)
            {
                if (text[columns] == ' ')
                    return text.Substring(0, columns) + '\n' + text.Substring(columns + 1);

                return text.Substring(0, columns) + '\n' + Wrap(text.Substring(columns), columns);
            }
                
            return text;
        }
    }
}
