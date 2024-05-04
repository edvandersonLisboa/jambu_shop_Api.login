using Login.Data.Contexts;
using Login.Data.Repositories.Base;
using Login.Domain.Entities;
using Login.Domain.Interfaces;

namespace Login.Data.Repositories;

public class EmpresaRepository : BaseRepository<EmpresaEntity>, IEmpresaRepository
{
    public EmpresaRepository(AppDBContext context) : base(context)
    {
        
    }
}
