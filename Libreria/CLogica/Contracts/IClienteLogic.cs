using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IClienteLogic
    {
        Task<List<Cliente>> GetAll();
        void CrearCliente(Cliente cliente);
        void ModificarCliente(string DocumentoCliente, Cliente cliente);
        Cliente ObtenerCliente(string DocumentoCliente);
        void EliminarCliente(string DocumentoCliente);
    }
}