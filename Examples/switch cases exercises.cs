// // C# Sharp Conditional Statement : Exercises, Practice, Solution
// // https://www.w3resource.com/csharp-exercises/conditional-statement/index.php
// // Opgave 11-20 (Switch cases exercises)


// class switchCasesExercises
// {
//     static void Main()
//     {  
//         // Exercise 11: Write a program to calculate the root of a quadratic equation.
//         int a, b, c;
//         double d, x1, x2;

//         Console.WriteLine("Calculate root of Quadratic Equation");

//         Console.WriteLine("Enter the value you want (a) to be: ");
//         a = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter the value you want (b) to be: ");
//         b = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter the value you want (c) to be: ");
//         c = Convert.ToInt32(Console.ReadLine());

//         d = b*b-4*a*c;
//         if (d == 0) {
//             Console.WriteLine("Both roots are equal.");
//             x1=-b/(2.0*a);
//             x2=x1;
//             Console.WriteLine("There is only one root, which is {0}.",x1);
//         }
//         else if (d>0) {
//             Console.WriteLine("There are two roots.");
//             x1=(-b+Math.Sqrt(d))/(2*a);
//         	x2=(-b-Math.Sqrt(d))/(2*a);

//             Console.Write("The first Root is {0}.",x1);
//         	Console.Write("The second Root is {0}.",x2);
//         }
//         else {
//             Console.Write("There is no root, because the discriminant is negative = {0}.",d);
//         }


//         // Exercise 12: Write a program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
//         int rollNumb, phy, chem, comp, totalMarks;
//         string nm, div;
//         double avg;

//         Console.Write("Input the Roll Number of the student: ");
//         rollNumb = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Input the student name: ");
//         nm = Console.ReadLine()!;

//         Console.Write("Input the marks of Physics: ");
//         phy = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Input the marks of Chemistry: ");
//         chem = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Input the marks of Computer Application: ");
//         comp = Convert.ToInt32(Console.ReadLine());

//         totalMarks = phy + chem + comp;
//         avg = totalMarks/3;

//         switch (avg){
//              case >= 60:
//                 div = "You're in the first division!";
//                 break;
//             case >= 48:
//                 div = "You're in the second division!";
//                 break;
//             case >= 36:
//                 div = "You barely passed! Congratulations!";
//                 break;
//             default:
//                 div = "You failed! Good luck next year!";
//                 break;
//         }

//         Console.WriteLine("--------------------------------------------------------------------------");
//         Console.WriteLine("Roll Number: {0} \nName of Student: {1}",rollNumb, nm);
//         Console.WriteLine("Marks in Physics: {0} \nMarks in Chemistry: {1} \nMarks in Computer Application: {2}", phy, chem, comp);
//         Console.WriteLine("Total Marks = {0} \nPercentage = {1} % \nDivision = {2}",totalMarks, avg, div);


//         // Exercise 13: Write a program to read temperature in centigrade and display a suitable message according to the temperature state below:
//         // Temp < 0 then Freezing weather
//         // Temp 0-10 then Very Cold weather
//         // Temp 10-20 then Cold weather
//         // Temp 20-30 then Normal in Temp
//         // Temp 30-40 then Its Hot
//         // Temp >=40 then Its Very Hot

//         int temp;

//         Console.Write("Input the temperature in celcius: ");
//         temp = Convert.ToInt32(Console.ReadLine());

//         switch (temp){
//             case < 0:
//                 Console.WriteLine("It's freezing outside! Bring a thick coat and scarf with you, when you go outside.");
//                 break;
//             case < 10:
//                 Console.WriteLine("It's cold outside! Bring a coat with you, when you go outside.");
//                 break;
//             case < 20:
//                 Console.WriteLine("It's warm outside. Bring a light coat with you, when you go outside.");
//                 break;
//             case < 30:
//                 Console.WriteLine("It's hot outside! Bring an extra T-shirt with you.");
//                 break;
//             case < 40:
//                 Console.WriteLine("It's very hot outside! Stay in the shade and go to the beach to cool down.");
//                 break; 
//             default:
//                 Console.WriteLine("The temperatur is to hot! Drink a lot of water and stay inside!");
//                 break;
//         }


//         // Exercise 14: Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
//         Console.WriteLine("Check whether a triangle is Equilateral, Isosceles or Scalene:");

//         int s1, s2, s3;

//         Console.Write("Input side 1 of triangle: ");
//         s1= Convert.ToInt32(Console.ReadLine());

//         Console.Write("Input side 2 of triangle: ");
//         s2= Convert.ToInt32(Console.ReadLine()); 

//         Console.Write("Input side 3 of triangle: ");
//         s3= Convert.ToInt32(Console.ReadLine());  

//         Console.WriteLine("--------------------------------------------------------------------------");
//         if (s1 == s2 && s1 == s3){
//             Console.WriteLine("This is an equilateral triangle, since side 1 is {0}, side 2 is {1}, and side 3 is {2}.",s1, s2, s3);
//         } else if (s1 == s2 || s1 == s3 || s2 == s3){
//             Console.WriteLine("This is an isosceles triangle, since side 1 is {0}, side 2 is {1}, and side 3 is {2}.",s1, s2, s3);
//         } else {
//             Console.WriteLine("This is a scalene triangle, since side 1 is {0}, side 2 is {1}, and side 3 is {2}.",s1, s2, s3);
//         }


//         // Exercise 15: Write a program to check whether a triangle can be formed by the given angles value.
//         int ang1, ang2, ang3, sum;

//         Console.WriteLine("Check whether a triangle can be formed by given value:");

//         Console.Write("Input angle 1 of triangle: ");
//         ang1= Convert.ToInt32(Console.ReadLine());

//         Console.Write("Input angle 2 of triangle: ");
//         ang2= Convert.ToInt32(Console.ReadLine()); 

//         Console.Write("Input angle 3 of triangle: ");
//         ang3= Convert.ToInt32(Console.ReadLine()); 

//         Console.WriteLine("--------------------------------------------------------------------------");

//         sum = ang1 + ang2 + ang3;   

//         switch (sum){
//             case 180:
//                 Console.WriteLine("The triangle is valid, since the sum is {0}.",sum); 
//                 break;
//             default:
//                 Console.WriteLine("The triangle is not valid, since the sum is {0}.",sum); 
//                 break;
//         }


//         // Exercise 16: Write a program to check whether an alphabet letter is a vowel or a consonant.'
//         Console.WriteLine("Check whether the input from the alphabet is a vowel or not.");

//         char ch;

//         Console.Write("Input any letter from the alphabet: ");
//         ch = Convert.ToChar(Console.ReadLine()!);

//         Console.WriteLine("--------------------------------------------------------------------------");

//         switch (ch){
//             case 'a':
//             case 'e':
//             case 'i':
//             case 'o':
//             case 'u':
//             case 'y':
//                 Console.WriteLine("The letter '" + ch + "' is a vowel.");
//                 break;
//             default:
//                 Console.WriteLine("The letter '" + ch + "' is a consonant.");
//                 break;
//         }

//         // Exercise 17: Write a program to calculate profit and loss on a transaction.
//         int costPrice, sellPrice, profit, loss;

//         Console.WriteLine("Enter the cost price.");
//         costPrice = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the sell price.");
//         sellPrice = Convert.ToInt32(Console.ReadLine());

//         if (sellPrice > costPrice){
//             profit = sellPrice - costPrice;
//             Console.WriteLine("You made a profit of " + profit + ".");
//         }else if(sellPrice < costPrice){
//             loss = costPrice - sellPrice;
//             Console.WriteLine("You made a loss of " + loss + ".");
//         }else{
//             Console.WriteLine("You are running in no profit no loss condition.");
//         }


//         // Exercise 18: Write a program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
//         string customerName, customerID;
//         int unitConsumed;
//         double totalAmountDue, amountCharged, surcharge = 0;

//         Console.WriteLine("Enter your name: ");
//         customerName = Console.ReadLine()!;

//         Console.WriteLine("Enter your ID: ");
//         customerID = Console.ReadLine()!;

//         Console.WriteLine("Enter the ammount of units consumed: ");
//         unitConsumed = Convert.ToInt32(Console.ReadLine());


//         switch(unitConsumed){
//             case < 199:
//                 amountCharged = (unitConsumed * 1.20);
//                 break;
//             case < 400:
//                 amountCharged = (unitConsumed * 1.50);
//                 break;
//             case < 600:
//                 amountCharged = (unitConsumed * 1.80);
//                 surcharge = (amountCharged * 0.15);
//                 break;
//             default:
//                 amountCharged = (unitConsumed * 2.00);
//                 surcharge = (amountCharged * 0.15);
//                 break;
//         }

//         totalAmountDue = amountCharged + surcharge;
//         Console.WriteLine("Customer ID " + customerID);
//         Console.WriteLine("Customer name " + customerName);
//         Console.WriteLine("Unit consumed " + unitConsumed);
//         Console.WriteLine("Amount Charges per unit " + amountCharged, unitConsumed);
//         Console.WriteLine("Surchage Amount " + surcharge);
//         Console.WriteLine("Net Amount Paid By the Customer: {0}.", totalAmountDue);


//         // Exercise 19: Write a program that accepts a grade and declare the equivalent description.
        
//         Console.WriteLine("Accept a grade and display equivalent description.");

//         Console.Write("Input the grade: ");
//         char grade = Convert.ToChar(Console.ReadLine()!.ToUpper());

//         switch (grade){
//             case 'E':
//                 Console.WriteLine("Your grade is excellent.");
//                 break;
//             case 'V':
//                 Console.WriteLine("Your grade is very good.");
//                 break; 
//             case 'G':
//                 Console.WriteLine("Your grade is good.");
//                 break; 
//             case 'A':
//                 Console.WriteLine("Your grade is average.");
//                 break; 
//             case 'F':
//                 Console.WriteLine("You failed.");
//                 break; 
//             default:
//                 Console.WriteLine("Your grade is invalid.");
//                 break; 
//         }


//         // Exercise 20: Write a program to read any day number as an integer and display the name of the day as a word. 

//         Console.WriteLine("Enter the day number (1-7, mon-sun).");
//         int day = Convert.ToInt32(Console.ReadLine());

//         switch(day){
//             case 1:
//                 Console.WriteLine("Day number {0} is Monday!", day);
//                 break;
//             case 2:
//                 Console.WriteLine("Day number {0} is Tuesday!", day);
//                 break;
//             case 3:
//                 Console.WriteLine("Day number {0} is Wednesday!", day);
//                 break;
//             case 4:
//                 Console.WriteLine("Day number {0} is Thursday!", day);
//                 break;
//             case 5:
//                 Console.WriteLine("Day number {0} is Friday!", day);
//                 break;
//             case 6:
//                 Console.WriteLine("Day number {0} is Saturday!", day);
//                 break;
//             case 7:
//                 Console.WriteLine("Day number {0} is Sunday!", day);
//                 break;
//         }  

//     }  
// } 