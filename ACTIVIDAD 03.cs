// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Función que usa lógica condicional para retornar un string
    static string VerificarMayoriaEdad(int edad)
    {
        if (edad >= 18)
        {
            return "Mayor de edad";
        }
        else
        {
            return "Menor de edad";
        }
    }

    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        string resultado = VerificarMayoriaEdad(edad);

        Console.WriteLine($"La persona es: {resultado}");
    }
}
