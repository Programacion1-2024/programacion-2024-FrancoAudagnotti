using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLogica;
using Azure.Identity;
using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using Microsoft.EntityFrameworkCore.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CLogica.Implementations
{
    public class PersonaLogic : IPersonaLogic
    {
        private IPersonaRepository _personaRepository;


        public PersonaLogic(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public void ModificarPersona(string documento, Persona personaActualizada)
        {
            Persona personaExistente = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            if (personaExistente == null)
                throw new ArgumentException("Persona no encontrada");

            personaExistente.Nombre = personaActualizada.Nombre;
            personaExistente.Apellido = personaActualizada.Apellido;
            personaExistente.Telefono = personaActualizada.Telefono;
            personaExistente.Email = personaActualizada.Email;
            personaExistente.Nacionalidad = personaActualizada.Nacionalidad;

            // actualizo atributos espesificos
            if (personaExistente.Autor != null && personaActualizada.Autor != null)
            {
                personaExistente.Autor.Biografia = personaActualizada.Autor.Biografia;
                personaExistente.Autor.FechaNacimiento = personaActualizada.Autor.FechaNacimiento;
                personaExistente.Autor.Libros = personaActualizada.Autor.Libros;
            }

            if (personaExistente.Cliente != null && personaActualizada.Cliente != null)
            {

            }

            if (personaExistente.Empleado != null && personaActualizada.Empleado != null)
            {

            }
            _personaRepository.Update(personaExistente);
            _personaRepository.Save();
        }

        public void EliminarPersona(string documento)
        {
            Persona persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            if (persona == null)
                throw new ArgumentException("Persona no encontrada");
            _personaRepository.Delete(persona);
            _personaRepository.Save();
        }
        public Persona ObtenerPersona(string documento)
        {
            Persona persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            if (persona == null)
                throw new ArgumentException("Persona no encontrada");

            return persona;
        }

        public async Task<List<Persona>> ObtenerTodos()
        //una task hace una operacion que se puede ejecutar en segundo plano,
        //se usan para manejar operaciones que pueden tardar en completarse
        {
            return (await _personaRepository.FindAllAsync()).ToList();
            //await hace que el metodo espere a que termine una tarea sin bloquear
            //el hilo en el que se esta ejecutando
        }
    }
}
