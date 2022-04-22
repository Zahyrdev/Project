using System;
    class Program
    {
        static void Main(string[] args){
            
            int cont = 1, multiplo, intervalo;
            Console.WriteLine("Insira um número e descubra o intervalo");
            intervalo = int.Parse(Console.ReadLine());
            do{
                multiplo = cont*3;
                Console.WriteLine(multiplo);
                cont = cont +1;
                
            }while(multiplo<intervalo);
           
           
        }
    }
    