using System;

namespace GroupTaskCalculator
{
    public class Data
    {
        private static string alph = "0123456789ABCDEF"; // Возможный алфавит
        private readonly string value;
        public string Value => value;
        private readonly int numSystem;
        public int NumSystem => numSystem;

        public Data(string value, int numSystem)
        {
            this.value = value;
            this.numSystem = numSystem;
        }// Конструктор

        public static Data Convert(Data inputValue, int outputCC)
        {
            if (inputValue.numSystem == outputCC) return inputValue; // Если системы счисления равны, зачем идти дальше?

            string sign= inputValue.Value[0] == '-'?"-":""; // Запомнить знак числа
            string firstPart = "";
            string secondPart = "";
            if (inputValue.value.IndexOf(",") > 0) // Разбить число на целую и дробную часть
            {
                firstPart = inputValue.value.Remove(inputValue.value.IndexOf(","));
                secondPart = inputValue.value.Substring(inputValue.value.IndexOf(",") + 1);
            }
            else firstPart = inputValue.value;
            firstPart = firstPart.Trim('-');

            decimal outputValue=0;

            #region Перевод в десятичную

            if (inputValue.numSystem != 10) // Если начальная система счисления 10, то перевод не требуется
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
            if (outputCC != 10) // Если нужная система счисления 10, то перевод не требуется
            {
                // Целая часть
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

                //Дробная часть
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

            // Ограничение в 10 знаков после запятой
            if (outputString.Contains(",") && outputString.Length - outputString.IndexOf(',') - 1 > 10)
                outputString=outputString.Remove(outputString.IndexOf(',') + 11);

            if (sign + outputString == "-0")
                return new Data("0", outputCC);
            return new Data(sign+outputString, outputCC);
        }// Перевод
    }
}


