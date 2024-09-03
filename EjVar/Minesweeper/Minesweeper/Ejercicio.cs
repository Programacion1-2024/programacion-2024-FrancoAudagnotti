using System;

namespace Minesweeper
{

    /*
    Consigna:
        Buscaminas es un juego popular en el que el usuario tiene que encontrar las minas utilizando pistas numéricas que indican cuántas minas están directamente adyacentes (horizontal, vertical, diagonal) a un cuadrado.

        Instrucciones
        Tu tarea consiste en sumar la cantidad de minas a los cuadrados vacíos de un tablero de Buscaminas completo. El tablero en sí es un rectángulo compuesto de cuadrados que están vacíos ( ' ' ) o tienen una mina ( '*' ).

        En cada casilla vacía, cuente la cantidad de minas adyacentes (horizontal, vertical y diagonalmente). Si la casilla vacía no tiene minas adyacentes, déjela vacía. De lo contrario, reemplácela con el recuento de minas adyacentes.

        Por ejemplo, puede recibir un tablero de 5 x 4 como éste (los espacios vacíos se representan aquí con el carácter '·' para su visualización en pantalla):

            ·*·*·
            ··*··
            ··*··
            ·····

        Tu código debería transformarse en esto:

            1*3*1
            13*31
            ·2*2·
            ·111·
    */

    public static class Minesweeper
    {
        public static string[] Annotate(string[] input)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }

}
