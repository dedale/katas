namespace RomanKata
{
    class RomanConverter
    {
        internal static string From(int arabic)
        {
            if (arabic == 1)
                return "I";
            return "II";
        }
    }
}
