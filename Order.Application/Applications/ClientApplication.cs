using AutoMapper;
using Order.Application.DataContracts.Request.Client;
using Order.Application.Interfaces;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validations.Base;
using System.Threading.Tasks;

namespace Order.Application.Applications
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
        public ClientApplication(IClientService clientService, IMapper mapper)
        {
            _mapper = mapper;
            _clientService = clientService;
        }
        public async Task<Response> CreateAsync(CreateClientRequest client)
        {
            var clientMapped = _mapper.Map<ClientModel>(client);
            return await _clientService.CreateAsync(clientMapped);
        }

        public Task<Response> DeleteAsync(string clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response> UpdateAsync(CreateClientRequest client)
        {
            throw new System.NotImplementedException();
        }
    }
}
