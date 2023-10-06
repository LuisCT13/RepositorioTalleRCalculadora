using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num1; int num2; int numop; int conf = 0;


            do
            {
                Console.Clear();
                Console.WriteLine("Este programa esta hecho el sugundo dia del simposio de ciencias e inteligencia artificial de la ingieneria en sistemas computacionales");
                Console.WriteLine("\r\n ingrese dos numeros para realizar una operacion");
                Console.WriteLine("\r\nnumero 1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\r\nnumero 2");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" \r\nTeclee el numero de la operacion a realizar\r\n 1.Suma\r\n 2.Resta \r\n 3.Multiplicacion\r\n 4.Division ");
                numop = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\r\n\r\n");
                switch (numop)
                {

                    case 1:
                        int resultado = num2 + num1;
                        Console.WriteLine(" el resultado de la suma de los dos numeros ingresados es: " + resultado);
                        break;

                    case 2:
                        int resultado2 = num1 - num2;
                        Console.WriteLine(" el resultado de la resta de los dos numeros ingresados es: " + resultado2);
                        break;

                    case 3:
                        int resultado3 = num1 * num2;
                        Console.WriteLine(" el resultado de la Multiplicacion de los dos numeros ingresados es: " + resultado3);
                        break;

                    case 4:
                        int resultado4 = num1 / num2;
                        Console.WriteLine(" El resultado de la Division de los dos numeros ingresados es: " + resultado4);
                        break;

                }
                Console.WriteLine(" Deseas volver a hacer otra operación?  si es asi, teclea 1 en la consola");
                Console.WriteLine( "Hecho por Luis Angel Covarrubias Tamayo UWU NYAAAAAAAAAAAAAAAAAAAAAAAA");
                conf = Convert.ToInt32(Console.ReadLine());

                



            } while (conf==1);





        }

        }

}