using System;
using System.Collections.Generic;


namespace Course
{
    class god
    {
        public void poxyi(int[] seq)
        {
            var counts = new Dictionary<int, int>();
            foreach(int num in seq)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach(var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine(pair.Key); 
                }
            }
        }

    }
}
