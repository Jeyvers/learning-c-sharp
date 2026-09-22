namespace SumIntArray
{
    class Program
    {
        public static void Run()
        {
            int[] numbers = [-1, -4, -3];

            if (SumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"Your total is: {total}");
            }
            else
            {
                Console.WriteLine("Your array is empty");
            }

        
        }

       
        static bool SumOfNumbers(int[] numbers, out int sum)
        {
            sum = 0;

            if (numbers.Length < 1)
                return false;

            foreach (var num in numbers)
            {
                sum += num;
            }

            return true;
        }
    }
}