//Cette classe permet de lancer le jeu 

public class Jeu
{
    private Tableau plateau;
    private int tour;
    public Jeu()
    {
        plateau = new Tableau(5, 5);
        tour = 0;
    }

    public void Partie()
    {
        tour++;
        bool quitter = false;
        while (!Gagner() && !quitter)
        {
            plateau.AffichageDeTableau();
            Console.WriteLine("Pour quitter veuillez saisir q.\nVeuillez saisir un mot du tableau : ");
            string mot = Console.ReadLine()!;
            quitter = Quitter(mot);
            if (!quitter)
            {
                if (RechercheDeMot(mot))
                {
                    if (!MotDejaTrouve(mot))
                    {
                        Console.WriteLine("Le mot " + mot + " est bien présent dans la grille.");
                        plateau.EnleverMot(mot);
                    }
                    else
                        Console.WriteLine("Le mot " + mot + " a déjà trouvé.");
                }
                else
                    Console.WriteLine("Le mot " + mot + " n'est pas présent dans la grille.");
            }

        }
    }

    public bool Gagner()
    {
        if (plateau.NombreDeMots() == 0)
        {
            return true;
        }
        return false;
    }

    public bool Quitter(string mot)
    {
        bool quitter = false;
        if (mot == "q")
        {
            quitter = true;
            Console.WriteLine("Merci d'avoir joué! A bientôt.");
        }
        return quitter;

    }

    public bool RechercheDeMot(string mot)
    {
        return plateau.EstDansTab(mot);
    }

    public bool MotDejaTrouve(string mot)
    {
        return plateau.EstTrouve(mot);
    }


}