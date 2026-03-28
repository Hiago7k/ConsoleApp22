using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2;

internal class Livro
{

    [JsonPropertyName("titulo")]
    public string? Titulo { get; }
    [JsonPropertyName("autor")]
    public string? Autor { get; }
    [JsonPropertyName("ano_publicacao")]
    public string? AnoPublicacao { get; set; }
    [JsonPropertyName("genero")]
    public string? Genero { get; }
    [JsonPropertyName("paginas")]
    public int Paginas { get; }
    [JsonPropertyName("editora")]
    public string? Editora { get; }
}

