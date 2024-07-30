namespace Max_Product
{
    class Validations{

        /// <summary>
        /// Method to check the user input is valid or not.
        /// </summary>
        /// <param name="number">caontains the user input </param>
        /// <returns></returns>
        public bool isValid(string number)
        {
            int Count = 0;
            //checking length of given input value
            if (number.Length < 4 || number.Length==0)
            {
                return false;
            }
            //condition to check weather the given input is number is not!
            for (int i = 0; i < number.Length; i++)
            {
                if ((int)number[i]<48 || (int)number[i]>57)
                {
                    Count++;
                }

                if ((int)number[i] == 45)
                {
                    Count--;
                }
            }
            if (Count == 0) { return true; }
            else
            {
                return false;
            }
        }

    }

}