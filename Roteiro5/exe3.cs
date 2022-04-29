using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args){
            
            int num1, num2, maior, menor;
            Console.WriteLine("Insira um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero: ");
            num2 = int.Parse(Console.ReadLine());
            maior = num1;
            menor = num2;
            if(num2 > maior){
                maior = num2;
                menor = num1;
            }
            else if(maior == num2){
                Console.WriteLine("Os numeros são iguais");
                return;
            }
            do{
                menor++;
                if (menor % 3 == 0)
                Console.Write(menor + " ");
            }while(menor < maior -1);
        }
    }
}
