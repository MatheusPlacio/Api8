using Domain.Models;

namespace Domain.Interfaces.IService
{
    public interface IClienteService
    {
        IList<Clientes> GetAllClientes();
    }
}
