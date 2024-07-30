using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAdditionConversion
{
    class Addition
    {
        public static float power(int Base, int exponential)
        {
            if (exponential > 0)
            {
                int result = 1;
                for (int i = 1; i <= exponential; i++)
                {
                    result *= Base;
                }

                return result;
            }
            else
            {
                float result = 1f;
                for (int i = exponential; i < 0; i++)
                {
                    result /= 2;
                }
                return result;
            }

    }
        public static string Reverse(string originalString)
        {
            string reversedString = "";
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reversedString += originalString[i];
            }

            return reversedString;
        }
        public static string integralPartBinary(int n)
        {
            if (n == 0) return "0";
            string res = "";
            int x = n;
            while (x != 0)
            {
                int remainder = x % 2;
                res = remainder + res;
                x /= 2;
            }
            return res;
        }
        public static string fractionalParttionBinary(float n)
        {
            if (n == 0.0) return "0";
            string res = "";
            string s = Convert.ToString(n);
            int c = 0;
            while (n != 1.0)
            {
                float x = n * 2;
                n = x;
                if (n > 1)
                {
                    n = n - 1;
                }
                s = Convert.ToString(x);
                res += s[0];
                c++;
                
            }

            return res;
        }
        public static string FloatToBinary(float Value)
        {
            int integerPart = (int)Value;
            float decimalPart = Value - integerPart;
            string binaryInteger = Addition.integralPartBinary(integerPart);
            //converting integer part of a float value into binaary
            string binaryDecimal = fractionalParttionBinary(decimalPart);
            //converting decimal part of a float value into binary
            //Joining the binary result of both intoart and decimal part
            string BinaryValue = binaryInteger + "." + binaryDecimal;
            return BinaryValue;
        }

        public static string BinaryAddition(string FirstNumberBinary, string SecondNumberBinary)
        {
            //spliting the binary based on the . to divide int part binary and decimal part binary
            string[] BinaryArray1 = FirstNumberBinary.Split('.');
            string[] BinaryArray2 = SecondNumberBinary.Split('.');
            //Identify the max int part len and decimal part len
            int maxIntegerPart = Math.Max(BinaryArray1[0].Length, BinaryArray2[0].Length);
            int maxDecimalPart = Math.Max(BinaryArray1[1].Length, BinaryArray2[1].Length);
            //perform padding to make the lengths of both inputs same
            string integralBinary1 = BinaryArray1[0].PadLeft(maxIntegerPart, '0');
            string integralBinary2 = BinaryArray2[0].PadLeft(maxIntegerPart, '0');
            string decimalBinary1 = BinaryArray1[1].PadRight(maxDecimalPart, '0');
            string decimalBinary2 = BinaryArray2[1].PadRight(maxDecimalPart, '0');
            //joining both int part binary and fractional part binary
            string FirstNumberBinaryValue = integralBinary1 + decimalBinary1;
            string SecondNumberBinaryValue = integralBinary2 + decimalBinary2;
            //Console.WriteLine("After Padding First number : "+ binary1);
            //Console.WriteLine("After Padding First number : " + binary2);
            int carry = 0;
            string resultedBinaryAddition = "";
            //performing addition
            for (int i = FirstNumberBinaryValue.Length - 1; i >= 0; i--)
            {
                int bit1 = FirstNumberBinaryValue[i] - '0';
                int bit2 = SecondNumberBinaryValue[i] - '0';
                int sum = bit1 + bit2 + carry;
                int bit = sum % 2;
                carry = sum / 2;
                resultedBinaryAddition += bit;
            }
            if (carry > 0)
            {
                resultedBinaryAddition += carry;
            }
            string BinaryValue = Reverse(resultedBinaryAddition);
            
            string finalBinaryValue = "";
            for (int i = 0; i < BinaryValue.Length - maxDecimalPart; i++)
            {
                finalBinaryValue += BinaryValue[i];
            }
            finalBinaryValue += ".";
            for (int i = BinaryValue.Length - maxDecimalPart; i < BinaryValue.Length; i++)
            {
                finalBinaryValue += BinaryValue[i];
            }
            //Console.WriteLine("After adding float numbers : "+finalBinary);
            return finalBinaryValue;
        }
        public static float BinaryToFloat(string finalBinaryValue)
        {
            string[] binariesArray = finalBinaryValue.Split('.');
            //split the int part binary and float part binary 
            int integerBinary = binariesArray[0].Length;
            int DecimalBianry = binariesArray[1].Length;
            int integerValue = 0;
            float DecimalValue = 0.0f;
            float FinalValue = 0.0f;
            string integerPArt = binariesArray[0];
            string DecimalPart = binariesArray[1];
            //converting int part binary to int 
            int integerpower = 0;
            for (int i = integerBinary - 1; i >= 0; i--)
            {
                int digit = integerPArt[i] - '0';
                integerValue += digit * ((int)power(2,integerpower++));
            }
            //converting decimal part binary to float part
            int decimalPower = -1;
            for (int i = 0; i < DecimalBianry; i++)
            {
                float digit = DecimalPart[i] - '0';
                DecimalValue +=(digit * power(2,decimalPower--));
            }
            
            FinalValue = integerValue + DecimalValue;
            return FinalValue;


        }
    }
}