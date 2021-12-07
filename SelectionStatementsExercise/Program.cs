using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
          static void Main(string[] args)
        {
            /*int favoriteNumber = 27;
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("try to guess my favorite nuber");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("TOO LOW");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("TOO HIGH!!!");

            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("enjoy th vacation");
            }
            else
            
                Console.WriteLine("Nevermind");*/

           
            string subject = "school";
            Console.WriteLine("choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                   case "school":
                    Console.WriteLine("did you come to school today");
                    break;
                    case "lunch";
                    Console.WriteLine("it's time to eat");
                    break;
                    case "english";
                    Console.WriteLine("are we going to do a pop quiz today");
                    break;
                    case "math";
                    Console.WriteLine("I was never good at math");
                    break;
                    case "computer class";
                    Console.WriteLine("I'm ready to learn");
                    break;
                default:
                    Console.WriteLine("I'm ready to go back home and play the game.");
                    break;
            }
        }
            
        }
        }
        
