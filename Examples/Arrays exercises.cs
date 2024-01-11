
using System.Diagnostics.CodeAnalysis;

class ArraysExercises{

    static void Main(){

        // //1. Write a C# Sharp program that stores elements in an array and prints them.

        // int[] elements = new int [10];

        // Console.WriteLine("Input 10 elements please!");

        // for(int i = 0; i < 10; i++){
        //     Console.Write("Element {0}: ", i);
        //     elements[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.WriteLine("The elements are: ");
        // for(int i = 0; i < 10; i++){
        //     Console.Write("{0} ", elements[i]);
        // }
        

        //2. Write a C# Sharp program to read n values in an array and display them in reverse order.

        // int[] elements = new int [3];

        // for(int i = 0; i <=3; i++){
        //     Console.WriteLine("Input element {0}", i);
        //     elements[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.WriteLine("The elements in order are: ");
        // for(int i = 0; i < 3; i++){
        //     Console.Write("{0} ", elements[i]);
        // }

        // Console.WriteLine("The elements in reverse order are: ");
        // for(int i = 3; i <= 0; i--){
        //     Console.Write("{0} ", elements[i]);
        // }
        

        //3. Write a program in C# Sharp to find the sum of all array elements.

        // int[] elements = new int[3];

        // for(int i = 0; i < 3; i++){
        //     Console.Write("Input the element {0}: ", i);
        //     elements[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.Write("The sum of the elements is: ");
        // Console.WriteLine("{0} ", elements.Sum());

        //4. Write a C# Sharp program to copy the elements of one array into another array.

        // int[] elements = new int[3];
        // int[] elementsCopy = new int[3];

        // for(int i = 0; i < 3; i++){
        //     Console.Write("Input the element {0}: ", i);
        //     elements[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // for(int i = 0; i < 3; i++){
        //     elementsCopy[i] = elements[i];
        // }

        // Console.WriteLine("The elements in the first array are: ");
        // for(int i = 0; i < 3; i++){
        //     Console.WriteLine("{0} ", elements[i]);
        // }

        //  Console.WriteLine("The elements in the second array are: ");
        // for(int i = 0; i < 3; i++){
        //     Console.WriteLine("{0} ", elementsCopy[i]);
        // }


        //5. Write a C# Sharp program in to count duplicate elements in an array.


        //6. Write a program in C# Sharp to print all unique elements in an array.


        //7. Write a C# Sharp program to merge two arrays of the same size sorted in ascending.
   
        Console.Write("Input the number of elements to be stored in both of the arrays: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Console.WriteLine("\nInput {0} elements in the first array: ", n);
        for(int i = 0; i < n; i++){
            Console.Write("Input element {0}: ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nInput {0} elements in the second array: ", n);
        for(int i = 0; i < n; i++){
            Console.Write("Input element {0}: ", i);
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }



    }

}

  