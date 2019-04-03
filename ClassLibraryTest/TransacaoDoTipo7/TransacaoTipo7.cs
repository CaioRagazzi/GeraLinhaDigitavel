using System;
using System.Text;

namespace ArquivoRemessa
{
    public class TransacaoTipo7
    {
        private const string tipoRegistro = "7";

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

        private string reserva = new string(' ', 290);

        public EmpresaBeneficiariaBanco empresaBeneficiariaBanco { get; set; }

        private string nossoNumero;
        /// <summary>
        /// Número Bancário
        /// </summary>
        public string NossoNumero
        {
            get { return nossoNumero; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("Nosso número deve conter 11 dígitos");
                }
                nossoNumero = Util.FormataCampoComZerosEsquerda(value, 11);
            }
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

        public TransacaoTipo7()
        {
            empresaBeneficiariaBanco = new EmpresaBeneficiariaBanco();
        }

        /// <summary>
        /// Método responsável por montar a linha do Trailler.
        /// </summary>
        /// <param name="stringTransacao">Recebe um objeto do tipo TransacaoTipo7</param>
        /// <returns>Retorna um StringBuilder com a linha completa da transação do tipo 7.</returns>
        public StringBuilder GetTransacao()
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, this.enderecoSacadorAvalista);
            transacao.Insert(46, this.cep);
            transacao.Insert(51, this.sufixoCep);
            transacao.Insert(54, this.cidade);
            transacao.Insert(74, this.uf);
            transacao.Insert(76, this.reserva);
            transacao.Insert(366, empresaBeneficiariaBanco.ToStringTransacaoTipo7());
            transacao.Insert(382, this.nossoNumero);
            NossoNumero NN = new NossoNumero
            {
                Carteira = empresaBeneficiariaBanco.CodigoCarteira.Substring(1, 2),
                NossoNumeroSemDigito = this.nossoNumero
            };
            transacao.Insert(393, NN.GetDigitoNossoNumero());

            return transacao;
        }
    }
}
