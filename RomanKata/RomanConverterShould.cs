using NUnit.Framework;
namespace RomanKata
{
    [TestFixture]
    class RomanConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(10, "X")]
        [TestCase(17, "XVII")]
        [TestCase(30, "XXX")]
        [TestCase(1111, "MCXI")]
        [TestCase(2444, "MMCDXLIV")]
        [TestCase(2555, "MMDLV")]
        [TestCase(3888, "MMMDCCCLXXXVIII")]
        [TestCase(3999, "MMMCMXCIX")]
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
