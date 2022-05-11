using System;

namespace Roteiro5{
    class Program{
        static void Main(string[] args){ 
        float media=0, x;
        int cont=0;
        for(int i=1; i<=6; i++){
        x=float.Parse(Console.ReadLine());
        if(x>0){
            cont++;
            media+=x;
            }
        }
        Console.WriteLine(cont+" valores positivos");
        Console.WriteLine("{0,0}",(media/cont));
        }
    }
}
