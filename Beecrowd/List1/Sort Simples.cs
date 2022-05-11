using System;
class Program
{
    static void Main(string[] args) { 
        
		string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
		int c = int.Parse(valores[2]);
 		if (a <= b && b <= c){
    		Console.WriteLine(a);
    		Console.WriteLine(b);
    		Console.WriteLine(c);
 		}else if (a <= c && c <= b){
      		Console.WriteLine(a);
      		Console.WriteLine(c);
      		Console.WriteLine(b);
    	}else if (b <= a && a <= c){
        	Console.WriteLine(b);
        	Console.WriteLine(a);
        	Console.WriteLine(c);
      	}else if (b <= c && c <= a){
          	Console.WriteLine(b);
          	Console.WriteLine(c);
          	Console.WriteLine(a);
        }else if (c <= a && a <= b){
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }else if (a == b && b == c){
              Console.WriteLine(a);
              Console.WriteLine(b);
              Console.WriteLine(c);
        } else{
              Console.WriteLine(c);
              Console.WriteLine(b);
              Console.WriteLine(a);
        }
			Console.WriteLine();
			Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
    }
}