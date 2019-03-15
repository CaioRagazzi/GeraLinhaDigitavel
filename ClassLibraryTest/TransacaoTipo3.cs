using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo3
    {
        private string identificacaoRegistro;

        public string IdentificacaoRegistro
        {
            get { return identificacaoRegistro; }
            set { identificacaoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoEmpresaBanco;

        public string IdentificacaoEmpresaBanco
        {
            get { return identificacaoEmpresaBanco; }
            set { identificacaoEmpresaBanco = Util.FormataCampoComEspacosDireita(value, 16); }
        }

        private string identificacaoTituloBanco;

        public string IdentificacaoTituloBanco
        {
            get { return identificacaoTituloBanco; }
            set { identificacaoTituloBanco = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string codigoCalculoRateio;

        public string CodigoCalculoRateio
        {
            get { return codigoCalculoRateio; }
            set { codigoCalculoRateio = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string tipoValorInformado;

        public string TipoValorInformado
        {
            get { return tipoValorInformado; }
            set { tipoValorInformado = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string filler;

        public string Filler
        {
            get { return filler; }
            set { filler = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string codigoBancoCreditoPrimeiroBeneficiario;

        public string CodigoBancoCreditoPrimeiroBeneficiario
        {
            get { return codigoBancoCreditoPrimeiroBeneficiario; }
            set { codigoBancoCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoAgenciaCreditoPrimeiroBeneficiario;

        public string CodigoAgenciaCreditoPrimeiroBeneficiario
        {
            get { return codigoAgenciaCreditoPrimeiroBeneficiario; }
            set { codigoAgenciaCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoPrimeiroBeneficiario;

        public string DigitoAgenciaCreditoPrimeiroBeneficiario
        {
            get { return digitoAgenciaCreditoPrimeiroBeneficiario; }
            set { digitoAgenciaCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoPrimeiroBeneficiario;

        public string NumeroContaCorrenteCreditoPrimeiroBeneficiario
        {
            get { return numeroContaCorrenteCreditoPrimeiroBeneficiario; }
            set { numeroContaCorrenteCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoPrimeiroBeneficiario;

        public string DigitoContaCorrenteCreditoPrimeiroBeneficiario
        {
            get { return digitoContaCorrenteCreditoPrimeiroBeneficiario; }
            set { digitoContaCorrenteCreditoPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string valorOuParcelamentoRateio;

        public string ValorOuParcelamentoRateio
        {
            get { return valorOuParcelamentoRateio; }
            set { valorOuParcelamentoRateio = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomePrimeiroBeneficiario;

        public string NomePrimeiroBeneficiario
        {
            get { return nomePrimeiroBeneficiario; }
            set { nomePrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler2;

        public string Filler2
        {
            get { return filler2; }
            set { filler2 = Util.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela;

        public string Parcela
        {
            get { return parcela; }
            set { parcela = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingPrimeiroBeneficiario;

        public string FloatingPrimeiroBeneficiario
        {
            get { return floatingPrimeiroBeneficiario; }
            set { floatingPrimeiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoBancoCreditoSegundoBeneficiario;

        public string CodigoBancoCreditoSegundoBeneficiario
        {
            get { return codigoBancoCreditoSegundoBeneficiario; }
            set { codigoBancoCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoAgenciaCreditoSegundoBeneficiario;

        public string CodigoAgenciaCreditoSegundoBeneficiario
        {
            get { return codigoAgenciaCreditoSegundoBeneficiario; }
            set { codigoAgenciaCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoSegundoBeneficiario;

        public string DigitoAgenciaCreditoSegundoBeneficiario
        {
            get { return digitoAgenciaCreditoSegundoBeneficiario; }
            set { digitoAgenciaCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoSegundoBeneficiario;

        public string NumeroContaCorrenteCreditoSegundoBeneficiario
        {
            get { return numeroContaCorrenteCreditoSegundoBeneficiario; }
            set { numeroContaCorrenteCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoSegundoBeneficiario;

        public string DigitoContaCorrenteCreditoSegundoBeneficiario
        {
            get { return digitoContaCorrenteCreditoSegundoBeneficiario; }
            set { digitoContaCorrenteCreditoSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string valorOuParcelamentoRateio2;

        public string ValorOuParcelamentoRateio2
        {
            get { return valorOuParcelamentoRateio2; }
            set { valorOuParcelamentoRateio2 = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomeSegundoBeneficiario;

        public string NomeSegundoBeneficiario
        {
            get { return nomeSegundoBeneficiario; }
            set { nomeSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler3;

        public string Filler3
        {
            get { return filler3; }
            set { filler3 = Util.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela2;

        public string Parcela2
        {
            get { return parcela2; }
            set { parcela2 = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingSegundoBeneficiario;

        public string FloatingSegundoBeneficiario
        {
            get { return floatingSegundoBeneficiario; }
            set { floatingSegundoBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoBancoCreditoTerceiroBeneficiario;

        public string CodigoBancoCreditoTerceiroBeneficiario
        {
            get { return codigoBancoCreditoTerceiroBeneficiario; }
            set { codigoBancoCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string codigoAgenciaCreditoTerceiroBeneficiario;

        public string CodigoAgenciaCreditoTerceiroBeneficiario
        {
            get { return codigoAgenciaCreditoTerceiroBeneficiario; }
            set { codigoAgenciaCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string digitoAgenciaCreditoTerceiroBeneficiario;

        public string DigitoAgenciaCreditoTerceiroBeneficiario
        {
            get { return digitoAgenciaCreditoTerceiroBeneficiario; }
            set { digitoAgenciaCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string numeroContaCorrenteCreditoTerceiroBeneficiario;

        public string NumeroContaCorrenteCreditoTerceiroBeneficiario
        {
            get { return numeroContaCorrenteCreditoTerceiroBeneficiario; }
            set { numeroContaCorrenteCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 12); }
        }

        private string digitoContaCorrenteCreditoTerceiroBeneficiario;

        public string DigitoContaCorrenteCreditoTerceiroBeneficiario
        {
            get { return digitoContaCorrenteCreditoTerceiroBeneficiario; }
            set { digitoContaCorrenteCreditoTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string valorOuParcelamentoRateio3;

        public string ValorOuParcelamentoRateio3
        {
            get { return valorOuParcelamentoRateio3; }
            set { valorOuParcelamentoRateio3 = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string nomeTerceiroBeneficiario;

        public string NomeTerceiroBeneficiario
        {
            get { return nomeTerceiroBeneficiario; }
            set { nomeTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 40); }
        }

        private string filler4;

        public string Filler4
        {
            get { return filler4; }
            set { filler4 = Util.FormataCampoComEspacosDireita(value, 31); }
        }

        private string parcela3;

        public string Parcela3
        {
            get { return parcela3; }
            set { parcela3 = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string floatingTerceiroBeneficiario;

        public string FloatingTerceiroBeneficiario
        {
            get { return floatingTerceiroBeneficiario; }
            set { floatingTerceiroBeneficiario = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        public StringBuilder GetTransacao(TransacaoTipo3 stringTransacao)
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, stringTransacao.identificacaoRegistro);
            transacao.Insert(1, stringTransacao.identificacaoEmpresaBanco);
            transacao.Insert(17, stringTransacao.identificacaoTituloBanco);
            transacao.Insert(29, stringTransacao.codigoCalculoRateio);
            transacao.Insert(30, stringTransacao.tipoValorInformado);
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
