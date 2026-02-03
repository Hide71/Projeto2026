using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2026.Biblioteca
{
    public class Revista: Livro{

        public int Mes { get; set; }
        public int Ano { get; set; }

        public Revista(){

        }

        public Revista(int mes, int ano){
            Mes = mes;
            Ano = ano;
        }
    }
    public class BibliotecaDeRevistas
    {
        public static void Executar(){
           Revista revista = new Revista();
           revista.Mes = 1;
           revista.Ano = 2026;
           revista.Titulo = "Homem-Aranha";
           revista.Autor = "Stan Lee";
           revista.Paginas = 300;
           revista.Status= false;

           Console.WriteLine("Titulo: " + revista.Titulo);
           Console.WriteLine("Autor: " + revista.Autor);
           Console.WriteLine("Páginas: " + revista.Paginas);
           Console.WriteLine("Mês da Publicação: " + revista.Mes);
           Console.WriteLine("Ano da Publicação: " + revista.Ano);
           Console.WriteLine("Status: " + revista.Status);
        }
    }
}