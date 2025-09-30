using System.Reflection;

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

    // slumpmässig fiende genereras och deklareras
     string[] fiender = ["Björn", "Maximus", "Gustavo"];

    string namn2 = fiender[Random.Shared.Next(3)];
    if (Random.Shared.Next(32) == 31)
    {
        namn2 = "V1d3";
    }
    Console.WriteLine($"{namn1} möter {namn2}");

// charchter customizastion
    Console.WriteLine($"Välj {namn1}s styrka");
    Console.WriteLine("1) träffsäkerhet");
    Console.WriteLine("2) muskler");
    Console.WriteLine("3) vågrät längd");
    Console.WriteLine("any other) aura");
    string styrka = Console.ReadLine();

// spelarens första teknik
    // Console.WriteLine($"välj {namn1}s första teknik");
    // Console.WriteLine($"1) sparka {namn2} i magen");
    // Console.WriteLine($"2) slå {namn2} i ansiktet");
    // Console.WriteLine("3) käka kreatin");
    // Console.WriteLine("any other) lock in");
    // string teknik1 = Console.ReadLine();

    // if (teknik1 == "1")
    // {
    //     teknik1 = $"sparka {namn2} i magen";
    // }
    // else if (teknik1 == "2")
    // {
    //     teknik1 = $"slå {namn2} i ansiktet";
    // }
    // else if (teknik1 == "3")
    // {
    //     teknik1 = $"käka kreatin";
    // }
    // else
    // {
    //     teknik1 = $"lock in";
    // }

// spelarens andra teknik
    // Console.WriteLine($"välj {namn1}s andra teknik");
    // Console.WriteLine($"1) sparka {namn2} i magen");
    // Console.WriteLine($"2) slå {namn2} i ansiktet");
    // Console.WriteLine("3) käka kreatin");
    // Console.WriteLine("any other) lock in");
    // string teknik2 = Console.ReadLine();

    // if (teknik2 == "1")
    // {
    //     teknik2 = $"sparka {namn2} i magen";
    // }
    // else if (teknik2 == "2")
    // {
    //     teknik2 = $"slå {namn2} i ansiktet";
    // }
    // else if (teknik2 == "3")
    // {
    //     teknik2 = $"käka kreatin";
    // }
    // else
    // {
    //     teknik2 = $"lock in";
    // }


    // skapar hitpoints
    int hitpoints1;
    if (namn1 == "V1d3")
    {
        hitpoints1 = 15;
    }
    else
    {
        hitpoints1 = 10;
    }

    if (styrka == "3")
    {
        hitpoints1 += 3;
    }

    // skapar muskler
    int muskler = 5;
    if (styrka == "2")
    {
        muskler += 2;
    }

    // skapar träffsäkerhet
    int träffsäkerhet = 0;
    if (styrka == "1")
    {
        träffsäkerhet += 2;
    }

    int hitpoints2 = 10;
    int muskler_fiender = 5;
    int träffsäkerhet_fiender = 0;

    // skapar unika fiender
    if (namn2 == "Björn")
    {
        träffsäkerhet_fiender += 2;
    }
    else if (namn2 == "Maximus")
    {
        muskler_fiender += 2;
    }
    else if (namn2 == "Gustavo")
    {
        hitpoints2 += 3;
    }
    else
    {
        hitpoints2 += 5;
        muskler_fiender += 1;
        träffsäkerhet_fiender += 1;
    }



    // kommentatorn indtroducerar gladiatorerna
    Console.WriteLine($"{namn1} möter {namn2}, börja!");
    Console.WriteLine($"vad kommer {namn1} att göra?");
    Console.WriteLine($"1) slå {namn2} i ansiktet");
    Console.WriteLine($"any other) sparka {namn2} i magen");
    Console.WriteLine("2) käka kreatin");
    Console.WriteLine("3) lock in");
    string attack = Console.ReadLine();

    // kampen
    while (hitpoints1 > 0 && hitpoints2 > 0)
    {
        // spelaren attackerar
        if (attack == "1")
        {
            hitpoints2 -= Random.Shared.Next(träffsäkerhet + 1, muskler - 1);
            Console.WriteLine($"{namn1} slår {namn2} i ansiktet!");
        }
        else if (attack == "2")
        {
            muskler *= 2;
            Console.WriteLine($"{namn1} dammar en kopp kreatin");
        }
        else if (attack == "3")
        {
            träffsäkerhet *= 2;
            while (träffsäkerhet >= muskler)
            {
                träffsäkerhet -= 1;
                muskler += 1;
            }
            Console.WriteLine($"{namn1} är numera locked in");
        }
        else
        {
            hitpoints2 -= Random.Shared.Next(träffsäkerhet, muskler);
            Console.WriteLine($"{namn1} sparkar {namn2} i magen!");
        }

        // fienden attackerar
        int attack_fiender = Random.Shared.Next(2);
        if (attack_fiender == 1)
        {
            hitpoints1 -= Random.Shared.Next(träffsäkerhet_fiender + 1, muskler_fiender - 1);
            Console.WriteLine($"{namn2} slår {namn1} i ansiktet!");
        }
        else
        {
            hitpoints1 -= Random.Shared.Next(träffsäkerhet_fiender, muskler_fiender);
            Console.WriteLine($"{namn2} sparkar {namn1} i magen!");
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
            Console.WriteLine("2) käka kreatin");
            Console.WriteLine("3) lock in");
            attack = Console.ReadLine();
        }
    }
    Console.WriteLine("tryck enter för att köra igen");
    spelar = Console.ReadLine();
}
    Console.ReadLine();