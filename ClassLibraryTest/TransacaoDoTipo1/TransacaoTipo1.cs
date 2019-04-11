using System;
using System.Collections.Generic;
using System.Text;
using TransacaoDoTipo1;
using UtilRemessa;

namespace ArquivoRemessa
{
    public class TransacaoTipo1
    {
        #region propriedades

        private const string tipoRegistro = "1";

        public DebitoAutomaticoCC DebitoAutomatico { get; set; }

        public EmpresaBeneficiariaBanco BeneficiariaBanco { get; set; }

        private string numeroControleParticipante;
        /// <summary>
        /// Nº Controle do Participante. Campo destinado para uso da Empresa, A informação que constar do Arquivo Remessa será confirmada no Arquivo Retorno, Não será impresso nos boletos de cobrança.
        /// </summary>
        public string NumeroControleParticipante
        {
            get { return numeroControleParticipante; }
            set { numeroControleParticipante = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(value, 25); }
        }

        private string codigoBancoDebito;
        /// <summary>
        /// Código do Banco a ser debitado na Câmara de Compensação. 
        /// Deverão ser informados 237, caso o cliente Beneficiário tenha optado pelo débito automático em
        /// Conta do Pagador.
        /// Para Títulos em que não deve ser aplicado o débito automático, este campo deverá ser preenchido
        /// com Zeros.
        /// </summary>
        public string CodigoBancoDebito
        {
            get { return codigoBancoDebito; }
            set { codigoBancoDebito = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        public Multa multa { get; set; }

        private decimal percentualMulta;
        /// <summary>
        /// Percentual de multa a ser considerado. Se campo 66 a 66 = 0, preencher com zeros. Se campo 66 a 66 = 2, preencher com percentual da multa com 2 decimais
        /// Exemplos de multas: [[90% = 90.00m], [37,5% = 37.50m], [15,96% = 15.96m]]
        /// </summary>
        public decimal PercentualMulta
        {
            get { return percentualMulta; }
            set { percentualMulta = value; }
        }

        private string identificacaoTituloBanco;
        /// <summary>
        /// Número Bancário para Cobrança Com e Sem Registro. 
        /// Campo reservado para o Nosso Número do Título (Número Bancário), cujo procedimento a ser adotado deve obedecer aos itens a seguir:
        /// </summary>
        public string IdentificacaoTituloBanco
        {
            get { return identificacaoTituloBanco; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception($"Nosso número deve conter 11 dígitos, possui {value.Length}");
                }
                identificacaoTituloBanco = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(value, 11);
            }
        }

        private string digitoAutoConferencia;

        public string DigitoAutoConferencia
        {
            get { return digitoAutoConferencia; }
            set { digitoAutoConferencia = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }

        private decimal descontoBonificacaoDia;
        /// <summary>
        /// Valor do desconto bonif./dia.
        /// Exemplos de multas: [[90% = 90.00m], [37,5% = 37.50m], [15,96% = 15.96m]]
        /// </summary>
        public decimal DescontoBonificacaoDia
        {
            get { return descontoBonificacaoDia; }
            set { descontoBonificacaoDia = value; }
        }

        public EmissaoBoletoCobranca condicaoEmissaoBoletoCobranca;

        private string condicaoRegistroDebitoAutomatico;
        /// <summary>
        /// Quando igual a “N” e os dados do débito estiverem incorretos, rejeita o registro na cobrança e não emite Boleto de cobrança;
        /// Quando diferente de “N” e os dados do débito estiverem incorretos, registra na cobrança e emite Boleto de cobrança.Nesta condição, não ocorrerá o agendamento do debito.
        /// </summary>
        public string CondicaoRegistroDebitoAutomatico
        {
            get { return condicaoRegistroDebitoAutomatico; }
            set { condicaoRegistroDebitoAutomatico = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoOperacaoBanco = "          ";

        private string indicadorRateioCredito;
        /// <summary>
        /// Indicador Rateio Crédito (opcional). “R”. Somente deverá ser preenchido com a Letra “R”, se a Empresa contratou o serviço de rateio de crédito, caso não, informar Branco
        /// </summary>
        public string IndicadorRateioCredito
        {
            get { return indicadorRateioCredito; }
            set { indicadorRateioCredito = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }

        private string enderecamentoAvisoDebitoAutomatico;
        /// <summary>
        /// 1 = emite aviso, e assume o endereço do Pagador constante do Arquivo-Remessa;
        /// 2 = não emite aviso;
        ///Diferente de 1 ou 2 = emite e assume o endereço do cliente debitado, constante do cadastro do Banco.
        /// </summary>
        public string EnderecamentoAvisoDebitoAutomatico
        {
            get { return enderecamentoAvisoDebitoAutomatico; }
            set { enderecamentoAvisoDebitoAutomatico = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }

        private string pagamentoParcial;
        /// <summary>
        /// Somente deverá ser preenchido com a quantidade de parcelas para pagamento, se a Empresa contratou o serviço Pagamento Parcial, caso não, informar Branco. Quantidade mínima de parcelas = 01 Quantidade máxima de parcelas = 99.
        /// </summary>
        public string PagamentoParcial
        {
            get { return pagamentoParcial; }
            set { pagamentoParcial = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 2); }
        }

        public IdentificacoesOcorrencia identificacaoOcorrencia;

        private string numeroDocumento;
        /// <summary>
        /// Documento
        /// </summary>
        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 10); }
        }

        private DateTime dataVencimentoTitulo;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public DateTime DataVencimentoTitulo
        {
            get { return dataVencimentoTitulo; }
            set { dataVencimentoTitulo = value; }
        }

        private decimal valorTitulo;
        /// <summary>
        /// Valor do Título (preencher sem ponto e sem vírgula) 
        /// Exemplos de multas: [[90% = 90.00m], [37,5% = 37.50m], [15,96% = 15.96m]]
        /// </summary>
        public decimal ValorTitulo
        {
            get { return valorTitulo; }
            set { valorTitulo = value; }
        }

        private string bancoEncarregadoCobranca;
        /// <summary>
        /// Preencher com zeros
        /// </summary>
        public string BancoEncarregadoCobranca
        {
            get { return bancoEncarregadoCobranca; }
            set { bancoEncarregadoCobranca = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        private string agenciaDepositaria;
        /// <summary>
        /// Preencher com zeros 
        /// </summary>
        public string AgenciaDepositaria
        {
            get { return agenciaDepositaria; }
            set { agenciaDepositaria = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 5); }
        }

        public EspecieTitulo especieTitulo;

        private string identificacao = "N";

        private DateTime dataEmissaoTitulo;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public DateTime DataEmissaoTitulo
        {
            get { return dataEmissaoTitulo; }
            set { dataEmissaoTitulo = value; }
        }

        public Protestos primeiraInstrucao;

        private string segundaInstrucao;
        /// <summary>
        /// Campo destinado para pré-determinar o protesto do Título ou a baixa por decurso de prazo, quando do registro. Não havendo interesse, preencher com Zeros. Porém, caso a Empresa deseje se utilizar da instrução automática de protesto ou da baixa por
        ///decurso de prazo, abaixo os procedimentos:
        /// </summary>
        public string SegundaInstrucao
        {
            get { return segundaInstrucao; }
            set { segundaInstrucao = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 2); }
        }

        private decimal valorCobrarDiaAtraso;
        /// <summary>
        /// Campo destinado para o Beneficiário informar o valor da mora dia a ser cobrado do Pagador, no
        ///caso de pagamento com atraso(somente valor).
        ///Porém, caso o Beneficiário não queira informar o valor da mora dia, no Arquivo Remessa,
        ///poderemos calculá-lo e imprimi-lo, contudo torna-se necessário informar o valor de sua taxa de juros
        ///mensal, através de carta, a qual deverá ser encaminhada para a nossa Agência, para o efetivo cadastramento.
        ///Nota: Emissão dos boletos pelo próprio cliente. Quando houver Comissão de Permanência a ser
        ///cobrado por dia de atraso, será obrigatória a informação desse valor no arquivo remessa.
        /// </summary>
        public decimal ValorCobrarDiaAtraso
        {
            get { return valorCobrarDiaAtraso; }
            set { valorCobrarDiaAtraso = value; }
        }

        private DateTime dataLimiteConcessaoDesconto;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public DateTime DataLimiteConcessaoDesconto
        {
            get { return dataLimiteConcessaoDesconto; }
            set { dataLimiteConcessaoDesconto = value; }
        }

        private decimal valorDesconto;
        /// <summary>
        /// Valor Desconto 
        /// Exemplos de multas: [[90% = 90.00m], [37,5% = 37.50m], [15,96% = 15.96m]]
        /// </summary>
        public decimal ValorDesconto
        {
            get { return valorDesconto; }
            set { valorDesconto = value; }
        }

        private decimal valorIOF;
        /// <summary>
        /// Este campo somente deverá ser preenchido pelas Empresas Beneficiários, cujo ramo de atividade seja Administradora de Seguros. O beneficiário deve informar o valor do IOF a ser recolhido. O recolhimento é realizado automaticamente pelo sistema do Banco.
        /// Exemplos de multas: [[90% = 90.00m], [37,5% = 37.50m], [15,96% = 15.96m]]
        /// </summary>
        public decimal ValorIOF
        {
            get { return valorIOF; }
            set { valorIOF = value; }
        }

        private decimal valorAbatimento;
        /// <summary>
        /// Valor Abatimento 
        /// Exemplos de multas: [[90% = 90.00m], [37,5% = 37.50m], [15,96% = 15.96m]]
        /// </summary>
        public decimal ValorAbatimento
        {
            get { return valorAbatimento; }
            set { valorAbatimento = value; }
        }

        public IdentificacaoTipoInscricaoPagador identificacaoTipoInscricao;

        private string numeroInscricaoPagador;
        /// <summary>
        /// CNPJ/ CPF - Vide Obs. Pág. 21
        /// (Preenchimento obrigatório)
        /// </summary>
        public string NumeroInscricaoPagador
        {
            get { return numeroInscricaoPagador; }
            set { numeroInscricaoPagador = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(value, 14); }
        }

        private string nomePagador;
        //TODO: Tratar nome quando existir caractere especial
        /// <summary>
        /// Nome pagador.
        /// </summary>
        public string NomePagador
        {
            get { return nomePagador; }
            set { nomePagador = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 40); }
        }

        private string enderecoCompleto;
        /// <summary>
        /// Endereço do Pagador
        /// </summary>
        public string EnderecoCompleto
        {
            get { return enderecoCompleto; }
            set { enderecoCompleto = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 40); }
        }

        private string primeiraMensagem;
        /// <summary>
        /// Campo livre para uso da Empresa. A mensagem enviada nesse campo será impressa somente no boleto e não será confirmada no Arquivo Retorno.
        /// </summary>
        public string PrimeiraMensagem
        {
            get { return primeiraMensagem; }
            set { primeiraMensagem = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 12); }
        }

        private string cep;
        /// <summary>
        /// CEP Pagador
        /// </summary>
        public string Cep
        {
            get { return cep; }
            set { cep = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 8); }
        }

        //private string sufixoCep;
        ///// <summary>
        ///// Sufixo CEP
        ///// </summary>
        //public string SufixoCep
        //{
        //    get { return sufixoCep; }
        //    set { sufixoCep = Util.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        //}

        private string segundaMensagem;
        /// <summary>
        /// Decomposição.
        /// Este campo poderá ser utilizado para informar:
        /// Somente Sacador/Avalista, ou Somente Mensagem.
        /// Não utilizar as expressões “taxa bancária” ou “tarifa bancária” nos boletos de cobrança, pois essa tarifa refere-se à negociada pelo Banco com seu cliente beneficiário. Orientação da FEBRABAN (Comunicado FB-170/2005).
        /// </summary>
        public string SegundaMensagem
        {
            get { return segundaMensagem; }
            set { segundaMensagem = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 60); }
        }
        #endregion propriedades

        public TransacaoTipo1()
        {
            DebitoAutomatico = new DebitoAutomaticoCC();
            BeneficiariaBanco = new EmpresaBeneficiariaBanco();
        }

        public StringBuilder GetTransacao()
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, this.DebitoAutomatico.Agencia);
            transacao.Insert(6, this.DebitoAutomatico.DigitoAgencia);
            transacao.Insert(7, this.DebitoAutomatico.RazaoConta);
            transacao.Insert(12, this.DebitoAutomatico.ContaCorrente);
            transacao.Insert(19, this.DebitoAutomatico.DigitoContaCorrente);
            transacao.Insert(20, this.BeneficiariaBanco.ToStringTransacaoTipo1());
            transacao.Insert(37, this.numeroControleParticipante);
            transacao.Insert(62, this.codigoBancoDebito);
            transacao.Insert(65, (int)this.multa);
            transacao.Insert(66, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.percentualMulta.ToString().Replace(",", ""), 4));
            transacao.Insert(70, this.identificacaoTituloBanco);
            NossoNumero NN = new NossoNumero
            {
                Carteira = BeneficiariaBanco.CodigoCarteira.Substring(1, 2),
                NossoNumeroSemDigito = this.IdentificacaoTituloBanco
            };
            transacao.Insert(81, NN.GetDigitoNossoNumero());
            transacao.Insert(82, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.descontoBonificacaoDia.ToString().Replace(",", ""), 10));
            transacao.Insert(92, (int)this.condicaoEmissaoBoletoCobranca);
            transacao.Insert(93, this.condicaoRegistroDebitoAutomatico);
            transacao.Insert(94, this.identificacaoOperacaoBanco);
            transacao.Insert(104, this.indicadorRateioCredito);
            transacao.Insert(105, this.enderecamentoAvisoDebitoAutomatico);
            transacao.Insert(106, this.pagamentoParcial);
            transacao.Insert(108, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(Convert.ToString((int)this.identificacaoOcorrencia), 2));
            transacao.Insert(110, this.numeroDocumento);
            transacao.Insert(120, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.dataVencimentoTitulo.ToString("ddMMyy"), 6));
            transacao.Insert(126, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.valorTitulo.ToString().Replace(",", ""), 13));
            transacao.Insert(139, this.bancoEncarregadoCobranca);
            transacao.Insert(142, this.agenciaDepositaria);
            transacao.Insert(147, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(Convert.ToString((int)this.especieTitulo), 2));
            transacao.Insert(149, identificacao);
            transacao.Insert(150, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.dataEmissaoTitulo.ToString("ddMMyy"), 6));
            transacao.Insert(156, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(Convert.ToString((int)this.primeiraInstrucao), 2));
            transacao.Insert(158, this.segundaInstrucao);
            transacao.Insert(160, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.valorCobrarDiaAtraso.ToString().Replace(",", ""), 13));
            if (dataLimiteConcessaoDesconto == new DateTime(0001, 01, 01))
            {
                transacao.Insert(173, "000000");
            }
            else
            {
                transacao.Insert(173, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.dataLimiteConcessaoDesconto.ToString("ddMMyy"), 6));
            }
            transacao.Insert(179, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.valorDesconto.ToString().Replace(",", ""), 13));
            transacao.Insert(192, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.valorIOF.ToString().Replace(",", ""), 13));
            transacao.Insert(205, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(this.valorAbatimento.ToString().Replace(",", ""), 13));
            transacao.Insert(218, UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(Convert.ToString((int)this.identificacaoTipoInscricao), 2));
            transacao.Insert(220, this.numeroInscricaoPagador);
            transacao.Insert(234, this.nomePagador);
            transacao.Insert(274, this.enderecoCompleto);
            transacao.Insert(314, this.primeiraMensagem);
            transacao.Insert(326, this.cep);
            //transacao.Insert(331, this.sufixoCep);
            transacao.Insert(334, this.segundaMensagem);

            var transacaoSemCaractereEspecial = UtilRemessa.FormataArquivo.SubstituiCaracteresEspeciais(Convert.ToString(transacao));

            transacao.Clear();
            transacao.Insert(0, transacaoSemCaractereEspecial);

            return transacao;
        }

    }
}
