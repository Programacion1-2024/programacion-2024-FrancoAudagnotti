int numero1, numero2;

Console.WriteLine("Ingrese un número: ");
if (int.TryParse(Console.ReadLine(),out numero1))
{
    Console.WriteLine("Ingrese otro número: ");
    if(int.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("El número es: " + (numero1 + numero2));
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



