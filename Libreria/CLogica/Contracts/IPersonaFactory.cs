using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLogica.Contracts
{
    public interface IPersonaFactory
    {
        Persona CrearPersona(Persona persona);
        Autor CrearAutor(Autor autor);
        Cliente CrearCliente(Cliente cliente);
        Empleado CrearEmpleado(Empleado empleado);
    }
}
