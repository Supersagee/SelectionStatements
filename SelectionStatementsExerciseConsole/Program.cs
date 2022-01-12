using System;

namespace SelectionStatementsExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //if,else statements
            var favNumber = 12;

            Console.WriteLine("Guess what my favorite number is");
            var userGuess = int.Parse(Console.ReadLine());
           
            if(userGuess < favNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if(userGuess > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Bingo!");
            }

            //switch statments
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Coding":
                    Console.WriteLine("I love to code!");
                    break;
                case "Reading":
                    Console.WriteLine("Reading is so relaxing :D");
                    break;
                case "Math":
                    Console.WriteLine("Math is fun, but can be really hard!");
                    break;
                case "English":
                    Console.WriteLine("English has way too many exceptions to the rule!");
                    break;
                case "Science":
                    Console.WriteLine("Science rules!");
                    break;
                default:
                    Console.WriteLine("I have no idea what you're talking about!");
                    break;

            }

        }
    }
}
