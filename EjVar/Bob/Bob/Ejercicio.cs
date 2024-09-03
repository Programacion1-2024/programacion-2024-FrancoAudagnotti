namespace Bob
{
    /*
        Consigna: 
            Bob es un adolescente despreocupado . Le gusta pensar que es genial y definitivamente no se entusiasma con nada. Eso no sería genial.

            Cuando la gente habla con él, sus respuestas son bastante limitadas.

            Instrucciones
            Tu tarea es determinar qué le responderá Bob a alguien cuando le digan algo o le hagan una pregunta.

            Bob sólo responde una de cinco cosas:

            "Sure". Esta es su respuesta si le haces una pregunta, como "How are you?". La convención que se utiliza para las preguntas es que terminan con un signo de interrogación.
            "Whoa, chill out!". Esta es su respuesta si LE GRITAS. La convención que se usa para gritar es TODAS LAS LETRAS EN MAYÚSCULAS.
            "Calm down, I know what I'm doing!". Esto es lo que dice si le gritas una pregunta.
            "Fine. Be that way!". Así es como responde al silencio. La convención que se utiliza para el silencio es nada o varias combinaciones de caracteres en blanco.
            "Whatever." Esto es lo que responde a cualquier otra cosa.
     */

    public class Ejercicio
    {
        public static string Response(string statement)
        {
            string respuesta = "Whatever.";

            if (string.IsNullOrWhiteSpace(statement))
            {
                respuesta = "Fine. Be that way!";
            }
            else if (statement.Trim().Last() == '?')
            {
                if (statement.ToUpper() == statement && statement.Any(char.IsLetter))
                {
                    respuesta = "Calm down, I know what I'm doing!";
                }
                else
                {
                    respuesta = "Sure.";
                }
            }
            else if (statement.ToUpper() == statement && statement.Any(char.IsLetter))
            {
                respuesta = "Whoa, chill out!";
            }
            return respuesta;
        }
    }
}
