using ClassLibraryTest.Utils;
using System;
using System.Text;

namespace ClassLibraryTest
{
    class TransacaoTipo6
    {
        private const string tipoRegistro = "6";

        public EmpresaBeneficiariaBanco empresaBeneficiariaBanco { get; set; }

        private string nossoNumero;
        /// <summary>
        /// Nosso Número
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

        private string brancos = new string(' ', 365);

        public TransacaoTipo6()
        {
            empresaBeneficiariaBanco = new EmpresaBeneficiariaBanco();
        }

        public StringBuilder GetTransacao(TransacaoTipo6 stringTransacao)
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, empresaBeneficiariaBanco.ToStringTransacaoTipo6());
            transacao.Insert(16, stringTransacao.nossoNumero);
            NossoNumero NN = new NossoNumero
            {
                Carteira = empresaBeneficiariaBanco.CodigoCarteira.Substring(1, 2),
                NossoNumeroSemDigito = stringTransacao.nossoNumero
            };
            transacao.Insert(27, NN.GetDigitoNossoNumero());
            transacao.Insert(28, stringTransacao.brancos);

            return transacao;
        }
    }
}
