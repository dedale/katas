using System;
namespace RomanKata
{
    class RomanConverter
    {
        class ArabicRoman
        {
            private readonly int arabic;
            private readonly string roman;
            public ArabicRoman(int arabic, string roman)
            {
                this.arabic = arabic;
                this.roman = roman;
            }
            public int Arabic { get { return arabic; } }
            public string Roman { get { return roman; } }
        }
        private static readonly ArabicRoman[] simpleNumbers =
        {
            new ArabicRoman(10, "X"),
            new ArabicRoman(5, "V"),
            new ArabicRoman(4, "IV"),
            new ArabicRoman(1, "I"),
        };
        internal static string From(int arabic)
        {
            string roman = string.Empty;
            foreach (var simple in simpleNumbers)
            {
                while (arabic >= simple.Arabic)
                {
                    roman += simple.Roman;
                    arabic -= simple.Arabic;
                }
            }
            return roman;
        }
    }
}
