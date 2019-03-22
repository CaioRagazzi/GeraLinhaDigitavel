using System.Text;

namespace ClassLibraryTest
{
    class Header
    {
        private string identificacaoRegistro;
        /// <summary>
        /// Identificação do registro
        /// </summary>
        public string IdentificacaoRegistro
        {
            get { return identificacaoRegistro; }
            set { identificacaoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoArquivoRemessa;
        /// <summary>
        /// Identificação do arquivo remessa
        /// </summary>
        public string IdentificacaoArquivoRemessa
        {
            get { return identificacaoArquivoRemessa; }
            set { identificacaoArquivoRemessa = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string literalRemessa;
        /// <summary>
        /// Literal remessa
        /// </summary>
        public string LiteralRemessa
        {
            get { return literalRemessa; }
            set { literalRemessa = Util.FormataCampoComEspacosDireita(value, 7); }
        }

        private string codigoServico;
        /// <summary>
        /// Código serviço
        /// </summary>
        public string CodigoServico
        {
            get { return codigoServico; }
            set { codigoServico = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string literalServico;
        /// <summary>
        /// Literal serviço
        /// </summary>
        public string LiteralServico
        {
            get { return literalServico; }
            set { literalServico = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string codEmpresa;
        /// <summary>
        /// Código da empresa. Será informado pelo Bradesco, quando do cadastramento da Conta beneficiário na sua Agência. Esse código deve ser alinhado à direita com Zeros à esquerda.
        /// </summary>
        public string CodEmpresa
        {
            get { return codEmpresa; }
            set { codEmpresa = Util.FormataCampoComZerosEsquerda(value, 20); }
        }

        private string nomeEmpresa;
        /// <summary>
        /// Nome da empresa. Razão social.
        /// </summary>
        public string NomeEmpresa
        {
            
            get { return nomeEmpresa; }
            set { nomeEmpresa = Util.FormataCampoComEspacosDireita(value, 30); }
        }

        private string numeroBradesco;
        /// <summary>
        /// Número do Bradesco na Câmara de Compensação
        /// </summary>
        public string NumeroBradesco
        {
            get { return numeroBradesco; }
            set { numeroBradesco = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string nomeBanco;
        /// <summary>
        /// Nome do Banco por Extenso.
        /// </summary>
        public string NomeBanco
        {
            get { return nomeBanco; }
            set { nomeBanco = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string dataGravacaoArquivo;
        /// <summary>
        /// Data da Gravação do Arquivo. Para a retransmissão de um Arquivo Remessa rejeitado, será necessário alterar a data constante desse campo, bem como atualizar o número de remessa na posição 111 a 117 (número sequencial de remessa).
        /// </summary>
        public string DataGravacaoArquivo
        {
            get { return dataGravacaoArquivo; }
            set { dataGravacaoArquivo = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string branco;
        /// <summary>
        /// Branco
        /// </summary>
        public string Branco
        {
            get { return branco; }
            set { branco = Util.FormataCampoComEspacosDireita(value, 8); }
        }

        private string identSistema;

        public string IdentSistema
        {
            get { return identSistema; }
            set { identSistema = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        /// <summary>
        /// O número de remessa deve iniciar de 0000001 e incrementado de + 1 a cada NOVO Arquivo Remessa, com o objetivo de evitar que ocorra duplicidade de arquivo não podendo, em hipótese alguma, ser repetida ou zerada.
        /// </summary>
        private string numSeqRemessa;

        public string NumSeqRemessa
        {
            get { return numSeqRemessa; }
            set { numSeqRemessa = value; }
        }

        private string branco2;

        public string Branco2
        {
            get { return branco2; }
            set { branco2 = Util.FormataCampoComEspacosDireita(value, 277); }
        }

        /// <summary>
        /// Método responsável por montar a linha do Header do arquivo de remessa.
        /// </summary>
        /// <param name="stringHeader">Objeto do tipo Header</param>
        /// <param name="numSequencial">Numero sequencial para colocar na linha do boleto.</param>
        /// <returns>Retorna um StringBuilder com a linha do Header completa.</returns>
        public StringBuilder GetHeader(Header stringHeader, string numSequencial)
        {

            StringBuilder header = new StringBuilder(400);

            header.Insert(0, stringHeader.identificacaoRegistro);
            header.Insert(1, stringHeader.identificacaoArquivoRemessa);
            header.Insert(2, stringHeader.literalRemessa);
            header.Insert(9, stringHeader.codigoServico);
            header.Insert(11, stringHeader.literalServico);
            header.Insert(26, stringHeader.codEmpresa);
            header.Insert(46, stringHeader.nomeEmpresa);
            header.Insert(76, stringHeader.numeroBradesco);
            header.Insert(79, stringHeader.nomeBanco);
            header.Insert(94, stringHeader.dataGravacaoArquivo);
            header.Insert(100, stringHeader.branco);
            header.Insert(108, stringHeader.identSistema);
            header.Insert(110, numSeqRemessa);
            header.Insert(117, stringHeader.branco2);
            header.Insert(394, numSequencial);

            return header;
        }
    }
}
