// // C# Sharp Conditional Statement : Exercises, Practice, Solution
// // https://www.w3resource.com/csharp-exercises/conditional-statement/index.php
// // Opgave 1-10 (if else exercises)

// class ifElseExercises
// {  
//    static void Main()  
//     {  
//         // Exercise 1: Write a program to accept two integers and check whether they are equal or not.
//         int numb1, numb2; 

//         Console.WriteLine("Enter a number: ");
//         numb1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter a second number: ");
//         numb2 = Convert.ToInt32(Console.ReadLine());

//         if (numb1 == numb2){
//             Console.WriteLine("These two nubmers you choose, " + numb1 + " and " + numb2 + " are equal.");
//         } else {
//             Console.WriteLine(numb1 + " and "+ numb2 + " are not equal.");
//         }


//         // Exercise 2: Write a program to check whether a given number is even or odd.
//         int numb1;

//         Console.WriteLine("Enter a whole number and see if it is odd or even: ");
//         numb1 = Convert.ToInt32(Console.ReadLine());

//         if (numb1 % 2 == 0){
//             Console.WriteLine(numb1 + " is an even number!");
//         } else {
//             Console.WriteLine(numb1 + " is an odd number!");
//         }


//         // Exercise 3: Write a program to check whether a given number is positive or negative.
//         int numb1;

//         Console.WriteLine("Enter a number to see if it is a positive and negative number: ");
//         numb1 = Convert.ToInt32(Console.ReadLine());

//         if (numb1 < 0){
//             Console.WriteLine("The number you chose, which is " + numb1 + ", is a negative number.");
//         } else {
//             Console.WriteLine("The number you chose, which is " + numb1 + ", is a positive number.");
//         }


//         // Exercise 4: Write a program to find out whether a given year is a leap year or not.
//         int year1;

//         Console.WriteLine("Enter a year to see if it is a leap year.");
//         year1 = Convert.ToInt32(Console.ReadLine());

//         if ((year1 % 400) == 0){
//             Console.WriteLine(year1 + "is a leap year!");
//         } else if ((year1 % 100) == 0){
//             Console.WriteLine(year1 + " is NOT a leap year.");
//         } else if ((year1 % 4) == 0){
//             Console.WriteLine(year1 + " is a leap year!");
//         } else {
//             Console.WriteLine(year1 + " is NOT a leap year.");
//         }


//         // Exercise 5: Write a program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
//         int age;

//         Console.WriteLine("Enter your age to see if your eligible to vote: ");
//         age = Convert.ToInt32(Console.ReadLine());

//         if (age >= 21){
//             Console.WriteLine("Your age is " + age + ", which means your eligible to vote!");
//         } else {
//             Console.WriteLine("Your age is " + age + ", which means your NOT eligible to vote!");
//         }


//         // Exercise 6: Write a program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
//         int m;
//         int n;

//         Console.WriteLine("Input the value of m: ");
//         m = Convert.ToInt32(Console.ReadLine());
//         if (m > 0){
//             n = 1;
//             Console.WriteLine("n is " + n );
//         } else if (m == 0){
//             n = 0;
//             Console.WriteLine("n is " + n );
//         } else if (m < 0){
//             n = -1;
//             Console.WriteLine("n is " + n );
//         }


//         // Exercise 7: Write a program to accept a person's height in centimeters and categorize them according to their height.
//         int height;

//         Console.WriteLine("Enter your height in centimeters to see if your a dwarf: ");
//         height = Convert.ToInt32(Console.ReadLine());

//         if (height <= 135){
//             Console.WriteLine("You are a dwarf! Since your height is " + height);
//         } else {
//             Console.WriteLine("You are NOT a dwarf, since your height is " + height);
//             }


//         // Exercise 8: Write a program to find the largest of three numbers.
//         int numb1, numb2, numb3;

//         Console.WriteLine("Find the largest of the three numbers your write down.");

//         Console.WriteLine("Write the 1st nubmer: ");
//         numb1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Write the 2nd nubmer: ");
//         numb2 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Write the 3nd nubmer: ");
//         numb3 = Convert.ToInt32(Console.ReadLine());

//         if (numb1 > numb2 && numb1 > numb3){
//             Console.WriteLine(numb1 + " is the biggest number of the three numbers you wrote.");
//         } else if(numb2 > numb1 && numb2 > numb3){
//             Console.WriteLine(numb2 + " is the biggest number of the three numbers you wrote.");
//         } else {
//             Console.WriteLine(numb3 + " is the biggest number of the three numbers you wrote.");
//         }


//         // Exercise 9: Write a program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
//         int X, Y;

//         Console.WriteLine("Find the quadrant in which the coordinate point lies");

//         Console.WriteLine("Enter the value for X coordinate: ");
//         X = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the value for Y coordinate: ");
//         Y = Convert.ToInt32(Console.ReadLine());

//         if (X > 0 && Y > 0){
//             Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the first quandrant.");
//         } else if (X < 0 && Y > 0){
//             Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the second quandrant.");
//         } else if (X < 0 && Y < 0){
//             Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the third quandrant.");
//         } else if (X > 0 && Y < 0){
//             Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies in the fourth quandrant.");
//         } else if(X == 0 && Y == 0){
//             Console.WriteLine("The coordinate point (" + X + ", " + Y + ") lies at the origin.");
//         }


//         // Exercise 10: Write a program to determine the eligibility for admission to a professional course based on the following criteria:
//         // Marks in Maths >=65
//         // Marks in Phy >=55
//         // Marks in Chem>=50
//         // Total in all three subject >=180
//         // or
//         // One subject with marks >=140

//         int math, phy, chem;

//          Console.WriteLine("Find out if your eligible for admission.");
//          Console.WriteLine("The total in all three subjects should be >=180 or one of your subject should have a mark of >=140");

//          Console.WriteLine("Enter you marks for Mathematics: ");
//          math = Convert.ToInt32(Console.ReadLine());

//           Console.WriteLine("Enter you marks for Physics: ");
//         phy = Convert.ToInt32(Console.ReadLine());

//           Console.WriteLine("Enter you marks for Chemistry: ");
//         chem = Convert.ToInt32(Console.ReadLine());

//         if (math >= 65 && phy >= 55 && chem >= 50){
//             Console.WriteLine("Congratulations! You are eligible for admission! You got a score on " + (math + phy + chem));
//         } else if (math + phy + chem >= 180){
//             Console.WriteLine("Congratulations! You are eligible for admission! You got a score on " + (math + phy + chem));
//         } else if (math >= 140 || phy >= 140 || chem >= 140){
//             Console.WriteLine("Congratulations! You are eligible for admission! You got a score on " + (math + phy + chem));  
//         } else {
//             Console.WriteLine("We are very sorry, but you are NOT eligible for admission. You got a score on " + (math + phy + chem));  
//         }

//    }  
// } 