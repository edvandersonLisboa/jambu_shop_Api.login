using Login.Domain.Entities;

namespace Login.Domain.DTOs;

public class FilialDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int EmpresaId { get; set; }
    public EmpresaEntity? Empresa { get; set; }
    public List<FuncionarioEntity>? Funcionarios { get; set; }
     public List<ClienteEntity>? Clientes { get; set; }
    public EnderecoEntity? Endereco { get; set; }
    public DateTime? Data_fundacao_filial { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}
