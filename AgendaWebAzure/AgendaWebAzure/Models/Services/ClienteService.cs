using AgendaWebAzure.Models.Entitties;
using AgendaWebAzure.Models.Infrastructure.Repositories;

namespace AgendaWebAzure.Models.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
        {
            _clienteRepository = clienteRepository;
        } 

        public async Task AddAsync(Cliente cliente)
        {
           await _clienteRepository.AddAsync(cliente);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _clienteRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Cliente cliente)
        {
            return await _clienteRepository.UpdateAsync(cliente);
        }
    }
}
