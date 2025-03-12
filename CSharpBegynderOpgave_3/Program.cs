//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.



int Midte = 40;

Console.ForegroundColor = ConsoleColor.White;


//En Console.ReadLine() returnere altid en streng, hvis vi skal lave den om til en int er vi nødt til at pakke det ind i Convert.ToInt()
Console.SetCursorPosition(Midte, 7);
Console.WriteLine("Hvad er dit gæt?:");

Console.SetCursorPosition(Midte, 8);
int input = Convert.ToInt32(Console.ReadLine()); //Det giver altså en fejl hvis vi taster noget ind som IKKE er et tal!







Random random = new Random();
int Resultat = random.Next(1, 11); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)







//Dette er if statements og bruges til at sammenligne værdier, det skal bruges til spillet.
if (input > Resultat)

{
	Console.SetCursorPosition(Midte, 9);
    Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine(" hahaha Du svarede forkert");
}
else if (input < Resultat)

{
    Console.SetCursorPosition(Midte, 9);
    Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("hahaha Du svarede forkert");
}
else 
{
    Console.SetCursorPosition(Midte, 9);
    Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine(" YAY Du vandt!!!");
}




Console.ReadKey();