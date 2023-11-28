namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElse();
        }
        public static void IfElse()
        {
            Console.WriteLine("What is the temperature like? Enter a number.");
            int temperature;
            try
            {
                temperature = int.Parse(Console.ReadLine());
                if (temperature < 20)
                {
                    Console.WriteLine("Take the coat");
                }
                else if (temperature == 20)
                {
                    Console.WriteLine("It's 20 degrees celsius. You should be fine");
                }
                else if (temperature > 20)
                {
                    Console.WriteLine("Wear something light");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception, please enter a number");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
