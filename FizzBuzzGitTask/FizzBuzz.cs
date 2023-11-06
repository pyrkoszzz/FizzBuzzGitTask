namespace FizzBuzz
{
    public class FizzBuzz
    {
        private enum Constants { Fizz, Buzz };
        private static bool IsDivisibleByThree(int number) => number % 3 == 0;
        private static bool IsDivisibleByFive(int number) => number % 5 == 0;

        private static string CheckFizzBuzz(int number)
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

        public static void PrintFizzBuzz(int number)
        {
            Console.WriteLine(CheckFizzBuzz(number));
        }
    }
}
