// TODO: Skapa minst 2 spelare
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----DRÖMMATCHEN----");
        
        Console.WriteLine("\n----Spelare 1-----");

        Console.Write("Ange spelarens namn: ");
        string namn1 = Console.ReadLine() ?? "Spelare1";

        Console.Write("Ange spelarens nummer: ");
        int nummer1 = int.Parse(Console.ReadLine());

        Console.Write("Ange spelarens Position: ");
        string position1 = Console.ReadLine()!;
        
        Console.Write("Ange spelarens mål: ");
        int mål1 = int.Parse(Console.ReadLine()!);

        Spelare spelare1 = new Spelare(namn1, nummer1, position1, mål1);

// Spelare spelare1 = new Spelare("Namn", nummer, "Position");


        Console.WriteLine("\n----Spelare 2-----");

        Console.Write("Ange spelarens namn: ");
        string namn2 = Console.ReadLine()!;

        Console.Write("Ange spelarens nummer: ");
        int nummer2 = int.Parse(Console.ReadLine());

        Console.Write("Ange spelarens Position: ");
        string position2 = Console.ReadLine();
        
        Console.Write("Ange spelarens mål: ");
        int mål2 = int.Parse(Console.ReadLine()!);

        Spelare spelare2 = new Spelare(namn2, nummer2, position2, mål2);


// Spelare spelare2 = new Spelare(...);

// TODO: Skapa 1 match

        Console.WriteLine("\n----MATCH-----");

        Console.Write("Ange hemmalag:");
        string hemma = Console.ReadLine();

        Console.Write("Ange bortalag:");
        string borta = Console.ReadLine();

        Console.Write("Ange datum: ");
        string datum = Console.ReadLine();

        Match match = new Match("Hemmalag", "Bortalag", "Datum");

        match.Presentera();

// Match match = new Match("Hemmalag", "Bortalag", "Datum");

// TODO: Anropa match.Presentera()


        Console.WriteLine("\n----MåLSKYTTAR-----");

        match.AnnounceraMålskytt(spelare1);
        match.AnnounceraMålskytt(spelare2);


// TODO: Anropa match.AnnounceraMålskytt() med båda spelarna

        Console.WriteLine("\n--- MATCHHJÄLTAR ---");

        Console.WriteLine(
            $"{spelare1.Namn} är matchhjälte: " +
            match.Ärmatchhjälte(spelare1)
        );

        Console.WriteLine(
            $"{spelare2.Namn} är matchhjälte: " +
            match.Ärmatchhjälte(spelare2)
        );

    }
}