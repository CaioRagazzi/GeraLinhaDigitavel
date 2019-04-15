using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno.TransacaoDoTipo1
{
    public enum IdentificacoesDeOcorrencia
    {
        SemMotivo = 0,
        EntradaConfirmada = 2,
        EntradaRejeitada = 3,
        LiquidacaoNormal = 6,
        BaixadoAutomatViaArquivo = 9,
        BaixadoConformeInstrucoesDaAgEncia = 10,
        ArquivoDeTitulosPendentes = 11,
        AbatimentoConcedido = 12,
        AbatimentoCancelado = 13,
        VencimentoAlterado = 14,
        LiquidacaoEmCartorio = 15,
        TituloPagoEmChequeVinculado = 16,
        LiquidacaoAposBaixaOuTituloNaoRegistrado = 17,
        AcertoDeDepositaria = 18,
        ConfirmacaoRecebInstDeProtesto = 19,
        ConfirmacaoRecebimentoInstrucaoSustacaoDeProtesto = 20,
        AcertoDoControleDoParticipante = 21,
        TituloComPagamentoCancelado = 22,
        EntradaDoTituloEmCartorio = 23,
        EntradaRejeitadaPorCEPIrregular = 24,
        ConfirmacaoRecebInstDeProtestoFalimentar = 25,
        BaixaRejeitada = 27,
        DebitoDetarifasCustas = 28,
        OcorrenciasDoPagador = 29,
        AlteracaoDeOutrosDadosRejeitados = 30,
        InstrucaoRejeitada = 32,
        ConfirmacaoPedidoAlteracaoOutrosDados = 33,
        RetiradoDeCartorioEManutencaoCarteira = 34,
        DesagendamentoDoDebitoAutomatico = 35,
        EstornoDePagamento = 40,
        SustadoJudicial = 55,
        AcertoDosDadosDoRateioDeCredito = 68,
        CancelamentoDosDadosDoRateio = 69,
        ConfirmacaoRecebPedidoDeNegativacao = 73,
        ConfirmPedidoDeExclDeNegat = 74
    }
}
