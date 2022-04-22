using System;
    class Program
    {
        static void Main(string[] args){
            
            int num,i=1,c=0;
             while(i<=num && i++)
            {
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if(num%i==0)
                {
                c++;
                }
                Console.WriteLine(num);
            }
        }
    } 