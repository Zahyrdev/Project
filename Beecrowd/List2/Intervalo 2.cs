using System;

namespace Roteiro5{
    class Program{
        static void Main(string[] args){ 
        int qtd, n, x=0, y=0, i; 
        qtd = int.Parse(Console.ReadLine());
            for(i=0;i<qtd;i++){
            n = int.Parse(Console.ReadLine());
                if((n>=10) && (n<=20)){
                    x++;
                }   
                else{
                    y++;
                }
            }
            Console.WriteLine(x + " in");
            Console.WriteLine(y + " out");
        }
    }
}