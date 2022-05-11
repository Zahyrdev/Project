using System;

namespace Roteiro5{
    class Program{
        static void Main(string[] args){ 
        int X, Y, total=0, total2=0;
        X = int.Parse(Console.ReadLine());
        Y = int.Parse(Console.ReadLine());
        if (X > Y) {
            for (int i = Y; i <= X; i++) {
                if(i % 13 != 0) {
                    total +=i;
                }
            }
            Console.WriteLine(total);
        }
        else if(X < Y){
                for (int i = X; i <= Y; i++) {
                    if(i % 13 != 0) {
                        total2 +=i;
                    }
                }
                Console.WriteLine(total2);
            }
        }
    }
}