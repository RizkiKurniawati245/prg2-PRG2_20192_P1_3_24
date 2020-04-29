using System;

namespace PRG2_20192_P1_3_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;

            Console.WriteLine("PROGRAM LAGU ANAK AYAM");
            Console.WriteLine("----------------------");
            
            Console.WriteLine("ANAK AYAM TURUN {0}\n", N);

            for (int i=N; i>0; i--)
            {
                int a;
                a = i;
                a--;

                if (i > 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", i, a);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun 1, mati 1 tinggal induknya");
                }
            } 
        }
    }
}
