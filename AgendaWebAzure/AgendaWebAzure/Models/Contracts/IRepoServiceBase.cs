using AgendaWebAzure.Models.Entitties;

namespace AgendaWebAzure.Models.Contracts
{
    public interface IRepoServiceBase <T, Y>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Y id);
        Task AddAsync(T cliente);
        Task<bool> UpdateAsync(T cliente);
        Task<bool> DeleteAsync(Y id);
    }
}
