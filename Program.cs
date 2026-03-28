using (HttpClient httpClient = new HttpClient())
{
    string resposta = await httpClient.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
    Console.WriteLine(resposta);


}