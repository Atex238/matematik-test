// See https://aka.ms/new-console-template for more information

Console.Title = "kursus";



Console.WriteLine("Hej Carl og velkommen til mit matematik kursus...");

Console.WriteLine("Håber din mor eller far vil være med til at se det og hjælpe");

Console.WriteLine("Tryk enter for at starte programet");

Console.ReadKey();

Console.WriteLine("Lvl 1 --- i lvl 1 er der tal fra 1 til 10");

Console.WriteLine("hvis der er fejl køre du det bare igen");

Console.Write("5 + 2 =  ");

int answer = Convert.ToInt32(Console.ReadLine());

if (answer == 7)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}

Console.ReadKey();

Console.Write("3 + 5 =  ");

int answer01 = Convert.ToInt32(Console.ReadLine());

if (answer01 == 8)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}




Console.ReadKey();

Console.Write("1 + 4 =  ");

int answer02 = Convert.ToInt32(Console.ReadLine());

if (answer02 == 5)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}



Console.ReadKey();

Console.Write("7 + 3 =  ");

int answer03 = Convert.ToInt32(Console.ReadLine());

if (answer03 == 10)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}


Console.ReadKey();

Console.Write("1+ 2 =  ");

int answer04 = Convert.ToInt32(Console.ReadLine());

if (answer04 == 3)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Tillykke du er nået til lvl 2");


Console.ReadKey();

Console.WriteLine("Lvl 2 i lvl 2 er der tal fra 10 til 15");




Console.ReadKey();

Console.Write("4 + 7  =  ");

int answer05 = Convert.ToInt32(Console.ReadLine());

if (answer05 == 11)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}


Console.ReadKey();

Console.Write("5 + 9  =  ");

int answer06 = Convert.ToInt32(Console.ReadLine());

if (answer06 == 14)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}


Console.ReadKey();

Console.Write("10 + 5 =  ");

int answer07 = Convert.ToInt32(Console.ReadLine());

if (answer07 == 15)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}



Console.ReadKey();

Console.Write("4 + 9  =  ");

int answer08 = Convert.ToInt32(Console.ReadLine());

if (answer08 == 13)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}



Console.ReadKey();

Console.Write("8 + 5 =  ");

int answer09 = Convert.ToInt32(Console.ReadLine());

if (answer09 == 13)
{
    Console.WriteLine("Korekt");
}

else
{
    Console.WriteLine("Forkert");
}

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Tillykke du har gennemført mit kursus håber du er blevet bedre til matematik");

Console.WriteLine("tryk på en knap");

Console.ReadKey();

Console.WriteLine("Hvis far er her så prøv at svar på dette");

Console.WriteLine("hvilket sprog er dette kodet i tryk for at se svar muligheder");

Console.ReadKey();

Console.WriteLine("0: C#");

Console.WriteLine("1: Ruby");

Console.WriteLine("2: Python");


Console.Write("Svaret er ");

int test = Convert.ToInt32(Console.ReadLine());

if (test == 0)
{
    Console.WriteLine("Ja det er kodet i c#");
}

else
{
    Console.WriteLine("Nej desvære det er kodet i c# et sprog hvor man kan kode spil");
}

Console.WriteLine("programmet er slut håber det var lige så sjovt som at kode det hav en god dag kh max");


// Wait before closing
Console.ReadKey();

