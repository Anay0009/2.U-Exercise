// // See https://aka.ms/new-console-template for more information

// // Dette tegn er for kommentarer, kan ikke ses i kodningen.
// // (ctrl + k + c) - Gør teksten du har markeret til en kommentar. 
// // (ctrl + k + u) - Gør teksten til kode.

// /*
// Kommentar med flere linjer. 
//  */

// //_________________________________________________________________________________________________________________

// // This is how you write a console (Console.Writeline er som et enter der laver en ny linje efter Console.WriteLine)
// // (Console.Write skriver teksten i en sammenhæng uden mellemrum, hvsi du laver en ny Console.Write)
// Console.WriteLine("Welcome to HELL!");

// Console.Write("Line number one");

// Console.Write("Line number two");

// Console.WriteLine("Line number three");

// //_________________________________________________________________________________________________________________

// /*Datatyper: int, float, string, bool
// int = Et helt tal (-5, 4, 6, 4549894)
// float = Decimal tal (4,54 6,7003, -9,032)
// string = Tekst i "" 
// bool = 
// */

// //Variabler'
// int x; //deklareret x
//     x = 4; //instansierende

//     int y = 5, z = 6; // deklareret og instansierende og z

//     int d = x + y - z * x / z % y;

//     Console.WriteLine("x = " + x + " og y = " + y + " og z = " + z);
//     Console.WriteLine("Resultat af d er = " + d);


// float e = 5.5f;

//     Console.WriteLine("Print e som en float: " + e);

//     int f = Convert.ToInt16(e); //Laver decimal tallet om til et helt tal, så den runder op eller ned

//     Console.WriteLine("Print e som et int: " + f); 


// string str = "Jeg er en string" + " og det er jeg også"; //(Det der bliver skrevet i gåseøjne)
//     // (\n) laver en ny linje selvom du skriver mere, som oven over.

//     Console.WriteLine(str);

// b00l

// //_________________________________________________________________________________________________________________

// // Udregninger (matematik)
// int a = 4;

// int j = 5;

// int m = a + j;

// Console.WriteLine("a + j = " + m); 


// // Console.WriteLine(str);

// string str = "The result is ";

// int u = 4, i = 5;

// Console.Write(str + (u + i));


// Console.Write("Write yout input: ");

// Console.WriteLine("This is my input: " + Console.ReadLine());

// // __________________________________________________________________________________________-

// // Ekstra (char)

// char c = 'c';

// Console.WriteLine("c is " + c);


// String input = Console.ReadLine()!;

// Console.WriteLine("Input is " + input);

// char c = Convert.ToChar(input);

// Console.WriteLine("this is my char input " + c);


// char c = (Convert.ToChar(Console.ReadLine()));

// Console.WriteLine("c is " + c);

// //_________________________________________________________________________________________________________________

// // If else statements

// int x = 7;

// bool isFour = x ==4;

// if (x == 4) {
//     Console.WriteLine("I am the if statement");
// } else if (x > 4 ){
//     Console.WriteLine("I am the second condition");

//     if ( x == 5 ){
//         Console.WriteLine("X is 5");
//     } else {
//         Console.WriteLine("I am a nested else statement");
    
//         if (x == 7){
//             Console.WriteLine("X is 7");
//         } else {
//             Console.WriteLine("X is not 7");
//         }
//     }
// } else {
//     Console.WriteLine("I am the else condition");
// }


// int x = 4;

// if (x > 5){
//     Console.WriteLine("Bigger");
// } else {
//     Console.WriteLine("Not");
// }


// int x = 5;

// if (x > 5){
//     Console.WriteLine("Bigger");
// } else if (x < 5) {
//     Console.WriteLine("Smaller");
// } else if (x != 0){
//     Console.WriteLine("Not 0");
// } else if (x == 5){
//     Console.WriteLine("x is 5");
// } else {
//     Console.WriteLine("Else");
// }


// int x = 7;

// if (x == 4) {
//     Console.WriteLine("I am the if statement");
// } else if (x > 4 ){
//     Console.WriteLine("I am the second condition");

//     if ( x == 5 ){
      
//         int y = 5;
        
//     } else {
       
//         int y = 7;
    
//         if (y > 7){
           
//             y = 6;
//         } else {
            
//         }
//         Console.WriteLine("Y is " + y);
//     }
// } else {
//     Console.WriteLine("I am the else condition");
// }

// //_________________________________________________________________________________________________________________


