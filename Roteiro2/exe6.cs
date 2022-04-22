using System;

class Program
{
        static void Main(string[] args)
    {
            double cat1, cat2, soma, res;
            Console.WriteLine("Digite A medida do Cateto A: ");
            cat1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a medida do cateto B: ");
            cat2 = double.Parse(Console.ReadLine());
            soma = Math.Pow(cat1, 2)+ Math.Pow(cat2, 2);
            res = Math.Sqrt(soma);
            Console.WriteLine("O valor da hipotenusa é : " + res);
    }
}
