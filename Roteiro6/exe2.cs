using System;

namespace roteiro6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1, S=0, contador=0;
            Console.WriteLine("Hello World!");
            while(x !=0){
                Console.WriteLine("informe um valor: ");
                x = int.Parse(Console.ReadLine());
                S = S + x;
                contador++;
            }
            if(contador > 0){
                contador--;
            }
            Console.WriteLine("Soma = "+S);
            Console.WriteLine("Quantidade de numero formados = "+ contador);    
        }
    }
}