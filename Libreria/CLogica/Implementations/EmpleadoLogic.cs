using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class EmpleadoLogic : IEmpleadoLogic
    {
        private IEmpleadoRepository _empleadoRepository;

        public EmpleadoLogic(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public void CrearEmpleado(Empleado empleado)
        {
            _empleadoRepository.Create(empleado);
            _empleadoRepository.Save();
        }
        public void ModificarEmpleado(string documentoEmpleado, Empleado empleado)
        {
            Empleado? empleadoExistente = _empleadoRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoEmpleado).FirstOrDefault();
            if (empleadoExistente == null)
                throw new ArgumentException("Empleado no encontrado");

            empleadoExistente.Cargo = empleado.Cargo;
            empleadoExistente.Sueldo = empleado.Sueldo;
            empleadoExistente.Antiguedad = empleado.Antiguedad;

            _empleadoRepository.Update(empleadoExistente);
            _empleadoRepository.Save();
        }
        public void EliminarEmpleado(string documentoEmpleado)
        {
            Empleado? empleado = _empleadoRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoEmpleado).FirstOrDefault();
            if (empleado == null)
                throw new ArgumentException("Empleado no encontrado");

            _empleadoRepository.Delete(empleado);
            _empleadoRepository.Save();
        }
        public Empleado ObtenerEmpleado(string documentoEmpleado)
        {
            {
                Empleado empleado = _empleadoRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento == documentoEmpleado).FirstOrDefault();
                if (empleado == null)
                    throw new ArgumentException("Empleado no encontrado");

                return empleado;
            }
        }
        public async Task<List<Empleado>> GetAll()
        {
            return await _empleadoRepository.GetAll();
        }

    }
}