using Database;

namespace Bibliotheque;

public interface IClientRepository
{
    Task<List<Client?>> GetClients();
}