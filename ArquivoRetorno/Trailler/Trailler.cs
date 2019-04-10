using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno
{
    public class Trailler
    {
        private string identificacaoRegistro;
        private string identificacaoDoRetorno;
        private string identificacaoTipoRegistro;
        private string codigoBanco;
        private string brancos;
        private string quantidadeTitulosCobranca;
        private string valorTotalCobranca;
        private string numAvisoBancario;
        private string brancos2;
        private string quantidadeRegistrosOcorrencia2ConfirmacaoEntradas;
        private string valorRegistrosOcorrencia2ConfirmacaoEntradas;
        private string valorRegistrosOcorrencia6Liquidacao;
        private string quantidadeRegistrosOcorrencia6Liquidacao;
        private string valorRegistrosOcorrencia6;
        private string quantidadeRegistrosOcorrencia9E10TitulosBaixados;
        private string valorDosRegistrosOcorrencia9E10TitulosBaixados;
        private string quantidadeRegistrosOcorrencia13AbatimentoCancelado;
        private string valorRegistrosOcorrencia13AbatimentoCancelado;
        private string quantidadeRegistrosOcorrencia14VencimentoAlterado;
        private string valorRegistrosOcorrencia14VencimentoAlterado;
        private string quantidadeRegistrosOcorrencia12AbatimentoConcedido;
        private string valorRegistrosOcorrencia12AbatimentoConcedido;
        private string quantidadeRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto;
        private string valorRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto;
        private string brancos3;
        private string valorTotalRateiosEfetuados;
        private string quantidadeTotalRateiosEfetuados;
        private string brancos4;
        private string numSequencialRegistro;

        public Trailler GetTrailler(string path)
        {
            List<String> lista = Util.FormataArquivo.LeArquivoRetorno(path);
            String linhaTrailler = lista[lista.Count -1];

            Trailler trailler = new Trailler
            {
                identificacaoRegistro = linhaTrailler.Substring(0, 1),
                identificacaoDoRetorno = linhaTrailler.Substring(1, 1),
                identificacaoTipoRegistro = linhaTrailler.Substring(2, 2),
                codigoBanco = linhaTrailler.Substring(4, 3),
                brancos = linhaTrailler.Substring(7, 10),
                quantidadeTitulosCobranca = linhaTrailler.Substring(17, 8),
                valorTotalCobranca = linhaTrailler.Substring(25, 14),
                numAvisoBancario = linhaTrailler.Substring(39, 8),
                brancos2 = linhaTrailler.Substring(47, 10),
                quantidadeRegistrosOcorrencia2ConfirmacaoEntradas = linhaTrailler.Substring(57, 5),
                valorRegistrosOcorrencia2ConfirmacaoEntradas = linhaTrailler.Substring(62, 12),
                valorRegistrosOcorrencia6Liquidacao = linhaTrailler.Substring(74, 12),
                quantidadeRegistrosOcorrencia6Liquidacao = linhaTrailler.Substring(86, 5),
                valorRegistrosOcorrencia6 = linhaTrailler.Substring(91, 12),
                quantidadeRegistrosOcorrencia9E10TitulosBaixados = linhaTrailler.Substring(103, 5),
                valorDosRegistrosOcorrencia9E10TitulosBaixados = linhaTrailler.Substring(108, 12),
                quantidadeRegistrosOcorrencia13AbatimentoCancelado = linhaTrailler.Substring(120, 5),
                valorRegistrosOcorrencia13AbatimentoCancelado = linhaTrailler.Substring(125, 12),
                quantidadeRegistrosOcorrencia14VencimentoAlterado = linhaTrailler.Substring(137, 5),
                valorRegistrosOcorrencia14VencimentoAlterado = linhaTrailler.Substring(142, 12),
                quantidadeRegistrosOcorrencia12AbatimentoConcedido = linhaTrailler.Substring(154, 5),
                valorRegistrosOcorrencia12AbatimentoConcedido = linhaTrailler.Substring(159, 12),
                quantidadeRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto = linhaTrailler.Substring(171, 5),
                valorRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto = linhaTrailler.Substring(176, 12),
                brancos3 = linhaTrailler.Substring(188, 174),
                valorTotalRateiosEfetuados = linhaTrailler.Substring(362, 15),
                quantidadeTotalRateiosEfetuados = linhaTrailler.Substring(377, 8),
                brancos4 = linhaTrailler.Substring(385, 9),
                numSequencialRegistro = linhaTrailler.Substring(394, 6)
            };

            return trailler;
        }
    }
}
