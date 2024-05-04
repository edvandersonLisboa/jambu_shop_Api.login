using Login.Domain.DTOs;

namespace Login.Application.Models;

public class FilialModel
{
    public string Nome { get; set; }
    public EnderecoDTO Endereco { get; set; }
    public IList<FuncionarioModel> Funcionarios { get; set; }
}
