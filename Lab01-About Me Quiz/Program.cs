using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1();
        }

        static void Question1()
        {
            string question = "First question: Am I an only child? [True or False]";
            string details = "I have a younger brother Eric.  He and I grew up battling each other on the N64, trading blows on Golden Eye and Mario Kart.";

            Console.WriteLine(question); //asks the user a question in the console
            string userResponse = Console.ReadLine().ToLower(); //takes user response, converts it to lower case and then stores it locally
            Console.WriteLine(details);
        }
    }
}
