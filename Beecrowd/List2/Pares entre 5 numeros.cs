using System;

namespace Roteiro5{
    class Program{
        static void Main(string[] args){ 
        int x, cont=0;
        for(int i=1; i<=5; i++){
        x=int.Parse(Console.ReadLine());
        if(x%2==0){
            cont++;
            }
        }
        Console.WriteLine(cont+" valores pares");
        }
    }
}
