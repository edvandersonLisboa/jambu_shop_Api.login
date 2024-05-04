using Login.Data.Contexts;
using Login.Data.Repositories.Base;
using Login.Domain.Entities;
using Login.Domain.Interfaces;

namespace Login.Data.Repositories;

public class FilialRepository : BaseRepository<FilialEntity>, IFilialRepository
{
    public FilialRepository(AppDBContext context) : base(context)
    {
        
    }
}
