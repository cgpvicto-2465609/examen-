namespace H26.P2.Algorithmes
{
    /// <summary>
    /// Fournit des méthodes statiques pour le tri de tableaux d'entiers.
    /// </summary>
    public static class OutilsTris
    {
        /// <summary>
        /// Trie un tableau d'entiers en utilisant l'algorithme Shell Sort.
        /// </summary>
        /// <param name="tab">Le tableau d'entiers à trier.</param>
        public static void ShellSort(int[] tab)
        {
            int n = tab.Length;
            for (int intervalle = n / 2; intervalle > 0; intervalle /= 2)
            {
                for (int i = intervalle; i < n; i++)
                {
                    int temp = tab[i];
                    int j;
                    for (j = i; j >= intervalle && tab[j - intervalle] > temp; j -= intervalle)
                    {
                        tab[j] = tab[j - intervalle];
                    }
                    tab[j] = temp;
                }
            }
        }

        /// <summary>
        /// Trie un tableau d'entiers en utilisant l'algorithme Quick Sort.
        /// </summary>
        /// <param name="tab">Le tableau d'entiers à trier.</param>
        public static void QuickSort(int[] tab)
        {
            QuickSort(tab, 0, tab.Length - 1);
        }

        /// <summary>
        /// Méthode récursive interne pour l'algorithme Quick Sort.
        /// </summary>
        /// <param name="tab">Le tableau à trier.</param>
        /// <param name="bas">L'indice de début de la partition.</param>
        /// <param name="haut">L'indice de fin de la partition.</param>
        private static void QuickSort(int[] tab, int bas, int haut)
        {
            if (bas < haut)
            {
                int indexPivot = Partitionner(tab, bas, haut);
                QuickSort(tab, bas, indexPivot - 1);
                QuickSort(tab, indexPivot + 1, haut);
            }
        }

        /// <summary>
        /// Partitionne le tableau pour Quick Sort autour d'un pivot.
        /// </summary>
        /// <param name="tab">Le tableau à partitionner.</param>
        /// <param name="bas">L'indice de début.</param>
        /// <param name="haut">L'indice de fin.</param>
        /// <returns>L'indice du pivot après partitionnement.</returns>
        private static int Partitionner(int[] tab, int bas, int haut)
        {
            int pivot = tab[haut];
            int i = bas - 1;

            for (int j = bas; j < haut; j++)
            {
                if (tab[j] <= pivot)
                {
                    i++;
                    Permuter(tab, i, j);
                }
            }

            Permuter(tab, i + 1, haut);
            return i + 1;
        }

        /// <summary>
        /// Permute deux éléments dans un tableau.
        /// </summary>
        private static void Permuter(int[] tab, int i, int j)
        {
            int temp = tab[i];
            tab[i] = tab[j];
            tab[j] = temp;
        }
    }
}
