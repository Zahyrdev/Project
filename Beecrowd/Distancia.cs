using System;
class Program
{
    static void Main(string[] args) { 
 
        double km, min;
        km = double.Parse(Console.ReadLine());
        min = (60 * km)/30;
        Console.WriteLine(min + " minutos");
    }

}