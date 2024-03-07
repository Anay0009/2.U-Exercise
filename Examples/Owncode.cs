

// class OwnCode
// {

//         static void Main()
//         {

//                 string name;
//                 int age, students, totalAge = 0;

//                 Console.WriteLine("\nHow many student are there in your class?\n ");

//                 Console.Write("Input the number of students: ");
//                 students = Convert.ToInt32(Console.ReadLine());

//                 Console.WriteLine("---------------------------------------");

//                 Console.WriteLine("Write the student's name one at a time.\n ");

//                 for (int i = 0; i < students; i++)
//                 {
//                         Console.Write("Name: ");
//                         name = Console.ReadLine()!;

//                         Console.Write("The age of that student: ");
//                         age = Convert.ToInt32(Console.ReadLine());

//                         totalAge = totalAge + age;

//                         Console.WriteLine("---------------------------------------");
//                 }

//                 double averageAge = (double)totalAge / students;

//                 Console.WriteLine("\nYou've listed {0} names, indicating there are {0} students in your class.", students);
//                 Console.WriteLine("The average age of the students is: {0}\n", averageAge);


//         }

// }



class GuessingGame
{
        static void Main()
        {
                // Welcome message
                Console.WriteLine("Welcome to the Guessing Game!");
                Console.WriteLine("Try to guess the secret number between 1 and 100.");
                Console.WriteLine("You have 10 attempts.");

                // Generate a random secret number between 1 and 100
                int secretNumber = new Random().Next(1, 101);

                int maxAttempts = 10;
                int attempts = 0; // Track the number of attempts

                // Main game loop
                while (attempts < maxAttempts)
                {
                        // Get the user's guess
                        int userGuess = GetUserGuess();

                        // Increment the attempts counter
                        attempts++;

                        // Check if the guess is correct
                        if (CheckGuess(userGuess, secretNumber))
                        {
                                Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} attempts.");
                                break;
                        }
                        else
                        {
                                // Provide feedback on the user's guess
                                if (IsClose(userGuess, secretNumber))
                                {
                                        Console.WriteLine($"Close, but not quite. You have {maxAttempts - attempts} attempts left. Try again.");
                                }
                                else
                                {
                                        Console.WriteLine($"Not even close. You have {maxAttempts - attempts} attempts left. Try again.");
                                }
                        }
                }

                // If the maximum attempts are reached and the loop hasn't broken, inform the user
                if (attempts == maxAttempts)
                {
                        Console.WriteLine($"Sorry, you've used all {maxAttempts} attempts. The correct number was {secretNumber}.");
                }
        }

        // Method to get the user's guess
        static int GetUserGuess()
        {
                Console.Write("Enter your guess: ");
                return Convert.ToInt32(Console.ReadLine());
        }

        // Method to check if the guess is correct
        static bool CheckGuess(int guess, int secretNumber)
        {
                return guess == secretNumber;
        }

        // Method to check if the guess is close
        static bool IsClose(int guess, int secretNumber)
        {
                // Define a threshold for closeness (e.g., within 10 units)
                int threshold = 10;
                return Math.Abs(secretNumber - guess) <= threshold;
        }
}
