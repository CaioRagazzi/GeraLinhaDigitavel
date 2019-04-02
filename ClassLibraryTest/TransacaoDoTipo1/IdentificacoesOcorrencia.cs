using System;
using System.Collections.Generic;
using System.Text;

namespace TransacaoDoTipo1
{
    public enum IdentificacoesOcorrencia
    {
        Remessa = 1,
        PedidoDeBaixa = 2,
        PedidoDeProtestoFalimentar = 3,
        ConcessaoDeAbatimento = 4,
        CancelamentoDeAbatimentoConcedido = 5,
        AlteracaDeVencimento = 6,
        AlteracaoDoControleDoParticipante = 7,
        AlteracaoDeSeuNumero = 8,
        PedidoDeProtesto = 9,
        SustarProtestoEBaixarTitulo = 18,
        SustarProtestoEManterEmCarteira = 19,
        AlteracaoValor = 20,
        AlteracaoValorComEmissaoDeBoletoQuandoEmissaoPeloBanco = 21,
        TransferenciaCessaoCreditoIDProd = 22,
        TransferenciaEntreCarteiras = 23,
        DevTransferenciaEntreCarteiras = 24,
        AlteracaoOutrosDados = 31,
        PedidoNegativacao = 45,
        ExcluirNegativacaoComBaixa = 46,
        ExcluirNegativacaoManterPendente = 47,
        AcertoDadosRateioCredito = 68,
        CancelamentoRateioCredito = 69
    }
}
