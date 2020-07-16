using NUnit.Framework;

namespace AvevaWord.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringContainsA()
        {
            Sequencer sequencer = new Sequencer();
            bool result = sequencer.DoesStringContainLetters("a", "abcde");
            Assert.That(result, Is.True);
        }

        [TestCase("ab", "abcde", true)]
        [TestCase("ab", "edcba", true)]
        [TestCase("ba", "abcde", true)]
        [TestCase("pq", "abcde", false)]
        public void String_Contains_Letters(string letters, string toCheck, bool expected)
        {
            Sequencer sequencer = new Sequencer();
            bool result = sequencer.DoesStringContainLetters(letters, toCheck);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("ab", "abcde", true)]
        [TestCase("ab", "cdeab", true)]
        [TestCase("ab", "cadeb", true)]
        [TestCase("ba", "abcde", false)]
        public void String_Contains_Letters_In_Sequence(string letters, string toCheck, bool expected)
        {
            Sequencer sequencer = new Sequencer();
            bool result = sequencer.DoesStringContainLettersInSequence(letters, toCheck);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}