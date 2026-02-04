using Projeto2026.Biblioteca;
using Projeto2026.Capitulo7;

namespace Projeto2026
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Biblioteca
               {"Biblioteca de Livros - Biblioteca", Biblioteca_de_Livros.Executar},
               {"Biblioteca de Revistas - Biblioteca", BibliotecaDeRevistas.Executar},
               {"Biblioteca de Fotos - Biblioteca", BibliotecaDeFotos.Executar},
               //Capitulo7
               {"Metodo de Extensão - Capitulo7", MetodoExtensao.Executar}

            });

            central.SelecionarEExecutar();
        }
    }
}