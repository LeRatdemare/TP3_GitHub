// Affichage tableau 

public class Tableau
{
    public int X { get; set; }
    public int Y { get; set; }
    public char[,] tab;

    //Constructeur
    public Tableau(int x, int y)
    {
        this.X = x;
        this.Y = y;
        tab = new char[x, y];
    }

    //Méthodes
    public int NombreDeMots()
    {
        return 4;
    }
}