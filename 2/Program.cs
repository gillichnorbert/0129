static void primszam()
{
    Console.Write("Írj be egy számot: ");
    int szam = Convert.ToInt32(Console.ReadLine());
    int oszto = 0;
    for (int i = 1; i <= szam/2; i++)
    {
        if (szam % i  == 0)
        {
            oszto++;
        }
    }       
    if (oszto == 1)
    {
        Console.WriteLine("Prímszám");
    }
    else
    {
        Console.WriteLine("Nem prímszám");
    }
}


primszam();
Console.ReadKey();