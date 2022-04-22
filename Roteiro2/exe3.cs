using System;

class Program
{
        static void Main(string[] args)
    {
            int a, b, res;
            Console.WriteLine("Qual o valor do produto?");
            a = int.Parse(Console.ReadLine());
            b = a * 10 / 100;
            res = a - b;
            Console.WriteLine("O desconto de 10% será de R$ " + res);
    }
}
