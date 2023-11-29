using System.Threading.Tasks.Sources;

namespace Introduction
{
    internal class Program
    {

        static int highscore = 100;
        static string highscorePlayer = "John";
        static void Main(string[] args)
        {
            //IfElse();
            //NestedIf();
            //UserLogin();
            //SwitchCase();
            //HighScore(50, "Test");
            //HighScore(150, "Rehan");
            //Ternary();
            /*
            Console.WriteLine("Please enter a number: ");
            string tempInput = Console.ReadLine();
            if(int.TryParse(tempInput, out int number))
            {
                TernaryCheck(number);
            }
            else
            {
                Console.WriteLine("Number not entered.");
            }
            */
            //ForLoops();
            //DoWhile();
            //WhileLoop();
            //Break();
            AverageScore();
        }
        public static void IfElse()
        {
            Console.WriteLine("What is the temperature like? Enter a number.");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number, 0 set as temperature.");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat.");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and pull over should be fine.");
            }
            else if (numTemp > 20 && numTemp < 30)
            {
                Console.WriteLine("Shorts are enough today.");
            }
            else
            {
                Console.WriteLine("It's a hot day, wear nothing.");
            }
        }
        public static void NestedIf()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            Console.WriteLine("Please enter your user name: ");
            string userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user.");

                Console.WriteLine("Hi there, " + userName);

                Console.WriteLine("Hi there, Admin.");
            }            

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in.");
            }
            else
            {
                Console.WriteLine("Please register or login.");
            }
        }
        public static void UserLogin()
        {
            string userName = "";
            Console.Write("Please register your username: ");
            userName = Console.ReadLine();
            Console.Write("Please register your password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Please login with your username: ");
            string loginName = Console.ReadLine();
            Console.WriteLine("Please login with your password: ");
            string loginPassword = Console.ReadLine();
            if (userName == loginName && password == loginPassword)
            {
                Console.WriteLine("You are logged in.");
            }
            else
            {
                Console.WriteLine("Please register or login.");
            }
        }
        public static void SwitchCase()
        {
            int age = 25;
            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club.");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            string username = "admin";

            switch(username)
            {
                case "root":
                    Console.WriteLine("You are logged in as root.");
                    break;
                case "admin":
                    Console.WriteLine("You are logged in as admin.");
                    break;
                default:
                    Console.WriteLine("You are logged in as guest.");
                    break;
            }
        }
        public static void HighScore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                Console.WriteLine("New highscore is " + highscore);
                Console.WriteLine("Player name: " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
        }
        public static void Ternary()
        {
            int temperature = -1;
            string stateOfMatter;

            // stateOfMatter = temperature < 0 ? "Solid" : "Liquid";
            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "Liquid";

            Console.WriteLine("State of matter is " + stateOfMatter);
        }
        public static void TernaryCheck(int input)
        {
            string outputText;

            outputText = input <= 15 ? "It is too cold here." : input >= 16 && input <= 28 ? "It is ok here." : "It is too hot here.";
            Console.WriteLine(outputText);
        }
        public static void ForLoops()
        {
            for (int i = 1; i <= 20; i+=2)
            {
                Console.WriteLine("i is " + i);
            }
        }
        public static void DoWhile()
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += $" {nameOfFriend}";
            } while (lengthOfText < 20);
            Console.WriteLine($"Thanks, that was enough! {wholeText}");
        }
        public static void WhileLoop()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("Press enter when someone enters the bus");
                string input = Console.ReadLine();
                if (input != "")
                {
                    continue;
                }
                counter++;
                Console.WriteLine($"Current counter is at {counter}.");
            }
        }
        public static void Break()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Found three! Continuing without printing.");
                    continue;
                }
                if (i == 7)
                {
                    Console.WriteLine("Found seven! Breaking.");
                    break;
                }
                Console.WriteLine(i);
            }
        }
        public static void AverageScore()
        {
            int total = 0;
            int counter = 0;
            float average = 0.0f;

            while (true)
            {
                Console.WriteLine("Please enter a score: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int score))
                {
                    if (score == -1)
                    {
                        average = (float)total / counter;
                        Console.WriteLine($"Total score is {total} with {counter} students. Average score is hence {average}.");
                        break;
                    }
                    if (score > 20 || score < 0)
                    {
                        Console.WriteLine("Invalid score, please enter a score between 0 and 20.");
                        continue;
                    }
                    total += score;
                    counter++;
                    Console.WriteLine($"Total score is {total} with {counter} students.");
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
                
            }
        }
    }
}
