namespace BinaryAdditionConversion
{
    class Validations
    {
        public float isValid()
        {
            bool flag;
            float result;
            do
            {
                Console.WriteLine("Enter the number : ");
                string value = Console.ReadLine();
                flag = true;
                if (float.TryParse(value, out  result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Please check the given input it must be between [0-9]");
                    flag = false;
                }
            } while (!flag);

            return result;
        }
    }
}