using System;
using System.Text;
using ArquivoRemessa;
using Xunit;
using System.Numerics;
using System.Globalization;

namespace XUnitTestProject1
{
    public class UtilTest
    {
        [Fact]
        public void TestaMetodoFormataCampoComEspacosDireitaComStringPreenchida()
        {
            var campo = "REMESSA";
            var tamanho = 20;
            var resultado = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(campo, tamanho);
            var stringEsperada = "REMESSA             ";
            Assert.Equal(stringEsperada, resultado);
        }

        [Fact]
        public void FormataCampoComZerosEsquerdaComStringVazia()
        {
            var campo = "";
            var tamanho = 10;
            var resultado = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(campo, tamanho);
            var stringEsperada = "          ";
            Assert.Equal(stringEsperada, resultado);
        }

        [Fact]
        public void TestaMetodoFormataCampoComZerosEsquerdaComStringPreenchida()
        {
            var campo = "REMESSA";
            var tamanho = 20;
            var resultado = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(campo, tamanho);
            var stringEsperada = "0000000000000REMESSA";
            Assert.Equal(stringEsperada, resultado);
        }

        [Fact]
        public void TestaMetodoFormataCampoComZerosEsquerdaComStringVazia()
        {
            var campo = "";
            var tamanho = 20;
            var resultado = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(campo, tamanho);
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

            CampoLivreCodigoDeBarras campoLivre = new CampoLivreCodigoDeBarras("3392", "09", "90740000039", "0000340", "0");

            CodigoDeBarras codigoDeBarras = new CodigoDeBarras(banco.Codigo, moeda.Codigo, new DateTime(2025, 02, 21), "0000001809", campoLivre);

            LinhaDigitavel linha = new LinhaDigitavel(moeda, banco, campoLivre, codigoDeBarras);

            var resultado = linha.GetLinhaDigitavel();
            var stringEsperada = "23793392099907400000339000034007578430000001809";

            Assert.Equal(resultado, stringEsperada);

        }

        [Fact]
        public void TestaFatorVencimento()
        {
            CampoLivreCodigoDeBarras campoLivre = new CampoLivreCodigoDeBarras("3392", "09", "90740000039", "0000340", "0");
            CodigoDeBarras cd = new CodigoDeBarras("237", "9", new DateTime(2019, 03, 23), "0000009000", campoLivre) ;

            var teste = cd.GetFatorVencimento(new DateTime(2019, 03, 23));
        }

        [Fact]
        public void TestaConverterGuid()
        {
            var guidConvert = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            var guidBack = new Guid(Convert.FromBase64String(guidConvert));
        }

        [Fact]
        public void TestaData()
        {
            var data1 = new DateTime();
            var datastring = data1.ToString("ddMMyyyy");
        }

        [Fact]
        public void TestaMoney()
        {
            decimal money = 20.50m;
            var moneystring = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(money.ToString().Replace(",",""), 10);
        }

        [Fact]
        public void TestConvertStringToDecimal()
        {
            string valorString = "0000000130020";
            decimal d = decimal.Parse(valorString, CultureInfo.InvariantCulture);
        }
    }
}
