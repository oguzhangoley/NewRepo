using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories
{
    public interface IRefreshRepository : IAsyncRepository<RefreshToken>, IRepository<RefreshToken>
    {
    }
}
