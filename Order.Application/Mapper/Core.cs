using AutoMapper;
using Order.Application.DataContract.Request.Client;
using Order.Application.DataContract.Request.User;
using Order.Application.DataContract.Response.Client;
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
            CreateMap<UpdateClientRequest, ClientModel>();

            CreateMap<ClientModel, CreateClientResponse>();
            CreateMap<ClientModel, ClientResponse>();

            CreateMap<UserModel, UserResponse>();
            CreateMap<CreateUserRequest, UserModel>().ForMember(target => target.PasswordHash, opt => opt.MapFrom(source => source.Password));


        }
    }
}
