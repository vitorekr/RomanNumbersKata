namespace RomanNumbers
{
    internal class RomanNumeralGenerator
    {
        internal string Convert(int number)
        {
            var romanNumber = "";

            foreach(KeyValuePair<int, string> romanToDecimal in RomanValueKey())
            {
                while (number >= romanToDecimal.Key)
                {
                    romanNumber += romanToDecimal.Value;
                    number -= romanToDecimal.Key;
                }
            }

            return romanNumber;
        }

        public static Dictionary<int, string> RomanValueKey()
        {
            Dictionary<int, string> values = new()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };
            return values;
        }
    }
}
