namespace CustomTryParse
{
    
    class Program
    {
       
        public static void Run ()
        {

        Console.Write("Write a number:");

       if(ParseNum(Console.ReadLine(), out int val))
            {
                Console.WriteLine($"You wrote {val}");
            } else
            {
                Console.WriteLine("You did not write a valid number");
                
            }
            
        }

        static bool ParseNum(string? num, out int val)
        {
            val = 0;

            if(string.IsNullOrEmpty(num))
            {
                return false;
            }
            
            try
            {
                         val = Convert.ToInt32(num);
              return true;

            }
            catch (Exception)
            {

                return false;
                
            }; 

       
        
        }
    }
}