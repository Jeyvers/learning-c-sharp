namespace Dicts
{
    class Program
    {
        public static void Run()
        {
            Dictionary<int, string> names = new Dictionary<int, string>{
                {1, "Aba"},
                {2, "Yeshua"}
            };

            names.Add(9, "Sweetums");

            for(int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
               
            }

            // example with try out
               Dictionary<string, string> teachers = new Dictionary<string, string>{
                {"Math", "Aba"},
                {"Geography", "Yeshua"}
            };

            // to escape runtime error in case this value doesn't exist, we do
            if(teachers.TryGetValue("Math", out string? mathTeacher))
            {
                Console.Write(mathTeacher);
            }

        }
    }
} 