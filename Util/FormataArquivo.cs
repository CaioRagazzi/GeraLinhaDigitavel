using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtilRemessa
{
    public static class FormataArquivo
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

        public static DateTime? ConverteETrataData(string dataString)
        {
            if (string.IsNullOrEmpty(dataString))
            {
                return null;
            }
            else
            {
                return DateTime.ParseExact(dataString, "ddMMyy", CultureInfo.InvariantCulture);
            }
        }

        public static decimal ConverteETrataDecimal(string valor)
        {
            var novoValor = valor.Insert((valor.Length - 2), ".");
            var valorConvertido = decimal.Parse(novoValor, CultureInfo.InvariantCulture);

            return valorConvertido;
        }

        public static string SubstituiCaracteresEspeciais(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var sb = new StringBuilder();
                var arrayChar = text.Normalize(NormalizationForm.FormD).ToCharArray();

                foreach (char c in arrayChar)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                        sb.Append(c);
                }
                return Regex.Replace(sb.ToString(), @"[^0-9a-zA-Z°ºª&¹²³.,\\@\- ]+", x => new string(' ', x.Length))
                    .Replace("ª", "a")
                    .Replace("º", "o")
                    .Replace("°", "o")
                    .Replace("&", "e")
                    .Replace("¹", "1")
                    .Replace("²", "2")
                    .Replace("³", "3")
                    .Replace("@", "a");
            }
            return string.Empty;
        }

        public static bool GravaArquivo(List<StringBuilder> listaTransacoes, String path)
        {
            StringBuilder header = new StringBuilder(400);
            List<StringBuilder> listaTransacoesTipo1 = new List<StringBuilder>(400);
            List<StringBuilder> listaTransacoesTipo2 = new List<StringBuilder>(400);
            List<StringBuilder> listaTransacoesTipo3 = new List<StringBuilder>(400);
            List<StringBuilder> listaTransacoesTipo6 = new List<StringBuilder>(400);
            List<StringBuilder> listaTransacoesTipo7 = new List<StringBuilder>(400);
            StringBuilder trailler = new StringBuilder(400);

            int numeroSequencial = 1;
            foreach (var item in listaTransacoes)
            {
                var tipoTransacao = item[0].ToString();
                switch (tipoTransacao)
                {
                    case "0":
                        header = item.Insert(394, numeroSequencial.ToString().PadLeft(6, '0'));
                        break;
                    case "1":
                        listaTransacoesTipo1.Add(item.Insert(394, numeroSequencial.ToString().PadLeft(6, '0')));
                        break;
                    case "2":
                        listaTransacoesTipo2.Add(item.Insert(394, numeroSequencial.ToString().PadLeft(6, '0')));
                        break;
                    case "3":
                        listaTransacoesTipo3.Add(item.Insert(394, numeroSequencial.ToString().PadLeft(6, '0')));
                        break;
                    case "6":
                        listaTransacoesTipo6.Add(item.Insert(394, numeroSequencial.ToString().PadLeft(6, '0')));
                        break;
                    case "8":
                        listaTransacoesTipo7.Add(item.Insert(394, numeroSequencial.ToString().PadLeft(6, '0')));
                        break;
                    case "9":
                        trailler = item.Insert(394, numeroSequencial.ToString().PadLeft(6, '0'));
                        break;
                    default:
                        break;
                }
                numeroSequencial++;
            }

            if (listaTransacoesTipo1.Count == 0)
            {
                throw new Exception("Nenhuma transação do tipo 1");
            }

            if (header.Length == 0 || trailler.Length == 0)
            {
                throw new Exception("Lista de transações não contém Header e/ou Trailler");
            }

            if (listaTransacoesTipo1.Count == 0 && listaTransacoesTipo2.Count == 0 && listaTransacoesTipo3.Count == 0 && listaTransacoesTipo6.Count == 0 && listaTransacoesTipo7.Count == 0)
            {
                throw new Exception("Lista de transações não contém nenhuma transação");
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in listaTransacoes)
                {
                    sw.WriteLine(item);
                }
            }

            return true;
        }

    }
}
