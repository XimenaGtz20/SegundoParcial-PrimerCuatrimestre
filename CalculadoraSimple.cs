sing System;
using System.Linq;

namespace Ejercicio_9;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Suma");
        Console.WriteLine("2.Resta");
        Console.WriteLine("3.Multiplicacion");
        Console.WriteLine("4.Division");
        Console.WriteLine("Indica la operacion que deseas realizar");
        int opcion = int.Parse(Console.ReadLine());
        int formula;

        Console.WriteLine("Ingresa el primer numero");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero");
        int numero2 = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                formula = numero1 + numero2;


                Console.WriteLine("Resultado = " + formula);

                break;

            case 2:
                formula = numero1 - numero2;

                Console.WriteLine("Resultado = " + formula);

                break;

            case 3:
                formula = numero1 * numero2;

                Console.WriteLine("Resultado = " + formula);

                break;

            case 4:
                if (numero2 != 0)
                {
                    formula = numero1 / numero2;


                    Console.WriteLine("Resultado = " + formula);
                }
                else
                {
                    Console.WriteLine("Error");
                }

                break;

            default:
                Console.WriteLine("Opcion no valida");

                break;

        }



    }
