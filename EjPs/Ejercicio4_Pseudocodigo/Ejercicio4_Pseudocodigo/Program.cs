float numero1, numero2, numero3;

Console.Write("Ingrese un número: ");
if(float.TryParse(Console.ReadLine(),out numero1))
{
    Console.Write("Ingrese otro número: ");
    if (float.TryParse(Console.ReadLine(), out numero2))
    {
        Console.Write("Ingrese  nuevamente otro número: ");
        if (float.TryParse(Console.ReadLine(),out numero3))
        {
            float sumaTotal = numero1 + numero2 + numero3;
            float promedioNumeros = sumaTotal / 3;
            Console.WriteLine("El proomedio es: " + promedioNumeros);
        }
        else
        {
            Console.WriteLine("Error, debe ingresar un número");
        }
    }
    else
    {
        Console.WriteLine("Error, debe ingresar un número");
    }
}
else
{
    Console.WriteLine("Error, debe ingresar un número");
}
