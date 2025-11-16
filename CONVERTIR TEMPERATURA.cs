// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Función que recibe Celsius y retorna Fahrenheit
    static double ConvertirAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main()
    {
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double c = double.Parse(Console.ReadLine());

        double fahrenheit = ConvertirAFahrenheit(c);

        Console.WriteLine($"{c}°C equivale a {fahrenheit}°F");
    }
}