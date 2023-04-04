using System.Threading.Tasks;
using Abp.Application.Services;
using vanson.Sessions.Dto;

namespace vanson.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
