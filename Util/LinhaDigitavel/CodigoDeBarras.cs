using System;
using System.Collections.Generic;
using System.Text;

namespace UtilRemessa
{
    public class CodigoDeBarras
    {
        internal readonly string codigoDoBanco;
        internal readonly string codigoDaMoeda;
        internal readonly string digitoVerificadorCodigoDeBarras;
        internal readonly string fatorVencimento;
        internal readonly string valor;
        internal readonly CampoLivreCodigoDeBarras campoLivre;

        public CodigoDeBarras(Banco codigoDoBanco, Moeda codigoDaMoeda, DateTime fatorVencimento, decimal valor, CampoLivreCodigoDeBarras campoLivre)
        {
            this.codigoDoBanco = Convert.ToString((int)codigoDoBanco);
            this.codigoDaMoeda = Convert.ToString((int)codigoDaMoeda);
            this.fatorVencimento = GetFatorVencimento(fatorVencimento);
            this.valor = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(valor.ToString().Replace(",", ""), 10);
            this.campoLivre = campoLivre;
            this.digitoVerificadorCodigoDeBarras = GetDigitoVerificadorCodigoDeBarras();
        }

        public string GetStringCodigoDeBarras()
        {
            StringBuilder stringDadosCodigoDeBarras = new StringBuilder(43);

            stringDadosCodigoDeBarras.Insert(0, codigoDoBanco); //Identificação do banco
            stringDadosCodigoDeBarras.Insert(3, codigoDaMoeda); //Código da Moeda (Real = 9, Outras=0)
            stringDadosCodigoDeBarras.Insert(4, GetDigitoVerificadorCodigoDeBarras()); //Dígito verificador do Código de Barras
            stringDadosCodigoDeBarras.Insert(5, fatorVencimento); //Fator de Vencimento (Vide Nota)
            stringDadosCodigoDeBarras.Insert(9, valor); //Valor
            stringDadosCodigoDeBarras.Insert(19, campoLivre); //Campo Livre

            return stringDadosCodigoDeBarras.ToString();
        }

        private string GetFatorVencimento(DateTime dataDeVencimento)
        {
            DateTime data2 = new DateTime(1997, 10, 07);

            var dataTratada = new DateTime(dataDeVencimento.Year, dataDeVencimento.Month, dataDeVencimento.Day);

            var data3 = dataTratada.Subtract(data2).TotalDays.ToString();

            if (data3.Length > 4)
            {
                data2 = new DateTime(2022, 05, 29);
                return data3 = dataDeVencimento.Subtract(data2).TotalDays.ToString().Substring(0, 4);
            }
            else
            {
                return data3.Substring(0, 4);
            }
        }

        private string GetDigitoVerificadorCodigoDeBarras()
        {
            var stringParaCalculo = new StringBuilder();
            var stringBanco = "4329876543298765432987654329876543298765432";
            int somatoria = 0;

            stringParaCalculo.Append(codigoDoBanco).Append(codigoDaMoeda).Append(fatorVencimento).Append(valor).Append(campoLivre.ToString());

            for (int i = stringParaCalculo.Length - 1; i >= 0; i--)
            {
                var multiplicacao = Convert.ToInt32(stringParaCalculo[i].ToString()) * Convert.ToInt32(stringBanco[i].ToString());

                somatoria += multiplicacao;
            }

            // TODO: Verificar se esta correto
            var resto = (somatoria % 11);
            var digito = 11 - resto;

            if (digito == 0 || digito == 1 || digito > 9)
            {
                digito = 1;
            }

            return digito.ToString();
        }

    }
}
