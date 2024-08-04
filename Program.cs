using System;

class Programa
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Ingrese 10 números desordenados:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("Números ordenados:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}