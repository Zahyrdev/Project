using System;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Entre com o primeiro valor: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o segundo valor: ");
        num2 = int.Parse(Console.ReadLine());
        do{
            Console.Write(num1+" ");
            num1 = num1 + 1;
        }while (num1 <= num2);
    }
}