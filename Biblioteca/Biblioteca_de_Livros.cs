using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2026.Biblioteca
{
    public class Livro{
        public string Titulo { get; set; }
        public string Autor { get; set;}
        public int Paginas { get; set;}
        public bool Status { get; set;}

        public Livro(){

        }
        public Livro(string titulo, string autor, int paginas, bool status){
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            Status = status;
        }
    }
  
    public class Biblioteca_de_Livros
    {
       public static void Executar(){
        var Meu_Livro = new Livro();
        Meu_Livro.Titulo = "Des Dearlove";
        Meu_Livro.Autor = "O Estilo Bill Gates de Gerir";
        Meu_Livro.Paginas = 203;
        Meu_Livro.Status = true;

        Console.WriteLine( "Autor: " + Meu_Livro.Autor);
        Console.WriteLine( "Titulo: " + Meu_Livro.Titulo);
        Console.WriteLine( "Páginas : " + Meu_Livro.Paginas);
        Console.WriteLine( "Status : " + Meu_Livro.Status);

        var Livro_2 = new Livro("Juan Garcia Sola", "Linguagem C", 296, true);
        Console.WriteLine("Autor: " + Livro_2.Autor);
        Console.WriteLine("Titulo: " + Livro_2.Titulo);
        Console.WriteLine("Páginas: " + Livro_2.Paginas);
        Console.WriteLine("Status: " + Livro_2.Status);

       }
    }
}    
    