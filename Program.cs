using ConsoleApp2;
using System.Text.Json;

using (HttpClient httpClient = new HttpClient())
{

    try {
        string resposta = await httpClient.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livros>>(resposta)!;
        var livrosPorNome = livros.OrderBy(livros => livros.ListaDeLivros.).ToList()!;

        foreach (var livrosOrdenados in livrosPorNome) 
        {
            Console.WriteLine(livrosOrdenados);
        }


    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Erro  {ex:Message}");
    }
}