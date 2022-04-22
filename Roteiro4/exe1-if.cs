using System;
class Program
{
        static void Main(string[] args)
    {
            float num1, num2, res;
            res = 0;
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
            if(op == 1){
                res = num1 + num2;
            }
            else if(op == 2){
                res = num1 - num2;
            }
            else if(op == 3){
                res = num1 * num2;
            }
            else if(op == 4){
                res = num1 / num2;
            }
            Console.WriteLine("Resultado "+ res);
    }
}
