namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declairing Variables
            int number;
            string response = string.Empty;
            string response2 = string.Empty;
            int points = 0;
            int lives = 3;
            Random rng = new();
            string user_response;

            Console.WriteLine("hit f and enter if it's a multiple of 3, b and enter if it's a multiple of 5, fb and enter if both apply or the number if nothing applies");
            Console.WriteLine("Enjoy Playing :)");
            Console.WriteLine("Press enter to begin!");
            Console.ReadKey();

            while (true) //Round 1 Easy difficulty
            {
                Console.Clear();
                number = rng.Next(1, 32); //gets random number

                if ((number % 3) == 0)
                {
                    response = "F";
                    response2 = "FIZZ";
                }
                else if ((number % 5) == 0)
                {
                    response = "B";
                    response2 = "BUZZ";
                }
                else if (((number % 3) == 0) && ((number % 5) == 0))
                {
                    response = "FB";
                    response2 = "FIZZBUZZ";
                }
                else if (((number % 3) != 0) && ((number % 5) != 0))
                { response = Convert.ToString(number); }
                Console.WriteLine(number);
                Console.Write(">");
                user_response = Console.ReadLine()?.ToUpper() ?? string.Empty;
                if ((response == user_response) || (response2 == user_response))
                {
                    Console.WriteLine("Corrrect!");
                    Console.WriteLine("Press Enter to continue!");
                    Console.ReadLine();
                    points += 3;
                }
                else if ((response != user_response) && (response2 != user_response))
                {
                    Console.WriteLine("Incorrect!");
                    lives--;
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                }
                if (lives == 0)
                {
                    Console.WriteLine("Game Over!!!");
                    Console.WriteLine("You socre {0} Points!", points);
                    Console.WriteLine("Press Enter To end the game!");
                    Console.ReadLine();
                    break;
                }


            }

        }
    }
}