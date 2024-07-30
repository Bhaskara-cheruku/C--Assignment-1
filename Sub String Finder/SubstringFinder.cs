using System;

namespace FindSubstringPositions
{
    class SubstringPositions
    {
        /// <summary>
        /// This Method is used to find the positions of substring occurance
        /// </summary>
        /// <param name="mainstring">This variable contains the main string which we need to find the substring in it</param>
        /// <param name="substring"> This is the substring we need to find it's occurance</param>
        /// <returns>A List will be returned contains Positions of substring</returns>
        public  string PositionsFinder(string mainstring, string substring)
        {
            //Position is declared to store the position values of substring occurance
            string positions="";
            int index = -1;
            for (int i = 0; i <= mainstring.Length - substring.Length; i++)
            {
                //inner loop to check weather the substring is existed in main method or not
                for (int j = 0; j < substring.Length; j++)
                {
                    if (mainstring[i + j] != substring[j])
                    {
                        break;
                    }
                    //Adding positions into List(positions)
                    if (j == substring.Length - 1)
                        positions += i;

                }
            }

            return positions;
        }

    }
}