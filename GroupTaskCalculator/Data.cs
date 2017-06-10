﻿using System;

namespace GroupTaskCalculator
{
    public class Data
    {
        private static string alph = "0123456789ABCDEF";
        private readonly string value;
        public string Value => value;
        private readonly int numSystem;
        public int NumSystem => numSystem;

        public Data(string value, int numSystem)
        {
            this.value = value;
            this.numSystem = numSystem;
        }

        public static Data Convert(Data inputValue, int outputCC)
        {
            if (inputValue.numSystem == outputCC) return inputValue;
            string sign= inputValue.Value[0] == '-'?"-":"";
            string firstPart = "";
            string secondPart = "";
            if (inputValue.value.IndexOf(",") > 0)
            {
                firstPart = inputValue.value.Remove(inputValue.value.IndexOf(","));
                secondPart = inputValue.value.Substring(inputValue.value.IndexOf(",") + 1);
            }
            else firstPart = inputValue.value;
            firstPart = firstPart.Trim('-');
            decimal outputValue=0;

            #region Перевод в десятичную

            if (inputValue.numSystem != 10)
            {
                for (int i = 0; i < firstPart.Length; i++)
                {
                    ulong val = (ulong) alph.IndexOf(firstPart[i]);
                    outputValue += val*(decimal) Math.Pow(inputValue.numSystem, firstPart.Length - i - 1);
                }

                for (int i = 0; i < secondPart.Length; i++)
                {
                    decimal val = alph.IndexOf(secondPart[i]);
                    outputValue += val*(decimal) Math.Pow(inputValue.numSystem, -1*(i + 1));
                }
            }
            else outputValue = decimal.Parse(inputValue.value.Replace("-",""));

            #endregion Перевод в десятичную

            #region Перевод в target систему

            string outputString;
            if (outputCC != 10)
            {
                ulong intPart = (ulong) outputValue;
                decimal doublePart = outputValue - intPart;

                string outputStringIntPart = "";
                while (intPart >= (ulong) outputCC)
                {
                    outputStringIntPart = alph[(int) (intPart%(ulong) outputCC)] + outputStringIntPart;
                    intPart /= (ulong) outputCC;
                }

                outputStringIntPart = intPart + outputStringIntPart;
                outputStringIntPart = outputStringIntPart.TrimStart('0');


                string outputStringdoublePart = "";
                while (doublePart != 0.0m && outputStringdoublePart.Length < 10)
                {
                    doublePart *= outputCC;
                    outputStringdoublePart += alph[(int) doublePart];
                    doublePart -= (int) doublePart;
                }
                outputStringdoublePart = outputStringdoublePart.TrimEnd('0');
                if (outputStringIntPart == "")
                    outputStringIntPart += 0;
                outputString = outputStringIntPart;
                if (outputStringdoublePart.Length != 0) outputString += "," + outputStringdoublePart;
            }
            else outputString = outputValue.ToString();

            #endregion Перевод в target систему

            if (sign + outputString == "-0")
                return new Data("0", outputCC);
            return new Data(sign+outputString, outputCC);
        }
    }
}


