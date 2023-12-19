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
// bool = 
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


// // Exercises 4: Write a progam that prints the result of four different operations.
// Console.WriteLine("The first equation is: -1 + 4 * 6, which equals to: " + (-1 + 4 * 6));
// Console.WriteLine("The second equation is: ( 35+ 5 ) % 7, which equals to: " + (( 35 + 5 ) % 7));
// Console.WriteLine("The third equation is: 14 + -4 * 6 / 11, which equals to: " + (14 + -4 * 6 / 11));
// Console.WriteLine("The fourth equation is: 2 + 15 / 6 * 1 - 7 % 2, which equals to: " + (2 + 15 / 6 * 1 - 7 % 2));


// Exercises 5: Write a progam that swap two numbers (skipped)


// // Exercises 6: Write a progam that prints the output of the multiplication of three numbers entered by the user.
// int number1, number2, number3;

// Console.WriteLine("Please provide three numbers you'd like to multiply together. ");

// Console.WriteLine("Input the first number: "); 
// number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input the second number: ");
// number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input the third number: ");
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


// //_________________________________________________________________________________________________________________

// // If else statements

// int x = 7;

// bool isFour = x ==4;

// if (x == 4) {
//     Console.WriteLine("I am the if statement");
// } else if (x > 4 ){
//     Console.WriteLine("I am the second condition");

//     if ( x == 5 ){
//         Console.WriteLine("X is 5");
//     } else {
//         Console.WriteLine("I am a nested else statement");
    
//         if (x == 7){
//             Console.WriteLine("X is 7");
//         } else {
//             Console.WriteLine("X is not 7");
//         }
//     }
// } else {
//     Console.WriteLine("I am the else condition");
// }


// int x = 4;

// if (x > 5){
//     Console.WriteLine("Bigger");
// } else {
//     Console.WriteLine("Not");
// }


// int x = 5;

// if (x > 5){
//     Console.WriteLine("Bigger");
// } else if (x < 5) {
//     Console.WriteLine("Smaller");
// } else if (x != 0){
//     Console.WriteLine("Not 0");
// } else if (x == 5){
//     Console.WriteLine("x is 5");
// } else {
//     Console.WriteLine("Else");
// }


// int x = 7;

// if (x == 4) {
//     Console.WriteLine("I am the if statement");
// } else if (x > 4 ){
//     Console.WriteLine("I am the second condition");

//     if ( x == 5 ){
      
//         int y = 5;
        
//     } else {
       
//         int y = 7;
    
//         if (y > 7){
           
//             y = 6;
//         } else {
            
//         }
//         Console.WriteLine("Y is " + y);
//     }
// } else {
//     Console.WriteLine("I am the else condition");
// }

// //_________________________________________________________________________________________________________________

// // Conditional exercises (Learned if else)

// // Exercise 1: Write a program to accept two integers and check whether they are equal or not.
// int numb1, numb2; 

// Console.WriteLine("Enter a number: ");
// numb1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter a second number: ");
// numb2 = Convert.ToInt32(Console.ReadLine());

// if (numb1 == numb2){
//     Console.WriteLine("These two nubmers you choose, " + numb1 + " and " + numb2 + " are equal.");
// } else {
//     Console.WriteLine(numb1 + " and "+ numb2 + " are not equal.");
// }


// // Exercise 2: Write a program to check whether a given number is even or odd.
// int numb1;

// Console.WriteLine("Enter a whole number and see if it is odd or even: ");
// numb1 = Convert.ToInt32(Console.ReadLine());

// if (numb1 % 2 == 0){
//     Console.WriteLine(numb1 + " is an even number!");
// } else {
//     Console.WriteLine(numb1 + " is an odd number!");
// }


// // Exercise 3: Write a program to check whether a given number is positive or negative.
// int numb1;

// Console.WriteLine("Enter a number to see if it is a positive and negative number: ");
// numb1 = Convert.ToInt32(Console.ReadLine());

// if (numb1 < 0){
//     Console.WriteLine("The number you chose, which is " + numb1 + ", is a negative number.");
// } else {
//     Console.WriteLine("The number you chose, which is " + numb1 + ", is a positive number.");
// }


// // Exercise 4: Write a program to find out whether a given year is a leap year or not.
// int year1;

// Console.WriteLine("Enter a year to see if it is a leap year.");
// year1 = Convert.ToInt32(Console.ReadLine());

// if ((year1 % 400) == 0){
//     Console.WriteLine(year1 + "is a leap year!");
// } else if ((year1 % 100) == 0){
//     Console.WriteLine(year1 + " is NOT a leap year.");
// } else if ((year1 % 4) == 0){
//     Console.WriteLine(year1 + " is a leap year!");
// } else {
//     Console.WriteLine(year1 + " is NOT a leap year.");
// }


// // Exercise 5: Write a program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
// int age;

// Console.WriteLine("Enter your age to see if your eligible to vote: ");
// age = Convert.ToInt32(Console.ReadLine());

// if (age >= 21){
//     Console.WriteLine("Your age is " + age + ", which means your eligible to vote!");
// } else {
//     Console.WriteLine("Your age is " + age + ", which means your NOT eligible to vote!");
// }


// // Exercise 6: Write a program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
// int m;
// int n;

// Console.WriteLine("Input the value of m: ");
// m = Convert.ToInt32(Console.ReadLine());
// if (m > 0){
//     n = 1;
//     Console.WriteLine("n is " + n );
// } else if (m == 0){
//     n = 0;
//     Console.WriteLine("n is " + n );
// } else if (m < 0){
//     n = -1;
//     Console.WriteLine("n is " + n );
// }


// // Exercise 7: Write a program to accept a person's height in centimeters and categorize them according to their height.
// int height;

// Console.WriteLine("Enter your height in centimeters to see if your a dwarf: ");
// height = Convert.ToInt32(Console.ReadLine());

// if (height <= 135){
//     Console.WriteLine("You are a dwarf! Since your height is " + height);
// } else {
//     Console.WriteLine("You are NOT a dwarf, since your height is " + height);
//     }


// // Exercise 8: Write a program to find the largest of three numbers.
// int numb1, numb2, numb3;

// Console.WriteLine("Find the largest of the three numbers your write down.");

// Console.WriteLine("Write the 1st nubmer: ");
// numb1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Write the 2nd nubmer: ");
// numb2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Write the 3nd nubmer: ");
// numb3 = Convert.ToInt32(Console.ReadLine());

// if (numb1 > numb2 && numb1 > numb3){
//     Console.WriteLine(numb1 + " is the biggest number of the three numbers you wrote.");
// } else if(numb2 > numb1 && numb2 > numb3){
//     Console.WriteLine(numb2 + " is the biggest number of the three numbers you wrote.");
// } else {
//     Console.WriteLine(numb3 + " is the biggest number of the three numbers you wrote.");
// }


// // Exercise 9: Write a program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
// int X, Y;

// Console.WriteLine("Find the quadrant in which the coordinate point lies");

// Console.WriteLine("Enter the value for X coordinate: ");
// X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the value for Y coordinate: ");
// Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0){
//     Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the first quandrant.");
// } else if (X < 0 && Y > 0){
//     Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the second quandrant.");
// } else if (X < 0 && Y < 0){
//     Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the third quandrant.");
// } else if (X > 0 && Y < 0){
//     Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the fourth quandrant.");
// } else if(X == 0 && Y == 0){
//     Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies at the origin.");
// }


// // Exercise 10: Write a program to determine the eligibility for admission to a professional course based on the following criteria:
// // Marks in Maths >=65
// // Marks in Phy >=55
// // Marks in Chem>=50
// // Total in all three subject >=180
// // or
// // One subject with marks >=140

// int math, phy, chem;

//  Console.WriteLine("Find out if your eligible for admission.");
//  Console.WriteLine("The total in all three subjects should be >=180 or one of your subject should have a mark of >=140");

//  Console.WriteLine("Enter you marks for Mathematics: ");
//  math = Convert.ToInt32(Console.ReadLine());

//   Console.WriteLine("Enter you marks for Physics: ");
// phy = Convert.ToInt32(Console.ReadLine());

//   Console.WriteLine("Enter you marks for Chemistry: ");
// chem = Convert.ToInt32(Console.ReadLine());

// if (math >= 65 && phy >= 55 && chem >= 50){
//     Console.WriteLine("Congratulations! You are eligible for admission! You got a score on " + (math + phy + chem));
// } else if (math + phy + chem >= 180){
//     Console.WriteLine("Congratulations! You are eligible for admission! You got a score on " + (math + phy + chem));
// } else if (math >= 140 || phy >= 140 || chem >= 140){
//     Console.WriteLine("Congratulations! You are eligible for admission! You got a score on " + (math + phy + chem));  
// } else {
//     Console.WriteLine("We are very sorry, but you are NOT eligible for admission. You got a score on " + (math + phy + chem));  
// }

// //_________________________________________________________________________________________________________________

// // Exercises, Practice, Solution

// // Exercise 11: Write a program to calculate the root of a quadratic equation.

// int a, b, c;
// double d, x1, x2;

// Console.WriteLine("Calculate root of Quadratic Equation");

// Console.WriteLine("Enter the value you want (a) to be: ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value you want (b) to be: ");
// b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value you want (c) to be: ");
// c = Convert.ToInt32(Console.ReadLine());

// d = b*b-4*a*c;
// if (d == 0) {
//     Console.WriteLine("Both roots are equal.");
//     x1=-b/(2.0*a);
//     x2=x1;
//     Console.WriteLine("There is only one root, which is {0}.",x1);
// }
// else if (d>0) {
//     Console.WriteLine("There are two roots.");
//     x1=(-b+Math.Sqrt(d))/(2*a);
// 	x2=(-b-Math.Sqrt(d))/(2*a);

//     Console.Write("The first Root is {0}.",x1);
// 	Console.Write("The second Root is {0}.",x2);
// }
// else {
//     Console.Write("There is no root, because the discriminant is negative = {0}.",d);
// }


// // Exercise 12: Write a program to read roll no, name and marks of three subjects and calculate the total, percentage and division.

// int rollNumb, phy, chem, comp, totalMarks;
// string nm, div;
// double avg;

// Console.Write("Input the Roll Number of the student: ");
// rollNumb = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the student name: ");
// nm = Console.ReadLine()!;

// Console.Write("Input the marks of Physics: ");
// phy = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the marks of Chemistry: ");
// chem = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the marks of Computer Application: ");
// comp = Convert.ToInt32(Console.ReadLine());

// totalMarks = phy + chem + comp;
// avg = totalMarks/3;

// switch (avg){
//      case >= 60:
//         div = "You're in the first division!";
//         break;
//     case >= 48:
//         div = "You're in the second division!";
//         break;
//     case >= 36:
//         div = "You barely passed! Congratulations!";
//         break;
//     default:
//         div = "You failed! Good luck next year!";
//         break;
// }

// Console.WriteLine("--------------------------------------------------------------------------");
// Console.WriteLine("Roll Number: {0} \nName of Student: {1}",rollNumb, nm);
// Console.WriteLine("Marks in Physics: {0} \nMarks in Chemistry: {1} \nMarks in Computer Application: {2}", phy, chem, comp);
// Console.WriteLine("Total Marks = {0} \nPercentage = {1} % \nDivision = {2}",totalMarks, avg, div);


// // Exercise 13: Write a program to read temperature in centigrade and display a suitable message according to the temperature state below:

// // Temp < 0 then Freezing weather
// // Temp 0-10 then Very Cold weather
// // Temp 10-20 then Cold weather
// // Temp 20-30 then Normal in Temp
// // Temp 30-40 then Its Hot
// // Temp >=40 then Its Very Hot

// int temp;

// Console.Write("Input the temperature in celcius: ");
// temp = Convert.ToInt32(Console.ReadLine());

// switch (temp){
//     case < 0:
//         Console.WriteLine("It's freezing outside! Bring a thick coat and scarf with you, when you go outside.");
//         break;
//     case < 10:
//         Console.WriteLine("It's cold outside! Bring a coat with you, when you go outside.");
//         break;
//     case < 20:
//         Console.WriteLine("It's warm outside. Bring a light coat with you, when you go outside.");
//         break;
//     case < 30:
//         Console.WriteLine("It's hot outside! Bring an extra T-shirt with you.");
//         break;
//     case < 40:
//         Console.WriteLine("It's very hot outside! Stay in the shade and go to the beach to cool down.");
//         break; 
//     default:
//         Console.WriteLine("The temperatur is to hot! Drink a lot of water and stay inside!");
//         break;
// }


// // Exercise 14: Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.

// Console.WriteLine("Check whether a triangle is Equilateral, Isosceles or Scalene:");

// int s1, s2, s3;

// Console.Write("Input side 1 of triangle: ");
// s1= Convert.ToInt32(Console.ReadLine());

// Console.Write("Input side 2 of triangle: ");
// s2= Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Input side 3 of triangle: ");
// s3= Convert.ToInt32(Console.ReadLine());  

// Console.WriteLine("--------------------------------------------------------------------------");
// if (s1 == s2 && s1 == s3){
//     Console.WriteLine("This is an equilateral triangle, since side 1 is {0}, side 2 is {1}, and side 3 is {2}.",s1, s2, s3);
// } else if (s1 == s2 || s1 == s3 || s2 == s3){
//     Console.WriteLine("This is an isosceles triangle, since side 1 is {0}, side 2 is {1}, and side 3 is {2}.",s1, s2, s3);
// } else {
//     Console.WriteLine("This is a scalene triangle, since side 1 is {0}, side 2 is {1}, and side 3 is {2}.",s1, s2, s3);
// }


// // Exercise 15: Write a program to check whether a triangle can be formed by the given angles value.

int ang1, ang2, ang3, sum;

Console.WriteLine("Check whether a triangle can be formed by given value:");

Console.Write("Input angle 1 of triangle: ");
ang1= Convert.ToInt32(Console.ReadLine());

Console.Write("Input angle 2 of triangle: ");
ang2= Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input angle 3 of triangle: ");
ang3= Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("--------------------------------------------------------------------------");

sum = ang1 + ang2 + ang3;   

switch (sum){
    case 180:
        Console.WriteLine("The triangle is valid, since the sum is {0}.",sum); 
        break;
    default:
        Console.WriteLine("The triangle is not valid, since the sum is {0}.",sum); 
        break;
}
