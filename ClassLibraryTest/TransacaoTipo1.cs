using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo1
    {
        private string identificacaoRegistro;
        /// <summary>
        /// Identificação do registro
        /// </summary>
        public string IdentificacaoRegistro
        {
            get { return identificacaoRegistro; }
            set { identificacaoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string agenciaPagador;
        /// <summary>
        /// Agência de débito (opcional). nº da Agência do pagador a ser debitada
        /// </summary>
        public string AgenciaPagador
        {
            get { return agenciaPagador; }
            set { agenciaPagador = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgencia;
        /// <summary>
        /// Dígito da Agência de Débito (opcional) . Dígito da Agência
        /// </summary>
        public string DigitoAgencia
        {
            get { return digitoAgencia; }
            set { digitoAgencia = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string razaoConta;
        /// <summary>
        /// Razão da Conta Corrente (opcional). razão da Conta - Ex. 07050
        /// </summary>
        public string RazaoConta
        {
            get { return razaoConta; }
            set { razaoConta = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string contaCorrente;
        /// <summary>
        /// Conta Corrente (opcional). nº da Conta Corrente do Pagador 
        /// </summary>
        public string ContaCorrente
        {
            get { return contaCorrente; }
            set { contaCorrente = Util.FormataCampoComEspacosDireita(value, 7); }
        }

        private string digitoContaCorrente;
        /// <summary>
        /// Dígito da Conta do Pagador. Digito da Conta Corrente. 
        /// </summary>
        public string DigitoContaCorrente
        {
            get { return digitoContaCorrente; }
            set { digitoContaCorrente = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoEmpresaBeneficiaria;
        /// <summary>
        /// 21 a 21 - Zero, 22 a 24 - códigos da carteira, 25 a 29 - códigos da Agência Beneficiários, sem o dígito, 30 a 36 - Contas Corrente, 37 a 37 - dígitos da Conta
        /// </summary>
        public string IdentificacaoEmpresaBeneficiaria
        {
            get { return identificacaoEmpresaBeneficiaria; }
            set { identificacaoEmpresaBeneficiaria = Util.FormataCampoComEspacosDireita(value, 17); }
        }

        private string numeroControleParticipante;
        /// <summary>
        /// Nº Controle do Participante. Campo destinado para uso da Empresa, A informação que constar do Arquivo Remessa será confirmada no Arquivo Retorno, Não será impresso nos boletos de cobrança.
        /// </summary>
        public string NumeroControleParticipante
        {
            get { return numeroControleParticipante; }
            set { numeroControleParticipante = Util.FormataCampoComEspacosDireita(value, 25); }
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
            set { codigoBancoDebito = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string multa;
        /// <summary>
        /// Se = 0 (sem multa) Se = 2 (tem multa). Se = 2 considerar percentual de multa.Se = 0, sem multa.
        /// </summary>
        public string Multa
        {
            get { return multa; }
            set { multa = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string percentualMulta;
        /// <summary>
        /// Percentual de multa a ser considerado. Se campo 66 a 66 = 0, preencher com zeros. Se campo 66 a 66 = 2, preencher com percentual da multa com 2 decimais
        /// </summary>
        public string PercentualMulta
        {
            get { return percentualMulta; }
            set { percentualMulta = Util.FormataCampoComEspacosDireita(value, 4); }
        }

        //TODO: efetuar o calculo do digito
        private string identificacaoTituloBanco;
        /// <summary>
        /// Número Bancário para Cobrança Com e Sem Registro. 
        /// Campo reservado para o Nosso Número do Título (Número Bancário), cujo procedimento a ser adotado deve obedecer aos itens a seguir:
        /// </summary>
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
        /// <summary>
        /// Valor do desconto bonif./dia.
        /// </summary>
        public string DescontoBonificacaoDia
        {
            get { return descontoBonificacaoDia; }
            set { descontoBonificacaoDia = Util.FormataCampoComEspacosDireita(value, 10); }
        }

        private string condicaoEmissaoBoletoCobranca;
        /// <summary>
        /// 1 = Banco emite e Processa o registro. 2 = Cliente emite e o Banco somente processa o registro
        /// </summary>
        public string CondicaoEmissaoBoletoCobranca
        {
            get { return condicaoEmissaoBoletoCobranca; }
            set { condicaoEmissaoBoletoCobranca = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string condicaoRegistroDebitoAutomatico;
        /// <summary>
        /// Quando igual a “N” e os dados do débito estiverem incorretos, rejeita o registro na cobrança e não emite Boleto de cobrança;
        /// Quando diferente de “N” e os dados do débito estiverem incorretos, registra na cobrança e emite Boleto de cobrança.Nesta condição, não ocorrerá o agendamento do debito.
        /// </summary>
        public string CondicaoRegistroDebitoAutomatico
        {
            get { return condicaoRegistroDebitoAutomatico; }
            set { condicaoRegistroDebitoAutomatico = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoOperacaoBanco;
        /// <summary>
        /// Brancos
        /// </summary>
        public string IdentificacaoOperacaoBanco
        {
            get { return identificacaoOperacaoBanco; }
            set { identificacaoOperacaoBanco = Util.FormataCampoComEspacosDireita(value, 10); }
        }

        private string indicadorRateioCredito;
        /// <summary>
        /// Indicador Rateio Crédito (opcional). “R”. Somente deverá ser preenchido com a Letra “R”, se a Empresa contratou o serviço de rateio de crédito, caso não, informar Branco
        /// </summary>
        public string IndicadorRateioCredito
        {
            get { return indicadorRateioCredito; }
            set { indicadorRateioCredito = Util.FormataCampoComEspacosDireita(value, 1); }
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
            set { enderecamentoAvisoDebitoAutomatico = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string pagamentoParcial;
        /// <summary>
        /// Somente deverá ser preenchido com a quantidade de parcelas para pagamento, se a Empresa contratou o serviço Pagamento Parcial, caso não, informar Branco. Quantidade mínima de parcelas = 01 Quantidade máxima de parcelas = 99.
        /// </summary>
        public string PagamentoParcial
        {
            get { return pagamentoParcial; }
            set { pagamentoParcial = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string identificacaoOcorrencia;
        /// <summary>
        /// 01..Remessa
        ///02..Pedido de baixa
        ///03..Pedido de Protesto Falimentar
        ///04..Concessão de abatimento
        ///05..Cancelamento de abatimento concedido
        ///06..Alteração de vencimento
        ///07..Alteração do controle do participante
        ///08..Alteração de seu número
        ///09..Pedido de protesto
        ///18..Sustar protesto e baixar Título
        ///19..Sustar protesto e manter em carteira
        ///20 Alteração de valor*
        ///21 Alteração de valor com emissão de Boleto(quando a emissão é pelo Banco)*
        ///22..Transferência Cessão crédito ID.Prod.10
        ///23..Transferência entre Carteiras
        ///24..Dev.Transferência entre Carteiras
        ///31..Alteração de outros dados
        ///045..Pedido de Negativação
        ///046..Excluir Negativação com baixa
        ///047..Excluir negativação e manter pendente
        ///68..Acerto nos dados do rateio de Crédito
        ///69..Cancelamento do rateio de crédito (uso futuro).
        /// </summary>
        public string IdentificacaoOcorrencia
        {
            get { return identificacaoOcorrencia; }
            set { identificacaoOcorrencia = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string numeroDocumento;
        /// <summary>
        /// Documento
        /// </summary>
        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = Util.FormataCampoComEspacosDireita(value, 10); }
        }

        private string dataVencimentoTitulo;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public string DataVencimentoTitulo
        {
            get { return dataVencimentoTitulo; }
            set { dataVencimentoTitulo = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string valorTitulo;
        /// <summary>
        /// Valor do Título (preencher sem ponto e sem vírgula) 
        /// </summary>
        public string ValorTitulo
        {
            get { return valorTitulo; }
            set { valorTitulo = Util.FormataCampoComZerosEsquerda(value, 13); }
        }

        private string bancoEncarregadoCobranca;
        /// <summary>
        /// Preencher com zeros
        /// </summary>
        public string BancoEncarregadoCobranca
        {
            get { return bancoEncarregadoCobranca; }
            set { bancoEncarregadoCobranca = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string agenciaDepositaria;
        /// <summary>
        /// Preencher com zeros 
        /// </summary>
        public string AgenciaDepositaria
        {
            get { return agenciaDepositaria; }
            set { agenciaDepositaria = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string especieTitulo;
        /// <summary>
        /// 01-Duplicata
        ///02-Nota Promissória
        ///03-Nota de Seguro
        ///04-Cobrança Seriada
        ///05-Recibo
        ///10-Letras de Câmbio
        ///11-Nota de Débito
        ///12-Duplicata de Serv.
        ///31-Cartão de Crédito
        ///32-Boleto de Proposta
        ///99-Outros
        /// </summary>
        public string EspecieTitulo
        {
            get { return especieTitulo; }
            set { especieTitulo = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string identificacao;
        /// <summary>
        /// Sempre = N 
        /// </summary>
        public string Identificacao
        {
            get { return identificacao; }
            set { identificacao = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string dataEmissaoTitulo;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public string DataEmissaoTitulo
        {
            get { return dataEmissaoTitulo; }
            set { dataEmissaoTitulo = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string primeiraInstrucao;
        /// <summary>
        /// Campo destinado para pré-determinar o protesto do Título ou a baixa por decurso de prazo, quando do registro. Não havendo interesse, preencher com Zeros. Porém, caso a Empresa deseje se utilizar da instrução automática de protesto ou da baixa por
        ///decurso de prazo, abaixo os procedimentos:
        /// </summary>
        public string PrimeiraInstrucao
        {
            get { return primeiraInstrucao; }
            set { primeiraInstrucao = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string segundaInstrucao;
        /// <summary>
        /// Campo destinado para pré-determinar o protesto do Título ou a baixa por decurso de prazo, quando do registro. Não havendo interesse, preencher com Zeros. Porém, caso a Empresa deseje se utilizar da instrução automática de protesto ou da baixa por
        ///decurso de prazo, abaixo os procedimentos:
        /// </summary>
        public string SegundaInstrucao
        {
            get { return segundaInstrucao; }
            set { segundaInstrucao = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string valorCobrarDiaAtraso;
        /// <summary>
        /// Campo destinado para o Beneficiário informar o valor da mora dia a ser cobrado do Pagador, no
        ///caso de pagamento com atraso(somente valor).
        ///Porém, caso o Beneficiário não queira informar o valor da mora dia, no Arquivo Remessa,
        ///poderemos calculá-lo e imprimi-lo, contudo torna-se necessário informar o valor de sua taxa de juros
        ///mensal, através de carta, a qual deverá ser encaminhada para a nossa Agência, para o efetivo cadastramento.
        ///Nota: Emissão dos boletos pelo próprio cliente. Quando houver Comissão de Permanência a ser
        ///cobrado por dia de atraso, será obrigatória a informação desse valor no arquivo remessa.
        /// </summary>
        public string ValorCobrarDiaAtraso
        {
            get { return valorCobrarDiaAtraso; }
            set { valorCobrarDiaAtraso = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string dataLimiteConcessaoDesconto;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public string DataLimiteConcessaoDesconto
        {
            get { return dataLimiteConcessaoDesconto; }
            set { dataLimiteConcessaoDesconto = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string valorDesconto;
        /// <summary>
        /// Valor Desconto 
        /// </summary>
        public string ValorDesconto
        {
            get { return valorDesconto; }
            set { valorDesconto = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string valorIOF;
        /// <summary>
        /// Este campo somente deverá ser preenchido pelas Empresas Beneficiários, cujo ramo de atividade seja Administradora de Seguros. O beneficiário deve informar o valor do IOF a ser recolhido. O recolhimento é realizado automaticamente pelo sistema do Banco.
        /// </summary>
        public string ValorIOF
        {
            get { return valorIOF; }
            set { valorIOF = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string valorAbatimento;
        /// <summary>
        /// Valor Abatimento 
        /// </summary>
        public string ValorAbatimento
        {
            get { return valorAbatimento; }
            set { valorAbatimento = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string identificacaoTipoInscricao;
        /// <summary>
        /// 01-CPF
        /// 02-CNPJ
        /// </summary>
        public string IdentificacaoTipoInscricao
        {
            get { return identificacaoTipoInscricao; }
            set { identificacaoTipoInscricao = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string numeroInscricaoPagador;
        /// <summary>
        /// CNPJ/ CPF - Vide Obs. Pág. 21
        /// (Preenchimento obrigatório)
        /// </summary>
        public string NumeroInscricaoPagador
        {
            get { return numeroInscricaoPagador; }
            set { numeroInscricaoPagador = Util.FormataCampoComEspacosDireita(value, 14); }
        }

        private string nomePagador;
        //TODO: Tratar nome quando existir caractere especial
        /// <summary>
        /// Nome pagador.
        /// </summary>
        public string NomePagador
        {
            get { return nomePagador; }
            set
            {
                var stringTratada = Util.FormataCampoCaracteresEspeciais(value);
                stringTratada = Util.FormataCampoComEspacosDireita(stringTratada, 40);
                nomePagador = stringTratada;
            }
        }

        private string enderecoCompleto;
        /// <summary>
        /// Endereço do Pagador
        /// </summary>
        public string EnderecoCompleto
        {
            get { return enderecoCompleto; }
            set { enderecoCompleto = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string primeiraMensagem;
        /// <summary>
        /// Campo livre para uso da Empresa. A mensagem enviada nesse campo será impressa somente no boleto e não será confirmada no Arquivo Retorno.
        /// </summary>
        public string PrimeiraMensagem
        {
            get { return primeiraMensagem; }
            set { primeiraMensagem = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string cep;
        /// <summary>
        /// CEP Pagador
        /// </summary>
        public string Cep
        {
            get { return cep; }
            set { cep = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string sufixoCep;
        /// <summary>
        /// Sufixo CEP
        /// </summary>
        public string SufixoCep
        {
            get { return sufixoCep; }
            set { sufixoCep = Util.FormataCampoComEspacosDireita(value, 3); }
        }

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
