using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora del grupo 4, por favor elija una operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        // Ejecutar la operación seleccionada
        switch (opcion)
        {
            case 1:
                RealizarOperacion(Sumar);
                break;
            case 2:
                RealizarOperacion(Restar);
                break;
            case 3:
                RealizarOperacion(Multiplicar);
                break;
            case 4:
                RealizarOperacion(Dividir);
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }


    // Método para realizar la operación seleccionada
    static void RealizarOperacion(Func<double, double, double> operacion)
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = operacion(num1, num2);
        Console.WriteLine("El resultado es: " + resultado);
    }
    // Métodos para las operaciones
    static double Sumar(double a, double b) => a + b;
    static double Restar(double a, double b) => a - b;
    static double Multiplicar(double a, double b) => a * b;
    static double Dividir(double a, double b) => a / b;

    // Método para manejar la división por cero
    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: División por cero no permitida.");
            return double.NaN; // Retorna Not a Number
        }
        return a / b;
    }

    //Metodo para cuando ingresen un valor no numérico
    static double LeerNumero()
    {
        double numero;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.Write("Entrada no válida. Por favor, ingrese un número: ");
            }
        }
    }

    // metodo para regresar al menú principal
    static void RegresarAlMenu()
    {
        Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
        Console.ReadKey();
        Main(); // Llama al método Main para reiniciar el programa
    }   
    
}