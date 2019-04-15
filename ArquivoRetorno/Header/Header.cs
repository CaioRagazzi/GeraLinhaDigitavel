using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UtilRemessa;

namespace ArquivoRetorno
{
    public class Header
    {
        private string TipoRegistro { get; set; }
        private string IdentificacaoArquivoRemessa { get; set; }
        private string LiteralRemessa { get; set; }
        private string CodigoServico { get; set; }
        private string LiteralServico { get; set; }
        private string CodEmpresa { get; set; }
        private string NomeEmpresa { get; set; }
        private string NumeroBradesco { get; set; }
        private string NomeBanco { get; set; }
        private string DataGravacaoArquivo { get; set; }
        private string DensidadeDeGravacao { get; set; }
        private string NumAvisoBancario { get; set; }
        private string Branco { get; set; }
        private string DataDoCredito { get; set; }
        private string Branco2 { get; set; }
        private string NumSequencialRegistro { get; set; }


        public Header GetHeader(string path)
        {
            List<String> lista = UtilRemessa.FormataArquivo.LeArquivoRetorno(path);
            String linhaHeader = lista[0];

            Header header =  new Header
            {
                TipoRegistro = linhaHeader.Substring(0, 1),
                IdentificacaoArquivoRemessa = linhaHeader.Substring(1, 1),
                LiteralRemessa = linhaHeader.Substring(2, 7),
                CodigoServico = linhaHeader.Substring(9, 2),
                LiteralServico = linhaHeader.Substring(11, 15),
                CodEmpresa = linhaHeader.Substring(26, 20),
                NomeEmpresa = linhaHeader.Substring(46, 30),
                NumeroBradesco = linhaHeader.Substring(76, 3),
                NomeBanco = linhaHeader.Substring(79, 15),
                DataGravacaoArquivo = linhaHeader.Substring(94, 6),
                DensidadeDeGravacao= linhaHeader.Substring(100, 8),
                NumAvisoBancario = linhaHeader.Substring(108, 5),
                Branco = linhaHeader.Substring(113, 266),
                DataDoCredito = linhaHeader.Substring(379, 6),
                Branco2 = linhaHeader.Substring(385, 9),
                NumSequencialRegistro = linhaHeader.Substring(394, 6)
            };

            return header;
        }
    }
}
