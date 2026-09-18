
namespace MultiplciationTableApp;

public class MultiplicationTable
{
    
    public static void Run()

    {


Console.Write("What number time table do you need? ");
string? input = Console.ReadLine();



int number;


while(!int.TryParse(input, out number ) || Convert.ToInt32(input) == 0)
{
    Console.Write("Please enter a valid number:");
    input = Console.ReadLine();
}

Console.WriteLine($"Here is your {number} multiplication table:");
for(int i = 1; i<= 12; i++)
{
   Console.WriteLine($"{number} x {i} = {i * number}");
}
    }}