﻿using System;

namespace Roteiro5
{
    class Program
    {
        static void Main(string[] args){
            
            int num1, impar;
            Console.WriteLine("Insira um numero: ");
            num1 = int.Parse(Console.ReadLine());
            impar = num1;
            do{
                impar--;
                if (impar % 2 != 0)
                    Console.Write(impar + ", ");
            }while(impar > 0);
        }
    }
}
