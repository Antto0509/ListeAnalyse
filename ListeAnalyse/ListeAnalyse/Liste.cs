using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeAnalyse
{
    internal class Liste
    {
        private string[] tableau;
        private int tailleMax;

        public Liste(int tailleMax)
        {
            this.tailleMax = tailleMax;
            this.tableau = new string[tailleMax];
        }

        public int TailleListe()
        {
            int count = 0;
            foreach (string element in tableau)
            {
                if (element != null)
                    count++;
            }
            return count;
        }

        public bool IsEmpty()
        {
            return TailleListe() == 0;
        }

        public bool IsFull()
        {
            return TailleListe() == tailleMax;
        }

        public string Value(int rang)
        {
            if (rang >= 0 && rang < tailleMax)
                return tableau[rang];
            else
                throw new IndexOutOfRangeException("Index hors limites");
        }

        public int Find(string element)
        {
            for (int i = 0; i < tailleMax; i++)
            {
                if (tableau[i] == element)
                    return i + 1; // Rang commence à 1
            }
            return 0; // Si l'élément n'est pas trouvé
        }

        public void Add(int rang, string element)
        {
            if (rang >= 0 && rang <= tailleMax)
            {
                if (!IsFull())
                {
                    // Décalage des éléments à droite pour faire de la place
                    for (int i = TailleListe(); i > rang; i--)
                    {
                        tableau[i] = tableau[i - 1];
                    }
                    tableau[rang] = element;
                }
                else
                {
                    throw new InvalidOperationException("La liste est pleine, impossible d'ajouter un nouvel élément.");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Index hors limites");
            }
        }

        public string Remove(int rang)
        {
            if (rang >= 0 && rang < tailleMax)
            {
                string element = tableau[rang];
                // Décalage des éléments à gauche pour remplir le trou
                for (int i = rang; i < TailleListe() - 1; i++)
                {
                    tableau[i] = tableau[i + 1];
                }
                tableau[TailleListe() - 1] = null; // Dernier élément devient null
                return element;
            }
            else
            {
                throw new IndexOutOfRangeException("Index hors limites");
            }
        }
    }
}
