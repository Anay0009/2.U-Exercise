// class Recursion
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
//                 // case 6:
//                 //     Exercise6();
//                 //     break;
//                 // case 7:
//                 //     Exercise7();
//                 //     break;
//                 // case 8:
//                 //     Exercise8();
//                 //     break;
//                 // case 9:
//                 //     Exercise9();
//                 //     break;
//                 // case 10:
//                 //     Exercise10();
//                 //     break;
//         }
//     }

//     // -------------------------------------------------------
//     // Exercise 1: Write a program in C# Sharp to print the first n natural numbers using recursion.

//     static void Exercise1()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine(" Write a program in C# Sharp to print the first n natural numbers using recursion.");
//         Console.WriteLine("---------------------------------------");

//         Rec(1, 10);
//     }

//     static void Rec(int x, int y)
//     {
//         if (x > y)
//         {
//             return;
//         }

//         Console.Write($"{x} ");
//         Rec(x + 1, y);
//     }

//     // -------------------------------------------------------
//     // Exercise 2: Write a program in C# Sharp to print numbers from n to 1 using recursion.

//     static void Exercise2()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to print numbers from n to 1 using recursion.");
//         Console.WriteLine("---------------------------------------");

//         MinRec(10, 1);
//     }

//     static void MinRec(int x, int y)
//     {
//         if (x < y)
//         {
//             return;
//         }

//         Console.Write($"{x} ");
//         MinRec(x - 1, y);

//     }

//     // -------------------------------------------------------
//     // Exercise 3: Write a program in C# Sharp to find the sum of the first n natural numbers using.

//     static void Exercise3()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to find the sum of the first n natural numbers using.");
//         Console.WriteLine("---------------------------------------");

//         Console.Write(Sum(10));

//     }

//     static int Sum(int x)
//     {
//         if (x == 0)
//         {
//             return 0;
//         }
//         return x + Sum(x - 1);
//     }

//     // -------------------------------------------------------
//     // Exercise 4: Write a program in C# Sharp to display the individual digits of a given number using recursion.

//     static void Exercise4()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to display the individual digits of a given number using recursion.");
//         Console.WriteLine("---------------------------------------");

//         Space(1234);

//     }

//     static void Space(int n)
//     {
//         if (n < 10)
//         {
//             Console.Write($"{n} ");
//         }
//         else
//         {
//             Space(n / 10);
//             Console.Write($"{n % 10} ");
//         }

//     }


//     // -------------------------------------------------------
//     // Exercise 5: Write a program in C# Sharp to count the number of digits in a number using recursion.

//     static void Exercise5()
//     {
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine("Write a program in C# Sharp to count the number of digits in a number using recursion.");
//         Console.WriteLine("---------------------------------------");

//         Console.Write(Numbercount(12345, 0));

//     }

//     static int Numbercount(int numb, int nodigits)
//     {
//         if (numb == 0)
//             return nodigits;

//         return Numbercount(numb/10, ++nodigits);
//     }
// }



