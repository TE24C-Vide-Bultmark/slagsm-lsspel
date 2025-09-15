Random generator = new Random();

// spelaren ger gladiatorerna namn
int namnlangd = 21;
string namn1 = "the nameless man";
while (namnlangd > 16)
{
    Console.WriteLine("Vad heter du?");
    namn1 = Console.ReadLine();
    namnlangd = namn1.Length;
}

// Console.WriteLine($"och vem ska den ökände {namn1} få äran att kämpa emot?");
// string namn2 = Console.ReadLine();
string namn2 = "björn";

// skapar hitpoints
int hitpoints1;
if (namn1 == "Vide")
{
    hitpoints1 = 15;
}
else
{
    hitpoints1 = 10;
}

// int hitpoints2;
// if (namn2 == "Vide")
// {
//     hitpoints2 = 15;
// }
// else
// {
//     hitpoints2 = 10;
// }

int hitpoints2 = 10;

// kommentatorn indtroducerar gladiatorerna
Console.WriteLine($"{namn1} möter {namn2}, börja!");

// kampen
while (hitpoints1 > 0 && hitpoints2 > 0)
{
    hitpoints1 -= Random.Shared.Next(5);
    Console.WriteLine($"{namn2} slår {namn1} i huvudet!");
    hitpoints2 -= Random.Shared.Next(5);
    Console.WriteLine($"{namn1} sparkar {namn2} i magen!");
    Console.WriteLine($"{namn1} har {hitpoints1} liv och {namn2} har {hitpoints2} liv");
    Console.ReadLine();
}
if (hitpoints1 < 1)
{
    Console.WriteLine($"{namn2} segrar!");
}
else if (hitpoints2 < 1)
{
    Console.WriteLine($"{namn1} segrar!");
}
else
{
    Console.WriteLine("oavgjort!");
}

    Console.ReadLine();