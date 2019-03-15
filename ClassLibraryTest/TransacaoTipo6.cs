using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo6
    {
        private string identificacaoRegistro;

        public string IdentificacaoRegistro
        {
            get { return identificacaoRegistro; }
            set { identificacaoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string carteira;

        public string Carteira
        {
            get { return carteira; }
            set { carteira = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string agencia;

        public string Agencia
        {
            get { return agencia; }
            set { agencia = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string contaCorrente;

        public string ContaCorrente
        {
            get { return contaCorrente; }
            set { contaCorrente = Util.FormataCampoComEspacosDireita(value, 7); }
        }

        private string nossoNumero;

        public string NossoNumero
        {
            get { return nossoNumero; }
            set { nossoNumero = Util.FormataCampoComEspacosDireita(value, 11); }
        }

        private string digitoNossoNumero;

        public string DigitoNossoNumero
        {
            get { return digitoNossoNumero; }
            set { digitoNossoNumero = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string brancos;

        public string Brancos
        {
            get { return brancos; }
            set { brancos = Util.FormataCampoComEspacosDireita(value, 366); }
        }

        public StringBuilder GetTransacao(TransacaoTipo6 stringTransacao)
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, stringTransacao.identificacaoRegistro);
            transacao.Insert(1, stringTransacao.carteira);
            transacao.Insert(4, stringTransacao.agencia);
            transacao.Insert(9, stringTransacao.contaCorrente);
            transacao.Insert(16, stringTransacao.nossoNumero);
            transacao.Insert(27, stringTransacao.digitoNossoNumero);
            transacao.Insert(28, stringTransacao.brancos);

            return transacao;
        }
    }
}
