using NUnit.Framework;
using TestConsole.ClassLibrary;

namespace TestConsole.Test2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            stringMethods = new StringMethods();
        }

        private static StringMethods stringMethods;

        [Test]
        [TestCase("test", "string", ExpectedResult = "teststring")]
        public string Concate(string a, string b)
        {
            return stringMethods.Concate(a, b);
        }
    }
}