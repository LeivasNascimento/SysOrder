using AutoMapper;
using Order.Application.DataContract.Request.Client;
using Order.Application.DataContract.Response.Client;
using Order.Application.DataContracts.Request.Client;
using Order.Application.Interfaces;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validations.Base;
using System.Collections.Generic;
using System.Linq;
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

        public Task<Response<ClientResponse>> GetByIdAsync(string clientId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Response<List<ClientResponse>>> ListByFilterAsync(string clientId, string name)
        {
            Response<List<ClientModel>> client = await _clientService.ListByFiltersAsync(clientId, name);

            if (client.Report.Any())
                return Response.Unprocessable<List<ClientResponse>>(client.Report);

            var response = _mapper.Map<List<ClientResponse>>(client.Data);

            return Response.OK(response);
        }

        public async Task<Response> UpdateAsync(UpdateClientRequest client)
        {
            var clientModel = _mapper.Map<ClientModel>(client);

            return await _clientService.UpdateAsync(clientModel);
        }

    }
}
