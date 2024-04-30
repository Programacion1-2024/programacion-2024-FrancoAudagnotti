////Ejercicio 1

//float precio;
//int cantidad;
//int codigo;
//int cantidadMax = 0;
//int codigoMax = 0;

//do
//{
//    Console.Write("Ingrese el código del producto: ");
//    if (int.TryParse(Console.ReadLine(), out codigo) && codigo != 0)
//    {
//        Console.Write($"Ingrese el precio del producto {codigo}: ");
//        if (float.TryParse(Console.ReadLine(),out precio))
//        {
//            Console.Write($"Ingrese la cantidad del producto {codigo}: ");
//            if (int.TryParse(Console.ReadLine(), out cantidad))
//            {
//                if(cantidad > cantidadMax)
//                {
//                    cantidadMax = cantidad;
//                    codigoMax = codigo;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Error, ingrese un codigo válido.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Error, ingrese un codigo válido.");
//        }
//    }
//    else if (codigo != 0)
//    {
//        Console.WriteLine("Error, ingrese un codigo válido.");
//    }
//} while (codigo != 0);
//Console.WriteLine($"El codigo que tiene más cantidad es el {codigoMax}");

////Ejercicio 2

//float precio;
//int cantidadEnStock;
//int cantidadDeVentas;
//int codigo;
//int cantidadNueva;
//int codigoMax = 0;

//do
//{
//    Console.Write("Ingrese el código del producto: ");
//    if (int.TryParse(Console.ReadLine(), out codigo) && codigo != 0)
//    {
//        Console.Write($"Ingrese el precio del producto {codigo}: ");
//        if (float.TryParse(Console.ReadLine(), out precio))
//        {
//            Console.Write($"Ingrese la cantidad en stock del producto {codigo}: ");
//            if (int.TryParse(Console.ReadLine(), out cantidadEnStock))
//            {
//                Console.Write($"Ingrese la cantidad vendida: ");
//                if (int.TryParse(Console.ReadLine(), out cantidadDeVentas))
//                {
//                    cantidadNueva = cantidadEnStock - cantidadDeVentas;
//                    if (cantidadNueva <= 0)
//                    {
//                        Console.WriteLine($"No quedan más productos con el código {codigo} en stock.");
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Error, ingrese un codigo válido.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Error, ingrese un codigo válido.");
//        }
//    }
//    else if (codigo != 0)
//    {
//        Console.WriteLine("Error, ingrese un codigo válido.");
//    }
//} while (codigo != 0);
//Console.WriteLine($"El codigo que tiene más cantidad es el {codigoMax}");


