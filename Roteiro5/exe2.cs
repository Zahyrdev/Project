using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args){
            
            int multiplo = 7;
            Console.WriteLine("Multiplos de 7 menores que 1000...");
            do{
                if (multiplo % 7 == 0)
                    Console.Write(multiplo + ", ");
                multiplo++;
            }while(multiplo < 1000);
        }
    }
}