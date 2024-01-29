static void teruletKiir()
    {
        int terulet;
        terulet = teglalapTerulet();
        Console.WriteLine("A téglalap területe: " + terulet);
    }

static int teglalapTerulet()
    {
        Console.WriteLine("Téglalap a-oldala: ");
        int oldalEgy = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Téglalap b-oldala: ");
        int oldalKetto = Convert.ToInt32(Console.ReadLine());
        int terulet = oldalEgy * oldalKetto;

        return terulet;
    }



teruletKiir();


Console.ReadKey();