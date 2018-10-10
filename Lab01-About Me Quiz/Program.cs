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
            Question4(); //calls the method for the fourth question; method returns a string
            Question5(); //calls the method for the fifth question; method does not have a return value
        }

        static bool Question1()
        {
            string question = "First question: Am I an only child? [True or False]";
            string details = "I have a younger brother Eric.  He and I grew up battling each other on the N64, trading blows on Golden Eye and Mario Kart.";
            bool parsedResponse = false;

            Console.WriteLine(question); //asks the user a question in the console
            string userResponse = Console.ReadLine().ToLower(); //takes user response, converts it to lower case and then stores it locally

            if(userResponse == "true" || userResponse == "false" || userResponse == "t" || userResponse == "f")//verifies that user entered an apporiate value
            {
                parsedResponse = Boolean.Parse(userResponse); //parses the user response to a boolean
            }
            
            Console.WriteLine(details);// displays the correct anwser with context to the user

            return parsedResponse; //returns either true or false
        }

        static bool Question2()
        {
            string question = "Next up: Am I in my 60\'s? [True or False]";
            string details = "I still have two and a half decades before I hit my golden years! During that time I hope to run a full marathon, have kids, and learn how to code!";
            bool parsedResponse = false;

            Console.WriteLine(question); //asks the user a question in the console
            string userResponse = Console.ReadLine().ToLower(); //takes user response in as a string, converts it to lower case and then stores it locally

            if (userResponse == "true" || userResponse == "false" || userResponse == "t" || userResponse == "f")//verifies that user entered an apporiate value
            {
                parsedResponse = Boolean.Parse(userResponse); //parses the user response to a boolean
            }

            Console.WriteLine(details);// displays the correct anwser with context to the user

            return parsedResponse; //returns either true or false
        }

        static int Question3() 
        {
            string question = "Ok, let\'s see if you can guess my favorite number! Don\'t worry if you can\'t get it on the first try, you\'ll have four chances :).";
            string details = "33 was my playing number throughout my AAU and high school basketball days.";
            string userResponse;
            int userResponseNum = 0;
            int correctResponse = 33; //my favorite number
            int numberGuesses = 4; //guesses allowed
            int j = 0;

            Console.WriteLine(question); //asks the user a question in the console
            do
            {
                Console.WriteLine("Enter a number, (" + (numberGuesses - j) + " guesses remain): ");//asks the user to enter a number, lets them know how many guesses they have
                userResponse = Console.ReadLine(); //takes user response in and parses it to an int, then stores it locally
                
                if(int.TryParse(userResponse, out userResponseNum))//verifies that user entered an apporiate value
                {
                    j++; //iterates after every try that is a number

                    if (userResponseNum == correctResponse) //if response is correct then loop breaks
                    {
                        break;
                    }
                    else if (userResponseNum < correctResponse) //if guess is too low then lets the user know
                    {
                        Console.WriteLine("Give it another shot, this time try something higher!");
                    }
                    else if (userResponseNum > correctResponse) //if guess is too high then lets the user know
                    {
                        Console.WriteLine("Too high, try something a little lower!");
                    }
                }

                else
                {
                    Console.WriteLine("Please enter numbers only!");
                }
            } while (j < numberGuesses && userResponseNum != correctResponse); //will continue until the user gets the correct anwser or runs out of the chances

            Console.WriteLine(details);// displays the correct anwser with context to the user

            return userResponseNum; //returns the user's final guess
        }

        static string Question4()
        {
            string question = "I\'ve lived in four cities outside the PNW, can you name one of them? I\'ll give you six guesses this time!";
            string details = "I\'ve called St. Roberts, Baghdad, Devil\'s Lake, and Ramadi home but none of them have the same feel to me as Seattle.";
            string userResponse;
            string[] correctResponse = { "st. roberts", "baghdad", "devil\'s lake", "ramadi" }; //cities i've lived in
            int numberGuesses = 6; //guesses allowed
            bool correctAnwser = false;
            int j = 0;
            Console.WriteLine(question); //asks the user a question in the console

            do
            {
                Console.WriteLine("Enter a city, (" + (numberGuesses - j) + " guesses remain): ");//asks the user to enter a number, lets them know how many guesses they have
                userResponse = Console.ReadLine().ToLower(); //takes user response in as a string, converts it to lower case and then stores it locally
                j++; //iterates after every try

                for (int i = 0; i < correctResponse.Length; i++)//iterates through the the correct anwser array to check for correct anwser
                {
                    if(userResponse == correctResponse[i])
                    {
                        correctAnwser = true;
                    }
                }
            } while (j < numberGuesses && !correctAnwser); //will continue until the user gets the correct anwser or runs out of the chances

            Console.WriteLine(details);// displays the correct anwser with context to the user

            return userResponse; //returns the user's final guess
        }

        static void Question5()
        {
            string question = "Have I ever served in the Armed Forces? [True or False]";
            string details = "I\'ve been a Combat Engineer in the U.S. Army Reserves for the last 15 years.  Had the opportunity to serve as a junior enlisted Soldier, a NCO, and an Officer both stateside and oversees.";

            Console.WriteLine(question); //asks the user a question in the console
            string userResponse = Console.ReadLine().ToLower(); //takes user response, converts it to lower case and then stores it locally
            Console.WriteLine(details);// displays the correct anwser with context to the user
        }
    }
}
