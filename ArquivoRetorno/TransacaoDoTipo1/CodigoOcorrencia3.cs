using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno.TransacaoDoTipo1
{
    public enum CodigoOcorrencia3
    {
        CodigoDoRegistroDetalheInvalido = 2,
        CodigoDaOcorrenciaInvalida = 3,
        CodigoDeOcorrenciaNaoPermitidaParaACarteira = 4,
        CodigoDeOcorrenciaNaoNumerico = 5,
        AgenciaContaDigitoInvalido = 7,
        NossoNumeroInvalido = 8,
        NossoNumeroDuplicado = 9,
        CarteiraInvalida = 10,
        IdentificacaoDaEmissaoDoBloquetoInvalida = 13,
        DataDeVencimentoInvalida = 16,
        VencimentoForaDoPrazoDeOperacao = 18,
        ValorDoTituloInvalido = 20,
        EspecieDoTituloInvalida = 21,
        EspecieNaoPermitidaParaACarteira = 22,
        DataDeEmissaoInvalida = 24,
        CodigoDoDescontoInvalido = 28,
        PrazoParaProtestoNegativacaoInvalido = 38,
        AgenciaBeneficiarioNaoPrevista = 44,
        NomeDoPagadorNaoInformado = 45,
        TipoNumeroDeInscricaoDoPagadorInvalidos = 46,
        EnderecoDoPagadorNaoInformadoTres = 47,
        CEPInvalidoTres = 48,
        CEPIrregularBancoCorrespondente = 50,
        EntradaParaTituloJacadastrado = 63,
        LimiteExcedido = 65,
        NumeroAutorizacaoInexistente = 66,
        DebitoNaoAgendadoerroNosDadosDeRemessa = 68,
        DebitoNaoAgendadoPagadorNaoConstaNoCadastroDeAutorizante = 69,
        DebitoNaoAgendadoBeneficiarioNaoAutorizadoPeloPagador = 70,
        DebitoNaoAgendadoBeneficiarioNaoParticipaDoDebitoAutomatico = 71,
        DebitoNaoAgendadoCodigoDeMoedaDiferenteDeR = 72,
        DebitoNaoAgendadoDataDeVencimentoInvalida = 73,
        DebitoNaoAgendadoConformeSeuPedidoTituloNaoRegistrado = 74,
        DebitoNaoAgendadoTipoDeNumeroDeInscricaoDoDebitadoInvalido = 75,
    }
}
