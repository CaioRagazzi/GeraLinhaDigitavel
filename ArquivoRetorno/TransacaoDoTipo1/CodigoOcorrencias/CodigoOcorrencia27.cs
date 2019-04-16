using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno.TransacaoDoTipo1
{
    public enum CodigoOcorrencia27
    {
        CodigoDeOcorrenciaNaoPermitidoParaACarteira = 4,
        AgenciaContaDigitoInvalidos = 7,
        NossoNumeroInvalido = 8,
        CarteiraInvalida = 10,
        CarteiraAgenciaContaNossoNumeroInvalidos = 15,
        TituloComOrdemDeProtestoEmitido = 40,
        CodigoParaBaixaDevolucaoViaTeleBradescoInvalido = 42,
        MovimentoParaTituloNaoCadastrado = 60,
        TransferenciaParaDescontoNaoPermitidoParaCarteira = 77,
        TituloComPagamentoVinculado = 85
    }
}
