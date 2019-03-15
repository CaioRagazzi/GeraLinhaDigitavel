using System.Text;

namespace ClassLibraryTest
{
    class Header
    {
        private string identificacaoRegistro;

        public string IdentificacaoRegistro
        {
            get { return identificacaoRegistro; }
            set { identificacaoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string identificacaoArquivoRemessa;

        public string IdentificacaoArquivoRemessa
        {
            get { return identificacaoArquivoRemessa; }
            set { identificacaoArquivoRemessa = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string literalRemessa;

        public string LiteralRemessa
        {
            get { return literalRemessa; }
            set { literalRemessa = Util.FormataCampoComEspacosDireita(value, 7); }
        }

        private string codigoServico;

        public string CodigoServico
        {
            get { return codigoServico; }
            set { codigoServico = Util.FormataCampoComEspacosDireita(value, 2); }
        }

        private string literalServico;

        public string LiteralServico
        {
            get { return literalServico; }
            set { literalServico = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string codEmpresa;

        public string CodEmpresa
        {
            get { return codEmpresa; }
            set { codEmpresa = Util.FormataCampoComZerosEsquerda(value, 20); }
        }

        private string nomeEmpresa;

        public string NomeEmpresa
        {
            
            get { return nomeEmpresa; }
            set { nomeEmpresa = Util.FormataCampoComEspacosDireita(value, 30); }
        }

        private string numeroBradesco;

        public string NumeroBradesco
        {
            get { return numeroBradesco; }
            set { numeroBradesco = Util.FormataCampoComEspacosDireita(value, 3); }
        }

        private string nomeBanco;

        public string NomeBanco
        {
            get { return nomeBanco; }
            set { nomeBanco = Util.FormataCampoComEspacosDireita(value, 15); }
        }

        private string dataGravacaoArquivo;

        public string DataGravacaoArquivo
        {
            get { return dataGravacaoArquivo; }
            set { dataGravacaoArquivo = Util.FormataCampoComEspacosDireita(value, 6); }
        }

        private string branco;

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

        private string branco2;

        public string Branco2
        {
            get { return branco2; }
            set { branco2 = Util.FormataCampoComEspacosDireita(value, 277); }
        }

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
            header.Insert(110, numSequencial.PadLeft(7, '0'));
            header.Insert(117, stringHeader.branco2);
            header.Insert(394, numSequencial);

            return header;
        }
    }
}
