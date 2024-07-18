using System;

namespace Aralikli_Faktoriyel_Hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2-8

            int t = 0;
            for (int i = 2; i < 9; i++)
            {
                t += Matematik.Faktoriyel(i);
                Console.WriteLine("{0}!={1}", i, Matematik.Faktoriyel(i) );
            }

            Console.WriteLine("Ortalama={0:F2}", (double)t/7);
             
        }
    }
}
