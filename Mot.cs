public class Mot
{
    public const int TAILLE_MAX = 7;
    static private Random rnd = new Random();

    public static String[] MOTS = {
    "chat", "chien", "maison", "fleur", "table", "soleil", "merci",
    "livre", "fraise", "feuille", "ciseaux", "pomme", "rouge", "plage",
    "ciel", "piano", "canard", "jouet", "école", "violet", "orange",
    "pizza", "amour", "cœur", "cadeau", "sable", "parole", "papier",
    "ombre", "nuage", "fouet", "farine", "miel", "argent", "argent",
    "cadeau", "bonjour", "chance", "bruit", "étoile", "hiver", "danse",
    "trésor", "nature", "oignon", "rêve", "flamme", "réveil", "coton",
    "poisson", "éponge", "feuille", "libre", "manger", "randonnée",
    "festival", "voyage", "montagne", "pluie", "arc-en-ciel", "oiseau",
    "crayon", "dessin", "guitare", "fraise", "nuit", "lune", "livre",
    "bougie", "vague", "terre", "joie", "peinture", "héros", "caméra",
    "fenêtre", "bouteille", "ciseaux", "mélodie", "évasion", "parfum",
    "bonheur", "princesse", "aventure", "hélicoptère", "brouillard",
    "horizon", "labyrinthe", "éclair", "plaisir", "enfance", "équilibre",
    "amitié", "chaleur", "cristal", "cascade", "évasion", "infini"
    };

    public Mot()
    {

    }

    public static String getMot(int taille)
    {
        int pos = rnd.Next(MOTS.Length);
        int nbMotsTestes = 0;
        while (nbMotsTestes < MOTS.Length && MOTS[pos].Length != taille)
        {
            pos = (pos + 1) % MOTS.Length;
            nbMotsTestes++;
        }
        if (nbMotsTestes < MOTS.Length)
            return MOTS[pos];
        else
            throw new Exception($"Il n'y a pas de mots de taille {taille} dans ma base de donnée...");
    }
}