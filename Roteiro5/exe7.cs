using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] arrayInteiro = Console.ReadLine().Split(" ");
            int i = 0;
            int soma = 0;
                do{
                    soma += int.Parse(arrayInteiro[i]);
                    i++;
                }while(i < arrayInteiro.Length);
                Console.WriteLine("Soma: " + soma);
        }
    }
}
