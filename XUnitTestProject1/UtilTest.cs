using System;
using System.Text;
using ClassLibraryTest;
using Xunit;

namespace XUnitTestProject1
{
    public class UtilTest
    {
        public UtilTest()
        {
        }

        [Fact]
        public void TestaMetodoFormataCampoComEspacosDireitaComStringPreenchida()
        {
            var campo = "REMESSA";
            var tamanho = 20;
            var resultado = Util.FormataCampoComEspacosDireita(campo, tamanho);
            var stringEsperada = "REMESSA             ";
            Assert.Equal(stringEsperada, resultado);
        }

        [Fact]
        public void FormataCampoComZerosEsquerdaComStringVazia()
        {
            var campo = "";
            var tamanho = 10;
            var resultado = Util.FormataCampoComEspacosDireita(campo, tamanho);
            var stringEsperada = "          ";
            Assert.Equal(stringEsperada, resultado);
        }

        [Fact]
        public void TestaMetodoFormataCampoComZerosEsquerdaComStringPreenchida()
        {
            var campo = "REMESSA";
            var tamanho = 20;
            var resultado = Util.FormataCampoComZerosEsquerda(campo, tamanho);
            var stringEsperada = "0000000000000REMESSA";
            Assert.Equal(stringEsperada, resultado);
        }

        [Fact]
        public void TestaMetodoFormataCampoComZerosEsquerdaComStringVazia()
        {
            var campo = "";
            var tamanho = 20;
            var resultado = Util.FormataCampoComZerosEsquerda(campo, tamanho);
            var stringEsperada = "00000000000000000000";
            Assert.Equal(stringEsperada, resultado);
        }

        [Fact]
        public void TestaGeraLinhaDigitavel()
        {
            Banco banco = new Banco()
            {
                Codigo = "237",
                Nome = "Bradesco"
            };

            Moeda moeda = new Moeda()
            {
                Codigo = "9",
                Nome = "Real"
            };

            CampoLivreCodigoDeBarras campoLivre = new CampoLivreCodigoDeBarras("0031", "04", "00317720028", "0095279", "0");

            CodigoDeBarras codigoDeBarras = new CodigoDeBarras(banco.Codigo, moeda.Codigo, "1001", "0000000000", campoLivre);

            LinhaDigitavel linha = new LinhaDigitavel(moeda, banco, campoLivre, codigoDeBarras);

            var resultado = linha.GetLinhaDigitavel();
            var stringEsperada = "23790031024003177200328009527905710010000000000";

            Assert.Equal(resultado, stringEsperada);

        }
    } 
}
