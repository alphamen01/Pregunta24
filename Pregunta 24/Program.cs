// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //INGRESAMOS EL NUMERO
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine()!);

        //INGRESAMOS LA CANTIDAD DE VECES EN QUE SE VA SUMAR EL NRO
        Console.Write("Ingresa la cantidad de veces a sumar: ");
        int n = int.Parse(Console.ReadLine()!);

        int resultado = SumarNCantidades(numero, n);

        Console.WriteLine("La suma de " + n + " veces el número " + numero + " es: " + resultado);
        //Console.WriteLine($"La suma de {n} veces el número {numero} es: {resultado}");
    }
        public static int SumarNCantidades(int numero, int n)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                //suma += numero; abreviado
                suma = suma + numero;
            }
            return suma;
        }

}