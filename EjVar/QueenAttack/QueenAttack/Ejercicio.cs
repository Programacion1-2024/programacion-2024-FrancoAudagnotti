using System;

namespace QueenAttack
{

    /*
    Consigna:
        Dada la posición de dos reinas en un tablero de ajedrez, indique si están o no posicionadas de manera que puedan atacarse entre sí.

        En el juego de ajedrez, una reina puede atacar piezas que estén en la misma fila, columna o diagonal.

        Un tablero de ajedrez se puede representar mediante una matriz de 8x8.

        Entonces, si te dicen que la reina blanca está en c5(indexado cero en la columna 2, fila 3) y la reina negra en f2(indexado cero en la columna 5, fila 6), entonces sabes que la configuración es así:

        Tablero de ajedrez con dos reinas. Las flechas que parten de la reina en c5 indican posibles direcciones de captura a lo largo de la columna, la fila y la diagonal.

        También puedes responder si las reinas pueden atacarse entre sí. En este caso, la respuesta sería sí, pueden, porque ambas piezas comparten una diagonal.

        Crédito
        La imagen del tablero de ajedrez fue realizada por habere-et-dispertire usando LaTeX y el paquete chessboard de Ulrike Fischer.
    */

    public class Queen
    {
        public Queen(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; }
        public int Column { get; }
    }

    public static class QueenAttack
    {
        public static bool CanAttack(Queen white, Queen black)
        {
            if (white.Row == black.Row)
            {
                return true;
            }
            else if (white.Column == black.Column)
            {
                return true;
            }
            else if (Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Queen Create(int row, int column)
        {
            if(row >= 0 && row <= 7 && column >= 0 && column <= 7)
            {
                return new Queen(row, column);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
