// Affichage tableau 

public class Tableau
{
    public int X { get; set; }
    public int Y { get; set; }
    public Dictionary<string, bool> mots;
    public char[,] tab;

    //Constructeur
    public Tableau(int x, int y)
    {
        this.X = x;
        this.Y = y;
        tab = new char[x, y];
        mots = new Dictionary<string, bool>();
        InitDictionaire();

    }

    //Méthodes
    public int NombreDeMots()
    {
        return 4;
    }

    public void InitDictionaire()
    {

    }

    public bool EstDansTab(string mot)
    {
        return false;
    }

    public bool EstTrouve(string mot)
    {
        return false;
    }

    public void AffichageDeTableau()
    {
        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                Console.WriteLine("_");
            }
        }
    }

    public void EnleverMot(string mot)
    {
        // Si le mot est dans la liste :
        // - On le retire de tab
        // - On le passe à true dans mots
        // Sinon :
        // On lève une erreur
    }

}