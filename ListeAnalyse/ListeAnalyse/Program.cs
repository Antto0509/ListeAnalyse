using System;

namespace ListeAnalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test de la classe Liste

            Console.WriteLine("Test de la classe Liste\n");

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



            // Test de la classe ListeChainee

            Console.WriteLine("\nTest de la classe ListeChainee\n");

            // Création d'une liste chaînée avec une capacité de 5 éléments
            ListeChainee maListeChainee = new ListeChainee(5);

            // Ajout d'éléments
            maListeChainee.Add(0, "Element1");
            maListeChainee.Add(1, "Element2");
            maListeChainee.Add(2, "Element3");

            // Affichage de la taille de la liste chaînée
            Console.WriteLine($"Taille de la liste chaînée : {maListeChainee.TailleListe()}");

            // Affichage du contenu de la liste chaînée
            for (int i = 1; i <= maListeChainee.TailleListe(); i++)
            {
                Console.WriteLine($"Element à la position {i} : {maListeChainee.Value(i)}");
            }

            // Recherche d'un élément dans la liste chaînée
            string recherche2 = "Element2";
            int rang2 = maListeChainee.Find(recherche2);
            Console.WriteLine($"Position de {recherche2} dans la liste chaînée : {rang2}");

            // Suppression d'un élément
            int rangASupprimer2 = 2;
            string elementSupprime2 = maListeChainee.Remove(rangASupprimer2);
            Console.WriteLine($"Element supprimé à la position {rangASupprimer2} : {elementSupprime2}");

            // Affichage du contenu après suppression
            Console.WriteLine("Contenu après suppression :");
            for (int i = 1; i <= maListeChainee.TailleListe(); i++)
            {
                Console.WriteLine($"Element à la position {i} : {maListeChainee.Value(i)}");
            }

            Console.ReadLine(); // Attendre que l'utilisateur appuie sur une touche
        }
    }
}
