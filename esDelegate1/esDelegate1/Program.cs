using System;

namespace esDelegate1
{
    class Program
    {
        static int[] vett = { -1, 2, 19, -2, 0, 4 };
        public delegate void Del(int[] r);

        static void Main(string[] args)
        {
            Del delegato = confronto;
            delegato(vett);
        }

        private static void confronto(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("Il numero " + arr[i] + " è minore di 0");
                }
                else if (arr[i] > 0)
                {
                    Console.WriteLine("Il numero " + arr[i] + " è maggiore di 0");
                }
                else if (arr[i] == 0)
                {
                    Console.WriteLine("Il numero " + arr[i] + " è uguale di 0");
                }
            }
        }

        
    }
}
