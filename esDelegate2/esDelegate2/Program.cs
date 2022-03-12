using System;

namespace esDelegate2
{
    class Program
    {
        public delegate double Del(double number);

        static void Main(string[] args)
        {
            Console.WriteLine("Inserire valore: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Del delegato = Square;
            delegato += Cube;

            double number = 0;
            foreach (Del item in delegato.GetInvocationList())
            {
                if(item.Method.Name == "Square")
                {
                    number = item(n);
                    Console.WriteLine("Il quadrato: " + number);
                }
                else if(item.Method.Name == "Cube")
                {
                    Console.WriteLine("Il cubo: " + item(number));
                }
            }
        }

        public static double Square(double n)
        {         
            return Math.Pow(n, 2);
        }

        public static double Cube(double n)
        {
            return Math.Pow(n, 3);
        }
    }
}
