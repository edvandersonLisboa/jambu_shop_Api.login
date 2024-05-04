using Login.Domain.Entities;

namespace Login.Domain.DTOs;

public class EmpresaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public IList<FilialEntity> Filiais { get; set; }
    public DateTime? Data_fundacao_empresa { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public bool isEmpClient { get; set; }
    public bool isAtived { get; set; }
}
