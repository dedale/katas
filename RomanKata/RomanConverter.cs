namespace RomanKata
{
    class RomanConverter
    {
        internal static string From(int arabic)
        {
            string roman = string.Empty;
            if (arabic == 5)
                return "V";
            for (int a = 1; a <= arabic; a++)
                roman += "I";
            return roman;
        }
    }
}
