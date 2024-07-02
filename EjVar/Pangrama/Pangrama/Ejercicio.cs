namespace Pangrama
{
    /*
        Consigna: 
            Trabajas para una empresa que vende fuentes a través de su sitio web. Les gustaría mostrar una oración diferente cada vez que alguien vea una fuente en su sitio web. Para dar una idea completa de la fuente, las oraciones aleatorias deben usar todas las letras del alfabeto inglés.

            Están organizando un concurso para recibir sugerencias de frases que puedan utilizar. Usted está a cargo de verificar los envíos para ver si son válidos.

            Tu tarea es descubrir si una oración es un pangrama.

            Un pangrama es una oración que utiliza cada letra del alfabeto al menos una vez. No distingue entre mayúsculas y minúsculas, por lo que no importa si una letra está en minúscula (por ejemplo k) o en mayúscula (por ejemplo K).

            Para este ejercicio, una oración es un pangrama si contiene cada una de las 26 letras del alfabeto inglés.

            TIPS: Funciones ToCharArray y Contains de la clase String
   */

                                public static class Pangram
                                {
                                    public static bool IsPangram(string input)
                                    {
                                        List<char> alphabetList = new List<char>();
                                        string alphabet = "abcdefghijklmnopqrstuvwxyz";
                                        foreach(char a in alphabet) 
                                        {
                                            alphabetList.Add(a);
                                        }

                                        List<char> inputList = new List<char>();

                                        foreach (char b in input)
                                        {
                                            if (char.IsLetterOrDigit(b))
                                            {
                                                inputList.Add(b);
                                            }
                                        }

                                        foreach (char c in inputList) 
                                        {
                                            if (alphabetList.Contains(c))
                                            {
                                                alphabetList.Remove(c);
                                            }
                                        }
                                        if (alphabetList.Count == 0)
                                        {
                                            return true;
                                        }

                                        return false;
            ////Primera resolucion, es ineficiente y uno sigue dando mal.
            //List<char> letters = new List<char>();

            //string alphabet = "abcdefghijklmnopqrstuvwxyz";
            //char[] alphabetArray = alphabet.ToCharArray();
            
            //input = input.ToLower();
            //char[] inputArray = input.ToCharArray();

            //for (int i = 0; i < inputArray.Length; i++) 
            //{
            //    for (int j = 0; j < alphabetArray.Length; j++)
            //    {
            //        if (inputArray.Contains(alphabetArray[j]))
            //        {
            //            letters.Add(inputArray[i]);
            //        }

            //    }
            //    if (letters.Count == 26)
            //    {
            //        return true;
            //    }
            //}

            //return false;
        }
    }
}
