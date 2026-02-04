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
        public override void Descarte(){
            this.MensagemDescarte = "A revista foi reciclada ";
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
           revista.Descarte();

           Console.WriteLine("Titulo: " + revista.Titulo);
           Console.WriteLine("Autor: " + revista.Autor);
           Console.WriteLine("Páginas: " + revista.Paginas);
           Console.WriteLine("Mês da Publicação: " + revista.Mes);
           Console.WriteLine("Ano da Publicação: " + revista.Ano);
           Console.WriteLine("Status: " + revista.Status);
           Console.WriteLine("Descarte: " + revista.MensagemDescarte);
           Console.WriteLine();

           var revista2 = new Revista(2, 2026);
           revista2.Titulo = "Capitão América";
           revista2.Autor = "Steve Ditko";
           revista2.Paginas = 248;
           revista2.Status = true;
           revista2.Descarte();
           Console.WriteLine("Titulo: " + revista2.Titulo);
           Console.WriteLine("Autor: " + revista2.Autor);
           Console.WriteLine("Páginas: " + revista2.Paginas);
           Console.WriteLine("Mês da Publicação: " + revista2.Mes);
           Console.WriteLine("Ano da Publicação: " + revista2.Ano);
           Console.WriteLine("Status: " + revista2.Status);
           Console.WriteLine("Descarte: " + revista2.MensagemDescarte);
        }
    }
}