using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2026.Biblioteca
{
    public class Foto : Revista{
        public string Tipo { get; set; }

        public Foto(){

        }

        public Foto(string tipo): base(){
            Tipo = tipo;
        }
    }
    public class BibliotecaDeFotos
    {
        public static void Executar(){
           var foto = new Foto();

           foto.Tipo = "colorida";
           foto.Titulo = "Praia 2020";
           foto.Autor = "Hideraldo";
           foto.Paginas = 1;
           foto.Status = true;
           foto.Ano = 2020;
           foto.Mes = 4;
           Console.WriteLine("Autor: " + foto.Autor);
           Console.WriteLine( "Titulo: " + foto.Titulo);
           Console.WriteLine( "Páginas : " + foto.Paginas);
           Console.WriteLine( "Status : " + foto.Status);
           Console.WriteLine("Mês da Publicação: " + foto.Mes);
           Console.WriteLine("Ano da Publicação: " + foto.Ano);
           Console.WriteLine("Tipo: " + foto.Tipo);
           Console.WriteLine();
           
           Foto foto2 = new Foto("Preto e branco");
           foto2.Titulo = "Aniversário 2026";
           foto2.Autor = "Hideraldo";
           foto2.Paginas = 1;
           foto2.Status = true;
           foto2.Ano = 2026;
           foto2.Mes = 12; 

           Console.WriteLine("Autor: " + foto2.Autor);
           Console.WriteLine( "Titulo: " + foto2.Titulo);
           Console.WriteLine( "Páginas : " + foto2.Paginas);
           Console.WriteLine( "Status : " + foto2.Status);
           Console.WriteLine("Mês da Publicação: " + foto2.Mes);
           Console.WriteLine("Ano da Publicação: " + foto2.Ano);
           Console.WriteLine("Tipo: " + foto2.Tipo);
           
            
        }
    }
}