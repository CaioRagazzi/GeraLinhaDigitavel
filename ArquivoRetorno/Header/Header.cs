using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Util;

namespace ArquivoRetorno
{
    public class Header
    {
        private string tipoRegistro;
        private string identificacaoArquivoRemessa;
        private string literalRemessa;
        private string codigoServico;
        private string literalServico;
        private string codEmpresa;
        private string nomeEmpresa;
        private string numeroBradesco;
        private string nomeBanco;
        private string dataGravacaoArquivo;
        private string densidadeDeGravacao;
        private string numAvisoBancario;
        private string branco;
        private string dataDoCredito;
        private string branco2;
        private string numSequencialRegistro;


        public Header GeraHeader(string path)
        {
            List<String> lista = Util.FormataArquivo.LeArquivoRetorno(path);
            String linhaHeader = lista[0];

            Header header =  new Header
            {
                tipoRegistro = linhaHeader.Substring(0, 1),
                identificacaoArquivoRemessa = linhaHeader.Substring(1, 1),
                literalRemessa = linhaHeader.Substring(2, 7),
                codigoServico = linhaHeader.Substring(9, 2),
                literalServico = linhaHeader.Substring(11, 15),
                codEmpresa = linhaHeader.Substring(26, 20),
                nomeEmpresa = linhaHeader.Substring(46, 30),
                numeroBradesco = linhaHeader.Substring(76, 3),
                nomeBanco = linhaHeader.Substring(79, 15),
                dataGravacaoArquivo = linhaHeader.Substring(94, 6),
                densidadeDeGravacao= linhaHeader.Substring(100, 8),
                numAvisoBancario = linhaHeader.Substring(108, 5),
                branco = linhaHeader.Substring(113, 266),
                dataDoCredito = linhaHeader.Substring(379, 6),
                branco2 = linhaHeader.Substring(385, 9),
                numSequencialRegistro = linhaHeader.Substring(394, 6)
            };

            return header;
        }
    }
}
