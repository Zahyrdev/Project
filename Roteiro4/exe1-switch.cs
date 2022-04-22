using System;
class Program
{
        static void Main(string[] args)
    {
            float num1, num2, res = 0;
            int op;
            Console.WriteLine("Entre com o primeiro valor");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com 1 para somar: ");
            Console.WriteLine("Entre com 2 para subttrair: ");
            Console.WriteLine("Entre com 3 para multiplicar: ");
            Console.WriteLine("Entre com 4 para dividir: ");
            op = int.Parse(Console.ReadLine());
            switch (op){
            case 1:
                res = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + res);
                break;
            case 2:
                res = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + res);
                break;
            case 3:
                res = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + res);
                break;
            case 4:
                res = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + res);
                break;
            default:
                Console.WriteLine("Digite uma opção valida");
                break;
            }
        }
}
