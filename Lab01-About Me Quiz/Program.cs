using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1(); //calls the method for the first question; method returns a boolean
            Question2(); //calls the method for the second question; method returns a boolean
            Question3(); //calls the method for the third question; method returns an int
        }

        static bool Question1()
        {
            string question = "First question: Am I an only child? [True or False]";
            string details = "I have a younger brother Eric.  He and I grew up battling each other on the N64, trading blows on Golden Eye and Mario Kart.";

            Console.WriteLine(question); //asks the user a question in the console
            string userResponse = Console.ReadLine().ToLower(); //takes user response, converts it to lower case and then stores it locally
            bool parsedResponse = Boolean.Parse(userResponse); //parses the user response to a boolean
            Console.WriteLine(details);// displays the correct anwser with context to the user

            return parsedResponse; //returns either true or false
        }

        static bool Question2()
        {
            string question = "Next up: Am I in my 60\'s? [True or False]";
            string details = "I still have two and a half decades before I hit my golden years! During that time I hope to run a full marathon, have kids, and learn how to code!";

            Console.WriteLine(question); //asks the user a question in the console
            string userResponse = Console.ReadLine().ToLower(); //takes user response, converts it to lower case and then stores it locally
            bool parsedResponse = Boolean.Parse(userResponse); //parses the user response to a boolean
            Console.WriteLine(details);// displays the correct anwser with context to the user

            return parsedResponse; //returns either true or false
        }

        static int Question3()
        {
            string question = "Ok, let\'s see if you can guess my favorite number! Don\'t worry if you can\'t get it on the first try, you\'ll have four chances :).";
            string details = "33 was my playing number throughout my AAU and high school basketball days.";
            int userResponse;
            int correctResponse = 33;
            int numberGuesses = 4;
            int j = 0;

            Console.WriteLine(question); //asks the user a question in the console
            do
            {
                Console.WriteLine("Enter a number, (" + (numberGuesses - j) + " guesses remain): ");
                userResponse = int.Parse(Console.ReadLine());
                j++;
                if (userResponse == correctResponse)
                {
                    break;
                }
                if (userResponse < correctResponse)
                {
                    Console.WriteLine("Give it another shot, this time try something higher!");
                }
                if (userResponse > correctResponse)
                {
                    Console.WriteLine("Too high, try something a little lower!");
                }
            } while (j < numberGuesses && userResponse != correctResponse);

            Console.WriteLine(details);// displays the correct anwser with context to the user

            return userResponse;
        }
    }
}
