////Ejercicio 1
//int numero;
//int[] arregloNumeros = new int[5];

//for (int i = 0; i < arregloNumeros.Length; i++)
//{
//    Console.Write("Ingrese un número: ");
//    if (int.TryParse(Console.ReadLine(), out numero))
//    {
//        arregloNumeros[i] = numero;
//    }
//}
//Console.WriteLine($"El arreglo es: ({arregloNumeros[0]}, {arregloNumeros[1]}, {arregloNumeros[2]}, {arregloNumeros[3]}, {arregloNumeros[4]})");

//Ejercicio 2
List<int> numerosEnteros = new List<int>();
int numeroIngresado = 1;
do
{
    Console.Write("Ingrese un número entero:");
    if (int.TryParse(Console.ReadLine(), out numeroIngresado) && numeroIngresado != 0)
    {
        numerosEnteros.Add(numeroIngresado);
    }

} while (numeroIngresado != 0);

var n = numerosEnteros.OrderByDescending(num => num);

foreach(int numeroEntero in n)
{
    if (numeroEntero % 2 == 0)
    {
        Console.WriteLine($"{numeroEntero} ,");
    }
}