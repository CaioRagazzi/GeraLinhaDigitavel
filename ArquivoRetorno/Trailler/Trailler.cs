using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno
{
    public class Trailler
    {
        public string IdentificacaoRegistro { get; set; }
        public string IdentificacaoDoRetorno { get; set; }
        public string IdentificacaoTipoRegistro { get; set; }
        public string CodigoBanco { get; set; }
        public string Brancos { get; set; }
        public string QuantidadeTitulosCobranca { get; set; }
        public string ValorTotalCobranca { get; set; }
        public string NumAvisoBancario { get; set; }
        public string Brancos2 { get; set; }
        public string QuantidadeRegistrosOcorrencia2ConfirmacaoEntradas { get; set; }
        public string ValorRegistrosOcorrencia2ConfirmacaoEntradas { get; set; }
        public string ValorRegistrosOcorrencia6Liquidacao { get; set; }
        public string QuantidadeRegistrosOcorrencia6Liquidacao { get; set; }
        public string ValorRegistrosOcorrencia6 { get; set; }
        public string QuantidadeRegistrosOcorrencia9E10TitulosBaixados { get; set; }
        public string ValorDosRegistrosOcorrencia9E10TitulosBaixados { get; set; }
        public string QuantidadeRegistrosOcorrencia13AbatimentoCancelado { get; set; }
        public string ValorRegistrosOcorrencia13AbatimentoCancelado { get; set; }
        public string QuantidadeRegistrosOcorrencia14VencimentoAlterado { get; set; }
        public string ValorRegistrosOcorrencia14VencimentoAlterado { get; set; }
        public string QuantidadeRegistrosOcorrencia12AbatimentoConcedido { get; set; }
        public string ValorRegistrosOcorrencia12AbatimentoConcedido { get; set; }
        public string QuantidadeRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto { get; set; }
        public string ValorRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto { get; set; }
        public string Brancos3 { get; set; }
        public string ValorTotalRateiosEfetuados { get; set; }
        public string QuantidadeTotalRateiosEfetuados { get; set; }
        public string Brancos4 { get; set; }
        public string NumSequencialRegistro { get; set; }

        public Trailler GetTrailler(string stringTrailler)
        {
            Trailler trailler = new Trailler
            {
                IdentificacaoRegistro = stringTrailler.Substring(0, 1),
                IdentificacaoDoRetorno = stringTrailler.Substring(1, 1),
                IdentificacaoTipoRegistro = stringTrailler.Substring(2, 2),
                CodigoBanco = stringTrailler.Substring(4, 3),
                Brancos = stringTrailler.Substring(7, 10),
                QuantidadeTitulosCobranca = stringTrailler.Substring(17, 8),
                ValorTotalCobranca = stringTrailler.Substring(25, 14),
                NumAvisoBancario = stringTrailler.Substring(39, 8),
                Brancos2 = stringTrailler.Substring(47, 10),
                QuantidadeRegistrosOcorrencia2ConfirmacaoEntradas = stringTrailler.Substring(57, 5),
                ValorRegistrosOcorrencia2ConfirmacaoEntradas = stringTrailler.Substring(62, 12),
                ValorRegistrosOcorrencia6Liquidacao = stringTrailler.Substring(74, 12),
                QuantidadeRegistrosOcorrencia6Liquidacao = stringTrailler.Substring(86, 5),
                ValorRegistrosOcorrencia6 = stringTrailler.Substring(91, 12),
                QuantidadeRegistrosOcorrencia9E10TitulosBaixados = stringTrailler.Substring(103, 5),
                ValorDosRegistrosOcorrencia9E10TitulosBaixados = stringTrailler.Substring(108, 12),
                QuantidadeRegistrosOcorrencia13AbatimentoCancelado = stringTrailler.Substring(120, 5),
                ValorRegistrosOcorrencia13AbatimentoCancelado = stringTrailler.Substring(125, 12),
                QuantidadeRegistrosOcorrencia14VencimentoAlterado = stringTrailler.Substring(137, 5),
                ValorRegistrosOcorrencia14VencimentoAlterado = stringTrailler.Substring(142, 12),
                QuantidadeRegistrosOcorrencia12AbatimentoConcedido = stringTrailler.Substring(154, 5),
                ValorRegistrosOcorrencia12AbatimentoConcedido = stringTrailler.Substring(159, 12),
                QuantidadeRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto = stringTrailler.Substring(171, 5),
                ValorRegistrosOcorrencia19ConfirmacaoInstrucaoProtesto = stringTrailler.Substring(176, 12),
                Brancos3 = stringTrailler.Substring(188, 174),
                ValorTotalRateiosEfetuados = stringTrailler.Substring(362, 15),
                QuantidadeTotalRateiosEfetuados = stringTrailler.Substring(377, 8),
                Brancos4 = stringTrailler.Substring(385, 9),
                NumSequencialRegistro = stringTrailler.Substring(394, 6)
            };

            return trailler;
        }
    }
}
