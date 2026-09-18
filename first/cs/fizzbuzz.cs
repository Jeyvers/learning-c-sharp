namespace FizzBuzzApp;

public class FizzBuzz
{
    public static void Run()
    {
Console.WriteLine("");

for(int i = 1; i <= 15; i++)
{
    bool isDivisibleByThree = i % 3 == 0;
    bool isDivisibleByFive = i % 5 == 0;

    if(isDivisibleByThree && isDivisibleByFive)
    {
        Console.WriteLine("FizzBuzz");
    } else if (isDivisibleByThree)
    {
        Console.WriteLine("Fizz");
    } else if (isDivisibleByFive)
    {
        Console.WriteLine("Buzz");
        
    } else
    {
        Console.WriteLine(i);
        
    }
}}}