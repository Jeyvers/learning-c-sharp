

public class Numbers()
{
    public static void Run()
    {
        List<int> numbers = new List<int>();

        for(int i = 0; i < 3; i++)
        {
            Console.Write("Enter a number: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }

        for(int i =0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        foreach(var item in numbers)
        {
            Console.WriteLine(item);
            
        }

        

    }
}