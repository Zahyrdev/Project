using System;

class Program
{
        static void Main(string[] args)
    {
            int area, b1, b2, altura;
            Console.WriteLine("Informe a base maior: ");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a base menor: ");
            b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura: ");
            altura = int.Parse(Console.ReadLine());
            area = ((b1 - b2) * altura) / 2;
            Console.WriteLine("A área do trapézio é de: " + area);
    }
}
