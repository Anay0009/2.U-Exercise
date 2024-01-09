
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

        int[] elements = new int [3];

        for(int i = 0; i <=3; i++){
            Console.WriteLine("Input element {0}", i);
            elements[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The elements in order are: ");
        for(int i = 0; i < 3; i++){
            Console.Write("{0} ", elements[i]);
        }

        Console.WriteLine("The elements in reverse order are: ");
        for(int i = 3; i <= 0; i--);

    }

}

  