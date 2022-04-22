using System;

class Program
{
        static void Main(string[] args)
    {
            int a;
            Console.WriteLine("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            if ( a % 2 == 1){
                Console.WriteLine("O numero " + a + " é impar.");
            }
            else if ( a % 2 == 0){
                Console.WriteLine("O numero " + a + " é par.");
            }
    }
            
}        


