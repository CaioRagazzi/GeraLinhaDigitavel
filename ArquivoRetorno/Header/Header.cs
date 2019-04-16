using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UtilRemessa;

namespace ArquivoRetorno
{
    public class Header
    {
        public string TipoRegistro { get; set; }
        public string IdentificacaoArquivoRemessa { get; set; }
        public string LiteralRemessa { get; set; }
        public string CodigoServico { get; set; }
        public string LiteralServico { get; set; }
        public string CodEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string NumeroBradesco { get; set; }
        public string NomeBanco { get; set; }
        public string DataGravacaoArquivo { get; set; }
        public string DensidadeDeGravacao { get; set; }
        public string NumAvisoBancario { get; set; }
        public string Branco { get; set; }
        public string DataDoCredito { get; set; }
        public string Branco2 { get; set; }
        public string NumSequencialRegistro { get; set; }


        public Header GetHeader(string stringHeader)
        {
            Header header =  new Header
            {
                TipoRegistro = stringHeader.Substring(0, 1),
                IdentificacaoArquivoRemessa = stringHeader.Substring(1, 1),
                LiteralRemessa = stringHeader.Substring(2, 7),
                CodigoServico = stringHeader.Substring(9, 2),
                LiteralServico = stringHeader.Substring(11, 15),
                CodEmpresa = stringHeader.Substring(26, 20),
                NomeEmpresa = stringHeader.Substring(46, 30),
                NumeroBradesco = stringHeader.Substring(76, 3),
                NomeBanco = stringHeader.Substring(79, 15),
                DataGravacaoArquivo = stringHeader.Substring(94, 6),
                DensidadeDeGravacao= stringHeader.Substring(100, 8),
                NumAvisoBancario = stringHeader.Substring(108, 5),
                Branco = stringHeader.Substring(113, 266),
                DataDoCredito = stringHeader.Substring(379, 6),
                Branco2 = stringHeader.Substring(385, 9),
                NumSequencialRegistro = stringHeader.Substring(394, 6)
            };

            return header;
        }
    }
}
