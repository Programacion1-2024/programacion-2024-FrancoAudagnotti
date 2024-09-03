using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dos_Por
{
    /*
        Consigna: 
            En algunos acentos ingleses, cuando se dice "two fer" (está en inglés) rápidamente, suena como "two for" (dos por). "Two-for-one" es una forma de decir que si compras uno, también te llevas otro gratis. Por eso, la frase "two-fer" a menudo implica una oferta de dos por uno.

            Imagina una panadería que tiene una oferta navideña en la que puedes comprar dos galletas por el precio de una ("¡two-fer one!"). Aceptas la oferta y (muy generosamente) decides darle la galleta extra a otra persona en la cola.

            Tu tarea es determinar qué dirás cuando regales la galleta extra.

            Si sabes el nombre de la persona (por ejemplo, si se llama Do-yun), dirás:
            Una para Do-yun, una para mi.

            Si no sabes el nombre de la persona, lo dirás vos:
            Una para vos, una para mi.

            TIPS: Valores por defecto en parametros de funciones
    */

    public static class TwoFer
    {
        // Para que los tests funcionen, primero necesitas asegurarte que el método Speak puede ser llamado sin ningun argumento o con un string como argumento
        public static string Speak()
        {
            return "Una para vos, una para mi.";
        }
    }
}
