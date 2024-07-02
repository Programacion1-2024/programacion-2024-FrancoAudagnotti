namespace Hamming
{
    /*
        Consigna: 
            Calcule la distancia de Hamming entre dos cadenas de ADN.

            Su cuerpo está formado por células que contienen ADN. Esas células se desgastan periódicamente y necesitan ser reemplazadas, lo que logran dividiéndose en células hijas. De hecho, ¡el cuerpo humano promedio experimenta alrededor de 10 mil billones de divisiones celulares en su vida!

            Cuando las células se dividen, su ADN también se replica. A veces, durante este proceso, se producen errores y piezas individuales de ADN se codifican con información incorrecta. Si comparamos dos cadenas de ADN y contamos las diferencias entre ellas podemos ver cuántos errores se produjeron. Esto se conoce como la "Distancia de Hamming".

            Leemos el ADN usando las letras C, A, G y T. Dos cadenas podrían verse así:

            GAGCCTACTAACGGGAT
            CATCGTAATGACGGCCT
            ^ ^ ^  ^ ^    ^^

            Tienen 7 diferencias y por tanto la Distancia de Hamming es 7.

            La distancia de Hamming es útil para muchas cosas en la ciencia, no solo en biología, por lo que es una buena frase con la que estar familiarizado.

            La distancia de Hamming solo se define para secuencias de igual longitud, por lo que intentar calcularla entre secuencias de diferentes longitudes no debería funcionar.
    */

    public static class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            int hammingDistance = 0;
            if (firstStrand.Length == secondStrand.Length) 
            { 
                for (int i = 0; i < firstStrand.Length; i++)
                {
                    if (firstStrand[i] != secondStrand[i])
                    {
                        hammingDistance++;
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return hammingDistance;
        }
    }
}
