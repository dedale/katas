namespace RomanKata
{
    class RomanConverter
    {
        internal static string From(int arabic)
        {
            string roman = string.Empty;
            for (int a = 1; a <= arabic; a++)
                roman += "I";
            return roman;
        }
    }
}
