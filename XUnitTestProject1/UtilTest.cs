using System;
using System.Text;
using ArquivoRemessa;
using Xunit;
using System.Numerics;
using System.Globalization;
using UtilRemessa;

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
            //Banco banco = new Banco()
            //{
            //    Codigo = "237",
            //    Nome = "Bradesco"
            //};

            //Moeda moeda = new Moeda()
            //{
            //    Codigo = "9",
            //    Nome = "Real"
            //};

            //CampoLivreCodigoDeBarras campoLivre = new CampoLivreCodigoDeBarras("3392", "09", "90740000039", "0000340");
            CampoLivreCodigoDeBarras campoLivre = new CampoLivreCodigoDeBarras("3392", "09", "91090000046", "0000340");

            //CodigoDeBarras codigoDeBarras = new CodigoDeBarras(Banco.Bradesco, Moeda.Real, new DateTime(2025, 04, 17), 18.09M, campoLivre);
            CodigoDeBarras codigoDeBarras = new CodigoDeBarras(Banco.Bradesco, Moeda.Real, new DateTime(2019, 04, 17, 13, 22, 46), 6.48M, campoLivre);

            LinhaDigitavel linha = new LinhaDigitavel(codigoDeBarras);

            var resultado = linha.GetLinhaDigitavel();
            var stringEsperada = "23793392099907400000339000034007547890000001809";

            Assert.Equal(resultado, stringEsperada);

        }

        [Fact]
        public void TestaFatorVencimento()
        {
            CampoLivreCodigoDeBarras campoLivre = new CampoLivreCodigoDeBarras("3392", "09", "90740000039", "0000340");
            CodigoDeBarras cd = new CodigoDeBarras(Banco.Bradesco, Moeda.Real, new DateTime(2019, 03, 23), 90.00M, campoLivre) ;

            //var teste = cd.GetFatorVencimento(new DateTime(2019, 03, 23));
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

        [Fact]
        public void TestaLinhaDigitavel()
        {
            CampoLivreCodigoDeBarras clcb = new CampoLivreCodigoDeBarras("", "", "", "");
            CodigoDeBarras cdb = new CodigoDeBarras(Banco.Bradesco, Moeda.Real, new DateTime(2019, 04, 18), 12M, clcb);
            LinhaDigitavel ld = new LinhaDigitavel(cdb);

            var teste = cdb.GetStringCodigoDeBarras();
        }
    }
}
