using System;
using System.Text;
using UtilRemessa;

namespace ArquivoRemessa
{
    public class TransacaoTipo7
    {

        #region propriedades
        private const string tipoRegistro = "7";

        private string enderecoSacadorAvalista;
        /// <summary>
        /// Endereço Sacador/Avalista
        /// </summary>
        public string EnderecoSacadorAvalista
        {
            get { return enderecoSacadorAvalista; }
            set { enderecoSacadorAvalista = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 45); }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 5); }
        }

        private string sufixoCep;

        public string SufixoCep
        {
            get { return sufixoCep; }
            set { sufixoCep = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 20); }
        }

        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 2); }
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
                    throw new Exception($"Nosso número deve conter 11 dígitos, possui {value.Length}");
                }
                nossoNumero = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(value, 11);
            }
        }

        private string dacNossoNumero;


        /// <summary>
        /// Dígito N/N
        /// </summary>
        public string DacNossoNumero
        {
            get { return dacNossoNumero; }
            set { dacNossoNumero = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 1); }
        }
        #endregion
        
        /// <summary>
        /// Método responsável por montar a linha do Trailler.
        /// </summary>
        /// <param name="stringTransacao">Recebe um objeto do tipo TransacaoTipo7</param>
        /// <returns>Retorna um StringBuilder com a linha completa da transação do tipo 7.</returns>
        public DefaultOfPagination GetTransacao()
        {
            var retorno = new TransacaoDoTipo7.Validacao.ValidaTransacaoTipo7().Validate(this);

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
            transacao.Insert(1, this.enderecoSacadorAvalista);
            transacao.Insert(46, this.cep);
            transacao.Insert(51, this.sufixoCep);
            transacao.Insert(54, this.cidade);
            transacao.Insert(74, this.uf);
            transacao.Insert(76, this.reserva);
            transacao.Insert(366, empresaBeneficiariaBanco.ToStringTransacaoTipo7());
            transacao.Insert(382, this.nossoNumero);
            NossoNumero NN = new NossoNumero(this.nossoNumero, empresaBeneficiariaBanco.CodigoCarteira.Substring(1, 2));
            transacao.Insert(393, NN.GetDigitoNossoNumero());

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
