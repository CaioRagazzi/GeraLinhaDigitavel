using System.Text;

namespace ClassLibraryTest
{
    class Trailler
    {
        private string identificacaoRegistro;

        public string IdentificacaoRegistro
        {
            get { return identificacaoRegistro; }
            set { identificacaoRegistro = Util.FormataCampoComEspacosDireita(value, 1); }
        }

        private string branco;

        public string Branco
        {
            get { return branco; }
            set { branco = Util.FormataCampoComEspacosDireita(value, 393); }
        }

        public StringBuilder GetTrailler(Trailler stringTrailler, string numSequencial)
        {
            StringBuilder trailler = new StringBuilder(400);

            trailler.Insert(0, stringTrailler.identificacaoRegistro);
            trailler.Insert(1, stringTrailler.branco);
            trailler.Insert(394, numSequencial);

            return trailler;
        }
    }
}
