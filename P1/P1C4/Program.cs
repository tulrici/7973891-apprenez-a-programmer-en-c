// TODO, étape 1 : instancier un objet de la classe Livre et affecter cet objet à une variable nommée monLivre

Livre monLivre = new Livre();
class Livre
{
    public string Titre;
    public string Auteur;
    public int NombreDePages;
    public string Editeur = "pas moi";
}


// TODO, étape 2 : affecter une valeur aux champs titre, auteur et nombre de pages de votre objet
monLivre.Titre = "Titre moins ouf";
monLivre.Auteur = "Carlos";
monLivre.NombreDePages = 50;

// Afficher le contenu des champs de cet objet 
Console.WriteLine("Le titre du livre est " + monLivre.Titre);
Console.WriteLine("Son auteur est " + monLivre.Auteur);
Console.WriteLine("Il compte " + monLivre.NombreDePages + " pages");