using System; 

class URI {

    static void Main(string[] args) { 

        int cod, qnt; 
        double total=0;
        string[] linha = Console.ReadLine().Split(' ');
        cod = int.Parse(linha[0]);
        qnt = int.Parse(linha[1]);
        if (cod==1){
            total=4*qnt;
        }
        else if (cod==2){
            total=4.5*qnt;
        }
        else if (cod==3){
            total=5*qnt;
        }
        else if (cod==4){
            total=2*qnt;
        }
        else if (cod==5){
            total=1.5*qnt;
        }
        Console.WriteLine("Total: R$ {0:0.00}",total);
    }

}