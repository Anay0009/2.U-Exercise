

// class OwnCode
// {

//     static void Main()
//     {

//         string name;
//         int age, students, totalAge = 0;

//         Console.WriteLine("\nHow many student are there in your class?\n ");

//         Console.Write("Input the number of students: ");
//         students = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("---------------------------------------");
        
//         Console.WriteLine("Write the student's name one at a time.\n ");

//         for (int i = 0; i < students; i++)
//         {
//             Console.Write("Name: ");
//             name = Console.ReadLine()!;
        
//             Console.Write("The age of that student: ");
//             age = Convert.ToInt32(Console.ReadLine()); 
            
//             totalAge = totalAge + age;

//             Console.WriteLine("---------------------------------------");
//         }

//         double averageAge = (double)totalAge/students;

//         Console.WriteLine("\nYou've listed {0} names, indicating there are {0} students in your class.", students);
//         Console.WriteLine("The average age of the students is: {0}\n", averageAge);


//         // Own code to a string

//         string path;

//         Console.WriteLine("Which way do you want to go?");
//         Console.WriteLine("Left, Right, or Down?");
//         path = Console.ReadLine()!.ToLower();

//         switch (path)
//         {
//             case "left":
//                 Console.WriteLine("You chose to go left.");
//                 break;
//             case "right":
//                 Console.WriteLine("You chose to go right.");
//                 break;
//             case "down":
//                 Console.WriteLine("You chose to go down.");
//                 break;
//             default:
//                 Console.WriteLine("You found the hidden path.");
//                 break;
//         }

//     }

// }
    