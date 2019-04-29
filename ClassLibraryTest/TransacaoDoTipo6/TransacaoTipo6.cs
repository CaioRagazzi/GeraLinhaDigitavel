using System;
using System.Text;
using UtilRemessa;

namespace ArquivoRemessa
{
    public class TransacaoTipo6
    {

        #region propriedades
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
                    throw new Exception($"Nosso número deve conter 11 dígitos, possui {value.Length}");
                }
                nossoNumero = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(value, 11);
            }
        }

        private string brancos = new string(' ', 365);
        #endregion

        public TransacaoTipo6()
        {
            //empresaBeneficiariaBanco = new EmpresaBeneficiariaBanco();
        }

        public DefaultOfPagination GetTransacao()
        {
            var retorno = new TransacaoDoTipo6.Validacao.ValidaTransacaoTipo6().Validate(this);

            if (retorno.Errors.Count > 0)
            {
                return new DefaultOfPagination()
                {
                    Status = false,
                    Resultado = retorno.Errors
                };
            }

            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, empresaBeneficiariaBanco.ToStringTransacaoTipo6());
            transacao.Insert(16, this.nossoNumero);
            NossoNumero NN = new NossoNumero(this.nossoNumero, empresaBeneficiariaBanco.CodigoCarteira.Substring(1, 2));
            //{
            //    Carteira = empresaBeneficiariaBanco.CodigoCarteira.Substring(1, 2),
            //    NossoNumeroSemDigito = this.nossoNumero
            //};
            transacao.Insert(27, NN.GetDigitoNossoNumero());
            transacao.Insert(28, this.brancos);

            var transacaoSemCaractereEspecial = UtilRemessa.FormataArquivo.SubstituiCaracteresEspeciais(Convert.ToString(transacao));

            transacao.Clear();
            transacao.Insert(0, transacaoSemCaractereEspecial);

            return new DefaultOfPagination()
            {
                Status = true,
                Resultado = transacao
            };
        }
    }
}
