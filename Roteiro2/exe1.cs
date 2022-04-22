using System;

class Program
{
        static void Main(string[] args)
    {
            int num1, num2, res;
            Console.WriteLine("Entre com o primeiro valor");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor");
            num2 = int.Parse(Console.ReadLine());
            res = num1 - num2;
            Console.WriteLine("Resultado "+ (num1) + " - " + (num2) + " = " + res);
    }
}
