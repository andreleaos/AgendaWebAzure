using AgendaWebAzure.Models.Entitties;
using Dapper;
using MySql.Data.MySqlClient;

namespace AgendaWebAzure.Models.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("clientedb");
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            using var connection = new MySqlConnection(_connectionString);
            var clientes = await connection.QueryAsync<Cliente>("SELECT * FROM clientes");
            return clientes;
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            using var connection = new MySqlConnection(_connectionString);
            var cliente = await connection.QueryFirstOrDefaultAsync<Cliente>("SELECT * FROM clientes WHERE id = @Id", new { Id = id });
            return cliente;
        }

        public async Task AddAsync(Cliente cliente)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.ExecuteAsync("INSERT INTO clientes (nome, email, fone) VALUES (@Nome, @Email, @Fone)", cliente);
        }

        public async Task<bool> UpdateAsync(Cliente cliente)
        {
            using var connection = new MySqlConnection(_connectionString);
            var rowsAffected = await connection.ExecuteAsync("UPDATE clientes SET nome = @Nome, email = @Email, fone = @Fone WHERE id = @Id", cliente);
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var connection = new MySqlConnection(_connectionString);
            var rowsAffected = await connection.ExecuteAsync("DELETE FROM clientes WHERE id = @Id", new { Id = id });
            return rowsAffected > 0;
        }
    }
}
