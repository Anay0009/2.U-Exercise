

class ownCode{

    static void Main(){

        string name;
        int age, students;

        Console.WriteLine("\nHow many student are there in your class?\n ");

        Console.Write("Input the number of students: ");
        students = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("Write the student's name one at a time.\n ");

        for (int i = 0; i < students; i++){
            Console.Write("Name: ");
            name = Console.ReadLine()!;
        
            Console.Write("The age of that student: ");
            age = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("---------------------------------------");
        }

    }

}
    