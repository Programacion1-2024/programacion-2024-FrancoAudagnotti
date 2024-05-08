using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Isograma
{
    /*
        Consigna: 
            Determina si una palabra o frase es un isograma.

            Un isograma (también conocido como "palabra sin patrón") es una palabra o frase sin una letra repetida; sin embargo, se permite que aparezcan espacios y guiones varias veces.

            Ejemplos de isogramas:

            lumberjacks
            background
            downstream
            six-year-old

            La palabra isogramas, sin embargo, no es un isograma porque la s se repite.

            TIPS: Funciones ToCharArray, IndexOf y LastIndexOf de la clase String
    */

    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            char[] wordArray = word.ToLower().ToCharArray();
            for (int i = 0; i < wordArray.Length; i++)
            {
                int first = word.ToLower().IndexOf(wordArray[i]);
                int last = word.ToLower().LastIndexOf(wordArray[i]);
                if (wordArray[i] != ' ' && wordArray[i] != '-' && first != last)
                {
                    return false;
                }
            }
            return true;
        }
    }
}