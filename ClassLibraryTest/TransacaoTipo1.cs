using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo1
    {
        private string identificacaoRegistro;

        public string IdentificacaoRegistro
        {
            get { return identificacaoRegistro; }
            set { identificacaoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string agenciaPagador;

        public string AgenciaPagador
        {
            get { return agenciaPagador; }
            set { agenciaPagador = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgencia;

        public string DigitoAgencia
        {
            get { return digitoAgencia; }
            set { digitoAgencia = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string razaoConta;

        public string RazaoConta
        {
            get { return razaoConta; }
            set { razaoConta = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string contaCorrente;

        public string ContaCorrente
        {
            get { return contaCorrente; }
            set { contaCorrente = Util.FormataCampoComEspacosDireita(value, 7); }
        }

        private string digitoContaCorrente;

        public string DigitoContaCorrente
        {
            get { return digitoContaCorrente; }
            set { digitoContaCorrente = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoEmpresaBeneficiaria;

        public string IdentificacaoEmpresaBeneficiaria
        {
            get { return identificacaoEmpresaBeneficiaria; }
            set { identificacaoEmpresaBeneficiaria = Util.FormataCampoComEspacosDireita(value, 17); }
        }

        private string numeroControleParticipante;

        public string NumeroControleParticipante
        {
            get { return numeroControleParticipante; }
            set { numeroControleParticipante = Util.FormataCampoComEspacosDireita(value, 25); }
        }

        private string codigoBancoDebito;

        public string CodigoBancoDebito
        {
            get { return codigoBancoDebito; }
            set { codigoBancoDebito = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string multa;

        public string Multa
        {
            get { return multa; }
            set { multa = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string percentualMulta;

        public string PercentualMulta
        {
            get { return percentualMulta; }
            set { percentualMulta = Util.FormataCampoComEspacosDireita(value, 4); }
        }

        //TODO: efetuar o calculo do digito
        private string identificacaoTituloBanco;

        public string IdentificacaoTituloBanco
        {
            get { return identificacaoTituloBanco; }
            set { identificacaoTituloBanco = Util.FormataCampoComZerosEsquerda(value, 11); }
        }

        private string digitoAutoConferencia;

        public string DigitoAutoConferencia
        {
            get { return digitoAutoConferencia; }
            set { digitoAutoConferencia = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string descontoBonificacaoDia;

        public string DescontoBonificacaoDia
        {
            get { return descontoBonificacaoDia; }
            set { descontoBonificacaoDia = Util.FormataCampoComEspacosDireita(value, 10); }
        }

        private string condicaoEmissaoBoletoCobranca;

        public string CondicaoEmissaoBoletoCobranca
        {
            get { return condicaoEmissaoBoletoCobranca; }
            set { condicaoEmissaoBoletoCobranca = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string condicaoRegistroDebitoAutomatico;

        public string CondicaoRegistroDebitoAutomatico
        {
            get { return condicaoRegistroDebitoAutomatico; }
            set { condicaoRegistroDebitoAutomatico = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoOperacaoBanco;

        public string IdentificacaoOperacaoBanco
        {
            get { return identificacaoOperacaoBanco; }
            set { identificacaoOperacaoBanco = Util.FormataCampoComEspacosDireita(value, 10); }
        }

        private string indicadorRateioCredito;

        public string IndicadorRateioCredito
        {
            get { return indicadorRateioCredito; }
            set { indicadorRateioCredito = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string enderecamentoAvisoDebitoAutomatico;

        public string EnderecamentoAvisoDebitoAutomatico
        {
            get { return enderecamentoAvisoDebitoAutomatico; }
            set { enderecamentoAvisoDebitoAutomatico = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string pagamentoParcial;

        public string PagamentoParcial
        {
            get { return pagamentoParcial; }
            set { pagamentoParcial = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string identificacaoOcorrencia;

        public string IdentificacaoOcorrencia
        {
            get { return identificacaoOcorrencia; }
            set { identificacaoOcorrencia = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        //public Dictionary<string, string> IdentificacaoOcorrencia = new Dictionary<string, string>()
        //{
        //    { "Remessa", "01" },
        //    { "PedidoBaixa", "02" },
        //    { "PedidoProtestoFalimentar", "03" },
        //    { "ConcessaoAbatimento", "04" },
        //    { "CancelamentoAbatimentoConcedido", "05" },
        //    { "AlteracaoVencimento", "06" },
        //    { "AlteracaoControleParticipante", "07" },
        //    { "AlteracaoSeuNumero", "08" },
        //    { "PedidoProtesto", "09" },
        //    { "SustarProtestoBaixarTitulo", "18" },
        //    { "SustarProtestoManterCarteira", "19" },
        //    { "AlteracaoValor", "20" },
        //    { "AlteracaoValorComEmissaoBoleto", "21" },
        //    { "TransferenciaCessaoCreditoID", "22" },
        //    { "TransferenciaEntreCarteiras", "23" },
        //    { "DevTransferenciaEntreCarteiras", "24" },
        //    { "AlteracaoDeOutrosDados", "31" },
        //    { "PedidoNegativacao", "45" },
        //    { "ExcluirNegativacaoManterPendente", "46" },
        //    { "ExcluirNegativacaoManterPendente", "47" },
        //    { "AcertoDadosRateioCredito", "68" },
        //    { "CancelamentoRateioCredito", "69" }
        //};

        private string numeroDocumento;

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = Util.FormataCampoComEspacosDireita(value, 10); }
        }

        private string dataVencimentoTitulo;

        public string DataVencimentoTitulo
        {
            get { return dataVencimentoTitulo; }
            set { dataVencimentoTitulo = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string valorTitulo;

        public string ValorTitulo
        {
            get { return valorTitulo; }
            set { valorTitulo = Util.FormataCampoComZerosEsquerda(value, 13); }
        }

        private string bancoEncarregadoCobranca;

        public string BancoEncarregadoCobranca
        {
            get { return bancoEncarregadoCobranca; }
            set { bancoEncarregadoCobranca = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string agenciaDepositaria;

        public string AgenciaDepositaria
        {
            get { return agenciaDepositaria; }
            set { agenciaDepositaria = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string especieTitulo;

        public string EspecieTitulo
        {
            get { return especieTitulo; }
            set { especieTitulo = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string identificacao;

        public string Identificacao
        {
            get { return identificacao; }
            set { identificacao = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string dataEmissaoTitulo;

        public string DataEmissaoTitulo
        {
            get { return dataEmissaoTitulo; }
            set { dataEmissaoTitulo = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string primeiraInstrucao;

        public string PrimeiraInstrucao
        {
            get { return primeiraInstrucao; }
            set { primeiraInstrucao = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string segundaInstrucao;

        public string SegundaInstrucao
        {
            get { return segundaInstrucao; }
            set { segundaInstrucao = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string valorCobrarDiaAtraso;

        public string ValorCobrarDiaAtraso
        {
            get { return valorCobrarDiaAtraso; }
            set { valorCobrarDiaAtraso = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string dataLimiteConcessaoDesconto;

        public string DataLimiteConcessaoDesconto
        {
            get { return dataLimiteConcessaoDesconto; }
            set { dataLimiteConcessaoDesconto = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string valorDesconto;

        public string ValorDesconto
        {
            get { return valorDesconto; }
            set { valorDesconto = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string valorIOF;

        public string ValorIOF
        {
            get { return valorIOF; }
            set { valorIOF = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string valorAbatimento;

        public string ValorAbatimento
        {
            get { return valorAbatimento; }
            set { valorAbatimento = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string identificacaoTipoInscricao;

        public string IdentificacaoTipoInscricao
        {
            get { return identificacaoTipoInscricao; }
            set { identificacaoTipoInscricao = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string numeroInscricaoPagador;

        public string NumeroInscricaoPagador
        {
            get { return numeroInscricaoPagador; }
            set { numeroInscricaoPagador = Util.FormataCampoComEspacosDireita(value, 14); }
        }

        private string nomePagador;

        public string NomePagador
        {
            get { return nomePagador; }
            set { nomePagador = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string enderecoCompleto;

        public string EnderecoCompleto
        {
            get { return enderecoCompleto; }
            set { enderecoCompleto = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string primeiraMensagem;

        public string PrimeiraMensagem
        {
            get { return primeiraMensagem; }
            set { primeiraMensagem = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string sufixoCep;

        public string SufixoCep
        {
            get { return sufixoCep; }
            set { sufixoCep = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string segundaMensagem;

        public string SegundaMensagem
        {
            get { return segundaMensagem; }
            set { segundaMensagem = Util.FormataCampoComEspacosDireita(value, 60); }
        }

        public StringBuilder GetTransacao(TransacaoTipo1 stringTransacao)
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, stringTransacao.identificacaoRegistro);
            transacao.Insert(1, stringTransacao.agenciaPagador);
            transacao.Insert(6, stringTransacao.digitoAgencia);
            transacao.Insert(7, stringTransacao.razaoConta);
            transacao.Insert(12, stringTransacao.contaCorrente);
            transacao.Insert(19, stringTransacao.digitoContaCorrente);
            transacao.Insert(20, stringTransacao.identificacaoEmpresaBeneficiaria);
            transacao.Insert(37, stringTransacao.numeroControleParticipante);
            transacao.Insert(62, stringTransacao.codigoBancoDebito);
            transacao.Insert(65, stringTransacao.multa);
            transacao.Insert(66, stringTransacao.percentualMulta);
            transacao.Insert(70, stringTransacao.identificacaoTituloBanco);
            transacao.Insert(81, stringTransacao.digitoAutoConferencia);
            transacao.Insert(82, stringTransacao.descontoBonificacaoDia);
            transacao.Insert(92, stringTransacao.condicaoEmissaoBoletoCobranca);
            transacao.Insert(93, stringTransacao.condicaoRegistroDebitoAutomatico);
            transacao.Insert(94, stringTransacao.identificacaoOperacaoBanco);
            transacao.Insert(104, stringTransacao.indicadorRateioCredito);
            transacao.Insert(105, stringTransacao.enderecamentoAvisoDebitoAutomatico);
            transacao.Insert(106, stringTransacao.pagamentoParcial);
            transacao.Insert(108, stringTransacao.identificacaoOcorrencia);
            transacao.Insert(110, stringTransacao.numeroDocumento);
            transacao.Insert(120, stringTransacao.dataVencimentoTitulo);
            transacao.Insert(126, stringTransacao.valorTitulo);
            transacao.Insert(139, stringTransacao.bancoEncarregadoCobranca);
            transacao.Insert(142, stringTransacao.agenciaDepositaria);
            transacao.Insert(147, stringTransacao.especieTitulo);
            transacao.Insert(149, stringTransacao.identificacao);
            transacao.Insert(150, stringTransacao.dataEmissaoTitulo);
            transacao.Insert(156, stringTransacao.primeiraInstrucao);
            transacao.Insert(158, stringTransacao.segundaInstrucao);
            transacao.Insert(160, stringTransacao.valorCobrarDiaAtraso);
            transacao.Insert(173, stringTransacao.dataLimiteConcessaoDesconto);
            transacao.Insert(179, stringTransacao.valorDesconto);
            transacao.Insert(192, stringTransacao.valorIOF);
            transacao.Insert(205, stringTransacao.valorAbatimento);
            transacao.Insert(218, stringTransacao.identificacaoTipoInscricao);
            transacao.Insert(220, stringTransacao.numeroInscricaoPagador);
            transacao.Insert(234, stringTransacao.nomePagador);
            transacao.Insert(274, stringTransacao.enderecoCompleto);
            transacao.Insert(314, stringTransacao.primeiraMensagem);
            transacao.Insert(326, stringTransacao.cep);
            transacao.Insert(331, stringTransacao.sufixoCep);
            transacao.Insert(334, stringTransacao.segundaMensagem);

            return transacao;
        }

    }
}
