using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLogica.Contracts;
using CEntidades.Entidades;
using CDatos.Repositories.Contracts;
using Microsoft.IdentityModel.Tokens;
using static System.Net.Mime.MediaTypeNames;

namespace CLogica.Implementations
{
    public class PersonaLogic : IPersonaLogic
    {
        private IPersonaRepository _personaRepository;
        public PersonaLogic(IPersonaRepository personaRepository) 
        {
            _personaRepository = personaRepository;
        }
        
        List<string> camposErroneos = new List<string>();

        //METODOS ABM
        public void AltaPersona(Persona personaNueva)
        {
            if (string.IsNullOrEmpty(personaNueva.Nombre) || !IsValidName(personaNueva.Nombre))  
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(personaNueva.Apellido) || !IsValidName(personaNueva.Apellido))
                camposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(personaNueva.Documento) || !IsValidDocumento(personaNueva.Documento) || _personaRepository.FindByCondition(p => p.Documento == personaNueva.Documento).Count() != 0)
                camposErroneos.Add("Documento");

            if (string.IsNullOrEmpty(personaNueva.Telefono) || !IsValidTelefono(personaNueva.Telefono))
                camposErroneos.Add("Telefono");

            if (string.IsNullOrEmpty(personaNueva.Email) || !IsValidEmail(personaNueva.Email))
                camposErroneos.Add("Email");

            if(camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", String.Join(", ", camposErroneos));
            }

            Persona persona = new Persona();
            persona.Nombre = personaNueva.Nombre;
            persona.Apellido = personaNueva.Apellido;
            persona.Documento = personaNueva.Documento;
            persona.Telefono = personaNueva.Telefono;
            persona.Email = personaNueva.Email;
            if (personaNueva.Autor == null)
            {
                persona.Autor = personaNueva.Autor;
            }
            if (personaNueva.Empleado == null)
            {
                persona.Empleado = personaNueva.Empleado;
            }
            if (personaNueva.Cliente == null)
            {
                persona.Cliente = personaNueva.Cliente;
            }

            _personaRepository.Create(persona);
            _personaRepository.Save();

        } 
        public void BajaPersona(string documento)
                {
                    if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                        throw new AggregateException("El documento igresado es invalido");

                    Persona? personaBuscada = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault() ?? throw new ArgumentNullException("No se encontró una persona con ese documento");

                    _personaRepository.Delete(personaBuscada);
                    _personaRepository.Save();
                }
        public void ModificacionPersona(string documento, Persona persona)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new AggregateException("El documento igresado es invalido");

            Persona? personaBuscada = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault() ?? throw new ArgumentNullException("No se encontró una persona con ese documento");

            if (string.IsNullOrEmpty(persona.Nombre) || !IsValidName(persona.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(persona.Apellido) || !IsValidName(persona.Apellido))
                camposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(persona.Documento) || !IsValidDocumento(persona.Documento))
                camposErroneos.Add("Documento");

            if (string.IsNullOrEmpty(persona.Telefono) || !IsValidTelefono(persona.Telefono))
                camposErroneos.Add("Telefono");

            if (string.IsNullOrEmpty(persona.Email) || !IsValidEmail(persona.Email))
                camposErroneos.Add("Email");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", String.Join(", ", camposErroneos));
            }


            personaBuscada.Nombre = persona.Nombre;
            personaBuscada.Apellido = persona.Apellido;
            personaBuscada.Documento = persona.Documento;
            personaBuscada.Telefono = persona.Telefono;
            personaBuscada.Email = persona.Email;

            _personaRepository.Update(personaBuscada);
            _personaRepository.Save();
        }

        #region Validaciones
        //Validaciones para usar en los metodos        
        public bool ContainsCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            return caracteres.Any(p => text.Contains(p));
        }
        private bool IsValidName(string nombre)
        {
            return ContainsCharacter(nombre) && nombre.Length < 15;
        }

        private bool IsValidDocumento(string documento)
        {
            return documento.Length != 8 && ContainsCharacter(documento);
        }

        private bool IsValidTelefono(string telefono)
        {
            return telefono.Length != 10 && ContainsCharacter(telefono);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains('@') && ContainsCharacter(email);
        }

        private bool DocumentoExistente(string documento)
        {
            var documentoExistente = _personaRepository
            .FindByCondition(p => p.Documento == documento)
            .FirstOrDefault();
            return documentoExistente != null;
        }
        #endregion Validaciones
    }
}
