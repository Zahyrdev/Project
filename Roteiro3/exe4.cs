using System;

class Program
{
        static void Main(string[] args)
    {
            int a, res;
            Console.WriteLine("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            res = Math.Abs(a);
            Console.WriteLine("O valor absoluto é " + res);      
    }
            
}        


