using System;
using System.Collections.Generic;

namespace GeograficWars.Shared
{
    public static class Shuffler
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;

            while (n > 1)
            {
                n--;

                int k = rng.Next(n + 1);

                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
