using System;

class Program
{
        static void Main(string[] args)
    {
            int a;
            Console.WriteLine("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            if ((a % 2 == 0) && (a % 7 == 0)){
                Console.WriteLine("O numero " + a + " é divisível por 2 e 7 ao mesmo tempo.");      
            }
            else{
               Console.WriteLine("O numero " + a + " não é divisível por 2 e 7 ao mesmo tempo.");
            }
    }
            
}    


