using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args)
        { 
            int soma = 0;
            do{
                Console.WriteLine("Soma: " + soma);
                Console.WriteLine("Digite um número entre 1 e 13");
                int valor = int.Parse(Console.ReadLine());
                if(valor > 0 && valor <= 13){
                    soma += valor;
                }
                else{
                    Console.WriteLine("O número de estar entre 1 e 13");
                }
                if (soma == 21){
                    Console.WriteLine("Voce venceu!");
                    return;
                }
            }while(soma < 21);
            Console.WriteLine("Voce perdeu - Soma: " + soma);
        }
    }
}
