namespace Login.Domain.Entities;

public class FuncionarioEntity
{
    public int id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser? User {get; set;}
    public int empreasaId { get; set; }
    public int FilialId { get; set; }
    public FilialEntity? Filial { get; set; }
    public DateTime? Data_nasc { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public bool isAtived { get; set; }

}
