namespace TriangleArea
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("Enter your triangle width: ");
            decimal twWidth = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter your triangle height: ");
            decimal twHeight = Convert.ToDecimal(Console.ReadLine());

            decimal triangleArea = twWidth*twHeight/2;

            Console.WriteLine($"The area of your triangle is {triangleArea}");

        }
    }
}