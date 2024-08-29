using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IPersonaLogic
    {
        void ModificarPersona(string documento, Persona persona);
        void EliminarPersona(string documento);
        Persona ObtenerPersona(string documento);
        Task<List<Persona>> ObtenerTodos();
    }
}
