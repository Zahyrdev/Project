    using System;

    namespace roteiro6
    {
        class Program
        {
            static void Main(string[] args)
            {
                double pgs = -1, pac, pds, maiorg = -1, menorg = 99999, maiora = -1, menora = 99999, maiord = -1, menord = 99999;
                while(pgs != 0){
                    Console.WriteLine("Entre com o valor da Gasolina: ");
                    pgs = double.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o valor da Alcool: ");
                    pac = double.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o valor da Diesel: ");
                    pds = double.Parse(Console.ReadLine());
                    if(pgs < menorg && pgs > 0){
                        menorg = pgs;
                    }
                    if (pgs > maiorg){
                        maiorg = pgs;
                    }
                    if(pac < menora && pac > 0){
                        menora = pac;
                    }
                    if (pac > maiora){
                        maiora = pac;
                    }
                    if(pds < menorg && pds > 0){
                        menord = pds;
                    }
                    if (pds > maiorg){
                        maiord = pds;
                    }
                }
                    Console.WriteLine("Menor preço para gasolina: "+ menorg);
                    Console.WriteLine("Maior preço para gasolina: "+ maiorg);
                    Console.WriteLine("Menor preço para alcool: "+ menora);
                    Console.WriteLine("Maior preço para alcool: "+ maiora);
                    Console.WriteLine("Menor preço para diesel: "+ menord);
                    Console.WriteLine("Maior preço para diesel: "+ maiord);
            }
        }
    }