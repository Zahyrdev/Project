using System;

namespace Roteiro5{
    class Program{
        static void Main(string[] args){ 
        int N,cont =1;
        N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(cont + " ");
                    cont++;
                }
                Console.Write("PUM\n");
                cont++;
            }
        }
    }
}