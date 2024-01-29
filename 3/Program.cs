static void Feltolt(int[] tomb)
{
    Random random = new Random();
    for (int i = 0; i < tomb.GetLength(0); i++)
    {
            tomb[i] = random.Next(1, 300);
    }
}



static void Atlag(int[] tomb)
{
    int osszeg = 0;
    double atlag = 0;
    for (int i = 0; i < tomb.Length; i++)
    {
        osszeg += tomb[i];

    }
    atlag = osszeg / tomb.Length;
    Console.WriteLine();
    Console.WriteLine("A tömb elemeinek átlaga: " + atlag);
}

int[] tomb = new int[15];

Feltolt(tomb);

Console.WriteLine("A tömb elemei: ");

for (int i = 0; i < tomb.Length; i++)
{
    Console.Write(tomb[i] + ", ");
}

Atlag(tomb);



Console.ReadKey();