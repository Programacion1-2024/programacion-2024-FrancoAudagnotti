using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class PersonaFactory : IPersonaFactory
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IAutorLogic _autorLogic;
        private readonly IEmpleadoLogic _empleadoLogic;
        private readonly IClienteLogic _clienteLogic;
        public PersonaFactory(IPersonaRepository personaRepository, IAutorLogic autorLogic, IClienteLogic clienteLogic, IEmpleadoLogic empleadoLogic)
        {
            _personaRepository = personaRepository;
            _autorLogic = autorLogic;
            _clienteLogic = clienteLogic;
            _empleadoLogic = empleadoLogic;
        }

        public Persona CrearPersona(Persona personaNueva)
        {
            if (DocumentoExistente(personaNueva.Documento))
                throw new ArgumentException("Documento ya existente");

            ValidarDatosPersona(personaNueva);

            Persona persona = new Persona
            {
                Nombre = personaNueva.Nombre,
                Apellido = personaNueva.Apellido,
                Nacionalidad = personaNueva.Nacionalidad,
                Documento = personaNueva.Documento,
                TipoDocumento = personaNueva.TipoDocumento,
                Telefono = personaNueva.Telefono,
                Email = personaNueva.Email,
            };

            if (personaNueva.Autor != null)
            {
                persona.Autor = CrearAutor(personaNueva.Autor);
                _autorLogic.CrearAutor(persona.Autor);
            }
            if (personaNueva.Cliente != null)
            {
                persona.Cliente = CrearCliente(personaNueva.Cliente);
                _clienteLogic.CrearCliente(persona.Cliente);
            }
            if (personaNueva.Empleado != null)
            {
                persona.Empleado = CrearEmpleado(personaNueva.Empleado);
                _empleadoLogic.CrearEmpleado(persona.Empleado);
            }

            return persona;
        }
        public Autor CrearAutor(Autor autor)
        {
            if (autor == null) return null; //si es null salgo del metodo
            return new Autor // si no es null agrego los atributos
            {
                Biografia = autor.Biografia,
                FechaNacimiento = autor.FechaNacimiento,
                Libros = autor.Libros
            };
        }

        public Cliente CrearCliente(Cliente cliente)
        {
            if (cliente == null) return null;
            return new Cliente
            {
                EsSocio = cliente.EsSocio,
                PagaIVA = cliente.PagaIVA,
                Prestamos = cliente.Prestamos,
                Ventas = cliente.Ventas,
            };
        }

        public Empleado CrearEmpleado(Empleado empleado)
        {
            if (empleado == null) return null;
            return new Empleado
            {
                Cargo = empleado.Cargo,
                Sueldo = empleado.Sueldo,
                Antiguedad = empleado.Antiguedad,

            };
        }

        //Validaciones 
        public bool ContieneCaracter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            return caracteres.Any(p => text.Contains(p));
        }
        private bool IsValidName(string nombre)
        {
            return !ContieneCaracter(nombre) && nombre.Length <= 15;
        }

        private bool IsValidDocumento(string documento)
        {
            return documento.Length == 8 && !ContieneCaracter(documento);
        }

        private bool IsValidTelefono(string telefono)
        {
            return telefono.Length == 10 && !ContieneCaracter(telefono);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains('@') && !ContieneCaracter(email);
        }

        private bool DocumentoExistente(string documento)
        {
            return _personaRepository
        .FindByCondition(p => p.Documento == documento)
        .Any();
        }
        private void ValidarDatosPersona(Persona persona)
        {
            if (string.IsNullOrEmpty(persona.Nombre) || !IsValidName(persona.Nombre))
                throw new ArgumentException("Nombre inválido");

            if (string.IsNullOrEmpty(persona.Apellido) || !IsValidName(persona.Apellido))
                throw new ArgumentException("Apellido inválido");

            if (string.IsNullOrEmpty(persona.Documento) || !IsValidDocumento(persona.Documento))
                throw new ArgumentException("Documento inválido");

            if (string.IsNullOrEmpty(persona.Telefono) || !IsValidTelefono(persona.Telefono))
                throw new ArgumentException("Teléfono inválido");

            if (string.IsNullOrEmpty(persona.Email) || !IsValidEmail(persona.Email))
                throw new ArgumentException("Email inválido");
        }
    }

}
