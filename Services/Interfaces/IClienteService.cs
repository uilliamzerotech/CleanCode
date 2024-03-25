using Model.Dto;

namespace Services.Interfaces
{
    public interface IClienteService
    {
        public ClienteDTO GetCliente(int id);
    }
}
