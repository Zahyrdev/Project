    using System;

    namespace roteiro7
    {
        class Program
        {
            static void Main(string[] args)
            {
                int i, n, S=0;
                Console.WriteLine("Informe N: ");
                n = int.Parse(Console.ReadLine());
                for(i=0; i<n; i++){
                    S=S+i;
                    Console.WriteLine("S= "+ S);
                }
            }
        }
    }