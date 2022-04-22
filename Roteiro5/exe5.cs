using System;
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Digite um numero: ");
            x= int.Parse(Console.ReadLine());

            while(x>=1){

            if (x%2==1)
                Console.WriteLine(x + "\t");
                x = x - 1;
            }     
        }
    }
