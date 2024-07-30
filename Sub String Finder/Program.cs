using System;

namespace FindSubstringPositions
{
    class Program
    {
        /// <summary>
        /// Entry point for project
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
            validation v = new validation();
            string mainString = v.ValidMainString();
            string subString = v.ValidSubString(mainString);

            Console.WriteLine(mainString);
            Console.WriteLine(subString);
            SubstringPositions SP = new SubstringPositions();
            //List to store positions
            string Positions = SP.PositionsFinder(mainString, subString);

            Console.WriteLine("No. of times occurred = " + Positions.Length);
            Console.Write("Index positions = ");

            foreach (char position in Positions)
            {
                    Console.Write(position + " ");
                
            }

        }

    }
}