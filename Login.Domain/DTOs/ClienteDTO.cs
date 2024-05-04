using Login.Domain.Entities;

namespace Login.Domain.DTOs;

public class ClienteDTO
{
    public int id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User {get; set;}
    public List<FilialEntity>? Filias { get; set; }
    public DateTime? Data_nasc { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public bool isAtived { get; set; }
}
