using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_infiltracion_de_Analia
{

    /*
        Consigna: 
            En este ejercicio, implementarás la lógica de búsqueda para un nuevo juego de rol que un amigo está desarrollando.

            El personaje principal del juego es Analia, una chica valiente con un perro mascota feroz y leal. Desafortunadamente, ocurre un desastre, ya que su mejor amiga fue secuestrada mientras buscaba bayas en el bosque.

            Analia intentará encontrar y liberar a su mejor amiga y, opcionalmente, llevará a su perro con ella en esta búsqueda.

            Después de un tiempo siguiendo el rastro de su mejor amiga, encuentra el campamento en el que está prisionera su mejor amiga. Resulta que hay dos secuestradores: un poderoso caballero y un astuto arquero.

            Habiendo encontrado a los secuestradores, Analia considera cuál de las siguientes acciones puede realizar:

            Ataque rápido: se puede realizar un ataque rápido si el caballero está durmiendo, ya que le toma tiempo ponerse la armadura, por lo que será vulnerable.
            Espía: se puede espiar al grupo si al menos uno de ellos está despierto. De lo contrario, espiar es una pérdida de tiempo.
            Señalar al prisionero: se puede señalar al prisionero mediante sonidos de pájaros si el prisionero está despierto y el arquero está durmiendo, ya que los arqueros están entrenados en señales de pájaros para que puedan interceptar el mensaje.
            Prisionero libre: Analia puede intentar colarse en el campo para liberar al prisionero. Esto es algo arriesgado y sólo puede tener éxito de dos maneras:
                Si Analia tiene su perro con ella, puede rescatar al prisionero si el arquero está dormido. El caballero le tiene miedo al perro y el arquero no tendrá tiempo de prepararse antes de que Analia y el prisionero puedan escapar.
                ¡Si Analia no tiene su perro entonces ella y el prisionero deben ser muy astutos! Analia puede liberar al prisionero si el prisionero está despierto y el caballero y el arquero están durmiendo, pero si el prisionero está durmiendo no pueden ser rescatados: el prisionero se sorprendería por la repentina aparición de Analia y despertaría al caballero y al arquero.
            
            Tienes cuatro tareas: implementar la lógica para determinar si las acciones anteriores están disponibles en función del estado de los tres personajes que se encuentran en el bosque y si el perro mascota de Analia está presente o no.

            Tarea 1: Comprueba si se puede realizar un ataque rápido
               Implemente el método ( estático ) QuestLogic.CanFastAttack() que toma un valor booleano que indica si el caballero está despierto. Este método regresa true si se puede realizar un ataque rápido según el estado del caballero. De lo contrario, devuelve false.
                   var knightIsAwake = true;
                   QuestLogic.CanFastAttack(knightIsAwake);
                   // => false

            Tarea 2: Comprueba si el grupo puede ser espiado
               Implementa el método ( estático ) QuestLogic.CanSpy() que toma tres valores booleanos, indicando si el caballero, el arquero y el prisionero, respectivamente, están despiertos. El método devuelve truesi se puede espiar al grupo, según el estado de los tres personajes. De lo contrario, devuelve false.
                   var knightIsAwake = false;
                   var archerIsAwake = true;
                   var prisonerIsAwake = false;
                   QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
                   // => true

            Tarea 3: Compruebe si se puede señalar al prisionero
               Implementa el método ( estático ) QuestLogic.CanSignalPrisoner() que toma dos valores booleanos, indicando si el arquero y el prisionero, respectivamente, están despiertos. El método devuelve true si se puede señalar al prisionero, según el estado de los dos personajes. De lo contrario, devuelve false.
                   var archerIsAwake = false;
                   var prisonerIsAwake = true;
                   QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
                   // => true

            Tarea 4: Compruebe si el prisionero puede ser liberado
               Implemente el método ( estático ) QuestLogic.CanFreePrisoner() que toma cuatro valores booleanos. Los primeros tres parámetros indican si el caballero, el arquero y el prisionero, respectivamente, están despiertos. El último parámetro indica si el perro mascota de Analia está presente. El método regresa truesi el prisionero puede ser liberado según el estado de los tres personajes y la presencia del perro mascota de Analia. De lo contrario, devuelve false.
                   var knightIsAwake = false;
                   var archerIsAwake = true;
                   var prisonerIsAwake = false;
                   var petDogIsPresent = false;
                   QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
                   // => false
    */

    static class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake == false)
            {
                return true;
            }
            return false;
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true) 
            {
                return true;
            }
            return false;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (archerIsAwake == false && prisonerIsAwake ==  true)
            {
                return true;
            }
            return false;
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent == true && archerIsAwake == false)
            {
                return true;
            }
            if (petDogIsPresent == false && archerIsAwake == false && knightIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            return false;
        }
    }
}
