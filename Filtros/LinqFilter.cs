using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Filtros;

internal class LinqFilter
{
    public static void FiltroDoLivro(List<Livro> livro) 
    {
        var filtrandoLivros = livro.Where(livro => livro.AnoPublicacao >= 1).ToList()!;

        foreach (var livroOrdenados in filtrandoLivros) 
        {
            Console.WriteLine($"- {livroOrdenados.AnoPublicacao}");
        }
    }

    public static void FiltrandoPorNome(List<Livro> livro)
    {

        var todosOsGeneros = livro.Select(generos => generos.Genero).Distinct().ToList()!;
        foreach (var genero in todosOsGeneros) 
        {
            Console.WriteLine($"- {genero}");
        }
      
    }



}
