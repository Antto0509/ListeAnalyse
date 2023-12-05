using System;

namespace ListeAnalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test de la classe Liste

            // Création d'une liste avec une capacité de 5 éléments
            Liste maListe = new Liste(5);

            // Ajout d'éléments
            maListe.Add(0, "Element1");
            maListe.Add(1, "Element2");
            maListe.Add(2, "Element3");

            // Affichage de la taille de la liste
            Console.WriteLine($"Taille de la liste : {maListe.TailleListe()}");

            // Affichage du contenu de la liste
            for (int i = 0; i < maListe.TailleListe(); i++)
            {
                Console.WriteLine($"Element à la position {i} : {maListe.Value(i)}");
            }

            // Recherche d'un élément dans la liste
            string recherche = "Element2";
            int rang = maListe.Find(recherche);
            Console.WriteLine($"Position de {recherche} dans la liste : {rang}");

            // Suppression d'un élément
            int rangASupprimer = 1;
            string elementSupprime = maListe.Remove(rangASupprimer);
            Console.WriteLine($"Element supprimé à la position {rangASupprimer} : {elementSupprime}");

            // Affichage du contenu après suppression
            Console.WriteLine("Contenu après suppression :");
            for (int i = 0; i < maListe.TailleListe(); i++)
            {
                Console.WriteLine($"Element à la position {i} : {maListe.Value(i)}");
            }

            Console.ReadLine(); // Attendre que l'utilisateur appuie sur une touche
        }
    }
}
