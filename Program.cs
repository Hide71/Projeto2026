using Projeto2026.Biblioteca;

namespace Projeto2026
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Biblioteca
               {"Biblioteca de Livros", Biblioteca_de_Livros.Executar},
               {"Biblioteca de Revistas", BibliotecaDeRevistas.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}