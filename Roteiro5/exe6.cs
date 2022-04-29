using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num1 = int.Parse(Console.ReadLine());
            long fatorial = num1;
            int i = num1;
            if (num1 == 0 || num1 == 1)
                Console.WriteLine("Fatorial: 1");
            else{
                do{
                    i--;
                    fatorial = fatorial * i;
                }while(i > 1);
                Console.WriteLine("Fatorial: " + fatorial);
            }
        }
    }
}
