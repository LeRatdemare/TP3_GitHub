// Affichage tableau 

using System.Runtime.CompilerServices;

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
        int compteur = 0;
        foreach (KeyValuePair<string, bool> mot in mots)
        {
            Console.WriteLine(mot.Key);
            if (!mot.Value)
                compteur++;
        }
        return compteur;
    }

    public void InitDictionaire()
    {
        // On veut au total 1/4 des lettres du tableau qui soient contenus dans des mots à trouver
        int nbLettresATrouver = (X * Y) / 2;
        int nbLettresPlacees = 0;

        while (nbLettresPlacees <= nbLettresATrouver - Mot.TAILLE_MAX)
        {
            int tailleMot = rnd.Next(Mot.TAILLE_MAX) + 1;
            mots.Add(Mot.getMot(tailleMot), false);
            nbLettresPlacees += tailleMot;
        }
    }

    public void PlacerMotsDansTableau()
    {
        // Placer les mots dans le tableau à partir du dictionnaire
    }

    public bool EstDansTab(string mot)
    {
        bool trouve = false;
        foreach (KeyValuePair<string, bool> motDuTableau in mots)
        {
            if (motDuTableau.Key == mot)
                trouve = true;
        }
        return trouve;
    }

    public bool EstTrouve(string mot)
    {
        if (mots[mot])
            return true;
        else
            return false;
    }

    public void AffichageDeTableau()
    {
        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                tab[i, j] = '_';
                if (j == 0)
                    Console.Write('#');

                Console.Write(tab[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // WARNING : Ne recherche que les mots de gauche à droite et de haut en bas
    public void EnleverMot(string mot)
    {
        // Si le mot est dans la liste :
        if (mots.ContainsKey(mot))
        {
            // - On le retire de tab
            int foundLetters = 0;

            int x = 0;
            int y = 0;
            while ((x < X || y < Y) && foundLetters < mot.Length)
            {

            }
            // - On le passe à true dans mots
            mots[mot] = true;
        }
        else
            throw new Exception($"Le mot {mot} n'est pas dans le tableau.");
    }

}