using System;

class Program
{
        static void Main(string[] args)
    {
            int n1, n2, n3, n4, media;
            Console.WriteLine("Nota 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 4: ");
            n4 = int.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("A média obtida foi: " +  media);
            if (media >= 60){

                Console.WriteLine("O aluno foi APROVADO.");
            }
            else{
                    
                Console.WriteLine("O aluno foi REPROVADO.");   

            }               
    }
            
}    


