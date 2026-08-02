Console.Write("What number time table do you need? ");
string? input = Console.ReadLine();





if(int.TryParse(input, out int number ))
{
    
Console.WriteLine($"Here is your {number} multiplication table:");
for(int i = 1; i<= 12; i++)
{
   Console.WriteLine($"{number} x {i} = {i * number}");
}
} else
{
    Console.WriteLine("please enter a valid number");
}