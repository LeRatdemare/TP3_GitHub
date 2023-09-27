// Affichage tableau 

public class Tableau
{
    static private Random rnd = new Random();
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
        // On veut au total 1/4 des lettres du tableau qui soient contenus dans des mots à trouver
        int nbLettresATrouver = (X * Y) / 4;
        int nbLettresPlacees = 0;

        while (nbLettresPlacees <= nbLettresATrouver - Mot.TAILLE_MAX)
        {

        }
    }

    public bool EstDansTab(string mot)
    {
        if (mots[mot] == true)
            return true;
        else
            return false;
    }

    public bool EstTrouve(string mot)
    {
        return false;
    }

    public override string ToString()
    {
        return base.ToString();
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