using System;

class Program
{
        static void Main(string[] args)
    {
            int a, b;
            Console.WriteLine("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            b = int.Parse(Console.ReadLine());
            if (a > b){
                Console.WriteLine(a + " é maior que " + b);
            }
            else if (b > a){
                Console.WriteLine(b + " é maior que " + a);
            }
    }
}        


