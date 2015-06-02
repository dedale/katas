using NUnit.Framework;
namespace RomanKata
{
    [TestFixture]
    class RomanConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(10, "X")]
        [TestCase(17, "XVII")]
        [TestCase(30, "XXX")]
        public void ConvertArabicNumber(int arabic, string roman)
        {
            Assert.AreEqual(roman, RomanConverter.From(arabic));
        }
    }
}

// Ctrl-Shift B : build
// Shift-Alt-F10 : choose & do action
// Ctrl-R A : run all tests
// Ctrl-K+C : comment
