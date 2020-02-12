using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Long_Form_Number_Converter
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> HundredsOnesDictionary = new Dictionary<string, string>();
        Dictionary<string, string> TensDictionary = new Dictionary<string, string>();
        Dictionary<string, string> TensAsOneDictionary = new Dictionary<string, string>();

        public Form1()
        {
            HundredsOnesDictionary.Add("1", "One");
            HundredsOnesDictionary.Add("2", "Two");
            HundredsOnesDictionary.Add("3", "Three");
            HundredsOnesDictionary.Add("4", "Four");
            HundredsOnesDictionary.Add("5", "Five");
            HundredsOnesDictionary.Add("6", "Six");
            HundredsOnesDictionary.Add("7", "Seven");
            HundredsOnesDictionary.Add("8", "Eight");
            HundredsOnesDictionary.Add("9", "Nine");

            TensDictionary.Add("2", "Twenty");
            TensDictionary.Add("3", "Thirty");
            TensDictionary.Add("4", "Fourty");
            TensDictionary.Add("5", "Fifty");
            TensDictionary.Add("6", "Sixty");
            TensDictionary.Add("7", "Seventy");
            TensDictionary.Add("8", "Eighty");
            TensDictionary.Add("9", "Ninety");

            TensAsOneDictionary.Add("10", "Ten");
            TensAsOneDictionary.Add("11", "Eleven");
            TensAsOneDictionary.Add("12", "Twelve");
            TensAsOneDictionary.Add("13", "Thirteen");
            TensAsOneDictionary.Add("14", "Fourteen");
            TensAsOneDictionary.Add("15", "Fifteen");
            TensAsOneDictionary.Add("16", "Sixteen");
            TensAsOneDictionary.Add("17", "Seventeen");
            TensAsOneDictionary.Add("18", "Eighteen");
            TensAsOneDictionary.Add("19", "Nineteen");

            InitializeComponent();
        }

        private void btnConvertInt_MouseUp(object sender, MouseEventArgs e)
        {
            lblOutput.Text = ParseNumber(txtUnsignedInt.Text);
        }

        private void btnConvertString_MouseUp(object sender, MouseEventArgs e)
        {
            lblOutput.Text = ParseNumber(txtString.Text);
        }

        string ParseNumber(ulong number)
        {
            return UIntToString(number);
        }

        string ParseNumber(string number)
        {
            return StringToString(number);
        }

        string UIntToString(ulong number)
        {
            String stringNumber = number.ToString();
            return StringToString(stringNumber);
        }

        string StringToString(string number)
        {
            return Convert3DigitSet(number);
        }

        string Convert3DigitSet(string input)
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

        string HundredsPlace(string input)
        {
            return HundredsOnesDictionary[input] + " Hundred";
        }

        string TensPlace(string input)
        {
            return TensDictionary[input];
        }

        string TensPlaceAsOne(string input)
        {
            return TensAsOneDictionary[input];
        }

        string OnesPlace(string input)
        {
            return HundredsOnesDictionary[input];
        }
    }
}
