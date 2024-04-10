Console.Write("Ingrese un número: ");
int numero;
if(int.TryParse(Console.ReadLine(), out numero))
{
    if(numero != 0)
    {
       if(numero > 0)
        {
            Console.WriteLine("Es positivo");
        }
        else
        {
            Console.WriteLine("Es negativo");
        }
    }
    else
    {
        Console.WriteLine("No es positivo ni negativo");
    }
}
else
{
Console.WriteLine("Error, debe ingresar un número");
}

