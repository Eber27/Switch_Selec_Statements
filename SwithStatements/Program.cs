using System;

namespace SwithStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = "science";
            Console.WriteLine("Which is my favorite Subject?");
            string useranswer = Console.ReadLine();

            switch (useranswer)
            {
                case "math":
                    Console.WriteLine("No It`s not Math!");
                    break;

                case "english":
                    Console.WriteLine("No! Not English neither!");
                    break;

                case "arts":
                    Console.WriteLine("No! I hate Arts! and you know that!");
                    break;

                case "science":
                    Console.WriteLine("You`re right! Science is the one!");
                    break;

                default:
                    Console.WriteLine("None of them");
                    break;
            }
            
        }
    }
}
