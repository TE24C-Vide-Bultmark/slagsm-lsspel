Random generator = new Random();
Console.WriteLine("tryck enter för att spela");
string spelar = Console.ReadLine();

while (spelar != "quit")
{
    Console.Clear();
    // spelaren ger gladiatorn ett namn
    int namnlangd = 21;
    string namn1 = "den namnlöse mannen";
    while (namnlangd > 16)
    {
        Console.WriteLine("Vad heter du?");
        namn1 = Console.ReadLine();
        namnlangd = namn1.Length;
    }

    string[] fiender = ["Björn", "Maximus", "Gustavo"];

    string namn2 = fiender[Random.Shared.Next(3)];

    // skapar hitpoints for spelaren
    int hitpoints1;
    if (namn1 == "V1d3")
    {
        hitpoints1 = 16;
    }
    else
    {
        hitpoints1 = 10;
    }

    int hitpoints2;
    // skapar unika karaktärer
    if (namn2 == "björn")
    {
        hitpoints2 = 10;
    }
    else if (namn2 == "maximus")
    {
        hitpoints2 = 12;
    }
    else
    {
        hitpoints2 = 14;
    }


    // kommentatorn indtroducerar gladiatorerna
    Console.WriteLine($"{namn1} möter {namn2}, börja!");
    Console.WriteLine($"vad kommer {namn1} att göra?");
    Console.WriteLine($"1) slå {namn2} i ansiktet");
    Console.WriteLine($"any button) sparka {namn2} i magen");
    string attack = Console.ReadLine();

    // kampen

    while (hitpoints1 > 0 && hitpoints2 > 0)
    {
        if (attack != "1")
        {
            hitpoints1 -= Random.Shared.Next(1, 4);
            Console.WriteLine($"{namn2} slår {namn1} i ansiktet!");
            hitpoints2 -= Random.Shared.Next(5);
            Console.WriteLine($"{namn1} sparkar {namn2} i magen!");
        }
        else
        {
            hitpoints1 -= Random.Shared.Next(5);
            Console.WriteLine($"{namn2} sparkar {namn1} i magen!");
            hitpoints2 -= Random.Shared.Next(1, 4);
            Console.WriteLine($"{namn1} slår {namn2} i ansiktet!");
        }
        Console.WriteLine($"{namn1} har {hitpoints1} liv och {namn2} har {hitpoints2} liv");

        if (hitpoints1 < 1 && hitpoints2 > 0)
        {
            Console.WriteLine($"{namn2} segrar!");
        }
        else if (hitpoints2 < 1 && hitpoints1 > 0)
        {
            Console.WriteLine($"{namn1} segrar!");
        }
        else if (hitpoints1 < 1 && hitpoints2 < 1)
        {
            Console.WriteLine("oavgjort!");
        }
        else
        {
            Console.WriteLine($"vad kommer {namn1} att göra?");
            Console.WriteLine($"1) slå {namn2} i ansiktet");
            Console.WriteLine($"any button) sparka {namn2} i magen");
            attack = Console.ReadLine();
        }
    }
    Console.WriteLine("tryck enter för att köra igen");
    spelar = Console.ReadLine();
}
    Console.ReadLine();