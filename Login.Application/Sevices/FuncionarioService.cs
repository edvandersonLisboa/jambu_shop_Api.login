using AutoMapper;
using Login.Application.Sevices.Base;
using Login.Application.Sevices.Interfaces;
using Login.Domain.DTOs;
using Login.Domain.Entities;
using Login.Domain.Interfaces;
using Login.Domain.Interfaces.Base;

namespace Login.Application.Sevices;

public class FuncionarioService : BaseService<FuncionarioDTO, FuncionarioEntity>, IFuncionarioService
{
    public FuncionarioService(IMapper mapper, IFuncionarioRepository repository) : base(mapper, repository)
    {
    }
}
