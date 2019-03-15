using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest
{
    public class Util
    {
        public static string FormataCampoComEspacosDireita(string campo, int tamanho) => campo.PadRight(tamanho, ' ').Substring(0, tamanho);

        public static string FormataCampoComZerosEsquerda(string campo, int tamanho) => campo.PadLeft(tamanho, '0').Substring(0, tamanho);
    }
}
