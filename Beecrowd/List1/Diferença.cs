using System;

class Program
{
    static void Main(string[] args)
        {
             int A, B, C, D, DIFERENCA;
            Console.WriteLine("Valor 1: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 3: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 4: ");
            D = int.Parse(Console.ReadLine());
            DIFERENCA = (A * B - C * D);
            Console.WriteLine("DIFERENCA = " + DIFERENCA);

    }

}