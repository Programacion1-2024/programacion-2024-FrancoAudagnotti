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
    public class ClienteLogic : IClienteLogic
    {
        private IClienteRepository _clienteRepository;

        public ClienteLogic(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void CrearCliente(Cliente cliente)
        {
            _clienteRepository.Create(cliente);
            _clienteRepository.Save();
        }
        public void ModificarCliente(string documentoCliente, Cliente cliente)
        {
            Cliente? clienteExistente = _clienteRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoCliente).FirstOrDefault();
            if (clienteExistente == null)
                throw new ArgumentException("Cliente no encontrado");

            clienteExistente.EsSocio = cliente.EsSocio;
            clienteExistente.PagaIVA = cliente.PagaIVA;
            clienteExistente.Prestamos = cliente.Prestamos;
            clienteExistente.Ventas = cliente.Ventas;

            _clienteRepository.Update(clienteExistente);
            _clienteRepository.Save();
        }
        public void EliminarCliente(string documentoCliente)
        {
            Cliente? cliente = _clienteRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoCliente).FirstOrDefault();
            if (cliente == null)
                throw new ArgumentException("Empleado no encontrado");

            _clienteRepository.Delete(cliente);
            _clienteRepository.Save();
        }
        public Cliente ObtenerCliente(string documentoCliente)
        {
            {
                Cliente? cliente = _clienteRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoCliente).FirstOrDefault();
                if (cliente == null)
                    throw new ArgumentException("Empleado no encontrado");

                return cliente;
            }
        }
        public async Task<List<Cliente>> GetAll()
        {
            return await _clienteRepository.GetAll();
        }
    }
}
