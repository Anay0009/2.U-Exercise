// // See https://aka.ms/new-console-template for more information

// // Dette tegn er for kommentarer, kan ikke ses i kodningen.
// // (ctrl + k + c) - Gør teksten du har markeret til en kommentar. 
// // (ctrl + k + u) - Gør teksten til kode.

// /*
// Kommentar med flere linjer. 
//  */

// //_________________________________________________________________________________________________________________

// // This is how you write a console (Console.Writeline er som et enter der laver en ny linje efter Console.WriteLine)
// // (Console.Write skriver teksten i en sammenhæng uden mellemrum, hvsi du laver en ny Console.Write)
// Console.WriteLine("Welcome to HELL!");

// Console.Write("Line number one");

// Console.Write("Line number two");

// Console.WriteLine("Line number three");

// //_________________________________________________________________________________________________________________

// /*Datatyper: int, float, string, bool
// int = Et helt tal (-5, 4, 6, 4549894)
// float = Decimal tal (4,54 6,7003, -9,032)
// string = Tekst i "" 
// */

// //Variabler'
// int x; //deklareret x
//     x = 4; //instansierende

//     int y = 5, z = 6; // deklareret og instansierende og z

//     int d = x + y - z * x / z % y;

//     Console.WriteLine("x = " + x + " og y = " + y + " og z = " + z);
//     Console.WriteLine("Resultat af d er = " + d);


// float e = 5.5f;

//     Console.WriteLine("Print e som en float: " + e);

//     int f = Convert.ToInt16(e); //Laver decimal tallet om til et helt tal, så den runder op eller ned

//     Console.WriteLine("Print e som et int: " + f); 


// string str = "Jeg er en string" + " og det er jeg også"; //(Det der bliver skrevet i gåseøjne)
//     // (\n) laver en ny linje selvom du skriver mere, som oven over.

//     Console.WriteLine(str);

// b00l

// //_________________________________________________________________________________________________________________

// // Udregninger (matematik)
// int a = 4;

// int j = 5;

// int m = a + j;

// Console.WriteLine("a + j = " + m); 


// // Console.WriteLine(str);

// string str = "The result is ";

// int u = 4, i = 5;

// Console.Write(str + (u + i));


// Console.Write("Write yout input: ");

// Console.WriteLine("This is my input: " + Console.ReadLine());

// //_________________________________________________________________________________________________________________

// Exercises 1: Write a progam that prints out your name
// Console.WriteLine("Hello Anaya");

// string name = "Anaya";
// Console.WriteLine("Hello " + name);


// Exercises 2: Write a progam that prints out the sum of two numbers
// int x = 15;
// int y = 7;

// Console.WriteLine("The sum of " + x + " plus " + y + " is " + (x + y));


// Exercises 3: Write a progam that prints the result of dividing two numbers.
// int x = 25;
// int y = 5;
// Console.WriteLine("The result of dividing " + x + " and " + y + " is " + (x/y));


// Exercises 4: Write a progam that prints the result of four different operations.
// Console.WriteLine("The first equation is: -1 + 4 * 6, which equals to: " + (-1 + 4 * 6));
// Console.WriteLine("The second equation is: ( 35+ 5 ) % 7, which equals to: " + (( 35+ 5 ) % 7));
// Console.WriteLine("The third equation is: 14 + -4 * 6 / 11, which equals to: " + (14 + -4 * 6 / 11));
// Console.WriteLine("The fourth equation is: 2 + 15 / 6 * 1 - 7 % 2, which equals to: " + (2 + 15 / 6 * 1 - 7 % 2));


// Exercises 5: Write a progam that swap two numbers (skipped)


// Exercises 6: Write a progam that prints the output of the multiplication of three numbers entered by the user.
// int number1, number2, number3;
// Console.WriteLine("Input the first number to multiply: ");
// number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input the second number to multiply: ");
// number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input the third number to multiply: ");
// number3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("The result of multiplying " + number1 + ", " + number2 + " and " + number3 + " is " + (number1*number2*number3));


// Exercises 7: Write a progam that prints on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
// int number1, number2;

// Console.WriteLine("Enter the first number: ");
// number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number: ");
// number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("The result of adding " + number1 + " and " + number2 + " is " + (number1+number2));
// Console.WriteLine("The result of subtracting " + number1 + " and " + number2 + " is " + (number1-number2));
// Console.WriteLine("The result of multiplaying " + number1 + " and " + number2 + " is " + (number1*number2));
// Console.WriteLine("The result of dividing " + number1 + " and " + number2 + " is " + (number1/number2));
// Console.WriteLine("The remainder of dividing " + number1 + " and " + number2 + " is " + (number1%number2) + ", also called modulus.");


// //_________________________________________________________________________________________________________________

// // Ekstra (char)

// char c = 'c';

// Console.WriteLine("c is " + c);


// String input = Console.ReadLine()!;

// Console.WriteLine("Input is " + input);

// char c = Convert.ToChar(input);

// Console.WriteLine("this is my char input " + c);


// char c = (Convert.ToChar(Console.ReadLine()));

// Console.WriteLine("c is " + c);

// //_________________________________________________________________________________________________________________

// // New exercises 

// // Exercise 1: Write a program that takes three letters and displays them in reverse order.

// Char letterOne, letterTwo, letterThree;

// Console.WriteLine("Enter the first letter: ");
// letterOne = Convert.ToChar(Console.ReadLine()!);

// Console.WriteLine("Enter the second letter: ");
// letterTwo = Convert.ToChar(Console.ReadLine()!);

// Console.WriteLine("Enter the third letter: ");
// letterThree = Convert.ToChar(Console.ReadLine()!);

// Console.WriteLine("The numbers are now: {0}, {1}, {2}", letterThree, letterTwo, letterOne);


// // Exercise 5: Write a program that takes the radius of a circle as input and calculates the perimeter and area of the circle.

// int radiuCircle;
// Console.WriteLine("Enter the radius of a circle: ");
// radiuCircle = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("The perimeter of the circle is " + ((2*radiuCircle)*3.141592653589793));
// Console.WriteLine("The area of the circle is " + (3.141592653589793 * (radiuCircle*radiuCircle)));


// // Exercise 7: Write a program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.

// float distance;
// float hour, min, sec;

// float timeSec;
// float mps;
// float kph, mph;

// Console.WriteLine("Input your distance in meters: ");
// distance = float.Parse(Console.ReadLine()!);

// Console.WriteLine("Input your hour: ");
// hour = float.Parse(Console.ReadLine()!);

// Console.WriteLine("Input your minuttes: ");
// min = float.Parse(Console.ReadLine()!);

// Console.WriteLine("Input your seconds: ");
// sec = float.Parse(Console.ReadLine()!);

// timeSec = (hour*3600) + (min*60) + sec;
// mps = distance/timeSec;
// kph = (distance/1000f) / (timeSec*3600f);
// mph = kph / 1.609f;

// Console.WriteLine("Your speed in metres/sec is " + mps);
// Console.WriteLine("Your speed in Km/h is " + mps);
// Console.WriteLine("Your speed in miles/h is " + mps);


// // Exercise 8: Write a program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.



