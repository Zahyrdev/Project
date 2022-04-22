using System;

class Program
{
        static void Main(string[] args)
    {
            int a, b, c, maior, menor;
            Console.WriteLine("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            c = int.Parse(Console.ReadLine());
            if ((a > b) && (a >= c)){

                maior = a;
            }
            else if ((b > a) && (b >= c)){
                    
                maior = b;     
            }
           else{
                    
                maior = c;   

            }
           if ((a < b) && (a <= c)){

                menor = a;
            }
            else if ((b < a) && (b <= c)){
                    
                menor = b;     
            }
            else{
                    
                menor = c;   
        }           
         Console.WriteLine("O numero maior é " + maior + " e o menor é " + menor + ".");    
    }
            
}    


