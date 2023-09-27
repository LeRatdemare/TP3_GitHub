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

    public override string ToString()
    {
        return base.ToString();
    }

    public void MotEnlever()
    {

    }

}