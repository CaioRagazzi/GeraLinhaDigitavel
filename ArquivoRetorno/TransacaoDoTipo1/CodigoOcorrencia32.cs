using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno.TransacaoDoTipo1
{
    public enum CodigoOcorrencia32
    {
        CodigoDoBancoInvalido = 1,
        CodigoDoRegistroDetalheInvalido = 2,
        CodigoOcorrenciaNaoPermitidoParaCarteira = 4,
        CodigoOcorrenciaNaoNumerico = 5,
        AgenciaContaDigitoInvalidos = 7,
        NossoNumeroInvalido = 8,
        CarteiraInvalida = 10,
        CaracteristicasDaCobranaaIncompativeis = 15,
        DataVencimentoInvalida = 16,
        DataVencimentoAnteriorDataEmissao = 17,
        VencimentoForaPrazoOperacao = 18,
        ValorTituloInvalido = 20,
        EspecieTituloInvalida = 21,
        EspecieNaoPermitidaParaCarteira = 22,
        DataEmissaoInvalida = 24,
        CodigoDescontoTelebradescoInvalido = 28,
        ValorDescontoMaiorIgualValorTitulo = 29,
        DescontoConcederNaoConfere = 30,
        ConcessaoDescontoJaExisteDescontoAnterior = 31,
        ValorAbatimentoInvalido = 33,
        ValorAbatimentoMaiorIgualValorTitulo = 34,
        ConcessaoAbatimentoJaExisteAbatimentoAnterior = 36,
        PrazoParaProtestoNegativacaoInvalido = 38,
        PedidoParaProtestoNegativacaoNaoPermitidoParaTitulo = 39,
        TituloComOrdemPedidoDeProtestoNegativacaoEmitido = 40,
        PedidoSustacaoExclParaTituloSemInstrucaoProtestoNegativacao = 41,
        CodigoParaBaixaDevolucaoInvalido = 42,
        NomePagadorNaoInformado = 45,
        TipoNumeroInscricaoPagadorInvalidos = 46,
        EnderecoPagadorNaoInformado = 47,
        CEPInvalido = 48,
        CEPReferenteBancoCorrespondente = 50,
        TipoInscricaoPagadorAvalistaInvalidos = 53,
        MovimentoParaTituloNaoCadastrado = 60,
        TituloComPagamentoVinculado = 85,
        SeuNumeroInvalido = 86,
        TituloPenhoradoInstrucaoNaoLiberadaPelaAgencia = 94,
        InstrucaoNaoPermitidaTituloNegativado = 97,
        InclusaoBloqueadaFaceDeterminacaoJudicial = 98,
        TelefoneBeneficiarioNaoInformadoInconsistente = 99,
    }
}
