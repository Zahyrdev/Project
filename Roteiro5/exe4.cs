using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args){
            
            int num1, divisor = 1;
            Console.WriteLine("Insira um numero: ");
            num1 = int.Parse(Console.ReadLine());
            do{
                if (num1 % divisor == 0)
                Console.Write(divisor + " ");
                divisor++;
            }while(divisor <= num1);
        }
    }
}
