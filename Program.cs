namespace _01.ExampleChatConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my guess number game!");
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            while (true)
            {
                Console.WriteLine("Please select a number between 1 and 101 and try to find the number i have kept!");
                string input = Console.ReadLine();
                int myGuess = Convert.ToInt32(input);

                if (myGuess == targetNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number I kept!");
                    Console.ReadLine();
                    break;
                }
                else if (myGuess > targetNumber)
                {
                    if (myGuess - 1 == targetNumber)
                    {
                        Console.WriteLine("You almost know. I think would be better ot reduce the number by one");
                    }
                    else
                    {
                        Console.WriteLine("You guessed a bigger number than I kept");
                    }

                }
                else if (myGuess < targetNumber)
                {
                    if (myGuess + 1 == targetNumber)
                    {
                        Console.WriteLine("You almost know. I think would be better if you increase the number by one.");
                    }
                    else
                    {
                        Console.WriteLine("You underestimated the number I kept");
                    }
                }
            }

        }
    }
}