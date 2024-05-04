using System.ComponentModel.DataAnnotations;

namespace Login.Application.Models.Account;

public class RegisterAccountModel
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string? Senha { get; set; }
    [DataType(DataType.Password)]
    [Display(Name = "Confirme a senha")]
    [Compare("Senha", ErrorMessage = "As senhas não connferem")]
    public string? ConfirmSenha { get; set; }
}
