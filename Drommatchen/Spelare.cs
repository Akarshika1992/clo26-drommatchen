public class Spelare    
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;
    private int _mål;
    
    // Properties — publik get, privat set
    public string Namn
    {
        
     get; private set; // Skapa get och privat set för Namn
    }

    public int Nummer
    {
        get; private set; // Skapa get och privat set för Nummer
    }

    public string Position
    {
    get; private set;   // Skapa get och privat set för Position
    }
    
    public int Mål
    {
        get; private set;   // Skapa get och privat set för Mål
    }
    // Konstruktor
    public Spelare(string namn, int nummer, string position, int mål)
    {
        Namn = namn;
        Nummer = nummer;
        Position = position;
        Mål = mål;
    }
}
