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
            try
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
            catch (IndexOutOfRangeException ex)
            {
                // Gérer l'exception localement
                Console.WriteLine($"Erreur lors de l'accès à la position {rang} : {ex.Message}");
                // Vous pouvez effectuer d'autres opérations ici en cas d'erreur d'index
                return null; // Ou une valeur par défaut appropriée
            }
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
            if (rang >= 0 && rang <= tailleMax)
            {
                if (!IsFull())
                {
                    // Décalage des éléments à droite pour faire de la place
                    for (int i = TailleListe(); i > rang; i--)
                    {
                        TabElmt[i] = TabElmt[i - 1];
                        TabInd[i] = TabInd[i - 1];
                    }
                    TabElmt[rang] = element;
                    TabInd[rang] = rang;
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
            try
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
            catch (IndexOutOfRangeException ex)
            {
                // Gérer l'exception IndexOutOfRangeException localement
                Console.WriteLine($"Erreur lors de la suppression : {ex.Message}");
                // Vous pouvez effectuer d'autres opérations ici en cas d'erreur d'index
                return null; // Ou une autre valeur par défaut selon vos besoins
            }
        }

        /*private int TrouverIndiceLibre()
        {
            for (int i = 0; i < tailleMax; i++)
            {
                if (TabElmt[i] == null)
                {
                    return i;
                }
            }
            return -1; // Aucun indice libre trouvé
        }*/
    }
}

