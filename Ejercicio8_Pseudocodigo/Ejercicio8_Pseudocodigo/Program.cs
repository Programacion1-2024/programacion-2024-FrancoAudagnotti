int numero1, numero2, numero3;

Console.Write("Ingrese un número: ");
if(int.TryParse(Console.ReadLine(), out numero1))
{
    Console.Write("Ingrese otro número: ");
    if (int.TryParse(Console.ReadLine(), out numero2))
    {
        Console.Write("Ingrese nuevamente otro número: ");
        if (int.TryParse(Console.ReadLine(), out numero3))
        {
            Console.WriteLine("El perímetro del triángulo es: " + (numero1 + numero2 + numero3));
        }
        else
        {
            Console.WriteLine("Error, debe ingresar un número.");
        }
    }
    else
    {
        Console.WriteLine("Error, debe ingresar un número.");
    }
}
else
{
    Console.WriteLine("Error, debe ingresar un número.");
}