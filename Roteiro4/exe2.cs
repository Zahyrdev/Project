using System;
class Program
{
    static void Main(string[] args)
    {
       try {
           int hora;
           do {
               Console.WriteLine("Informe uma hora entre 0 e 23 ou 100 para sair: ");
               hora = int.Parse(Console.ReadLine());

               switch(hora) {
                    case 3:
                        Console.WriteLine("Matinas");
                        break;

                    case 5:
                        Console.WriteLine("Laudes");
                        break;

                    case 7:
                        Console.WriteLine("Prima");
                        break;

                    case 9:
                        Console.WriteLine("Tercia");
                        break;

                    case 12:
                        Console.WriteLine("Sexta");
                        break;

                    case 15:
                        Console.WriteLine("Noa");
                        break;

                    case 18:
                        Console.WriteLine("Vésperas");
                        break;

                    case 21:
                        Console.WriteLine("Completas");
                        break;

                    case 100:
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Não é uma hora canônica");
                        break;
                    }
               } while(hora != 100);

           } catch(Exception ex){
               Console.WriteLine("Erro" + ex.Message);
               Main(args);
           }
       }
}