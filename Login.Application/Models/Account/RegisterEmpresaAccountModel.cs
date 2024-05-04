using Login.Domain.DTOs;

namespace Login.Application.Models.Account;

public class RegisterEmpresaAccountModel
{
    public string? Nome { get; set; }

    public DateTime Data_Fundacao { get; set; }

    public IEnumerable<EnderecoDTO> Enderecos { get; set; }


}
