
using Login.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Login.Data.Contexts;

public class AppDBContext : IdentityDbContext<ApplicationUser>
{
  
    public DbSet<ClienteEntity> TB_CLIENTES => Set<ClienteEntity>();
    public DbSet<FuncionarioEntity> TB_FUNCIONARIOS {get; set;}
    public DbSet<EmpresaEntity> TB_EMPRESAS { get; set; }
    public DbSet<FilialEntity> TB_FILIAS => Set<FilialEntity>();
    public DbSet<EnderecoEntity> TB_ENDERECOS { get; set; }
    public DbSet<FilialClienteEntity> TB_FILIAS_CLIENTES { get; set; }

    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<FilialEntity>()
                    .HasMany(e => e.Clientes)
                    .WithMany(e => e.Filias)
                    .UsingEntity<FilialClienteEntity>(
                        j => j.Property(e => e.Created).HasDefaultValueSql("CURRENT_TIMESTAMP")
                    );
    }
    
}