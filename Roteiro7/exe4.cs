using System;

namespace roteiro7
{
    class Program
    {
        static void Main(string[] args)
        {
            float C, K;
            for (C = 0; C <= 100; C = C + 1)
            {
                K = C + (float)273.15;
                Console.WriteLine("C = " + C + " K=" + K);
            }     
        }
    }
}
