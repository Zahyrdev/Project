using System;

namespace roteiro7
{
    class Program
    {
        static void Main(string[] args)
        {
        /*double d, c = 1, e, somatorio = 0;

        for (int i = 1; i <= 50; i++)
        {
            d = c / (double)i;
            c = c + 2;
            somatorio += d;
        }

        Console.WriteLine(somatorio);*/

        /* double c = 21, e = 250, d = 0, soma = 0;
        for (double i = 21; i <= 250; i++)
        {
            d = c / e;
            c = c + 1;
            e = e - 1;
            soma += d;
        }
        Console.WriteLine(soma);*/

        /*double p, d, c = 0, n = 0, soma = 0;
        Console.WriteLine("Digite o valor de N");
        n = double.Parse(Console.ReadLine());
        for (double i = 1; i <= n; i++)
        {
            Console.Write("{0}/{1}", i, Math.Pow(i, 2));
            if (i != n)
            {
                if (i % 2 == 0)
                    Console.Write(" + ");
                else
                    Console.Write(" - ");
            }
            soma = i%2==0 ? soma-(double)i/Math.Pow(i, 2) : soma+(double)i/Math.Pow(i, 2);
        }
        Console.WriteLine("\nL = {0:0.00}", soma);*/
        }
    }
}
