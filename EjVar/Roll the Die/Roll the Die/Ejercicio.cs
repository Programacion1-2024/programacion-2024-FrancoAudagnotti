using System;

namespace Roll_the_Die
{

    /*
        Consigna: 
            Continuando con el tema del juego de magos y guerreros, es hora de agregar un método de lanzamiento de dados multiuso. Este será el dado tradicional de 18 caras con números del 1 al 18. Los jugadores también generan una fuerza de hechizo.

            Tarea 1: Permite que un jugador de magos y guerreros lance un dado.
               Implementar un método RollDie() en la clase Player.
                   var player = new Player();
                   player.RollDie();
                   // => >= 1 <= 18

            Tarea 2: Los jugadores necesitan su fuerza. Proporcionar un medio para generar fuerza de hechizo
               Implementar un método GenerateSpellStrength() en la clase de jugador. La fuerza del hechizo está entre 0,0 y hasta 100,0, pero sin incluirlo.

               Tenga en cuenta que la fuerza del hechizo debe ser un número real (no un número entero) para reducir la posibilidad de un empate cuando se comparan las fortalezas de dos adversarios.
                   var player = new Player();
                   player.GenerateSpellStrength();
                   // => >= 0.0 < 100.0
    */


    public class Player
    {
        public int RollDie()
        {
            Random random = new Random();
            return random.Next(1,19);

        }
        public double GenerateSpellStrength()
        {
            Random random = new Random();
            return random.NextDouble()*100;
        }
    }
}
