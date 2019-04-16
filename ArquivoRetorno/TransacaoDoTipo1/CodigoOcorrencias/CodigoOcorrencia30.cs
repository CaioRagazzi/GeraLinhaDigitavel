using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno.TransacaoDoTipo1
{
    public enum CodigoOcorrencia30
    {
        CodigoDoBancoInvalido = 1,
        CodigoDeOcorrenciaNaoPermitidoParaACarteira = 4,
        CodigoDaOcorrenciaNaoNumerico = 5,
        NossoNumeroInvalido = 8,
        CaracteristicaDaCobrancaIncompativel = 15,
        DataDeVencimentoInvalido = 16,
        DataDeVencimentoAnteriorADataDeEmissao = 17,
        VencimentoForaDoPrazoDeOperacao = 18,
        DataDeEmissaoInvalida = 24,
        CodigoDeJurosDeMoraInvalido = 26,
        ValorTaxaDeJurosDeMoraInvalido = 27,
        CodigoDeDescontoInvalido = 28,
        ValorDoDescontoMaiorIgualAoValorDoTitulo = 29,
        DescontoAConcederNaoConfere = 30,
        ConcessaoDeDescontoJaExistenteDescontoAnterior = 31,
        ValorIOFInvalido = 32,
        ValorAbatimentoInvalido = 33,
        ValorAbatimentoMaiorIgualAoValorDoTitulo = 34,
        PrazoParaProtestoNegativacaoInvalido = 38,
        PedidoParaProtestoNegativacaoNaoPermitidoParaOTitulo = 39,
        TituloComOrdemPedidoDeProtestoNegativacaoEmitido = 40,
        CodigoParaBaixaDevolucaoInvalido = 42,
        TipoNumeroDeInscricaoDoPagadorInvalidos = 46,
        CepInvalido = 48,
        TipoNumeroDeInscricaoDoPagadorAvalistaInvalidos = 53,
        PagadorrAvalistaNaoInformado = 54,
        CodigoDaMultaInvalido = 57,
        DataDaMultaInvalida = 58,
        MovimentoParaTituloNaoCadastrado = 60,
        DataJurosMoraInvalida = 79,
        DataDescontoInvalida = 80,
        TituloPagamentoVinculado = 85,
        EmailPagadorNaoLidoNoPrazoCincoDias = 88,
        EmailPagadorNaoRecebido = 91
    }
}
