//Cette classe permet de lancer le jeu 

public class Jeu
{
    private Tableau plateau;
    private int tour;
    public Jeu()
    {
        plateau = new Tableau(5, 5);
    }

    public void Partie()
    {
        while (!Gagner())
        {
            Console.WriteLine("Pour quitter veuillez saisir q.\nVeuillez saisir un mot du tableau : ");
        }
    }

    public bool Gagner()
    {
        return false;
    }


}