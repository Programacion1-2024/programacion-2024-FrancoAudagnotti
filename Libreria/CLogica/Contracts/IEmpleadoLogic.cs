using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IEmpleadoLogic
    {
        void CrearEmpleado(Empleado empleado);
        void ModificarEmpleado(string DocumentoEmpleado, Empleado empleado);
        Empleado ObtenerEmpleado(string DocumentoEmpleado);
        void EliminarEmpleado(string DocumentoEmpleado);
        Task<List<Empleado>> GetAll();
    }
}