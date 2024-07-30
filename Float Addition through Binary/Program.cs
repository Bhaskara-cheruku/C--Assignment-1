using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BinaryAdditionConversion
{
    class Program
    {
        /// <summary>
        /// This is the Main Method of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Validations v = new Validations();
            float input1 = v.isValid();
            float input2 = v.isValid();
            string input1Binary = Addition.FloatToBinary(input1);
            string input2Binary = Addition.FloatToBinary(input2);
            Console.WriteLine("Float to binary conversion of First number : " + input1Binary);
            Console.WriteLine("Float to binary conversion of Second number : " + input2Binary);
            string binaryAddition = Addition.BinaryAddition(input1Binary, input2Binary);
            Console.WriteLine("After Adding two float numbers in binary Format " + binaryAddition);
            float resultedFloat = Addition.BinaryToFloat(binaryAddition);
            Console.WriteLine("Sum of two given float numbers : " + resultedFloat);
        }
    }
}