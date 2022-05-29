using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using TestConsole.Main;

namespace TestConsole.Tests
{
    [ExcludeFromCodeCoverage]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            math = new MathMethods();
        }

        private static MathMethods math;

        [Test]
        [TestCase(5, 1, ExpectedResult = 6)]
        public int Plus_Returns_Correctly_Result(int a, int b)
        {
            return math.Plus(a, b);
        }
    }
}