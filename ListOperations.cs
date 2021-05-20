using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public static class ListOperations
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this List<T> questions)
        {
            int n = questions.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = questions[k];
                questions[k] = questions[n];
                questions[n] = value;
            }
        }
    }
}