using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Insira o N-ésimo termo de uma sequencia Fibonacci: ");
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];
            if (n <= 0){
                Console.WriteLine("Digite uma posição inteira maior que 0");
                return;
            }
            fibonacci[0] = 1;
            if (n <= 1){
                Console.WriteLine("Valor do " + n + "°termo: " + fibonacci[n-1]);
                return;
            }
            fibonacci[1] = 1;
            if (n <= 2){
                Console.WriteLine("Valor do " + n + "°termo: " + fibonacci[n-1]);
                return;
            }
            int i = 2;
            do{
                int aux = 0;
                int j = i -2;
                do{
                    aux += fibonacci[j];
                    j++;
                }while(j < i);
                fibonacci[i] = aux;
                i++;
            }while(i < n);
            Console.WriteLine("Valor do " + n + "°termo: " + fibonacci[n-1]);    
        }
    }
}
