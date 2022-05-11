using System;
class Program
{
    static void Main(string[] args) { 
        
		string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
		double C = double.Parse(valores[2]);
 		if(((B * B) - 4 * A * C) < 0 || A == 0){
        Console.WriteLine("Impossivel calcular");
   		}
    	else{
        double t = Math.Sqrt((B * B) - 4 * A * C);
        Console.WriteLine("R1 = {0:0.00000}", ((-B + t) / (2 * A))); 
		Console.WriteLine("R2 = {0:0.00000}", ((-B - t) / (2 * A)));
		}
    }
}