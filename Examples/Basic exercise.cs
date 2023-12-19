// // C# Sharp Basic Declarations and Expressions : Exercises, Practice, Solution
// // https://www.w3resource.com/csharp-exercises/basic/index.php
// // Opgave 1-14 (datatypes exercises)

// public class basicexercise 
// {
    
//     public static void Main()
//     {
//         // Exercises 1: Write a progam that prints out your name
//         Console.WriteLine("Hello Anaya");

//         string name = "Anaya";
//         Console.WriteLine("Hello " + name);


//         // Exercises 2: Write a progam that prints out the sum of two numbers
//         int x = 15;
//         int y = 7;

//         Console.WriteLine("The sum of " + x + " plus " + y + " is " + (x + y));


//         // Exercises 3: Write a progam that prints the result of dividing two numbers.
//         int x = 25;
//         int y = 5;
//         Console.WriteLine("The result of dividing " + x + " and " + y + " is " + (x/y));


//         // Exercises 4: Write a progam that prints the result of four different operations.
//         Console.WriteLine("The first equation is: -1 + 4 * 6, which equals to: " + (-1 + 4 * 6));
//         Console.WriteLine("The second equation is: ( 35+ 5 ) % 7, which equals to: " + (( 35 + 5 ) % 7));
//         Console.WriteLine("The third equation is: 14 + -4 * 6 / 11, which equals to: " + (14 + -4 * 6 / 11));
//         Console.WriteLine("The fourth equation is: 2 + 15 / 6 * 1 - 7 % 2, which equals to: " + (2 + 15 / 6 * 1 - 7 % 2));


//         // Exercises 5: Write a progam that swap two numbers (skipped)


//         // Exercises 6: Write a progam that prints the output of the multiplication of three numbers entered by the user.
//         int number1, number2, number3;

//         Console.WriteLine("Please provide three numbers you'd like to multiply together. ");

//         Console.WriteLine("Input the first number: "); 
//         number1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Input the second number: ");
//         number2 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Input the third number: ");
//         number3 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("The result of multiplying " + number1 + ", " + number2 + " and " + number3 + " is " + (number1*number2*number3));


//         // Exercises 7: Write a progam that prints on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
//         // // int number1, number2;

//         Console.WriteLine("Enter the first number: ");
//         number1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the first number: ");
//         number2 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("The result of adding " + number1 + " and " + number2 + " is " + (number1+number2));
//         Console.WriteLine("The result of subtracting " + number1 + " and " + number2 + " is " + (number1-number2));
//         Console.WriteLine("The result of multiplaying " + number1 + " and " + number2 + " is " + (number1*number2));
//         Console.WriteLine("The result of dividing " + number1 + " and " + number2 + " is " + (number1/number2));
//         Console.WriteLine("The remainder of dividing " + number1 + " and " + number2 + " is " + (number1%number2) + ", also called modulus.");

//         // _________________________________________________________________________________________________


//         // Exercise 1: Write a program that takes three letters and displays them in reverse order.
//         Char letterOne, letterTwo, letterThree;

//         Console.WriteLine("Enter the first letter: ");
//         letterOne = Convert.ToChar(Console.ReadLine()!);

//         Console.WriteLine("Enter the second letter: ");
//         letterTwo = Convert.ToChar(Console.ReadLine()!);

//         Console.WriteLine("Enter the third letter: ");
//         letterThree = Convert.ToChar(Console.ReadLine()!);

//         Console.WriteLine("The numbers are now: {0}, {1}, {2}", letterThree, letterTwo, letterOne);


//         // Exercise 5: Write a program that takes the radius of a circle as input and calculates the perimeter and area of the circle.
//         int radiuCircle;
//         Console.WriteLine("Enter the radius of a circle: ");
//         radiuCircle = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("The perimeter of the circle is " + ((2*radiuCircle)*3.141592653589793));
//         Console.WriteLine("The area of the circle is " + (3.141592653589793 * (radiuCircle*radiuCircle)));


//         // Exercise 7: Write a program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.
//         float distance;
//         float hour, min, sec;

//         float timeSec;
//         float mps;
//         float kph, mph;

//         Console.WriteLine("Input your distance in meters: ");
//         distance = float.Parse(Console.ReadLine()!);

//         Console.WriteLine("Input your hour: ");
//         hour = float.Parse(Console.ReadLine()!);

//         Console.WriteLine("Input your minuttes: ");
//         min = float.Parse(Console.ReadLine()!);

//         Console.WriteLine("Input your seconds: ");
//         sec = float.Parse(Console.ReadLine()!);

//         timeSec = (hour*3600) + (min*60) + sec;
//         mps = distance/timeSec;
//         kph = (distance/1000f) / (timeSec*3600f);
//         mph = kph / 1.609f;

//         Console.WriteLine("Your speed in metres/sec is " + mps);
//         Console.WriteLine("Your speed in Km/h is " + mps);
//         Console.WriteLine("Your speed in miles/h is " + mps);


//         // Exercise 8: Write a program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.

     
//     }
// }

        
