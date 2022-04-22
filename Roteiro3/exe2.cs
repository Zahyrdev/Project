using System;

class Program
{
        static void Main(string[] args)
    {
            float a;
            Console.WriteLine("Digite um numero: ");
            a = float.Parse(Console.ReadLine());
            if ( a > 0 ){
                Console.WriteLine("O numero " + a + " é positivo.");
            }
            else if ( a < 0){
                Console.WriteLine("O numero " + a + " é negativo.");
            }
            else if (a == 0){
                Console.WriteLine("O numero " + a + " é nulo.");
            }
    }
}        


