using System;

namespace uppift_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två strängar");
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            Console.WriteLine("Den längsta strängen är: " + Längst(text1, text2));

        }
        static string Längst(string text1, string text2)
        {
            if (text1.Length >= text2.Length)
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }
    }
}
