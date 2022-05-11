using System; 

class URI {

    static void Main(string[] args) {
        double i=1, n=0, p=0;
        while(i<=6) {
        n = double.Parse(Console.ReadLine());
        if(n>0)
            p++;
            i++;
        }
        Console.WriteLine(p +" valores positivos");
    }
}