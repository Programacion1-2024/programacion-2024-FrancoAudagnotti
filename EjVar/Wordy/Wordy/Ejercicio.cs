using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Xunit.Sdk;

namespace Wordy
{
    /*
    Consigna:
        Instrucciones
        Analizar y evaluar problemas matemáticos simples y devolver la respuesta como un número entero.

        Iteración 0 — Números
            Los problemas sin operaciones simplemente se evalúan al número dado.

                What is 5?
                    Se evalúa como 5.

        Iteración 1 — Adición
            Sumar dos números juntos.

                What is 5 plus 13?
                    Se evalúa como 18.

            Manejar números grandes y números negativos.

        Iteración 2: Resta, multiplicación y división
            Ahora, realiza las otras tres operaciones.

                What is 7 minus 5?
                    2

                What is 6 multiplied by 4?
                    24

                What is 25 divided by 5?
                    5

        Iteración 3: Operaciones múltiples
            Manejar un conjunto de operaciones, en secuencia.

            Dado que se trata de problemas verbales, evalúe la expresión de izquierda a derecha, ignorando el orden típico de operaciones.

                What is 5 plus 13 plus 6?
                    24

                What is 3 plus 2 multiplied by 3?
                    15 (es decir, no 9)

        Iteración 4: Errores
            El analizador debe rechazar:

            Operaciones no admitidas ("What is 52 cubed?")

            Preguntas no matemáticas ("Who is the President of the United States?")

            Problemas de palabras con sintaxis no válida ("What is 1 plus plus 2?")
    */

    public static class Wordy
    {
        public static int Answer(string question)
        {
            int result = 0;
            string[] words = question.Replace("?","").Split(' ');

            if (!IsNumber(words.Last()))
            {
                throw new ArgumentException();
            }
            if (!(words[0] == "What" && words[1] == "is"))
            {
                throw new ArgumentException();
            }
            words = words.Skip(2).ToArray();
            if (words.Length == 1)
            {
                if (words[0].ToCharArray().Where(c => !Char.IsNumber(c)).Count() > 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    result = Int32.Parse(words[0]);
                }
            }
            else
            {
                int? previousNumber = null;
                string operation = "";
                foreach (string word in words) 
                {
                    if (IsNumber(word)) 
                    {
                        if(previousNumber.HasValue)
                        {
                            previousNumber = DoOperation(previousNumber.Value, Int32.Parse(word), operation);
                        }
                        else
                        {
                            previousNumber = Int32.Parse(word);
                        }
                        operation = "";
                    }
                    else
                    {
                        operation += word;
                    }
                }
                result = previousNumber.Value;
            }
            return result;

        }            
        private static bool IsNumber(string word)
        {
            return word.ToCharArray().Where(c => !Char.IsNumber(c) && c != '-').Count() == 0;
        }

        private static int DoOperation(int previousNumber, int currentNumber, string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "dividedby":
                    {
                        result = previousNumber / currentNumber; 
                        break;
                    }
                case "multipliedby":
                    {
                        result = previousNumber * currentNumber;
                        break;
                    }
                case "minus":
                    {
                        result = previousNumber - currentNumber;
                        break;
                    }
                case "plus":
                    {
                        result = previousNumber + currentNumber;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException();
                    }
            }
            return result;
        }
    }
}
