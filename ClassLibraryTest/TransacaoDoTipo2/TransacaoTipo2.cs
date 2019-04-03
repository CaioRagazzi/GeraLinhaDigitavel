using System;
using System.Globalization;
using System.Text;

namespace ArquivoRemessa
{
    public class TransacaoTipo2
    {
        private const string tipoRegistro = "2";

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

        private DateTime dataLimiteDesconto2;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public DateTime DataLimiteDesconto2
        {
            get { return dataLimiteDesconto2; }
            set { dataLimiteDesconto2 = value; }
        }

        private decimal valorDesconto2;

        public decimal ValorDesconto2
        {
            get { return valorDesconto2; }
            set { valorDesconto2 = value; }
        }

        private DateTime dataLimiteDesconto3;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public DateTime DataLimiteDesconto3
        {
            get { return dataLimiteDesconto3; }
            set { dataLimiteDesconto3 = value; }
        }

        private decimal valorDesconto3;

        public decimal ValorDesconto3
        {
            get { return valorDesconto3; }
            set { valorDesconto3 = value; }
        }

        private string reserva = "       ";

        public EmpresaBeneficiariaBanco BeneficiariaBanco { get; set; }

        private string nossoNumero;
        /// <summary>
        /// Número Bancário. Esses campos deverão ser preenchidos, de acordo com a posição 71 a 82 do registro de transação - tipo 1.
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
                nossoNumero = Util.FormataCampoComEspacosDireita(value, 11);
            }
        }

        public TransacaoTipo2()
        {
            BeneficiariaBanco = new EmpresaBeneficiariaBanco();
        }

        public StringBuilder GetTransacao()
        {
            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, this.mensagem1);
            transacao.Insert(81, this.mensagem2);
            transacao.Insert(161, this.mensagem3);
            transacao.Insert(241, this.mensagem4);
            transacao.Insert(321, Util.FormataCampoComZerosEsquerda(this.dataLimiteDesconto2.ToString("ddMMyy"), 6));
            transacao.Insert(327, Util.FormataCampoComZerosEsquerda(this.valorDesconto2.ToString().Replace(",", ""), 13));
            transacao.Insert(340, Util.FormataCampoComZerosEsquerda(this.dataLimiteDesconto3.ToString("ddMMyy"), 6));
            transacao.Insert(346, Util.FormataCampoComZerosEsquerda(this.valorDesconto3.ToString().Replace(",", ""), 13));
            transacao.Insert(359, this.reserva);
            transacao.Insert(366, BeneficiariaBanco.ToStringTransacaoTipo2());
            transacao.Insert(382, this.nossoNumero);
            NossoNumero NN = new NossoNumero
            {
                Carteira = "09",
                NossoNumeroSemDigito = this.nossoNumero
            };
            transacao.Insert(393, NN.GetDigitoNossoNumero());

            return transacao;
        }
    }
}
