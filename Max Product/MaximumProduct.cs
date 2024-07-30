namespace Max_Product
{
    /// <summary>
    ///Finding Maximum Product of four adjacent digits
    /// </summary>
    class MaxProductFourDigits
    {
        /// <summary>
        /// Logic to find the Max Product of four digit 
        /// </summary>
        /// <param name="Value"> This Variable consists of user given input number</param>
        /// <param name="digits">It will stores the four single digits of Max Product</param>
        /// <returns></returns>
        public int maxProductFinder(string Value,out int digit1, out int digit2, out int digit3, out int digit4)
        {
            int Max_value = int.MinValue;
            digit1 = int.MinValue;
            digit2 = int.MinValue;
            digit3 = int.MinValue;
            digit4 = int.MinValue;
            for (int i = 0; i < Value.Length - 3; i++)
            {
                //Calculating product of four consecutive digits in a given number
                int Product = (Value[i] - '0') * (Value[i + 1] - '0') * (Value[i + 2] - '0') * (Value[i + 3] - '0');
                if (Product > Max_value)
                {
                    Max_value = Product;
                    digit1 = Value[i] - '0';
                    digit2 = Value[i + 1] - '0';
                    digit3 = Value[i + 2] - '0';
                    digit4 = Value[i + 3] - '0';

                }
            }

            return Max_value;
        }
    }
}
