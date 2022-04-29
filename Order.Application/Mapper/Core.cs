using AutoMapper;
using Order.Application.DataContracts.Request.Client;
using Order.Domain.Models;

namespace Order.Application.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<CreateClientRequest, ClientModel>();
            CreateMap<ClientModel, CreateClientResponse>();
        }
    }
}
