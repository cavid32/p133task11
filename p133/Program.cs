using System;

namespace p133
{
    class Program
    {
        static void Main(string[] args)
        {
            //Isdifadeci Terefinde Cumle Daxil Olunur.
            //Daxil Olunan Cumlenin En Uzun Sozunu Tap.

            Console.WriteLine("Cumleni daxil et");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");
            string BifOfWords = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    BifOfWords = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(BifOfWords);
        }
    }
}
