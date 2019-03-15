using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest
{
    public class CodigoDeBarras
    {
        private readonly string codigoDoBanco;
        private readonly string codigoDaMoeda;
        public readonly string digitoVerificadorCodigoDeBarras;
        public readonly string fatorVencimento;
        public readonly string valor;
        private readonly CampoLivreCodigoDeBarras campoLivre;

        public CodigoDeBarras(string codigoDoBanco, string codigoDaMoeda, string fatorVencimento, string valor, CampoLivreCodigoDeBarras campoLivre)
        {
            this.codigoDoBanco = codigoDoBanco;
            this.codigoDaMoeda = codigoDaMoeda;
            this.fatorVencimento = fatorVencimento;
            this.valor = valor;
            this.campoLivre = campoLivre;
            this.digitoVerificadorCodigoDeBarras = GetDigitoVerificadorCodigoDeBarras();
        }

        public StringBuilder GetStringCodigoDeBarras()
        {
            StringBuilder stringDadosCodigoDeBarras = new StringBuilder(43);

            stringDadosCodigoDeBarras.Insert(0, codigoDoBanco); //Identificação do banco
            stringDadosCodigoDeBarras.Insert(3, codigoDaMoeda); //Código da Moeda (Real = 9, Outras=0)
            stringDadosCodigoDeBarras.Insert(4, GetDigitoVerificadorCodigoDeBarras()); //Dígito verificador do Código de Barras
            stringDadosCodigoDeBarras.Insert(5, fatorVencimento); //Fator de Vencimento (Vide Nota)
            stringDadosCodigoDeBarras.Insert(9, valor); //Valor
            stringDadosCodigoDeBarras.Insert(19, campoLivre); //Campo Livre

            return stringDadosCodigoDeBarras;
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
