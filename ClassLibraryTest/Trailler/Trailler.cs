using System;
using System.Text;

namespace ArquivoRemessa
{
    public class Trailler
    {
        private const string tipoRegistro = "9";

        private string branco = new string(' ', 393);

        public StringBuilder GetTrailler()
        {
            StringBuilder trailler = new StringBuilder(400);

            trailler.Insert(0, tipoRegistro);
            trailler.Insert(1, this.branco);

            var transacaoSemCaractereEspecial = UtilRemessa.FormataArquivo.SubstituiCaracteresEspeciais(Convert.ToString(trailler));

            trailler.Clear();
            trailler.Insert(0, transacaoSemCaractereEspecial);

            return trailler;
        }
    }
}
