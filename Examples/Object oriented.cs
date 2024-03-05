// class ObjectOriented
// {

//     static void Main()
//     {
//         Console.WriteLine("What exercise do you want me to find?");
//         Console.WriteLine("1, 2, 3, 4, 6, 7, 8, 9 or 10?: ");
//         int x = Convert.ToInt32(Console.ReadLine());

//         switch (x)
//         {
//             case 1:
//                 Exercise1();
//                 break;
//             case 2:
//                 Exercise2();
//                 break;
//             case 3:
//                 Exercise3();
//                 break;
//             case 4:
//                 Exercise4();
//                 break;
//             case 5:
//                 Exercise5();
//                 break;
//             case 6:
//                 Exercise6();
//                 break;
//             case 7:
//                 Exercise7();
//                 break;
//             case 8:
//                 Exercise8();
//                 break;
//             case 9:
//                 Exercise9();
//                 break;
//             case 10:
//                 Exercise10();
//                 break;
//         }
//     }
//     // // -----------------------------------------------------------------------------

//     // // Exercise 1: Write a program in C# Sharp to create a user defined function.
//     static void Exercise1()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a user defined function.");
//         Console.WriteLine("---------------------------------------");

//         Welcome();
//         Day();
//     }

//     static void Welcome()
//     {
//         Console.WriteLine("Welcome friends");
//     }

//     static void Day()
//     {
//         Console.WriteLine("Have a nicce day!");
//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 2: Write a program in C# Sharp to create a user defined function with parameters.
//     static void Exercise2()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a user defined function with parameters.");
//         Console.WriteLine("---------------------------------------");

//         Console.Write("Please input a name : ");
//         string str1 = Console.ReadLine()!;

//         WelcomeFriend(str1);
//         NiceDay();
//     }

//     static void WelcomeFriend(string name)
//     {
//         Console.WriteLine($"Welcome friend {name} !");
//     }

//     static void NiceDay()
//     {
//         Console.WriteLine("Have a nice day!");
//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 3: Write a program in C# Sharp to create a function for the sum of two numbers.
//     static void Exercise3()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a function for the sum of two numbers.");
//         Console.WriteLine("---------------------------------------");

//         Console.Write("Enter the first number: ");
//         int numb1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter the second number: ");
//         int numb2 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(numb1, numb2));
//     }

//     static int Sum(int numb1, int numb2)
//     {
//         int total;
//         total = numb1 + numb2;
//         return total;
//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 4: Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
//     static void Exercise4()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.");
//         Console.WriteLine("---------------------------------------");

//         string str2;

//         Console.Write("Please input a string : ");
//         str2 = Console.ReadLine()!;

//         Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
//     }

//     static int SpaceCount(string str)
//     {

//         int spcctr = 0;
//         string str1;

//         for (int i = 0; i < str.Length; i++)
//         {
//             str1 = str.Substring(i, 1);
//             if (str1 == " ")
//                 spcctr++;
//         }
//         return spcctr;
//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 5: Write a program in C# Sharp to calculate the sum of elements in an array.
//     static void Exercise5()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to calculate the sum of elements in an array.");
//         Console.WriteLine("---------------------------------------");

//         int[] arr1 = new int[5];

//         Console.Write("Input 5 elements in the array :\n");

//         for (int i = 0; i < 5; i++)
//         {
//             Console.Write("Element - {0} : ", i);
//             arr1[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.WriteLine("The sum of the elements of the array is {0}.", Sum(arr1));

//         static int Sum(int[] arr1)
//         {

//             int tot = 0;

//             for (int x = 0; x < arr1.Length; x++)
//             {
//                 tot += arr1[x];
//             }

//             return tot;
//         }
//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 6: Write a program in C# Sharp to create a function to swap two integer numbers.
//     static void Exercise6()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a function to swap two integer numbers.");
//         Console.WriteLine("---------------------------------------");

//         int n1, n2;

//         Console.Write("Enter a number: ");
//         n1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter another number: ");
//         n2 = Convert.ToInt32(Console.ReadLine());

//         interchange(ref n1, ref n2);

//         Console.WriteLine("Now the 1st number is : {0} , and the 2nd number is : {1}", n1, n2);

//     }

//     static void interchange(ref int numb1, ref int numb2)
//     {
//         int newnumb;

//         newnumb = numb1;
//         numb1 = numb2;
//         numb2 = newnumb;
//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 7: Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
//     static void Exercise7()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.");
//         Console.WriteLine("---------------------------------------");

//         int n1;
//         int exp1;

//         Console.Write("Input Base number: ");
//         n1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Input the Exponent : ");
//         exp1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ", n1, exp1, PowerRaising(n1, exp1));
//     }

//     static int PowerRaising(int num, int exp)
//     {
//         int rvalue = 1;
//         int i;

//         for (i = 1; i <= exp; i++)
//         {
//             rvalue = rvalue * num;
//         }
//         return rvalue;
//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 8: Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.
//     static void Exercise8()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.");
//         Console.WriteLine("---------------------------------------");


//     }


//     // // -----------------------------------------------------------------------------

//     // // Exercise 9: Write a program in C# Sharp to create a function to check whether a number is prime or not.
//     static void Exercise9()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a function to check whether a number is prime or not.");
//         Console.WriteLine("---------------------------------------");

//         Console.Write("Input a number : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         if (chkprime(n))
//         {
//             Console.WriteLine(n + " is a prime number");
//         }
//         else
//         {
//             Console.WriteLine(n + " is not a prime number");
//         }

//         static bool chkprime(int num)
//         {
//             for (int i = 2; i < num; i++)
//             {
//                 if (num % i == 0)
//                 {
//                     return false;
//                 }
//             }
//             return true;
//         }

//     }

//     // // -----------------------------------------------------------------------------

//     // // Exercise 10: Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
//     static void Exercise10()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.");
//         Console.WriteLine("---------------------------------------");

//         int numb;

//         Console.Write("Enter a number: ");
//         numb = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("The sum of the digits of the number {0} is: {1} \n", numb, SumCal(numb));
//     }

//     static int SumCal(int n)
//     {
//         string n1 = Convert.ToString(n);
//         int sum = 0;

//         for (int i = 0; i < n1.Length; i++)
//         {
//             sum += Convert.ToInt32(n1.Substring(i, 1));
//         }

//         return sum;
//     }


// }