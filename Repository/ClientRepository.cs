using Database;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheque.Repository;

public class ClientRepository : IClientRepository
{
    private readonly ApiContext _apiContext;

    public ClientRepository(ApiContext apiContext)
    {
        this._apiContext = apiContext;
    }
    
    public Task<List<Client?>> GetClients()
    {
        return _apiContext.Clients.ToListAsync();
    }
}