using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;


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
        public static string SpinWords(string value)
        {
            string[] words = value.Split(' '); 
            StringBuilder sb = new StringBuilder();            
            foreach(string word in words)
            {
                if(word.Length >= 5)
                {
                    char[] charArray = word.ToCharArray();
                    Array.Reverse(charArray);
                    sb.Append(charArray);
                }
                else
                {
                    sb.Append(word);
                }
                sb.Append(' ');
            }
            if(sb.Length > 0)
            {
                sb.Length--;
            }
            return sb.ToString();
        }
        public static string Likes(string[] name)
        {
            switch(name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    return $"{name[0]}, {name[1]} and {name.Length -2} others like this";
            }
        }

    }
}
