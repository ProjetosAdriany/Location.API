using System.Threading.Tasks;
using Api.Domain.DTOs;

namespace Api.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> findByEmail(LoginDTO user);
    }
}
