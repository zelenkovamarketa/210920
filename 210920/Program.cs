using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _210920
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            Encode1.k = Console.ReadLine();
            if (path.Contains(".txt"))
            {
                string s1 = Encode1.Encoding1(File.ReadAllText(path));
                Console.WriteLine(s1);
                Console.WriteLine(Encode1.Decoding1(s1));
                string path2 = path.Replace(".txt", ".cry");
                File.WriteAllText(path2, s1);
            }
            if (path.Contains(".cry"))
            {
                string s2 = Encode1.Decoding1(File.ReadAllText(path));
                Console.WriteLine(s2);
                string path2 = path.Replace(".cry", ".txt");
                File.WriteAllText(path2, s2);
            }
            Console.ReadLine();
        }
    }
    class Encode1
    {
        public static string k;
        public static string Encoding1(string t)
        {
            string r = "";
            for (int i = 0; i < t.Length; i++)
            {
                int x = (int)t[i] ^ k[i % (k.Length - 1)];
                r += (char)x;
            }
            return r;
        }
        public static string Decoding1(string l)
        {
            string r = "";
            for (int i = 0; i < l.Length; i++)
            {
                int x = (int)k[i % (k.Length - 1)] ^ l[i];
                r += (char)x;
            }
            return r;
        }
    }
}
