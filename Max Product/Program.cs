namespace Max_Product
{
    class Program{

        /// <summary>
        /// Entry Point for the project
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to check : ");
            string Value = Console.ReadLine();
            Validations v = new Validations();
            do
            {
                if (v.isValid(Value))
                {
                    int digit1, digit2, digit3, digit4;
                    MaxProductFourDigits mpf = new MaxProductFourDigits();
                    int Max_Product = mpf.maxProductFinder(Value, out digit1, out digit2, out digit3, out digit4);

                    Console.WriteLine(digit1 + " * " + digit2 + " * " + digit3 + " * " + digit4 + " = " + Max_Product);
                }
                else
                {
                    Console.WriteLine("Please enter the correct number [0-9]");
                    Console.WriteLine("Example : 2313573894");
                    Console.WriteLine("Enter the number to check : ");
                    string newValue = Console.ReadLine();
                    Value = newValue;
                    if (v.isValid(Value))
                    {
                        int digit1, digit2, digit3, digit4;
                        MaxProductFourDigits mpf = new MaxProductFourDigits();
                        int Max_Product = mpf.maxProductFinder(Value, out digit1, out digit2, out digit3, out digit4);
                        Console.WriteLine(digit1 + " * " + digit2 + " * " + digit3 + " * " + digit4 + " = " + Max_Product);
                    }
                }
            } while (!v.isValid(Value));

        }
    }
}