using System;
using System.Linq;

namespace Ejercicio_10;

public static class Program

{
    static void Main()
    {
        int numero;
        int pos = 0;
        int neg = 0;

        Console.WriteLine("Ingresa un numero, se detiene en cero: ");

        Console.Write("Numero: ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            if (numero > 0)
            {
                pos++;
            }
            else
            {
                neg++;
            }

            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Conteo de numeros");
        Console.WriteLine("Numeros positivos: " + pos);
        Console.WriteLine("Numeros negativos: " + neg);
    }
}
