using Login.Data.Contexts;
using Login.Data.Repositories.Base;
using Login.Domain.Entities;
using Login.Domain.Interfaces;

namespace Login.Data.Repositories;

public class FuncionarioRepository : BaseRepository<FuncionarioEntity>, IFuncionarioRepository
{
    public FuncionarioRepository(AppDBContext context) : base(context)
    {
    }
}
