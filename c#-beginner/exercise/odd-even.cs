namespace OddEven
{
    class Program
    {
        public static void Run()
        {
            // Create two lists with integer data types, one for even numbers, one for odd numbers
            // loop from 0 - 20, if number is even, if number is odd, then print

            List<int> evenNumbers = [];
            List<int> oddNumbers = [];

            for(int i = 0; i<=20; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                } else
                {
                    oddNumbers.Add(i);
                }
            } 

            // (i % 2 == 0 ? evenNumbers : oddNumbers).Add(i); Nice!!!
            Console.WriteLine(string.Join("," , evenNumbers));
            Console.WriteLine(string.Join("," , oddNumbers));
        }
    }
}