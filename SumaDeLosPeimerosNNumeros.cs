using System;
using System.Linq;

namespace Ejercicio_11;

public static class Program
{
    public static void Main()
    {
        int suma = 0;
        int x = 1;
        int n = 0;
        Console.WriteLine(" Ingrsa el Numero");
        n = int.Parse(Console.ReadLine());
        do
        {
            suma = suma + x;
            x++;
        } while (x <= n);

        Console.WriteLine("La suma de 1 a n " + n + " es = " + suma);
    }
}
