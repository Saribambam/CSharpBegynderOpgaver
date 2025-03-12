////Opgradér spillet fra Opgave_3 med et Loop sådan at man får flere forsøg når man gætter forkert
int Midte = 40;

//Console.ForegroundColor = ConsoleColor.White;


//En Console.ReadLine() returnere altid en streng, hvis vi skal lave den om til en int er vi nødt til at pakke det ind i Convert.ToInt()
//Console.SetCursorPosition(Midte, 7);
//Console.WriteLine("Hvad er dit gæt?:");

//Console.SetCursorPosition(Midte, 8);
 //Det giver altså en fejl hvis vi taster noget ind som IKKE er et tal!
int counter = 1;

Random random = new Random();
int Resultat = random.Next(1, 11); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)

while (counter <= 3)
{
    Console.Clear();
    Console.SetCursorPosition(Midte, 7);
    Console.WriteLine("Hvad er dit gæt?:");
    Console.SetCursorPosition(Midte, 8);
    int input = Convert.ToInt32(Console.ReadLine());

    if (input > Resultat)

    {
        Console.SetCursorPosition(Midte, 9);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" hahaha Du svarede forkert, svaret er mindre");
        Console.ReadKey();
    }
    else if (input < Resultat)

    {
        Console.SetCursorPosition(Midte, 9);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("hahaha Du svarede forkert´, svaret er større");
        Console.ReadKey();
    }
    else
    {
        Console.SetCursorPosition(Midte, 9);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" YAY Du vandt!!!");
        Console.ReadKey();
        break;
    }

    counter++;
}


Console.WriteLine("Jeg er en klovn");
//int Resultat = random.Next(1, 11); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)


Console.ReadKey();
//Eksempel på while loop

//While loop der tæller til 10

//	Console.WriteLine(counter);
//	counter++;
//}

//Console.ReadKey();
//Console.WriteLine("");

////Eksempel på for loop
//for(int i = 0; i < 10; i += 2)
//{
//	Console.WriteLine(i);
//}
//Console.ReadKey();



