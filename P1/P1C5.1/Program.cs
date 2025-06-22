// TODO : Déclarer une variable nommée couleurs d'un array de string de longueur 5
string [] couleurs = new string[] {"rouge", "jaune", "orange", "vert", "bleu"};

// TODO : Remplir le tableau avec les couleurs demandées dans le README.md

// TODO : Remplacer vert par émeraude dans le tableau
couleurs[3] = "émeraude";

// Afficher le contenu du tableau
foreach (string couleur in couleurs)
{
    Console.WriteLine(couleur);
}