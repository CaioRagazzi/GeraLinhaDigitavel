using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ArquivoRemessa
{
    public static class Util
    {
        public static string FormataCampoComEspacosDireita(string campo, int tamanho)
        {
            if (string.IsNullOrWhiteSpace(campo)) campo = "";
            return campo.PadRight(tamanho, ' ').Substring(0, tamanho);
        }

        public static string FormataCampoComZerosEsquerda(string campo, int tamanho)
        {
            if (string.IsNullOrWhiteSpace(campo)) campo = "";
            return campo.PadLeft(tamanho, '0').Substring(0, tamanho);
        }

        //public static string FormataCampoComZerosEsquerda(int campo, int tamanho)
        //{
        //    if (string.IsNullOrWhiteSpace(campo)) campo = "";
        //    return campo.ToString().PadLeft(tamanho, '0').Substring(0, tamanho);
        //}

        public static string FormataCampoCaracteresEspeciais(string campo)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = campo.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

    }
}
