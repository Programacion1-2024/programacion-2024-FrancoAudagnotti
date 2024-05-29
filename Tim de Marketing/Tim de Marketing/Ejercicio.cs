using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_de_Marketing
{

    /*
        Consigna: 
            En este ejercicio, escribirá código para imprimir credenciales con los nombres de los empleados de la fábrica.

            Tarea 1: Imprimir una credencial para un empleado
               Los empleados tienen un ID, nombre y nombre de departamento. Las etiquetas de las credenciales de empleado tienen el siguiente formato: "[id] - name - DEPARTMENT". Implemente el método ( estático ) Badge.Print() para devolver la etiqueta de identificación de un empleado.
                   Badge.Print(734, "Ernest Johnny Payne", "Strategic Communication");
                   // => "[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION"

            Tarea 2: Imprimir una credencial para un nuevo empleado
               Debido a una peculiaridad en el sistema informático, en ocasiones los nuevos empleados aún no tienen una identificación cuando comienzan a trabajar en la fábrica. Como se requieren credenciales, recibirán una insignia temporal sin el prefijo de identificación. Modifique el método ( estático ) Badge.Print() para admitir nuevos empleados que aún no tienen una identificación.
                   Badge.Print(id: null, "Jane Johnson", "Procurement");
                   // => "Jane Johnson - PROCUREMENT"

            Tarea 3: Imprimir una credencial para el propietario
               Incluso el propietario de la fábrica tiene que llevar una placa en todo momento. Sin embargo, un propietario no tiene departamento. En este caso, la etiqueta debería imprimirse "OWNER" en lugar del nombre del departamento. Modifique el método ( estático ) Badge.Print() para imprimir una etiqueta para el propietario.
                   Badge.Print(254, "Charlotte Hale", department: null);
                   // => "[254] - Charlotte Hale - OWNER"

               Tenga en cuenta que es posible que el propietario también sea un nuevo empleado
                   Badge.Print(id: null, "Charlotte Hale", department: null);
                   // => "Charlotte Hale - OWNER"
    */

    static class Badge
    {
        public static string Print(int? id, string name, string? department)
        {
            if (id == null)
            {
                if (department == null)
                {
                    return ($"{name} - OWNER");
                }
                else
                {
                    return ($"{name} - {department.ToUpper()}");
                }
            }
            else if (department == null)
            {
                return ($"[{id}] - {name} - OWNER");
            }
            return ($"[{id}] - {name} - {department.ToUpper()}");
        }
    }
}
