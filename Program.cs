using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1:
                Sumar();
                break;
            case 2:
                Console.WriteLine("Función de resta pendiente.");
                break;
            case 3:
                Console.WriteLine("Función de multiplicación pendiente.");
                break;
            case 4:
                Console.WriteLine("Función de división pendiente.");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void Sumar()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        double resultado = num1 + num2;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
    }
}
