// Construir un programa que pida un número y luego diga si este número es par o no.
using System;
using System.ComponentModel.Design;

public class TallerPunto4
{
    static void Main(string[] args)
    {
        // Datos de entrada: num1

        int num;

        // Pedir Numero

        Console.Write("Ingrese un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        // Realizar proceso

        if (num % 2 == 0)
        {
            Console.Write($"El número {num} es PAR:");
        }
        else
        {
            Console.Write($"El número {num} es IMPAR:");
        }
    }
}

