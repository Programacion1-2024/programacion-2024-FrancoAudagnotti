int numero1, numero2;

Console.Write("Ingrese un número: ");
if(int.TryParse(Console.ReadLine(), out numero1))
{
    Console.Write("Ingrese otro número: ");
    if (int.TryParse(Console.ReadLine(), out numero2))
    {
        if (numero1 != numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + " es mayor.");
            }
            else
            {
                Console.WriteLine(numero2 + " es mayor.");
            }
        }
        else
        {
            Console.WriteLine("Son iguales.");
        }
    }
    else
    {
        Console.WriteLine("Error, no ingresó un número.");
    }
}
else
{
    Console.WriteLine("Error, no ingresó un número.");
}

