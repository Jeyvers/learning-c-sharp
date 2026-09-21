namespace TwoInt
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("What would be the number?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What would be the count?");
            int count = Convert.ToInt32(Console.ReadLine());

            List<int> values = [];
            for (int i = 1; i <= count; i++)
            {
                int sum = i * num;
                values.Add(sum);
            }
            
            Console.WriteLine(string.Join(", ", values));
        }
    }
}