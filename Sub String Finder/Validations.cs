using System.Data.SqlTypes;

namespace FindSubstringPositions
{
    class validation
    {
        /// <summary>
        /// Method to check the user input is valid or not.
        /// </summary>
        /// <param name="mainString">Main string</param>
        /// <param name="subString">Sub string</param>
        /// <returns></returns>
        public bool Isvalid(string mainString, string subString)
        {
            int Count = 0;
                if (mainString.Length == 0 || subString.Length == 0 || mainString.Length < subString.Length)
                {
                    Count++;
                }

                for (int i = 0; i < mainString.Length; i++)
                {
                    if (((int)mainString[i] < 65) || (((int)mainString[i] > 90) && ((int)mainString[i] < 97)) || ((int)mainString[i] > 122))
                    {
                    
                        Count++;
                    }
                    
                }

                for (int i = 0; i < subString.Length; i++)
                {
                    if (((int)subString[i] < 65) || (((int)subString[i] > 90) && ((int)subString[i] < 97)) || ((int)subString[i] > 122))
                    {
                        Count++;
                    }
                }

                if (Count > 0)
                {
                    Console.WriteLine(Count);
                return false;
                }
                else
                {
                    return true;
                }
        }

        public string ValidMainString()
        {
            Console.WriteLine("Enter the first string (Main string):");
            string mainString = Console.ReadLine();
            bool flag;
            do
            {
                flag = true;
               
                int Count = 0;
                for (int i = 0; i < mainString.Length; i++)
                {
                    if (((int)mainString[i] < 65) || (((int)mainString[i] > 90) && ((int)mainString[i] < 97)) ||
                        ((int)mainString[i] > 122))
                    {

                        Count++;
                    }

                }

                if (Count > 0)
                {
                    Console.WriteLine("Please enter the correct string(should contain only characters)");
                    Console.WriteLine("Example : cjahicakjbvbujai");
                    mainString = Console.ReadLine();
                    flag= false;
                }
            } while (!flag);

            return mainString;
        }

        public string ValidSubString(string mainString)
        {
            Console.WriteLine("Enter the Second string (Sub string):");
            string subString = Console.ReadLine();
            bool flag;
            do
            {
                flag = true;
                int Count = 0;
                for (int i = 0; i < subString.Length; i++)
                {
                    if (((int)subString[i] < 65) || (((int)subString[i] > 90) && ((int)subString[i] < 97)) ||
                        ((int)subString[i] > 122))
                    {
                        Count++;
                    }
                }
                if (mainString.Length == 0 || subString.Length == 0)
                {
                    Count++;
                }
                if (mainString.Length < subString.Length)
                {
                    Console.WriteLine("Sub String is bigger than Main string");
                    flag = false;
                }
                if (Count > 0)
                {
                    Console.WriteLine("Please enter the correct string(should contain only characters)");
                    Console.WriteLine("Example : cjahicakjbvbujai");
                    subString = Console.ReadLine();
                    flag = false;
                }
            } while (!flag);

            return subString;
        }
    }
}