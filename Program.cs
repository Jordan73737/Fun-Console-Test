using System;

class Program
{
    static void Main()
    {
        int correctAnswers = 0;

        // Show starting screen
        Console.Clear();
        Console.WriteLine("**********  THE TEST  **********\n\n\n\nPress Enter to continue");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("The following test is VERY difficult to ace. \n\n\n\nPress Enter to begin");
        Console.ReadLine();
        Console.Clear();


        // Array to store questions and their corresponding answers
        string[,] questionsAndAnswers = {
            {"I start with T, end with T, and have T in me. Who am I?", "A. Teapot", "B. Transparent", "C. Twilight", "D. Tent", "A"},
            {"A shephard has 86 goats. All but 6 die. How many are left?", "A. 80", "B. 0", "C. 6", "D. 86", "D"},
            {"Swap one letter from each of the words RIGHT and BLIGHT to make two related words", "A. TIGHT and FLIGHT", "B. FIGHT and BRIGHT", "C. LIGHT and BRIGHT", "D. LIGHT and FLIGHT", "C"},
            {"If Tom's father is Tony, then Tony is the ????? of Toms father.", "A. Son", "B. Name", "C. Father", "D. Grandfather", "B"},
            {"What falls but never breaks?", "A. Day", "B. Night", "C. Noon", "D. The Horizon", "B"},
            {"Divide 30 by a half and add 10 what have you got?", "A. 70", "B. 15", "C. 25", "D. 60", "A"},
            {"How many animals of each species did Moses take with him into the Ark?", "A. None", "B. 10", "C. 2 of every kind", "D. 7 pairs of each clean animal and flying creature", "A"},
            {"One day, a person went to a horse racing area. Instead of counting the number of humans and horses,\nhe counted 74 heads and 196 legs. How many humans and horses were there?", "A. 37 humans and 98 horses", "B. 24 horses and 50 humans", "C. 31 horses and 74 humans", "D. 24 humans and 50 horses", "B"},
            {"Half of 2 + 2 =?", "A. 1", "B. 2", "C. 3", "D. 4", "C"},
            {"For a polynomial p(x), the value of p(3) is -2. Which of the following must be true about p(x)?", "A. x - 5 is a factor of p(x)", "B. x - 2 is a factor of p(x)", "C. x + 2 is a factor of p(x)", "D. The remainder when p(x) is divided by x - 3 is -2", "D"}
        };

        // While loop starts the game
        int i = 0;
        while (i < questionsAndAnswers.GetLength(0))
        {
            Console.Clear();
            DisplayQuestion(questionsAndAnswers[i, 0]);
            DisplayOptions(questionsAndAnswers[i, 1], questionsAndAnswers[i, 2], questionsAndAnswers[i, 3], questionsAndAnswers[i, 4]);

            // Get user input with try-catch block
            string userAnswer = "";
            try
            {
                Console.Write("You answered: ");
                userAnswer = Console.ReadLine().ToUpper();

                // Check if the answer is one of the valid options
                if (userAnswer != "A" && userAnswer != "B" && userAnswer != "C" && userAnswer != "D")
                {
                    throw new Exception("Invalid input. Please enter A, B, C, or D.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine("Press Enter to try again...");
                Console.ReadLine();
                continue; // Skip the rest of the loop and go to the next iteration
            }

            // Check if the answer is correct
            if (userAnswer == questionsAndAnswers[i, 5])
            {
                Console.WriteLine("Correct.");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {questionsAndAnswers[i, 5]}.");
            }

            // Display current score 
            Console.WriteLine($"\nScore: {correctAnswers}/{questionsAndAnswers.GetLength(0)}");

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            i++; // Increment the counter
        }

        Console.Clear();
        Console.WriteLine($"Test complete. Your final score is: {correctAnswers}/{questionsAndAnswers.GetLength(0)}");
        // Display a message based on the user's final score
        string[] messages = {
            "This is almost impressive",
            "Really?",
            "*facepalm*",
            "Absolutely Embarrassing",
            "I hope you're enjoying nursery",
            "So, what made you drop out of school?",
            "You had...one of the test scores of all time",
            "A decent score I suppose",
            "Good score",
            "Ok, you're pretty smart",
            "Damn, we got a badass over here!"
        };

        int messageIndex = Math.Min(correctAnswers, messages.Length - 1); // Ensure index is within bounds
        Console.WriteLine(messages[messageIndex]);
        Console.ReadLine();
    }

    static void DisplayQuestion(string question)
    {
        Console.WriteLine(question + "\n");
    }

    static void DisplayOptions(string optionA, string optionB, string optionC, string optionD)
    {
        Console.WriteLine($"{optionA}\n{optionB}\n{optionC}\n{optionD}\n");
    }
}


// WRITE FUNCTION THAT SAVES DIFFERENT USERS SCORE AND KEEPS IT IN A LEADERBOARD DISPLAY 