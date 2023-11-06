namespace FizzBuzz
{
    public class FizzBuzz
    {
        private enum Constants { Fizz, Buzz };
        private static bool IsDivisibleByThree(int number) => number % 3 == 0;
        private static bool IsDivisibleByFive(int number) => number % 5 == 0;

        protected static string CheckFizzBuzz(int number)
        {
            string result = string.Empty;

            if (IsDivisibleByThree(number))
                result += Constants.Fizz;
            if (IsDivisibleByFive(number))
                result += Constants.Buzz;
            if (result.Length == 0)
                result += number.ToString();

            return result;
        }
    }

    public class FizzBuzzPrinter : FizzBuzz
    {
        public static void PrintFizzBuzz(int number)
        {
            Console.WriteLine(CheckFizzBuzz(number));
        }
        
        public static void PrintFizzBuzzRange(int start, int stop)
        {
            for(int i = start; i <= stop; i++)
            {
                PrintFizzBuzz(i);
            }
        }
    }
}
