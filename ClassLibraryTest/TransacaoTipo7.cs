using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo7
    {
        private string tipoRegistro;
        /// <summary>
        /// Fixo 7
        /// </summary>
        public string TipoRegistro
        {
            get { return tipoRegistro; }
            set { tipoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string enderecoSacadorAvalista;
        /// <summary>
        /// Endereço Sacador/Avalista
        /// </summary>
        public string EnderecoSacadorAvalista
        {
            get { return enderecoSacadorAvalista; }
            set { enderecoSacadorAvalista = Util.FormataCampoComEspacosDireita(value, 45); }
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

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = Util.FormataCampoComEspacosDireita(value, 20); }
        }

        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string reserva;
        /// <summary>
        /// Filler
        /// </summary>
        public string Reserva
        {
            get { return reserva; }
            set { reserva = Util.FormataCampoComEspacosDireita(value, 290); }
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
        /// Número Bancário
        /// </summary>
        public string NossoNumero
        {
            get { return nossoNumero; }
            set { nossoNumero = Util.FormataCampoComEspacosDireita(value, 11); }
        }

        private string dacNossoNumero;
        /// <summary>
        /// Dígito N/N
        /// </summary>
        public string DacNossoNumero
        {
            get { return dacNossoNumero; }
            set { dacNossoNumero = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        /// <summary>
        /// Método responsável por montar a linha do Trailler.
        /// </summary>
        /// <param name="stringTransacao">Recebe um objeto do tipo TransacaoTipo7</param>
        /// <returns>Retorna um StringBuilder com a linha completa da transação do tipo 7.</returns>
        public StringBuilder GetTransacao(TransacaoTipo7 stringTransacao)
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, stringTransacao.tipoRegistro);
            transacao.Insert(1, stringTransacao.enderecoSacadorAvalista);
            transacao.Insert(46, stringTransacao.cep);
            transacao.Insert(51, stringTransacao.sufixoCep);
            transacao.Insert(54, stringTransacao.cidade);
            transacao.Insert(74, stringTransacao.uf);
            transacao.Insert(76, stringTransacao.reserva);
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
