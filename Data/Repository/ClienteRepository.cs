using Data.Context;
using Domain.Interfaces.IRepository;
using Domain.Models;

namespace Data.Repository
{
    public class ClienteRepository : Repository<Clientes>, IClienteRepository
    {
        private readonly MyContext _context;
        public ClienteRepository(MyContext context) : base(context)
        {
            _context = context;
        }
    }
}
