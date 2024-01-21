namespace GA_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            try
            {
                // try / catch
                Console.Write("Please enter a whole number: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);

            } // End of try
            catch
            {
                Console.WriteLine("The format was invalid");
            }

            // try / catch

            Console.WriteLine(number);

        } // Main

    } // void

} // class
