// See https://aka.ms/new-console-template for more information

// Dette tegn er for kommentarer, kan ikke ses i kodningen.
// (ctrl + k + c) - Gør teksten du har markeret til en kommentar. 
// (ctrl + k + u) - Gør teksten til kode.

/*
Kommentar med flere linjer. 
 */

//_________________________________________________________________________________________________________________

// This is how you write a console (Console.Writeline er som et enter der laver en ny linje efter Console.WriteLine)
// (Console.Write skriver teksten i en sammenhæng uden mellemrum, hvsi du laver en ny Console.Write)
Console.WriteLine("Welcome to HELL!");

Console.Write("Line number one");

Console.Write("Line number two");

Console.WriteLine("Line number three");

//_________________________________________________________________________________________________________________

/*Datatyper: int, float, string, bool
int = Et helt tal (-5, 4, 6, 4549894)
float = Decimal tal (4,54 6,7003, -9,032)
string = Tekst i "" 
*/

//Variabler'
int x; //deklareret x
    x = 4; //instansierende

    int y = 5, z = 6; // deklareret og instansierende og z

    int d = x + y - z * x / z % y;

    Console.WriteLine("x = " + x + " og y = " + y + " og z = " + z);
    Console.WriteLine("Resultat af d er = " + d);


float e = 5.5f;

    Console.WriteLine("Print e som en float" + e);

    int f = Convert.ToInt16(e); //Laver decimal tallet om til et helt tal, så den runder op eller ned

    Console.WriteLine("Print e som et int:" + f); 


string str = "Jeg er en string" + "og det er jeg også"; //(Det der bliver skrevet i gåseøjne)
    // (\n) laver en ny linje selvom du skriver mere, som oven over.

    Console.WriteLine(str);