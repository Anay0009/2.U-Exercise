

// class ArraysExercises{

//     static void Main(){
//        Console.WriteLine("What exercise do you want me to find?");
//         Console.WriteLine("1, 2, 3, 4 or 7: ");
//         int x = Convert.ToInt32(Console.ReadLine());
        
//         switch(x){
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
//                 Exercise7();
//                 break;
//         } 
//     }
        
  
//         static void Exercise1(){
//         //1. Write a C# Sharp program that stores elements in an array and prints them.

//              Console.WriteLine("---------------------------------------");
//              Console.WriteLine("Write a C# Sharp program that stores elements in an array and prints them.");
//              Console.WriteLine("---------------------------------------");

//              int[] elements = new int [10];

//              Console.WriteLine("Input 10 elements please!");

//              for(int i = 0; i < 10; i++){
//                  Console.Write("Element {0}: ", i);
//                  elements[i] = Convert.ToInt32(Console.ReadLine());
//                 }

//              Console.WriteLine("The elements are: ");
//                 for(int i = 0; i < 10; i++){
//                     Console.Write("{0} ", elements[i]);
//                 }
//         }


//         static void Exercise2(){
//         //2. Write a C# Sharp program to read n values in an array and display them in reverse order.
        
//              Console.WriteLine("---------------------------------------");
//              Console.WriteLine("Write a C# Sharp program to read n values in an array and display them in reverse order.");
//              Console.WriteLine("---------------------------------------");

//              int[] elements = new int [3];

//              for(int i = 0; i <=3; i++){
//                 Console.WriteLine("Input element {0}", i);
//                 elements[i] = Convert.ToInt32(Console.ReadLine());
//              }

//              Console.WriteLine("The elements in order are: ");
//              for(int i = 0; i < 3; i++){
//                 Console.Write("{0} ", elements[i]);
//              }

//              Console.WriteLine("The elements in reverse order are: ");
//              for(int i = 3; i <= 0; i--){
//                 Console.Write("{0} ", elements[i]);
//         }
//         }
  
        
//         static void Exercise3(){          
//         //3. Write a program in C# Sharp to find the sum of all array elements.
        
//             Console.WriteLine("---------------------------------------");
//             Console.WriteLine("Write a program in C# Sharp to find the sum of all array elements.");
//             Console.WriteLine("---------------------------------------");

//             int[] elements = new int[3];

//             for(int i = 0; i < 3; i++){
//                 Console.Write("Input the element {0}: ", i);
//                 elements[i] = Convert.ToInt32(Console.ReadLine());
//         }

//             Console.Write("The sum of the elements is: ");
//             Console.WriteLine("{0} ", elements.Sum());

//         }


//         static void Exercise4(){
//         //4. Write a C# Sharp program to copy the elements of one array into another array.

//             Console.WriteLine("---------------------------------------");
//             Console.WriteLine("Write a C# Sharp program to copy the elements of one array into another array.");
//             Console.WriteLine("---------------------------------------");

//             int[] elements = new int[3];
//             int[] elementsCopy = new int[3];

//             for(int i = 0; i < 3; i++){
//                 Console.Write("Input the element {0}: ", i);
//                 elements[i] = Convert.ToInt32(Console.ReadLine());
//                 }

//             for(int i = 0; i < 3; i++){
//                 elementsCopy[i] = elements[i];
//                 }

//             Console.WriteLine("The elements in the first array are: ");
//             for(int i = 0; i < 3; i++){
//                 Console.WriteLine("{0} ", elements[i]);
//             }

//             Console.WriteLine("The elements in the second array are: ");
//             for(int i = 0; i < 3; i++){
//                 Console.WriteLine("{0} ", elementsCopy[i]);
//             }
//         }


//         static void Exercise7(){
//         //7. Write a C# Sharp program to merge two arrays of the same size sorted in ascending.
        
//             Console.WriteLine("---------------------------------------");
//             Console.WriteLine("Write a C# Sharp program to merge two arrays of the same size sorted in ascending.");
//             Console.WriteLine("---------------------------------------");

//             Console.Write("Input the number of elements to be stored in both of the arrays: ");
//             int n = Convert.ToInt32(Console.ReadLine());
        
//             int[] intArray1 = new int[n];
//             int[] intArray2 = new int[n];

//             Console.WriteLine("\nInput {0} elements (above 0) in the first array: ", n);
//             for(int i = 0; i < n; i++){
//                 Console.Write("Input element {0}: ", i);
//                 intArray1[i] = Convert.ToInt32(Console.ReadLine());
//         }

//             Console.WriteLine("\nInput {0} elements (above 0) in the second array: ", n);
//             for(int i = 0; i < n; i++){
//                 Console.Write("Input element {0}: ", i);
//                 intArray2[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         }
// }
