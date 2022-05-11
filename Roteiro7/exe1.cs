    using System;

    namespace roteiro7
    {
        class Program
        {
            static void Main(string[] args)
            {
                int C;
                double F;
                for(C=0; C<=100; C++){
                    F= 9 * C / 5 + 32;
                    Console.WriteLine("C= " + C + " / F= " + F);
                }
            }
        }
    }