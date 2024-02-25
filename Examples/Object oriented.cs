class ObjectOriented{

    static void Main(){
    Console.WriteLine("What exercise do you want me to find?");
    Console.WriteLine("1, 2, 3, 4, 6, 7, 8, 9 or 10?: ");
    int x = Convert.ToInt32(Console.ReadLine());

    switch(x){
        case 1:
            Exercise1();
            break;
        case 2:
            Exercise2();
            break;
        case 3:
            Exercise3();
            break;
        case 4:
            Exercise4();
            break;
        // case 5:
        //     Exercise5();
        //     break;
        // case 6:
        //     Exercise6();
        //     break;
        // case 7:
        //     Exercise7();
        //     break;
        // case 8:
        //     Exercise8();
        //     break;
        // case 9:
        //     Exercise9();
        //     break;
        // case 10:
        //     Exercise10();
        //     break;
    }
    }
    //-----------------------------------------------------------------------------

    // Exercise 1: Write a program in C# Sharp to create a user defined function.
    static void Exercise1(){
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Write a program in C# Sharp to create a user defined function.");
        Console.WriteLine("---------------------------------------");
        
        Welcome();
        Day();
    }
    
    static void Welcome(){
        Console.WriteLine("Welcome friends");
    }

    static void Day(){
        Console.WriteLine("Have a nicce day!");
    }
    
    //-----------------------------------------------------------------------------

    // Exercise 2: Write a program in C# Sharp to create a user defined function with parameters.
    static void Exercise2(){
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Write a program in C# Sharp to create a user defined function with parameters.");
        Console.WriteLine("---------------------------------------");
        
        string str1;

        Console.Write("Please input a name : ");
        str1 = Console.ReadLine()!;

        WelcomeFriend(str1);
        NiceDay();
    }

    static void WelcomeFriend(string name){
        Console.WriteLine("Welcome friend " + name + " !");
    }
    
    static void NiceDay(){
        Console.WriteLine("Have a nicce day!");
    }

    //-----------------------------------------------------------------------------

    // Exercise 3: Write a program in C# Sharp to create a function for the sum of two numbers.
    static void Exercise3(){
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Write a program in C# Sharp to create a function for the sum of two numbers.");
        Console.WriteLine("---------------------------------------");

        Console.Write("Enter the first number: ");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int numb2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(numb1, numb2));
    }

    static int Sum(int numb1, int numb2){
        int total;
        total = numb1 + numb2;
        return total;
    }

    //-----------------------------------------------------------------------------

    // Exercise 4: Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
    static void Exercise4(){
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.");
        Console.WriteLine("---------------------------------------");

        string str2;
        
        Console.Write("Please input a string : ");
        str2 = Console.ReadLine()!;

        Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
    }

    static int SpaceCount(string str){   
       
        int spcctr = 0;
        string str1;

        for (int i = 0; i < str.Length; i++){
            str1 = str.Substring(i, 1);
            if (str1 == " ")
                spcctr++;
        }
        return spcctr;
    }
    
    
}