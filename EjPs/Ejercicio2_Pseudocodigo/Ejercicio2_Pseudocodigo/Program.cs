int num1;

Console.WriteLine("Ingrese un número: ");
if(int.TryParse(Console.ReadLine(),out num1))
{
    if (num1 % 2 == 0)
    {
        Console.WriteLine("Es par");
    }
    else {
        Console.WriteLine("es impar");
    }
}
else
{
    Console.WriteLine("Error, debe ingresar un número");
}

   