using AutoMapper;
using Login.Application.Sevices.Base;
using Login.Application.Sevices.Interfaces;
using Login.Domain.DTOs;
using Login.Domain.Entities;
using Login.Domain.Interfaces;
using Login.Domain.Interfaces.Base;

namespace Login.Application.Sevices;

public class FilialService : BaseService<FilialDTO, FilialEntity>, IFilialService
{
    public FilialService(IMapper mapper, IFilialRepository repository) : base(mapper, repository)
    {
    }
}
