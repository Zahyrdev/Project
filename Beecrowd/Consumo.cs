using System;
class Program
{
    static void Main(string[] args) { 
 
        int X;
        double Y, consumo;
        X = int.Parse(Console.ReadLine());
        Y = double.Parse(Console.ReadLine());
        consumo = X/Y;
        Console.WriteLine("{0:0.000} km/l",consumo);
    }

}