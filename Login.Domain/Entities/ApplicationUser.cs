using Microsoft.AspNetCore.Identity;

namespace Login.Domain.Entities;

public class ApplicationUser : IdentityUser
{
 public string?  UserSobrenome { get; set; }
 public EnderecoEntity endereco { get; set; }

}
