using CDatos.Contexts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Metodos
{
    public class CRUDPersona
    {
        LibreriaContext context = new LibreriaContext();
        public void AltaPersona(Persona persona)
        {
            var DNIbuscado = context.Persona.Find(persona.DNI);
            if (DNIbuscado == null)
            {
                Persona personaNueva = new Persona();
                if (persona.Autor != null)
                {
                    personaNueva.Autor = persona.Autor;
                }
                else if (persona.Cliente != null)
                {
                    personaNueva.Cliente = persona.Cliente;
                }
                else if (persona.Empleado != null)
                {
                    personaNueva.Empleado = persona.Empleado;
                }
            }

            else
            {
                throw new Exception("");
            }

        }        
    }
}
