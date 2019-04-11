using System;
using System.Text;
using UtilRemessa;

namespace ArquivoRemessa
{
    public class TransacaoTipo3
    {
        private const string tipoRegistro = "3";

        private EmpresaBeneficiariaBanco IdentificacaoEmpresaBanco { get; set; }

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
                identificacaoTituloBanco =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 12);
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
            set { codigoAgenciaCreditoPrimeiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoPrimeiroBeneficiario;
        /// <summary>
        /// Dígito da Agência
        /// </summary>
        public string DigitoAgenciaCreditoPrimeiroBeneficiario
        {
            get { return digitoAgenciaCreditoPrimeiroBeneficiario; }
            set { digitoAgenciaCreditoPrimeiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoPrimeiroBeneficiario;
        /// <summary>
        /// Número da Conta Corrente do Beneficiário
        /// </summary>
        public string NumeroContaCorrenteCreditoPrimeiroBeneficiario
        {
            get { return numeroContaCorrenteCreditoPrimeiroBeneficiario; }
            set { numeroContaCorrenteCreditoPrimeiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoPrimeiroBeneficiario;
        /// <summary>
        /// Dígito da Conta Corrente
        /// </summary>
        public string DigitoContaCorrenteCreditoPrimeiroBeneficiario
        {
            get { return digitoContaCorrenteCreditoPrimeiroBeneficiario; }
            set { digitoContaCorrenteCreditoPrimeiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
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
            set { valorOuParcelamentoRateio =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomePrimeiroBeneficiario;
        /// <summary>
        /// Para cada Título, serão permitidos no máximo 90 beneficiários, isto é, no máximo 30 registros tipo 3. para cada Título. (Registro Tipo 1)
        /// </summary>
        public string NomePrimeiroBeneficiario
        {
            get { return nomePrimeiroBeneficiario; }
            set { nomePrimeiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler2;
        /// <summary>
        /// Brancos
        /// </summary>
        public string Filler2
        {
            get { return filler2; }
            set { filler2 =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela;
        /// <summary>
        /// Identificação da Parcela
        /// Para diferenciar rateios de um mesmo Título, para o mesmo beneficiário várias vezes.
        /// </summary>
        public string Parcela
        {
            get { return parcela; }
            set { parcela =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingPrimeiroBeneficiario;
        /// <summary>
        /// Informar a quantidade de dias para rateio, após a data do crédito da cobrança na Conta Corrente do beneficiário. Essa quantidade está limitada a 30 (trinta) dias.
        /// </summary>
        public string FloatingPrimeiroBeneficiario
        {
            get { return floatingPrimeiroBeneficiario; }
            set { floatingPrimeiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoBancoCreditoSegundoBeneficiario;
        /// <summary>
        /// Fixo “237”
        /// </summary>
        public string CodigoBancoCreditoSegundoBeneficiario
        {
            get { return codigoBancoCreditoSegundoBeneficiario; }
            set { codigoBancoCreditoSegundoBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoAgenciaCreditoSegundoBeneficiario;
        /// <summary>
        /// Código da Agência do Beneficiário
        /// </summary>
        public string CodigoAgenciaCreditoSegundoBeneficiario
        {
            get { return codigoAgenciaCreditoSegundoBeneficiario; }
            set { codigoAgenciaCreditoSegundoBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoSegundoBeneficiario;
        /// <summary>
        /// Dígito da Agência 
        /// </summary>
        public string DigitoAgenciaCreditoSegundoBeneficiario
        {
            get { return digitoAgenciaCreditoSegundoBeneficiario; }
            set { digitoAgenciaCreditoSegundoBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoSegundoBeneficiario;
        /// <summary>
        /// Número da Conta Corrente do Beneficiário
        /// </summary>
        public string NumeroContaCorrenteCreditoSegundoBeneficiario
        {
            get { return numeroContaCorrenteCreditoSegundoBeneficiario; }
            set { numeroContaCorrenteCreditoSegundoBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoSegundoBeneficiario;
        /// <summary>
        /// Dígito da Conta Corrente
        /// </summary>
        public string DigitoContaCorrenteCreditoSegundoBeneficiario
        {
            get { return digitoContaCorrenteCreditoSegundoBeneficiario; }
            set { digitoContaCorrenteCreditoSegundoBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
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
            set { valorOuParcelamentoRateio2 =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomeSegundoBeneficiario;
        /// <summary>
        /// Nome do Beneficiário
        /// </summary>
        public string NomeSegundoBeneficiario
        {
            get { return nomeSegundoBeneficiario; }
            set { nomeSegundoBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler3;
        /// <summary>
        /// Brancos
        /// </summary>
        public string Filler3
        {
            get { return filler3; }
            set { filler3 =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela2;
        /// <summary>
        /// Identificação da Parcela
        /// </summary>
        public string Parcela2
        {
            get { return parcela2; }
            set { parcela2 =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingSegundoBeneficiario;
        /// <summary>
        /// Quantidade de dias para Crédito do Beneficiário
        /// </summary>
        public string FloatingSegundoBeneficiario
        {
            get { return floatingSegundoBeneficiario; }
            set { floatingSegundoBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoBancoCreditoTerceiroBeneficiario;
        /// <summary>
        /// Fixo “237”
        /// </summary>
        public string CodigoBancoCreditoTerceiroBeneficiario
        {
            get { return codigoBancoCreditoTerceiroBeneficiario; }
            set { codigoBancoCreditoTerceiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoAgenciaCreditoTerceiroBeneficiario;
        /// <summary>
        /// Código da Agência do Beneficiário
        /// </summary>
        public string CodigoAgenciaCreditoTerceiroBeneficiario
        {
            get { return codigoAgenciaCreditoTerceiroBeneficiario; }
            set { codigoAgenciaCreditoTerceiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoTerceiroBeneficiario;
        /// <summary>
        /// Dígito da Agência
        /// </summary>
        public string DigitoAgenciaCreditoTerceiroBeneficiario
        {
            get { return digitoAgenciaCreditoTerceiroBeneficiario; }
            set { digitoAgenciaCreditoTerceiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoTerceiroBeneficiario;
        /// <summary>
        /// Número da Conta Corrente do Beneficiário
        /// </summary>
        public string NumeroContaCorrenteCreditoTerceiroBeneficiario
        {
            get { return numeroContaCorrenteCreditoTerceiroBeneficiario; }
            set { numeroContaCorrenteCreditoTerceiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoTerceiroBeneficiario;
        /// <summary>
        /// Dígito da Conta Corrente
        /// </summary>
        public string DigitoContaCorrenteCreditoTerceiroBeneficiario
        {
            get { return digitoContaCorrenteCreditoTerceiroBeneficiario; }
            set { digitoContaCorrenteCreditoTerceiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
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
            set { valorOuParcelamentoRateio3 =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomeTerceiroBeneficiario;
        /// <summary>
        /// Nome do 3º Beneficiário
        /// </summary>
        public string NomeTerceiroBeneficiario
        {
            get { return nomeTerceiroBeneficiario; }
            set { nomeTerceiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler4;
        /// <summary>
        /// Brancos
        /// </summary>
        public string Filler4
        {
            get { return filler4; }
            set { filler4 =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela3;
        /// <summary>
        /// Identificação da Parcela
        /// </summary>
        public string Parcela3
        {
            get { return parcela3; }
            set { parcela3 =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingTerceiroBeneficiario;


        /// <summary>
        /// Quantidade de Dias para Crédito do Beneficiário
        /// </summary>
        public string FloatingTerceiroBeneficiario
        {
            get { return floatingTerceiroBeneficiario; }
            set { floatingTerceiroBeneficiario =UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        public TransacaoTipo3()
        {
            IdentificacaoEmpresaBanco = new EmpresaBeneficiariaBanco();
        }

        public StringBuilder GetTransacao()
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, IdentificacaoEmpresaBanco.ToString().Substring(1, 16));
            transacao.Insert(17, this.identificacaoTituloBanco);
            transacao.Insert(29,UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(Convert.ToString((int)this.codigoCalculoRateio), 2));
            transacao.Insert(30,UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(Convert.ToString((int)this.tipoValorInformado), 2));
            transacao.Insert(31, this.filler);
            transacao.Insert(43, this.codigoBancoCreditoPrimeiroBeneficiario);
            transacao.Insert(46, this.codigoAgenciaCreditoPrimeiroBeneficiario);
            transacao.Insert(51, this.digitoAgenciaCreditoPrimeiroBeneficiario);
            transacao.Insert(52, this.numeroContaCorrenteCreditoPrimeiroBeneficiario);
            transacao.Insert(64, this.digitoContaCorrenteCreditoPrimeiroBeneficiario);
            transacao.Insert(65, this.valorOuParcelamentoRateio);
            transacao.Insert(80, this.nomePrimeiroBeneficiario);
            transacao.Insert(120, this.filler2);
            transacao.Insert(120, this.parcela);
            transacao.Insert(157, this.floatingPrimeiroBeneficiario);
            transacao.Insert(160, this.codigoBancoCreditoSegundoBeneficiario);
            transacao.Insert(163, this.codigoAgenciaCreditoSegundoBeneficiario);
            transacao.Insert(167, this.digitoAgenciaCreditoSegundoBeneficiario);
            transacao.Insert(169, this.numeroContaCorrenteCreditoSegundoBeneficiario);
            transacao.Insert(181, this.digitoContaCorrenteCreditoSegundoBeneficiario);
            transacao.Insert(182, this.valorOuParcelamentoRateio2);
            transacao.Insert(197, this.nomeSegundoBeneficiario);
            transacao.Insert(237, this.filler3);
            transacao.Insert(268, this.parcela2);
            transacao.Insert(274, this.floatingSegundoBeneficiario);
            transacao.Insert(277, this.codigoBancoCreditoTerceiroBeneficiario);
            transacao.Insert(280, this.codigoAgenciaCreditoTerceiroBeneficiario);
            transacao.Insert(285, this.DigitoAgenciaCreditoTerceiroBeneficiario);
            transacao.Insert(286, this.numeroContaCorrenteCreditoTerceiroBeneficiario);
            transacao.Insert(298, this.digitoContaCorrenteCreditoTerceiroBeneficiario);
            transacao.Insert(299, this.valorOuParcelamentoRateio3);
            transacao.Insert(314, this.nomeTerceiroBeneficiario);
            transacao.Insert(354, this.filler4);
            transacao.Insert(385, this.parcela3);
            transacao.Insert(391, this.floatingTerceiroBeneficiario);

            var transacaoSemCaractereEspecial =UtilRemessa.FormataArquivo.SubstituiCaracteresEspeciais(Convert.ToString(transacao));

            transacao.Clear();
            transacao.Insert(0, transacaoSemCaractereEspecial);

            return transacao;
        }
    }
}
