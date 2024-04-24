////Ejercicio 1

//int contraseña = 0;

//do
//{
//    Console.Write("Nombre de usuario: ");
//    Console.ReadLine();

//    Console.Write("Contraseña: ");
//    if (int.TryParse(Console.ReadLine(), out contraseña) && contraseña == 667788)
//    {
//        Console.WriteLine("Sesión iniciada");
//    }
//    else
//    {
//        Console.WriteLine("Contraseña incorrecta.");
//    }

//} while (contraseña != 667788);

////Ejercicio 2

//float numero = -1;

//Console.WriteLine("Ingrese un número:");
//do
//{
//    if(!float.TryParse(Console.ReadLine(), out numero))
//    {
//        Console.WriteLine("Error, vuelva a ingresar un número: ");
//        numero = -1;
//    }
//} while (numero < 0);


////Ejercicio 3

//int i = 0;
//float numero = -1;
//float total = 0;
//float promedio = 0;

//Console.WriteLine("Ingrese un número, la lista finalizará cuando el numero ingresado sea positivo:");
//do
//{
//    if (!float.TryParse(Console.ReadLine().Replace(".", ","), out numero))
//    {
//        Console.WriteLine("Error, vuelva a ingresar un número: ");
//        numero = -1;
//    }
//    else if (numero < 0)
//    {
//        i += 1;
//        total += numero;
//        promedio = total / i;
//    }
//} while (numero < 0);

//if (total < 0)
//{
//    Console.WriteLine($"El promedio de los negativos es: {promedio}");
//}


////Ejercicio 4

//float numero;
//float total = 0;

//Console.WriteLine("Ingrese numeros, la lista finaliza al ingresar un número de tres cifras:");
//do
//{
//    if (float.TryParse(Console.ReadLine().Replace(".", ","), out numero))
//    {
//        Console.WriteLine("Error, vuelva a ingresar un número");
//    }
//    else if (numero < 100)
//    {
//        total += numero;
//    }
//} while (numero < 100);
//if (total != 0)
//{
//    Console.WriteLine($"el promedio es: {total}");
//}


////Ejercicio 5

//float numero;
//float total = 0;
//float promedio = 0;
//float i = 0;

//Console.WriteLine("Ingrese numeros, la lista finaliza al ingresar un número de tres cifras:");
//do
//{
//    if (!float.TryParse(Console.ReadLine().Replace(".", ","), out numero))
//    {
//        Console.WriteLine("error, vuelva a ingresar un número");

//    }
//    else if (numero < 100)
//    {
//        i += 1;
//        total += numero;
//        promedio = total / i;
//    }
//} while (numero < 100);

//if (promedio != 0)
//{
//    Console.WriteLine($"el promedio es: {promedio}");
//}

