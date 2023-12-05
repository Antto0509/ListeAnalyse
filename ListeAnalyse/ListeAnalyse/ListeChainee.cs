using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeAnalyse
{
    internal class ListeChainee
    {
        private string[] TabElmt;
        private int[] TabInd;
        private int tailleMax;

        public ListeChainee(int tailleMax)
        {
            this.tailleMax = tailleMax;
            this.TabElmt = new string[tailleMax];
            this.TabInd = new int[tailleMax];

            // Initialisation du tableau TabInd pour indiquer que chaque élément pointe vers le suivant
            for (int i = 0; i < tailleMax - 1; i++)
            {
                TabInd[i] = i + 1;
            }
            // Le dernier élément pointe vers -1 pour indiquer la fin de la liste
            TabInd[tailleMax - 1] = -1;
        }

        public int TailleListe()
        {
            int count = 0;
            int indice = 0;

            // Parcourir la liste à partir du premier élément
            while (indice != -1)
            {
                count++;
                indice = TabInd[indice];
            }
            return count;
        }

        public bool IsEmpty()
        {
            return TabInd[0] == -1;
        }

        public bool IsFull()
        {
            return TailleListe() == tailleMax;
        }

        public string Value(int rang)
        {
            int indice = 0;
            int count = 0;

            // Parcourir la liste jusqu'à la position spécifiée
            while (count < rang && indice != -1)
            {
                indice = TabInd[indice];
                count++;
            }

            if (indice != -1)
                return TabElmt[indice];
            else
                throw new IndexOutOfRangeException("Index hors limites");
        }

        public int Find(string element)
        {
            int indice = 0;
            int rang = 1;

            // Parcourir la liste pour trouver l'élément
            while (indice != -1)
            {
                if (TabElmt[indice] == element)
                    return rang;

                indice = TabInd[indice];
                rang++;
            }

            return 0; // Si l'élément n'est pas trouvé
        }

        public void Add(int rang, string element)
        {
            if (rang >= 1 && rang <= tailleMax)
            {
                if (!IsFull())
                {
                    int nouvelIndice = 0;
                    int precedentIndice = -1;
                    int count = 0;

                    // Trouver l'endroit où insérer le nouvel élément
                    while (count < rang && nouvelIndice != -1)
                    {
                        precedentIndice = nouvelIndice;
                        nouvelIndice = TabInd[nouvelIndice];
                        count++;
                    }

                    // Insérer le nouvel élément
                    TabElmt[nouvelIndice] = element;
                    TabInd[nouvelIndice] = precedentIndice;
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
            if (rang >= 1 && rang <= tailleMax)
            {
                int indiceASupprimer = 0;
                int precedentIndice = -1;
                int count = 0;

                // Trouver l'endroit où supprimer l'élément
                while (count < rang && indiceASupprimer != -1)
                {
                    precedentIndice = indiceASupprimer;
                    indiceASupprimer = TabInd[indiceASupprimer];
                    count++;
                }

                if (indiceASupprimer != -1)
                {
                    string elementSupprime = TabElmt[indiceASupprimer];

                    // Réorganiser les pointeurs pour supprimer l'élément
                    if (precedentIndice != -1)
                        TabInd[precedentIndice] = TabInd[indiceASupprimer];
                    else
                        TabInd[0] = TabInd[indiceASupprimer];

                    TabInd[indiceASupprimer] = -1; // Définir le pointeur de l'élément supprimé à -1

                    return elementSupprime;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index hors limites");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Index hors limites");
            }
        }
    }
}

