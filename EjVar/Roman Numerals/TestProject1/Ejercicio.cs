using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    /*
    Consigna: 
        En la actualidad, la mayoría de las personas del mundo utilizan números arábigos (0 a 9), pero si retrocedemos dos mil años, descubriremos que la mayoría de los europeos utilizaban números romanos.

        Para escribir un número romano utilizamos las siguientes letras latinas, cada una de las cuales tiene un valor:

         M	     D	 C	L	X	V	I
        1000	500	100	50	10	5	1

        Un número romano es una secuencia de estas letras y su valor es la suma de los valores de las letras. Por ejemplo, XVIIItiene el valor 18 ( 10 + 5 + 1 + 1 + 1 = 18).

        Sin embargo, hay una regla que complica las cosas y es que la misma letra no se puede usar más de tres veces seguidas.
        Eso significa que no podemos expresar números como 4 con el aparentemente natural IIII. En cambio, para esos números, usamos un método de resta entre dos letras.
        Por lo tanto, no pensamos en 4como 1 + 1 + 1 + 1sino como 5 - 1. Y, de manera ligeramente confusa para nuestro pensamiento moderno, escribimos primero el número más pequeño.
        Esto se aplica solo en los siguientes casos: 4 ( IV), 9 ( IX), 40 ( XL), 90 ( XC), 400 ( CD) y 900 ( CM).

        El orden es importante en los números romanos. Las letras (y los compuestos especiales mencionados anteriormente) deben ordenarse de izquierda a derecha por orden decreciente de valor.

        A continuación se muestran algunos ejemplos:

         105 => CV
        ---- => --
         100 => C
        +  5 =>  V


         106 => CVI
        ---- => --
         100 => C
        +  5 =>  V
        +  1 =>   I


         104 => CIV
        ---- => ---
         100 => C
        +  4 =>  IV


        Y un último ejemplo más complejo:

         1996 => MCMXCVI
        ----- => -------
         1000 => M
        + 900 =>  CM
        +  90 =>    XC
        +   5 =>      V
        +   1 =>       I

        Instrucciones
        Su tarea es convertir un número de números arábigos a números romanos.

        Para este ejercicio, solo nos interesarán los números romanos tradicionales, en los que el número más grande es MMMCMXCIX (o 3.999).
 */

    public static class Ejercicio
    {
        public static string ToRoman(this int value)
        {
            string result = "";

            Dictionary<int, string> arabicToRoman = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };
            while (value > 0)
            {
                foreach (var item in arabicToRoman)
                {
                    if (value >= item.Key)
                    {
                        result += item.Value;
                        value -= item.Key;
                    }
                    if (item.Key <= value)
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
