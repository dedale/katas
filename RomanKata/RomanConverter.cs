namespace RomanKata
{
    class RomanConverter
    {
        internal static string From(int arabic)
        {
            string roman = string.Empty;
            if (arabic >= 10)
            {
                roman += "X";
                arabic -= 10;
            }
            if (arabic >= 5)
            {
                roman += "V";
                arabic -= 5;
            }
            for (int a = 1; a <= arabic; a++)
                roman += "I";
            return roman;
        }
    }
}
