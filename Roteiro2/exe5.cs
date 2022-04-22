using System;

class Program
{
        static void Main(string[] args)
    {
            int res, s1, s2;
            Console.WriteLine("Qual o salário minímo? ");
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o salário do funcionário? ");
            s2 = int.Parse(Console.ReadLine());
            res = s2 / s1;
            Console.WriteLine("O funcionário recebe cerca de " + res +" salários minímos.");
    }
}
