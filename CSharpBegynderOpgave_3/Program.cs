//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.


//En Console.ReadLine() returnere altid en streng, hvis vi skal lave den om til en int er vi nødt til at pakke det ind i Convert.ToInt()
Console.WriteLine("Indtast et tal:");
int input = Convert.ToInt32(Console.ReadLine()); //Det giver altså en fejl hvis vi taster noget ind som IKKE er et tal!
Console.WriteLine(input); //Udskriv inputtet.





Random random = new Random();
int Resultat = random.Next(0,11); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)
Console.WriteLine("hvad er dit gæt?");






//Dette er if statements og bruges til at sammenligne værdier, det skal bruges til spillet.
if (input > Resultat)
{
	Console.WriteLine(" hahaha Du svarede forkert");
}
else if (input < Resultat)
{
	Console.WriteLine("hahaha Du svarede forkert");
}
else 
{
	Console.WriteLine("Du vandt");
}




Console.ReadKey();