using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2026.Capitulo7
{
    public static class Extensao{
        public static string FormatarData(this DateTime data, string formato){
            return data.ToString(formato);
        }
        public static string Formatar(this decimal valor, string formato){
            return valor.ToString(formato);
        } 
        public static int Somar(this int valor, int outroValor)
        =>valor + outroValor;
    }
    public class MetodoExtensao
    {
        public static void Executar(){
           Console.WriteLine(DateTime.Today.FormatarData("dd/MMM/yyyy"));
           Console.WriteLine(DateTime.Today.FormatarData("dddd dd/MMM/yyyy"));
           Console.WriteLine(DateTime.Today.FormatarData("MMMM/yyyy"));
           Console.WriteLine(DateTime.Today.FormatarData("yyyy"));
           Console.WriteLine();
           Console.WriteLine(5800.00M.Formatar("R$ ##,##0.00"));
           decimal valor = 4755.80M;
           Console.WriteLine(valor.Formatar("C2"));
           Console.WriteLine();
           Console.WriteLine(5.Somar(4));
           Console.WriteLine(80.Somar(4));
        }
    }
}