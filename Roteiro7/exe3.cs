using System;

namespace roteiro7
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            double cos, sen;
            for (i=0; i <= 360; i = i + 15)
		{
                cos = Math.Cos((double)i);
                sen = Math.Sin((double)i);
                Console.WriteLine("ângulo = "+i+"cos="+cos);
                Console.WriteLine("ângulo = "+i+ "sen = "+sen);
            }
        }
    }
}
