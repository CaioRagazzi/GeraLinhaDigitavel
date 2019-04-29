using System;
using System.Text;
using UtilRemessa;

namespace ArquivoRemessa
{
    public class Header
    {
        #region Propriedades
        private const string tipoRegistro = "0";

        private const string identificacaoArquivoRemessa = "1";

        private const string literalRemessa = "REMESSA";

        private const string codigoServico = "01";

        private const string literalServico = "COBRANCA       ";

        private string codEmpresa;
        /// <summary>
        /// Código da empresa. Será informado pelo Bradesco, quando do cadastramento da Conta beneficiário na sua Agência. Esse código deve ser alinhado à direita com Zeros à esquerda.
        /// </summary>
        public string CodEmpresa
        {
            get { return codEmpresa; }
            set { codEmpresa = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(value, 20); }
        }

        private string nomeEmpresa;
        /// <summary>
        /// Nome da empresa. Razão social.
        /// </summary>
        public string NomeEmpresa
        {
            
            get { return nomeEmpresa; }
            set { nomeEmpresa = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 30); }
        }

        private string numeroBradesco;
        /// <summary>
        /// Número do Bradesco na Câmara de Compensação
        /// </summary>
        public string NumeroBradesco
        {
            get { return numeroBradesco; }
            set { numeroBradesco = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 3); }
        }

        private string nomeBanco;
        /// <summary>
        /// Nome do Banco por Extenso.
        /// </summary>
        public string NomeBanco
        {
            get { return nomeBanco; }
            set { nomeBanco = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 15); }
        }

        private DateTime dataGravacaoArquivo;
        /// <summary>
        /// Data da Gravação do Arquivo. Para a retransmissão de um Arquivo Remessa rejeitado, será necessário alterar a data constante desse campo, bem como atualizar o número de remessa na posição 111 a 117 (número sequencial de remessa).
        /// </summary>
        public DateTime DataGravacaoArquivo
        {
            get { return dataGravacaoArquivo; }
            set { dataGravacaoArquivo = value; }
        }

        private string branco = new string(' ', 8);

        private string identSistema;

        public string IdentSistema
        {
            get { return identSistema; }
            set { identSistema = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 2); }
        }

        /// <summary>
        /// O número de remessa deve iniciar de 0000001 e incrementado de + 1 a cada NOVO Arquivo Remessa, com o objetivo de evitar que ocorra duplicidade de arquivo não podendo, em hipótese alguma, ser repetida ou zerada.
        /// </summary>
        private string numSeqRemessa;

        public string NumSeqRemessa
        {
            get { return numSeqRemessa; }
            set { numSeqRemessa = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(value, 7); }
        }

        private string branco2 = new string(' ', 277);
        #endregion

        /// <summary>
        /// Método responsável por montar a linha do Header do arquivo de remessa.
        /// </summary>
        /// <param name="stringHeader">Objeto do tipo Header</param>
        /// <param name="numSequencial">Numero sequencial para colocar na linha do boleto.</param>
        /// <returns>Retorna um StringBuilder com a linha do Header completa.</returns>
        public DefaultOfPagination GetHeader()
        {

            var retorno = new ValidaHeader().Validate(this);

            if (retorno.Errors.Count > 0)
            {
                return new DefaultOfPagination()
                {
                    Status = false,
                    Resultado = retorno.Errors
                };
            }

            StringBuilder header = new StringBuilder(400);

            header.Insert(0, tipoRegistro);
            header.Insert(1, identificacaoArquivoRemessa);
            header.Insert(2, literalRemessa);
            header.Insert(9, codigoServico);
            header.Insert(11, literalServico);
            header.Insert(26, this.codEmpresa);
            header.Insert(46, this.nomeEmpresa);
            header.Insert(76, this.numeroBradesco);
            header.Insert(79, this.nomeBanco);
            header.Insert(94, FormataArquivo.FormataCampoComZerosEsquerda(this.dataGravacaoArquivo.ToString("ddMMyy"), 6));
            header.Insert(100, this.branco);
            header.Insert(108, this.identSistema);
            header.Insert(110, numSeqRemessa);
            header.Insert(117, this.branco2);

            var transacaoSemCaractereEspecial = FormataArquivo.SubstituiCaracteresEspeciais(Convert.ToString(header));

            header.Clear();
            header.Insert(0, transacaoSemCaractereEspecial);

            return new DefaultOfPagination()
            {
                Status = true,
                Resultado = header
            };
        }
    }
}
