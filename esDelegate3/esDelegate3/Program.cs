using System;

namespace esDelegate3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci primo numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci Secondo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Del delegato = Somma;
            delegato += Sottrazione;
            delegato += Moltiplicazione;
            delegato += Divisione;

            foreach(Del item in delegato.GetInvocationList())
            {
                Console.WriteLine("L'operazione {0} tra {1} e {2} risulta {3}", item.Method.Name, num1, num2, item(num1, num2));
            }
        }

        delegate double Del(double n1, double n2);

        static double Somma(double n1, double n2) {
            return n1 + n2;
        }

        static double Sottrazione(double n1, double n2)
        {
            return n1 - n2;
        }

        static double Moltiplicazione(double n1, double n2)
        {
            return n1 * n2;
        }

        static double Divisione(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
