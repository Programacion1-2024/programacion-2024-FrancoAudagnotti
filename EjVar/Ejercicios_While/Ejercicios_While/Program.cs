
//Ejercicio 1 y 2

/*float numero = 1;
float suma = 0;
int contador = -1;
float promedio = 0;


Console.WriteLine("Ingrese los valores: ");
do  
{
    if(float.TryParse(Console.ReadLine().Replace(".",","), out numero) & numero >= 0)
    {
        contador += 1;
        suma += numero;
        promedio = suma / contador;
    }
    else
    {
        Console.WriteLine("Error, deve ingresar un número positivo. Vuelva a ingresar los valores: ");
    }

} while (numero != 0);

Console.WriteLine($"La suma de los valores es: {suma}.");
Console.WriteLine($"Su promedio es {promedio}");*/


//Ejercicio 3

/*string nombres = "a";
int contador = -1;

Console.WriteLine("Ingrese los nombres de las personas de la lista:");

while (!string.IsNullOrEmpty(nombres))
{
    nombres = Console.ReadLine();
    contador += 1;
} 

Console.WriteLine($"Hay {contador} personas.");*/


//Ejercicio 4

/*float costo = 1;
float totalFactura = 0;

Console.WriteLine("A continuación ingresa los datos, se mostrarán los resultados al ingresar como costo y cantidad 0. ");
while (costo != 0)
{
    Console.Write("Costo por unidad: ");
    if(float.TryParse(Console.ReadLine(), out costo))
    {
        Console.Write("Cantidad: ");
        if (float.TryParse(Console.ReadLine(), out float cantidad))
        {
            float totalUnidad = cantidad * costo;
            totalFactura += totalUnidad;
        }
        else
        {
            Console.WriteLine("Error, debe igresar un valor numérico. Vuelva a ingresar el costo.");
        }
    }
    else
    {
        Console.WriteLine("Error, debe igresar un valor numérico.");
    }
}
Console.WriteLine($"El total de la factura es: {totalFactura}");*/


//Ejercicio 5
/*int i = 0;
float totalProductos = 0;

Console.Write("Ingrese el total de productos que compró: ");
if (float.TryParse(Console.ReadLine(), out float cantProductos))
{
    while (i < cantProductos)
    {
        Console.Write("Ingrese el precio del producto: ");
        if (float.TryParse(Console.ReadLine(), out float precioProducto))
        {
            totalProductos += precioProducto;
            i += 1;
        }
        else
        {
            Console.WriteLine("Error, debe igresar un valor numérico.");
        }
    }
    Console.WriteLine($"El total de su compra es: {totalProductos}");
}
else
{
    Console.WriteLine("Error, debe igresar un valor numérico.");
}*/


