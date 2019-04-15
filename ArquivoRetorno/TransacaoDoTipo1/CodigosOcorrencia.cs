using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno.TransacaoDoTipo1
{
    public enum CodigosOcorrencia
    {
        OcorrenciaAceita = 0,
        CodigoDoBancoInvalido = 1,
        CodigoDoMovimentoNaoPermitidoParaACarteira = 4,
        CaracteristicasDaCobrancaIncompativeis = 15,
        DataDeVencimentoAnteriorADataDeEmissao = 17,
        EspecieDoTituloInvalido = 21,
        DataDaEmissaoInvalida = 24,
        ValorTaxaDeJurosMoraInvalido = 27,
        PrazoParaProtestoNegativacaoInvalidoAlterado = 38,
        PedidoParaProtestoNegativacaoNaoPermitidoParaOTituloAlterado = 39,
        PrazoParaBaixaEDevolucaoInvalido = 43,
        NomeDoPagadorInvalido = 45,
        TipoNumDeInscricaoDoPagadorInvalidos = 46,
        EnderecoDoPagadorNaoInformado = 47,
        CEPInvalido = 48,
        CEPReferenteABancoCorrespondente = 50,
        NumDeInscricaoDoPagadorAvalistaInvalidosCPFCNPJ = 53,
        PagadorAvalistaNaoInformado = 54,
        DebitoAutomaticoAgendado = 67,
        DebitoNaoagendadoErroNosDadosDeRemessa = 68,
        DebitoNaoagendadoPagadorNaoConstaNoCadastroDeAutorizante = 69,
        DebitoNaoagendadoBeneficiarioNaoAutorizadoPeloPagador = 70,
        DebitoNaoagendadoBeneficiarioNaoParticipaDaModalidadeDeDebAutomatico = 71,
        DebitoNaoagendadoCodigoDeMoedaDiferenteDeR = 72,
        DebitoNaoagendadoDataDeVencimentoInvalidaVencida = 73,
        DebitoNaoagendadoTipoDoNumeroDeInscricaoDoPagadorDebitadoInvalido = 75,
        DebitoEletronicoDDA = 76,
        SeuNumeroDoDocumentoInvalido = 86,
        EmailPagadorNaoEnviadoTituloComDebitoAutomatico = 89,
        EmailpagadorNaoEnviadoTituloDeCobrancaSemregistro = 90
    }
}
