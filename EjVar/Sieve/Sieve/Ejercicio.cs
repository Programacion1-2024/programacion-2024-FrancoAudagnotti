using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Sieve
{

    /*
    Consigna:
        Compraste una gran caja de piezas de computadora al azar en una venta de garaje y comenzaste a juntar las piezas para construir computadoras personalizadas.

        Quiere probar el rendimiento de diferentes combinaciones de piezas y decide crear su propio programa de evaluación comparativa para comparar sus ordenadores. Elige el famoso algoritmo "Criba de Eratóstenes", un algoritmo antiguo, pero que debería llevar sus ordenadores al límite.

        Instrucciones
        Su tarea es crear un programa que implemente el algoritmo de la Criba de Eratóstenes para encontrar todos los números primos menores o iguales a un número dado.

        Un número primo es un número mayor que 1 que solo es divisible por 1 y por sí mismo. Por ejemplo, 2, 3, 5, 7, 11 y 13 son números primos. Por el contrario, 6 no es un número primo, ya que no solo es divisible por 1 y por sí mismo, sino también por 2 y 3.

        Para utilizar la criba de Eratóstenes, primero se crea una lista de todos los números entre 2 y el número indicado. Luego se repiten los siguientes pasos:

        Busque el siguiente número sin marcar en su lista (salteando los números marcados). Este es un número primo.
        Marca todos los múltiplos de ese número primo como no primos.
        Repite estos pasos hasta que hayas recorrido todos los números de la lista. Al final, todos los números sin marcar son primos.

        Ejemplo
            Digamos que estás encontrando los números primos menores o iguales a 10.

            Enumere 2, 3, 4, 5, 6, 7, 8, 9, 10, dejándolos todos sin marcar.
            El 2 no está marcado y, por lo tanto, es primo. Marca el 4, el 6, el 8 y el 10 como "no primos".
            El 3 no está marcado y, por lo tanto, es primo. Marca el 6 y el 9 como no primos (marcar el 6 es opcional, ya que ya está marcado) .
            El 4 está marcado como "no primo", por lo que lo omitimos.
            El 5 no está marcado y, por lo tanto, es primo. Marca el 10 como no primo (opcional, ya que ya está marcado) .
            El 6 está marcado como "no primo", por lo que lo omitimos.
            El 7 no está marcado y por lo tanto es primo.
            El 8 está marcado como "no primo", por lo que lo omitimos.
            El 9 está marcado como "no primo", por lo que lo omitimos.
            El 10 está marcado como "no primo", por lo que nos detenemos ya que no hay más números para verificar.

            Has examinado todos los números y has descubierto que 2, 3, 5 y 7 todavía no están marcados, lo que significa que son primos menores o iguales a 10.
    */

    public static class Sieve
    {
        public static int[] Primes(int limit)
        {
            int[] numberArray = Enumerable.Range(1, limit).ToArray();
            List<int> primeNumberList = new List<int>();
            

            if (numberArray.Length >= 2)
            {
                primeNumberList.Add(2);
            }

            for (int i = 2; i < numberArray.Length; i += 2)
            {
                foreach (int num in primeNumberList)
                {
                    if (numberArray[i] % num != 0)
                    {
                        primeNumberList.Add(numberArray[i]);
                    }
                }
            }
            return primeNumberList.ToArray();
        }
    }
}
