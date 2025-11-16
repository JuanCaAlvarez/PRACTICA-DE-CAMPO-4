// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Esta función 'void' no retorna ningún valor, solo ejecuta una acción.
    static void Saludar(string nombre, int edad)
    {
        Console.WriteLine($"¡Hola, {nombre}! Veo que tienes {edad} años.");
    }

    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombreUsuario = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edadUsuario = int.Parse(Console.ReadLine());

        // Se llama a la función para que realice la acción de imprimir
        Saludar(nombreUsuario, edadUsuario);
    }
}
