namespace Login.Domain.Entities;

public class EnderecoEntity
{
    public int Id { get; set; }
    public string Cep { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string rua { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}
