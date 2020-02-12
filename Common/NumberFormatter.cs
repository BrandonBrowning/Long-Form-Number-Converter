using System.Collections.Generic;

namespace Common
{
    public static class NumberFormatter
    {
        private static IDictionary<string, string> HundredsOnesDictionary = new Dictionary<string, string>
        {
            ["1"] = "One",
            ["2"] = "Two",
            ["3"] = "Three",
            ["4"] = "Four",
            ["5"] = "Five",
            ["6"] = "Six",
            ["7"] = "Seven",
            ["8"] = "Eight",
            ["9"] = "Nine",
        };

        private static IDictionary<string, string> TensDictionary = new Dictionary<string, string>
        {
            ["2"] = "Twenty",
            ["3"] = "Thirty",
            ["4"] = "Fourty",
            ["5"] = "Fifty",
            ["6"] = "Sixty",
            ["7"] = "Seventy",
            ["8"] = "Eighty",
            ["9"] = "Ninety",
        };

        private static IDictionary<string, string> TensAsOneDictionary = new Dictionary<string, string>
        {
            ["10"] = "Ten",
            ["11"] = "Eleven",
            ["12"] = "Twelve",
            ["13"] = "Thirteen",
            ["14"] = "Fourteen",
            ["15"] = "Fifteen",
            ["16"] = "Sixteen",
            ["17"] = "Seventeen",
            ["18"] = "Eighteen",
            ["19"] = "Nineteen",
        };

        public static string Spell(string input)
        {
            return Convert3DigitSet(input);
        }

        private static string Convert3DigitSet(string input)
        {
            string output = "";

            while (input.Length < 3)
                input = "0" + input;

            if (!input.Substring(0, 1).Equals("0"))
                output += " " + HundredsPlace(input.Substring(0, 1));

            if (!input.Substring(1, 1).Equals("0"))
            {
                if (!input.Substring(1, 1).Equals("1"))
                    output += " " + TensPlace(input.Substring(1, 1));
                else
                {
                    output += " " + TensPlaceAsOne(input.Substring(1, 2));
                    return output;
                }
            }

            if (!input.Substring(2, 1).Equals("0"))
                output += " " + OnesPlace(input.Substring(2, 1));

            if (output.Equals(""))
                return "Zero";

            if (output.Substring(0, 1).Equals(" "))
                output = output.Substring(1, output.Length - 1);
            return output;
        }

        private static string HundredsPlace(string input)
        {
            return HundredsOnesDictionary[input] + " Hundred";
        }

        private static string TensPlace(string input)
        {
            return TensDictionary[input];
        }

        private static string TensPlaceAsOne(string input)
        {
            return TensAsOneDictionary[input];
        }

        private static string OnesPlace(string input)
        {
            return HundredsOnesDictionary[input];
        }
    }
}
