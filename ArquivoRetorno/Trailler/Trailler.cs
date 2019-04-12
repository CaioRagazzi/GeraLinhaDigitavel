using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno
{
    public class Trailler
    {
        private string IdentificacaoRegistro { get; set; }
        private string IdentificacaoDoRetorno { get; set; }
        private string IdentificacaoTipoRegistro { get; set; }
        private string CodigoBanco { get; set; }
        private string Brancos { get; set; }
        private string QuantidadeTitulosCobranca { get; set; }
        private string ValorTotalCobranca { get; set; }
        private string NumAvisoBancario { get; set; }
        private string Brancos2 { get; set; }
        private string QuantidadeRegistrosOcorrencia2ConfirmacaoEntradas { get; set; }
        private string ValorRegistrosOcorrencia2ConfirmacaoEntradas { get; set; }
        private string ValorRegistrosOcorrencia6Liquidacao { get; set; }
        private string QuantidadeRegistrosOcorrencia6Liquidacao { get; set; }
        private string ValorRegistrosOcorrencia6 { get; set; }
        private string QuantidadeRegistrosOcorrencia9E10TitulosBaixados { get; set; }
        private string ValorDosRegistrosOcorrencia9E10TitulosBaixados { get; set; }
        private string QuantidadeRegistrosOcorrencia13AbatimentoCancelado { get; set; }
        private string ValorRegistrosOcorrencia13AbatimentoCancelado { get; set; }
        private string QuantidadeRegistrosOcorrencia14VencimentoAlterado { get; set; }
        private string ValorRegistrosOcorrencia14VencimentoAlterado { get; set; }
        private string QuantidadeRegistrosOcorrencia12AbatimentoConcedido { get; set; }
        private string ValorRegistrosOcorrencia12AbatimentoConcedido { get; set; }
        private string QuantidadeRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto { get; set; }
        private string ValorRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto { get; set; }
        private string Brancos3 { get; set; }
        private string ValorTotalRateiosEfetuados { get; set; }
        private string QuantidadeTotalRateiosEfetuados { get; set; }
        private string Brancos4 { get; set; }
        private string NumSequencialRegistro { get; set; }

        public Trailler GetTrailler(string path)
        {
            List<String> lista = UtilRemessa.FormataArquivo.LeArquivoRetorno(path);
            String linhaTrailler = lista[lista.Count -1];

            Trailler trailler = new Trailler
            {
                IdentificacaoRegistro = linhaTrailler.Substring(0, 1),
                IdentificacaoDoRetorno = linhaTrailler.Substring(1, 1),
                IdentificacaoTipoRegistro = linhaTrailler.Substring(2, 2),
                CodigoBanco = linhaTrailler.Substring(4, 3),
                Brancos = linhaTrailler.Substring(7, 10),
                QuantidadeTitulosCobranca = linhaTrailler.Substring(17, 8),
                ValorTotalCobranca = linhaTrailler.Substring(25, 14),
                NumAvisoBancario = linhaTrailler.Substring(39, 8),
                Brancos2 = linhaTrailler.Substring(47, 10),
                QuantidadeRegistrosOcorrencia2ConfirmacaoEntradas = linhaTrailler.Substring(57, 5),
                ValorRegistrosOcorrencia2ConfirmacaoEntradas = linhaTrailler.Substring(62, 12),
                ValorRegistrosOcorrencia6Liquidacao = linhaTrailler.Substring(74, 12),
                QuantidadeRegistrosOcorrencia6Liquidacao = linhaTrailler.Substring(86, 5),
                ValorRegistrosOcorrencia6 = linhaTrailler.Substring(91, 12),
                QuantidadeRegistrosOcorrencia9E10TitulosBaixados = linhaTrailler.Substring(103, 5),
                ValorDosRegistrosOcorrencia9E10TitulosBaixados = linhaTrailler.Substring(108, 12),
                QuantidadeRegistrosOcorrencia13AbatimentoCancelado = linhaTrailler.Substring(120, 5),
                ValorRegistrosOcorrencia13AbatimentoCancelado = linhaTrailler.Substring(125, 12),
                QuantidadeRegistrosOcorrencia14VencimentoAlterado = linhaTrailler.Substring(137, 5),
                ValorRegistrosOcorrencia14VencimentoAlterado = linhaTrailler.Substring(142, 12),
                QuantidadeRegistrosOcorrencia12AbatimentoConcedido = linhaTrailler.Substring(154, 5),
                ValorRegistrosOcorrencia12AbatimentoConcedido = linhaTrailler.Substring(159, 12),
                QuantidadeRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto = linhaTrailler.Substring(171, 5),
                ValorRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto = linhaTrailler.Substring(176, 12),
                Brancos3 = linhaTrailler.Substring(188, 174),
                ValorTotalRateiosEfetuados = linhaTrailler.Substring(362, 15),
                QuantidadeTotalRateiosEfetuados = linhaTrailler.Substring(377, 8),
                Brancos4 = linhaTrailler.Substring(385, 9),
                NumSequencialRegistro = linhaTrailler.Substring(394, 6)
            };

            return trailler;
        }
    }
}
