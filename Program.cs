using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            int num1; int num2;int numop; 
            Console.WriteLine("Este programa esta hecho el sugundo dia del simposio de ciencias e inteligencia artificial de la ingieneria en sistemas computacionales");
            Console.WriteLine("\r\n ingrese dos numeros para realizar una suma");
            Console.WriteLine("numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" teclee el numero de la operacion a realizar\r\n 1.Suma\r\n2. Resta ");
            numop = Convert.ToInt32(Console.ReadLine());

            switch(numop)
            {
                case 1:
                    int resultado = num2 + num1;
                    Console.WriteLine(" el resultado de la suma de los dos numeros ingresados es: "+resultado);
                    break;
                    case 2:int resultado2 = num1 - num2;
                        Console.WriteLine(" el resultado de la resta de los dos numeros ingresados es: "+ resultado2);
                    break;
            }



        }
    }
}