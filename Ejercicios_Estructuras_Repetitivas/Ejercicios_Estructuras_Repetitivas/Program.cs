using System;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 1
        /*
        Console.WriteLine("Ingrese 5 valores enteros:");

        int suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Valor {i}: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                suma += numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                i--;
            }
        }
        Console.WriteLine($"La suma de los 5 numeros es: {suma}"); */
        
        //Ejercicio 2
        /*Console.WriteLine("Ingrese 8 números enteros: ");

        int suma = 0;
        for (int i = 1; i <= 8; i++)
        {
            Console.Write($"Número {i}: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                suma += numero;
            }
            else
            {
                Console.WriteLine("Error, debe ingresar un número entero.");
                i--;
            }
        }
        double promedio = (double)suma / 8;
        Console.WriteLine($"El es promedio: {promedio}");*/

        //Ejercicio 3
        /*Console.WriteLine("A continucación ingrese costos unitarios y cantidad caomprada");

        int total = 0;
        for (int i = 1; i <= 5; i++) 
        {
            Console.Write($"Costo producto {i}: ");
            if (int.TryParse(Console.ReadLine(), out int costo))
            {
                Console.Write($"Cantidad producto {i}: ");
                if (int.TryParse(Console.ReadLine(), out int cantidad))
                {
                    int multiplicacion = costo * cantidad;
                    total += multiplicacion;
                }
                else
                {
                    Console.WriteLine("Error, debe ingresar un número entero.");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Error, debe ingresar un número entero.");
                i--;
            }
        }
        Console.WriteLine($"La cantidad adeudada es: {total}");*/

        //Ejercicio 4

        /*Console.WriteLine("A continuación ingrese 8 números enteros.");
        Console.Write("Numero 1: ");
        if (int.TryParse(Console.ReadLine(), out int mayor))
        {
            for (int i = 2; i <= 8; i++)
            {
                Console.Write($"Numero {i}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Error, debe ingresar un número entero.");
                    i--;
                }
            }
            Console.WriteLine($"El número más grande es: {mayor}");
        }
        else 
        {
            Console.WriteLine("Error, debe ingresar un número entero.");
        }*/

        // Ejercicio 5

        Console.WriteLine("A continuación ingrese lo solicitado: ");
        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Nombre de Cliente: ");
        }
        
    }
}
