using ClassLibraryTest.TransacaoDoTipo3;
using ClassLibraryTest.Utils;
using System;
using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo3
    {
        private const string tipoRegistro = "3";

        private EmpresaBeneficiariaBanco identificacaoEmpresaBanco;

        private string identificacaoTituloBanco;
        /// <summary>
        /// Nosso Numero, esse campo deverá ser informado com Zeros, quando a emissão do Boleto de Cobrança for pelo Banco; quando for pela Empresa, esse campo deverá ser preenchido conforme os critérios apresentados nas páginas 18 a 20.
        /// </summary>
        public string IdentificacaoTituloBanco
        {
            get { return identificacaoTituloBanco; }
            set
            {
                if (value.Length != 12)
                {
                    throw new Exception("Nosso número deve conter 12 dígitos");
                }
                identificacaoTituloBanco = Util.FormataCampoComEspacosDireita(value, 12);
            }
        }

        public CodigosCalculoRateio codigoCalculoRateio;

        public TiposDeValorInformado tipoValorInformado;

        private string filler = "            ";

        private string codigoBancoCreditoPrimeiroBeneficiario = "237";

        private string codigoAgenciaCreditoPrimeiroBeneficiario;
        /// <summary>
        /// Código da Agência
        /// </summary>
        public string CodigoAgenciaCreditoPrimeiroBeneficiario
        {
            get { return codigoAgenciaCreditoPrimeiroBeneficiario; }
            set { codigoAgenciaCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoPrimeiroBeneficiario;
        /// <summary>
        /// Dígito da Agência
        /// </summary>
        public string DigitoAgenciaCreditoPrimeiroBeneficiario
        {
            get { return digitoAgenciaCreditoPrimeiroBeneficiario; }
            set { digitoAgenciaCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoPrimeiroBeneficiario;
        /// <summary>
        /// Número da Conta Corrente do Beneficiário
        /// </summary>
        public string NumeroContaCorrenteCreditoPrimeiroBeneficiario
        {
            get { return numeroContaCorrenteCreditoPrimeiroBeneficiario; }
            set { numeroContaCorrenteCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoPrimeiroBeneficiario;
        /// <summary>
        /// Dígito da Conta Corrente
        /// </summary>
        public string DigitoContaCorrenteCreditoPrimeiroBeneficiario
        {
            get { return digitoContaCorrenteCreditoPrimeiroBeneficiario; }
            set { digitoContaCorrenteCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string valorOuParcelamentoRateio;
        /// <summary>
        /// Valor do rateio, de acordo com o tipo(percentual ou valor).
        /// Moeda corrente - Deverá ser informado com 2 (duas) decimais.
        /// Moeda indexada - Deverá ser informado com 5 (cinco) decimais.
        /// Percentual - deverá ser informado com 3 (três) decimais.
        /// </summary>
        public string ValorOuParcelamentoRateio
        {
            get { return valorOuParcelamentoRateio; }
            set { valorOuParcelamentoRateio = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomePrimeiroBeneficiario;
        /// <summary>
        /// Para cada Título, serão permitidos no máximo 90 beneficiários, isto é, no máximo 30 registros tipo 3. para cada Título. (Registro Tipo 1)
        /// </summary>
        public string NomePrimeiroBeneficiario
        {
            get { return nomePrimeiroBeneficiario; }
            set { nomePrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler2;
        /// <summary>
        /// Brancos
        /// </summary>
        public string Filler2
        {
            get { return filler2; }
            set { filler2 = Util.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela;
        /// <summary>
        /// Identificação da Parcela
        /// Para diferenciar rateios de um mesmo Título, para o mesmo beneficiário várias vezes.
        /// </summary>
        public string Parcela
        {
            get { return parcela; }
            set { parcela = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingPrimeiroBeneficiario;
        /// <summary>
        /// Informar a quantidade de dias para rateio, após a data do crédito da cobrança na Conta Corrente do beneficiário. Essa quantidade está limitada a 30 (trinta) dias.
        /// </summary>
        public string FloatingPrimeiroBeneficiario
        {
            get { return floatingPrimeiroBeneficiario; }
            set { floatingPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoBancoCreditoSegundoBeneficiario;
        /// <summary>
        /// Fixo “237”
        /// </summary>
        public string CodigoBancoCreditoSegundoBeneficiario
        {
            get { return codigoBancoCreditoSegundoBeneficiario; }
            set { codigoBancoCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoAgenciaCreditoSegundoBeneficiario;
        /// <summary>
        /// Código da Agência do Beneficiário
        /// </summary>
        public string CodigoAgenciaCreditoSegundoBeneficiario
        {
            get { return codigoAgenciaCreditoSegundoBeneficiario; }
            set { codigoAgenciaCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoSegundoBeneficiario;
        /// <summary>
        /// Dígito da Agência 
        /// </summary>
        public string DigitoAgenciaCreditoSegundoBeneficiario
        {
            get { return digitoAgenciaCreditoSegundoBeneficiario; }
            set { digitoAgenciaCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoSegundoBeneficiario;
        /// <summary>
        /// Número da Conta Corrente do Beneficiário
        /// </summary>
        public string NumeroContaCorrenteCreditoSegundoBeneficiario
        {
            get { return numeroContaCorrenteCreditoSegundoBeneficiario; }
            set { numeroContaCorrenteCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoSegundoBeneficiario;
        /// <summary>
        /// Dígito da Conta Corrente
        /// </summary>
        public string DigitoContaCorrenteCreditoSegundoBeneficiario
        {
            get { return digitoContaCorrenteCreditoSegundoBeneficiario; }
            set { digitoContaCorrenteCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string valorOuParcelamentoRateio2;
        /// <summary>
        /// Valor do rateio, de acordo com o tipo(percentual ou valor).
        /// Moeda corrente - Deverá ser informado com 2 (duas) decimais.
        /// Moeda indexada - Deverá ser informado com 5 (cinco) decimais.
        /// Percentual - deverá ser informado com 3 (três) decimais.
        /// </summary>
        public string ValorOuParcelamentoRateio2
        {
            get { return valorOuParcelamentoRateio2; }
            set { valorOuParcelamentoRateio2 = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomeSegundoBeneficiario;
        /// <summary>
        /// Nome do Beneficiário
        /// </summary>
        public string NomeSegundoBeneficiario
        {
            get { return nomeSegundoBeneficiario; }
            set { nomeSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler3;
        /// <summary>
        /// Brancos
        /// </summary>
        public string Filler3
        {
            get { return filler3; }
            set { filler3 = Util.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela2;
        /// <summary>
        /// Identificação da Parcela
        /// </summary>
        public string Parcela2
        {
            get { return parcela2; }
            set { parcela2 = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingSegundoBeneficiario;
        /// <summary>
        /// Quantidade de dias para Crédito do Beneficiário
        /// </summary>
        public string FloatingSegundoBeneficiario
        {
            get { return floatingSegundoBeneficiario; }
            set { floatingSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoBancoCreditoTerceiroBeneficiario;
        /// <summary>
        /// Fixo “237”
        /// </summary>
        public string CodigoBancoCreditoTerceiroBeneficiario
        {
            get { return codigoBancoCreditoTerceiroBeneficiario; }
            set { codigoBancoCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoAgenciaCreditoTerceiroBeneficiario;
        /// <summary>
        /// Código da Agência do Beneficiário
        /// </summary>
        public string CodigoAgenciaCreditoTerceiroBeneficiario
        {
            get { return codigoAgenciaCreditoTerceiroBeneficiario; }
            set { codigoAgenciaCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoTerceiroBeneficiario;
        /// <summary>
        /// Dígito da Agência
        /// </summary>
        public string DigitoAgenciaCreditoTerceiroBeneficiario
        {
            get { return digitoAgenciaCreditoTerceiroBeneficiario; }
            set { digitoAgenciaCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoTerceiroBeneficiario;
        /// <summary>
        /// Número da Conta Corrente do Beneficiário
        /// </summary>
        public string NumeroContaCorrenteCreditoTerceiroBeneficiario
        {
            get { return numeroContaCorrenteCreditoTerceiroBeneficiario; }
            set { numeroContaCorrenteCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoTerceiroBeneficiario;
        /// <summary>
        /// Dígito da Conta Corrente
        /// </summary>
        public string DigitoContaCorrenteCreditoTerceiroBeneficiario
        {
            get { return digitoContaCorrenteCreditoTerceiroBeneficiario; }
            set { digitoContaCorrenteCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string valorOuParcelamentoRateio3;
        /// <summary>
        /// Valor do rateio, de acordo com o tipo(percentual ou valor).
        /// Moeda corrente - Deverá ser informado com 2 (duas) decimais.
        /// Moeda indexada - Deverá ser informado com 5 (cinco) decimais.
        /// Percentual - deverá ser informado com 3 (três) decimais.
        /// </summary>
        public string ValorOuParcelamentoRateio3
        {
            get { return valorOuParcelamentoRateio3; }
            set { valorOuParcelamentoRateio3 = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomeTerceiroBeneficiario;
        /// <summary>
        /// Nome do 3º Beneficiário
        /// </summary>
        public string NomeTerceiroBeneficiario
        {
            get { return nomeTerceiroBeneficiario; }
            set { nomeTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler4;
        /// <summary>
        /// Brancos
        /// </summary>
        public string Filler4
        {
            get { return filler4; }
            set { filler4 = Util.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela3;
        /// <summary>
        /// Identificação da Parcela
        /// </summary>
        public string Parcela3
        {
            get { return parcela3; }
            set { parcela3 = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingTerceiroBeneficiario;


        /// <summary>
        /// Quantidade de Dias para Crédito do Beneficiário
        /// </summary>
        public string FloatingTerceiroBeneficiario
        {
            get { return floatingTerceiroBeneficiario; }
            set { floatingTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        public TransacaoTipo3()
        {
        }

        public StringBuilder GetTransacao(TransacaoTipo3 stringTransacao)
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, identificacaoEmpresaBanco.ToString().Substring(1, 16));
            transacao.Insert(17, stringTransacao.identificacaoTituloBanco);
            transacao.Insert(29, Util.FormataCampoComZerosEsquerda(Convert.ToString((int)stringTransacao.codigoCalculoRateio), 2));
            transacao.Insert(30, Util.FormataCampoComZerosEsquerda(Convert.ToString((int)stringTransacao.tipoValorInformado), 2));
            transacao.Insert(31, stringTransacao.filler);
            transacao.Insert(43, stringTransacao.codigoBancoCreditoPrimeiroBeneficiario);
            transacao.Insert(46, stringTransacao.codigoAgenciaCreditoPrimeiroBeneficiario);
            transacao.Insert(51, stringTransacao.digitoAgenciaCreditoPrimeiroBeneficiario);
            transacao.Insert(52, stringTransacao.numeroContaCorrenteCreditoPrimeiroBeneficiario);
            transacao.Insert(64, stringTransacao.digitoContaCorrenteCreditoPrimeiroBeneficiario);
            transacao.Insert(65, stringTransacao.valorOuParcelamentoRateio);
            transacao.Insert(80, stringTransacao.nomePrimeiroBeneficiario);
            transacao.Insert(120, stringTransacao.filler2);
            transacao.Insert(120, stringTransacao.parcela);
            transacao.Insert(157, stringTransacao.floatingPrimeiroBeneficiario);
            transacao.Insert(160, stringTransacao.codigoBancoCreditoSegundoBeneficiario);
            transacao.Insert(163, stringTransacao.codigoAgenciaCreditoSegundoBeneficiario);
            transacao.Insert(167, stringTransacao.digitoAgenciaCreditoSegundoBeneficiario);
            transacao.Insert(169, stringTransacao.numeroContaCorrenteCreditoSegundoBeneficiario);
            transacao.Insert(181, stringTransacao.digitoContaCorrenteCreditoSegundoBeneficiario);
            transacao.Insert(182, stringTransacao.valorOuParcelamentoRateio2);
            transacao.Insert(197, stringTransacao.nomeSegundoBeneficiario);
            transacao.Insert(237, stringTransacao.filler3);
            transacao.Insert(268, stringTransacao.parcela2);
            transacao.Insert(274, stringTransacao.floatingSegundoBeneficiario);
            transacao.Insert(277, stringTransacao.codigoBancoCreditoTerceiroBeneficiario);
            transacao.Insert(280, stringTransacao.codigoAgenciaCreditoTerceiroBeneficiario);
            transacao.Insert(285, stringTransacao.DigitoAgenciaCreditoTerceiroBeneficiario);
            transacao.Insert(286, stringTransacao.numeroContaCorrenteCreditoTerceiroBeneficiario);
            transacao.Insert(298, stringTransacao.digitoContaCorrenteCreditoTerceiroBeneficiario);
            transacao.Insert(299, stringTransacao.valorOuParcelamentoRateio3);
            transacao.Insert(314, stringTransacao.nomeTerceiroBeneficiario);
            transacao.Insert(354, stringTransacao.filler4);
            transacao.Insert(385, stringTransacao.parcela3);
            transacao.Insert(391, stringTransacao.floatingTerceiroBeneficiario);

            return transacao;
        }
    }
}
