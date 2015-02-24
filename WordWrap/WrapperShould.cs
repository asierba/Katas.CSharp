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
            Assert.AreEqual("two\nwor\nds", Wrapper.Wrap("two words", 3));
            Assert.AreEqual("words\nwords", Wrapper.Wrap("words words", 7));
            Assert.AreEqual("words\nwords\nwords", Wrapper.Wrap("words words words", 7));
            Assert.AreEqual("two\ntwo\ntwo", Wrapper.Wrap("two two two", 3));
            
        }

        [Test]
        public void SpaceAtTheBeginning()
        {
            Assert.AreEqual(" two\ntwo\ntwo", Wrapper.Wrap(" two two two", 4));
        }
    }
}
