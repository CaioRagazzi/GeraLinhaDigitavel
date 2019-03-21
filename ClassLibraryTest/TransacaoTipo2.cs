using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo2
    {
        private string tipoRegistro;

        public string TipoRegistro
        {
            get { return tipoRegistro; }
            set { tipoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string mensagem1;

        public string Mensagem1
        {
            get { return mensagem1; }
            set { mensagem1 = Util.FormataCampoComEspacosDireita(value, 80); }
        }

        private string mensagem2;

        public string Mensagem2
        {
            get { return mensagem2; }
            set { mensagem2 = Util.FormataCampoComEspacosDireita(value, 80); }
        }

        private string mensagem3;

        public string Mensagem3
        {
            get { return mensagem3; }
            set { mensagem3 = Util.FormataCampoComEspacosDireita(value, 80); }
        }

        private string mensagem4;

        public string Mensagem4
        {
            get { return mensagem4; }
            set { mensagem4 = Util.FormataCampoComEspacosDireita(value, 80); }
        }

        private string dataLimiteDesconto2;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public string DataLimiteDesconto2
        {
            get { return dataLimiteDesconto2; }
            set { dataLimiteDesconto2 = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string valorDesconto2;

        public string ValorDesconto2
        {
            get { return valorDesconto2; }
            set { valorDesconto2 = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string dataLimiteDesconto3;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public string DataLimiteDesconto3
        {
            get { return dataLimiteDesconto3; }
            set { dataLimiteDesconto3 = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string valorDesconto3;

        public string ValorDesconto3
        {
            get { return valorDesconto3; }
            set { valorDesconto3 = Util.FormataCampoComEspacosDireita(value, 13); }
        }

        private string reserva;
        /// <summary>
        /// Filler
        /// </summary>
        public string Reserva
        {
            get { return reserva; }
            set { reserva = Util.FormataCampoComEspacosDireita(value, 7); }
        }

        private string carteira;
        /// <summary>
        /// Nº da Carteira
        /// </summary>
        public string Carteira
        {
            get { return carteira; }
            set { carteira = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string agencia;
        /// <summary>
        /// Código da Agência Beneficiário
        /// </summary>
        public string Agencia
        {
            get { return agencia; }
            set { agencia = Util.FormataCampoComEspacosDireita(value, 5); }
        }

        private string contaCorrente;
        /// <summary>
        /// Nº da Conta Corrente
        /// </summary>
        public string ContaCorrente
        {
            get { return contaCorrente; }
            set { contaCorrente = Util.FormataCampoComEspacosDireita(value, 7); }
        }

        private string digitoCC;
        /// <summary>
        /// DAC C/C
        /// </summary>
        public string DigitoCC
        {
            get { return digitoCC; }
            set { digitoCC = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string nossoNumero;
        /// <summary>
        /// Número Bancário. Esses campos deverão ser preenchidos, de acordo com a posição 71 a 82 do registro de transação - tipo 1.
        /// </summary>
        public string NossoNumero
        {
            get { return nossoNumero; }
            set { nossoNumero = Util.FormataCampoComEspacosDireita(value, 11); }
        }

        private string dacNossoNumero;

        public string DacNossoNumero
        {
            get { return dacNossoNumero; }
            set { dacNossoNumero = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        public StringBuilder GetTransacao(TransacaoTipo2 stringTransacao)
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, stringTransacao.tipoRegistro);
            transacao.Insert(1, stringTransacao.mensagem1);
            transacao.Insert(81, stringTransacao.mensagem2);
            transacao.Insert(161, stringTransacao.mensagem3);
            transacao.Insert(241, stringTransacao.mensagem4);
            transacao.Insert(321, stringTransacao.dataLimiteDesconto2);
            transacao.Insert(327, stringTransacao.valorDesconto2);
            transacao.Insert(340, stringTransacao.dataLimiteDesconto3);
            transacao.Insert(346, stringTransacao.valorDesconto3);
            transacao.Insert(359, stringTransacao.reserva);
            transacao.Insert(366, stringTransacao.carteira);
            transacao.Insert(369, stringTransacao.agencia);
            transacao.Insert(374, stringTransacao.contaCorrente);
            transacao.Insert(381, stringTransacao.digitoCC);
            transacao.Insert(382, stringTransacao.nossoNumero);
            transacao.Insert(393, stringTransacao.dacNossoNumero);

            return transacao;
        }
    }
}
