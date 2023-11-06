namespace FizzBuzz
{
    public class FizzBuzz
    {
        private enum Constants { Fizz, Buzz, Whizz, Bang };
        private static bool IsDivisibleByThree(int number) => number % 3 == 0;
        private static bool IsDivisibleByFive(int number) => number % 5 == 0;
        private static bool IsDivisibleBySeven(int number) => number % 7 == 0;
        private static bool IsDivisibleByEleven(int number) => number % 11 == 0;

        protected static string CheckFizzBuzz(int number)
        {
            string result = string.Empty;

            if (IsDivisibleByThree(number))
                result += Constants.Fizz;
            if (IsDivisibleByFive(number))
                result += Constants.Buzz;
            if(IsDivisibleBySeven(number))
                result += Constants.Whizz;
            if (IsDivisibleByEleven(number))
                result += Constants.Bang;
            if (result.Length == 0)
                result += number.ToString();

            return result;
        }

        protected static bool IsFizzBuzzWhizzBang(int number)
        {
            return CheckFizzBuzz(number) == (Constants.Fizz.ToString() + Constants.Buzz.ToString() + Constants.Whizz.ToString() + Constants.Bang.ToString());
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

        public static void PrintUntilFizzBuzzWhizzBang()
        {
            int number = 0;
            do
            {
                number++;
                PrintFizzBuzz(number);
            } while(!IsFizzBuzzWhizzBang(number));
        }
    }
}
