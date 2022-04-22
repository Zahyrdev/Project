using System;

class Program
{
        static void Main(string[] args)
    {
            double horat, salarioh, sb, desc, sl;
            Console.WriteLine("Horas Trabalhadas: ");
            horat = double.Parse(Console.ReadLine());
            Console.WriteLine("Salario Hora: ");
            salarioh = double.Parse(Console.ReadLine());
            sb = (horat * salarioh);
            if (sb < 350.00){
                desc = 0 + sb;
                sl = sb;
                Console.WriteLine("O salário bruto é de R$ " + sb.ToString("F"));  
                Console.WriteLine("O valor de desconto é de R$ " + desc.ToString("F"));
                Console.WriteLine("O salario liquido é de R$ " + sl.ToString("F"));
                Console.WriteLine("O salario bruto sofreu um desconto de 0%.");  
            }
            else if ((sb >= 350.00) && (sb <= 1000)){
                desc = 0.1 * sb;
                sl = sb - desc;
                Console.WriteLine("O salário bruto é de R$ " + sb.ToString("F"));  
                Console.WriteLine("O valor de desconto é de R$ " + desc.ToString("F"));
                Console.WriteLine("O salario liquido é de R$ " + sl.ToString("F"));
                Console.WriteLine("O salario bruto sofreu um desconto de 10%.");      

            }   
            else if (sb > 1000.00){
                desc = 0.2 * sb;
                sl = sb - desc;
                Console.WriteLine("O salário bruto é de R$ " + sb.ToString("F"));  
                Console.WriteLine("O valor de desconto é de R$ " + desc.ToString("F"));
                Console.WriteLine("O salario liquido é de R$ " + sl.ToString("F")); 
                Console.WriteLine("O salario bruto sofreu um desconto de 20%.");   
            }               
    }            
    
           
}    


