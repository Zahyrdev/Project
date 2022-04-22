using System;

class Program
{
        static void Main(string[] args)
    {
            int a, b, c, soma;
            Console.WriteLine("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            c = int.Parse(Console.ReadLine());
            if ((a < b) && (c <= a)){

                soma = a + b;
            }
            else if ((a < c) && (b <= a)){
                    
                soma = a + c;     
            }
           else{
                    
                soma = b + c;   

            }
            Console.WriteLine("A soma dos numeros maiores é " + soma + ".");                
    }
            
}    


