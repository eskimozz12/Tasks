using NUnit.Framework;
using Test2Library;

namespace Test_Task3
{
    public class StringCheckerTests
    {
        StringChecker?checker;
        [SetUp]
        public void Setup()
        {
            checker = new StringChecker();
        }

        [TestCase("How are you, doing....today?", ExpectedResult = 5)]
        [TestCase("Wish,I were, more patient when I work", ExpectedResult = 8)]
        [TestCase("some...random.,,..,,text", ExpectedResult = 3)]
        [TestCase("keyboard.mouse?,monitor pc sky", ExpectedResult = 5)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase(" ", ExpectedResult = 0)]
        public int? TestWordCounter(string test)
        {
            return checker?.Value(test);
        }
        [TestCase("How are you, doing....today?", ExpectedResult = "are doing How today you")]
        [TestCase("Wish,I were, more patient when I work", ExpectedResult = "I I more patient were when Wish work")]
        [TestCase("some...random.,,..,,text", ExpectedResult = "random some text")]
        [TestCase("keyboard.mouse?,monitor pc sky", ExpectedResult = "keyboard monitor mouse pc sky")]
        [TestCase("", ExpectedResult = "")]
        public string? TestWordSort(string test)
        {
            return checker?.Sort(test);
        }
        [TestCase("How are you, doing....today?", ExpectedResult = "How Are You Doing Today")]
        [TestCase("Wish,I were, more patient when I work", ExpectedResult = "Wish I Were More Patient When I Work")]
        [TestCase("some...random.,,..,,text", ExpectedResult = "Some Random Text")]
        [TestCase("keyboard.mouse?,monitor pc sky", ExpectedResult = "Keyboard Mouse Monitor Pc Sky")]
        [TestCase("", ExpectedResult = "")]
        public string? TestWordFirstUpper(string test)
        {
            return checker?.FirstUpper(test);
        }
        [TestCase("How are you, doing....today?", ExpectedResult = new object[] {"How","are","you","doing","today"})]
        [TestCase("Wish,I were, more patient when I work", ExpectedResult = new object[] { "Wish", "I", "were", "more", "patient","when","I","work" })]
        [TestCase("some...random.,,..,,text", ExpectedResult = new object[] { "some", "random", "text"})]
        [TestCase("keyboard.mouse?,monitor pc sky", ExpectedResult = new object[] { "keyboard", "mouse", "monitor", "pc", "sky"})]
        [TestCase("", ExpectedResult = new object[] { })]
        public string[]? TestWordRemoveChars(string test)
        {
            return checker?.RemoveChars(test);
        }
    }
}