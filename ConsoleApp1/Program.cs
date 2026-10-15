
Console.Write("Podaj imie bohatera:"    );
string imie = Console.ReadLine();
Console.Clear();
Console.Write("Podaj ilosc puntktow zycia:"    );
int zycie = int.Parse(Console.ReadLine());
Console.Clear();
Console.Write("Podaj swoj poziom:"    );
int poziom = int.Parse(Console.ReadLine());
Console.Clear();
Console.Write("Podaj ilosc zlota:"    );
int zloto = int.Parse(Console.ReadLine());
Console.Clear();
Console.Write("Czy masz mape? (true/false)"    );
bool mapa = bool.Parse(Console.ReadLine());
Console.Clear();
Console.Write("Czy masz klucz?  (true/false)"    );
bool klucz = bool.Parse(Console.ReadLine());
bool mozeWyruszyc;
bool jestBogaty;
if (mapa == true&& klucz == true)
{
     mozeWyruszyc = true;
}
else
{
     mozeWyruszyc = false;
}
if (zloto >= 100)
{
     jestBogaty = true;
}
else
{
     jestBogaty = false;
}
if (zycie == 0)
{
    Console.WriteLine("Bohater nie zyje");
}
if (zycie >=25 && zycie <= 75);
{
    Console.WriteLine("Bohater jest ranny");
}
if (zycie > 75)
{
    Console.WriteLine("Bohater jest w dobrej formie");
}
Console.Clear   ();
Console.Write("Podejmij decyzje \n 1. Rozpocznij wyprawe   \n 2. odpocznij w karczmie \n 3.Wejdz do sklepu\n");
string decyzja = Console.ReadLine();
switch (decyzja)
{
    case "1":
        if (mozeWyruszyc == true)
        {
            Console.WriteLine("Wyruszasz w podroz");
        }
        else
        {
            Console.WriteLine("Nie mozesz wyruszyc w podroz poniewaz nie masz mapy lub klucza");
        }
        break;
    case "2":
        Console.WriteLine("Odpoczywasz w karczmie");
        zycie+= 25;
        break;
    case "3":
        Console.WriteLine("Wejdz do sklepu");
        if (jestBogaty == true)
        {
            Console.WriteLine("Masz wystarczajaco zlota aby cos kupic");
        }
        else
        {
            Console.WriteLine("Nie masz wystarczajaco zlota aby cos kupic");
        }
        break;
    default:
        Console.WriteLine("Niepoprawna decyzja");
        break;                      
}
Console.ReadKey();
Console.Clear();




Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+============================+");
Console.WriteLine("|        STATYSTYKI          |");
Console.WriteLine("+============================+");
Console.WriteLine("+----------------------------+");

Console.WriteLine($"| Imie bohatera: {imie}   ");

if (zycie <25 || zycie ==0)
{
    Console.ForegroundColor = ConsoleColor.Red;
}
else if (zycie >= 25 && zycie <= 75)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
}

if (zycie > 75)
{
    Console.ForegroundColor = ConsoleColor.Green;
}
Console.WriteLine($"| Puntky zycia: {zycie}         ");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"| Poziom: {poziom}              ");
Console.WriteLine($"| Zloto: {zloto}                ");
Console.WriteLine("+----------------------------+");
if (zycie!= 0)
{
    Console.WriteLine("|Bohater zyje");
}
if (mapa == true && klucz == true)
{
    Console.WriteLine("|Bohater moze wyruszyc w podroz");
}
else
{
    Console.WriteLine("|Bohater nie moze wyruszyc w podroz");
}
if (jestBogaty == true)
{
    Console.WriteLine("|Bohater jest bogaty");
}
else
{
    Console.WriteLine("|Bohater nie jest bogaty");
}
