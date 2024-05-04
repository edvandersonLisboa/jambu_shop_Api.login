using System.Text.Json.Serialization;

namespace Login.Domain.DTOs;

public class EnderecoDTO
{
    public int Id { get; set; }
    public string Cep { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string rua { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    [JsonIgnore]
    public DateTime Created { get; set; }   
    [JsonIgnore]
    public DateTime? Updated { get; set; }
}
