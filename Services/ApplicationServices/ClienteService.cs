using Model.Context;
using Model.Dto;
using Model.Entity;
using Services.CrossCutting;
using Services.Interfaces;

namespace Services.ApplicationServices
{
    public class ClienteService:IClienteService
    {
        private readonly DataBaseContext _context;

        public ClienteService(DataBaseContext context)
        {
            _context = context;
        }

        public ClienteDTO GetCliente(int id)
        {
            var cliente =  _context.Cliente.Find(id);
            if (cliente == null)
                throw new Exception("O cliente não foi encontrado!");
            var dto = DtoConverter.Converter<Cliente, ClienteDTO>(cliente);
            return dto;

            // Implementação para obter cliente do contexto e mapear para DTO
        }
        // outras implementações dos métodos da interface
    }
}
