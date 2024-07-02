using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Conjetura_de_Collatz
{

    /*
        Consigna: 
            La Conjetura de Collatz o problema 3x+1 se puede resumir de la siguiente manera:

            Tome cualquier número entero positivo n. Si n es par, divide n entre 2 para obtener n/2. Si n es impar, multiplica n por 3 y suma 1 para obtener 3n + 1. Repite el proceso indefinidamente. La conjetura afirma que no importa con qué número comiences, eventualmente siempre llegarás a 1.

            Dado un número n, devuelve el número de pasos necesarios para llegar a 1.

            Ejemplos
            Comenzando con n = 12, los pasos serían los siguientes:

            12
            6
            3
            10
            5
            16
            8
            4
            2
            1

            Resultando en 9 pasos. Entonces, para la entrada n = 12, el valor de retorno sería 9.
    */

    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            int i = 0;
            if (number > 0) 
            {
                while (number != 1) 
                {
                    i++;
                    if (number % 2 == 0)
                    {
                        number /= 2;
                    }
                    else
                    {
                        number = 3 * number + 1;
                    }
                }                
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

            return i;
        }
    }
}
