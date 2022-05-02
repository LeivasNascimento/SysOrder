using Order.Application.DataContract.Request.Client;
using Order.Application.DataContract.Response.Client;
using Order.Application.DataContracts.Request.Client;
using Order.Domain.Validations.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<Response> CreateAsync(CreateClientRequest client);
        Task<Response> UpdateAsync(UpdateClientRequest client);
        Task<Response> DeleteAsync(string clientId);

        Task<Response<List<ClientResponse>>> ListByFilterAsync(string clientId, string name);

        Task<Response<ClientResponse>> GetByIdAsync(string clientId);

    }
}
