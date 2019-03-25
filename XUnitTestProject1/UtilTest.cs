using System;
using System.Text;
using ClassLibraryTest;
using Xunit;

namespace XUnitTestProject1
{
    public class UtilTest
    {
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

            CampoLivreCodigoDeBarras campoLivre = new CampoLivreCodigoDeBarras("3392", "09", "90740000039", "0000340", "0");

            CodigoDeBarras codigoDeBarras = new CodigoDeBarras(banco.Codigo, moeda.Codigo, new DateTime(2025, 02, 21), "0000001809", campoLivre);

            LinhaDigitavel linha = new LinhaDigitavel(moeda, banco, campoLivre, codigoDeBarras);

            var resultado = linha.GetLinhaDigitavel();
            var stringEsperada = "23793392099907400000339000034007578430000001809";

            Assert.Equal(resultado, stringEsperada);

        }

        [Fact]
        public void TestaSubtracao()
        {
            //DateTime data1 = new DateTime(2025, 02, 23);
            //DateTime data2 = new DateTime(1997, 10, 07);
            ////DateTime data3;

            //var data3 = data1.Subtract(data2).TotalDays.ToString();

            //if (data3.Length > 4)
            //{
            //    data2 = new DateTime(2022, 05, 29);
            //    return data3 = data1.Subtract(data2).TotalDays.ToString().Substring(0, 4);
            //}
            //else
            //{
            //    return data3.Substring(0, 4);
            //}

            //string teste = data3.ToString().Substring(0, 4);

        }
    }
}
