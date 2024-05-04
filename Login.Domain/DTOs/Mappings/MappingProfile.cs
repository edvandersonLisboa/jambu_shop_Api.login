using AutoMapper;
using Login.Domain.Entities;

namespace Login.Domain.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<ClienteEntity,ClienteDTO>().ReverseMap();
        CreateMap<EmpresaEntity,EmpresaDTO>().ReverseMap();
        CreateMap<EnderecoEntity,EnderecoDTO>().ReverseMap();
        CreateMap<FilialClienteEntity,FilialClienteDTO>().ReverseMap();
        CreateMap<FilialEntity,FilialClienteDTO>().ReverseMap();
        CreateMap<FuncionarioEntity,FuncionarioDTO>().ReverseMap();
    }
}
