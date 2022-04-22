using System;

class Program
{
        static void Main(string[] args)
    {
            double c, a, v, raio;
            Console.WriteLine("Digite a medida do raio: ");
            raio = double.Parse(Console.ReadLine());
            c = Math.Round(2 * Math.PI * raio);
            a = Math.Round(Math.PI * Math.Pow(raio, 2));
            v = Math.Round(4 * Math.PI * Math.Pow(raio, 3) /3);
            Console.WriteLine("O valor do comprimento é " + c);
            Console.WriteLine("O valor da área é " + a);
            Console.WriteLine("O valor do volume é : " + v);
    }
}
