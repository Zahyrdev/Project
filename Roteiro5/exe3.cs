using System;
    class Program
    {
        static void Main(string[] args){
            
             int num, resultado=1;

                Console.WriteLine("Digite um número e descubra seu fatorial");
                num=int.Parse(Console.ReadLine());

                do{
                    resultado = resultado*num;
                    num = num-1;

                }while(num != 1);

                Console.WriteLine("O fatorial do número digitado é {0}", resultado);
        }
    }     

    