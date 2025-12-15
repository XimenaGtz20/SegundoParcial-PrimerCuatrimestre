using System;
using System.Linq;

namespace Ejercicio_13;

public static class Program
{
    public static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("1.Calcular el doble de un numero: ");
            Console.WriteLine("2.Calcular el triple de un numero: ");
            Console.WriteLine("3.Calcular el cuadrado de un numero: ");
            Console.WriteLine("4.Salir.");

            Console.WriteLine("Ingresa el numero: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Indica la operacion que deseas realizar: ");
            opcion = int.Parse(Console.ReadLine());
            int formula;

            switch (opcion)
            {
                case 1:

                    formula = num * 2;

                    Console.WriteLine("Resultado: " + formula);

                    break;


                case 2:

                    formula = num * 3;

                    Console.WriteLine("Resultado: " + formula);

                    break;

                case 3:

                    formula = num * num;

                    Console.WriteLine("Redultado: " + formula);

                    break;

                case 4:

                    Console.WriteLine("Salir.");

                    break;

                default:

                    Console.WriteLine("Opcion no valida.");

                    break;
            }




        } while (opcion != 4);
    }
}
