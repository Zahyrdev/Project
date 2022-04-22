using System;

class Program
{
        static void Main(string[] args)
    {
            double x, y, z;
            Console.WriteLine("Digite a medida do ângulo A: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a medida do ângulo B: ");
            y = double.Parse(Console.ReadLine());
            z = 180 - (x + y);
            Console.WriteLine("A medida do ângulo C é " + z);
    }
}
