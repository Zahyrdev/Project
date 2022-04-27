using System;
    namespace Roteiro6{
        class Atividade4{
            static void Main(string[] args){

                int num = 1, s = 0, cont = 0;
                char repetir;

                do{
                while(num != 0){
                Console.WriteLine("Digite um valor:");
                num = int.Parse(Console.ReadLine());
                s = s + num;
                Console.WriteLine("A soma dos números anteriores é: {0}, Contagem:{1}", s, cont);
                cont++;
                }
                Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
                    repetir = Console.ReadKey().KeyChar; 
                } while (repetir == 'S' || repetir == 's'); 

        }
    }
}