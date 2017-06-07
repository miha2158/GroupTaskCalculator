using System;

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
            string firstPart = "";
            string secondPart = "";
            if (inputValue.value.IndexOf(",") > 0)
            {
                firstPart = inputValue.value.Remove(inputValue.value.IndexOf(","));
                secondPart = inputValue.value.Substring(inputValue.value.IndexOf(",") + 1);
            }
            else firstPart = inputValue.value;
            
            double outputValue=0;

            #region Первод в десятичную

            for (int i = 0; i < firstPart.Length; i++)
            {
                int val = alph.IndexOf(firstPart[i]);
                outputValue += val*Math.Pow(inputValue.numSystem, firstPart.Length - i - 1);
            }

            for (int i = 0; i < secondPart.Length; i++)
            {
                double val = alph.IndexOf(secondPart[i]);
                outputValue += val * Math.Pow(inputValue.numSystem, -1*(i+1));
            }

            #endregion Первод в десятичную

            #region Перевод в target систему

            int intPart=(int)outputValue;
            double doublePart = outputValue - intPart;

            string outputStringIntPart="";
            while (intPart>=inputValue.numSystem)
            {
                outputStringIntPart = alph[intPart% outputCC]+outputStringIntPart;
                intPart /= outputCC;
            }

            outputStringIntPart = intPart + outputStringIntPart;
            outputStringIntPart = outputStringIntPart.TrimStart('0');


            string outputStringdoublePart = "";
            while (doublePart != 0.0 && outputStringdoublePart.Length<10 )
            {
                doublePart *= outputCC;
                outputStringdoublePart += alph[(int)doublePart];
                doublePart -= (int) doublePart;
            }
            outputStringdoublePart = outputStringdoublePart.TrimEnd('0');
            if (outputStringIntPart == "")
                outputStringIntPart += 0;
            string outputString= outputStringIntPart;
            if (outputStringdoublePart.Length != 0) outputString += "," + outputStringdoublePart;

            #endregion Перевод в target систему
            
            return new Data(outputString, outputCC);
        }
    }
}


