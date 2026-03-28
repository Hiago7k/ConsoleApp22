using ConsoleApp2;
using ConsoleApp2.Filtros;
using System.Text.Json;

using (HttpClient httpClient = new HttpClient())
{

    try {
        string resposta = await httpClient.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
        LinqFilter filtrinho = new LinqFilter();
        //LinqFilter.FiltroDoLivro(livros);
        LinqFilter.FiltrandoPorNome(livros);
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Erro  {ex:Message}");
    }
}