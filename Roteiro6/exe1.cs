using System;

namespace roteiro6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1, S=0;
            while(x !=0){
                Console.WriteLine("informe um valor: ");
                x = int.Parse(Console.ReadLine());
                S = S + x;
                Console.WriteLine("soma = "+S);
            }
        }
    }
}