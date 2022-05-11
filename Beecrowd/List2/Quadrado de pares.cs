using System;

namespace Roteiro5{
    class Program{
        static void Main(string[] args){ 
        int num, cont;
        num = int.Parse(Console.ReadLine());
            for ( cont = 1; cont <= num; ++cont){
                if(cont % 2 == 0){
                    Console.Write(cont+"^2 = "+(cont*cont)+"\n");
                }
            }
        }
    }
}