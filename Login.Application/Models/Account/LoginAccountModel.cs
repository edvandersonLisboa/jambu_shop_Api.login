using System.ComponentModel.DataAnnotations;

namespace Login.Application.Models.Account;

public class LoginAccountModel
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string? Senha { get; set; }
    [Display(Name ="Lembre-me")]
    public bool RelembreMe { get; set; }
}
