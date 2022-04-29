using Order.Application.DataContracts.Request.Client;
using Order.Domain.Validations.Base;
using System.Threading.Tasks;

namespace Order.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<Response> CreateAsync(CreateClientRequest client);
        Task<Response> UpdateAsync(CreateClientRequest client);
        Task<Response> DeleteAsync(string clientId);

    }
}
