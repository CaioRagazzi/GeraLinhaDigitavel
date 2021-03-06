﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UtilRemessa
{
    public class LinhaDigitavel
    {
        private readonly string codigoMoeda;
        private readonly string codigoBanco;
        private readonly CampoLivreCodigoDeBarras campoLivre;
        private readonly string fatorVencimento;
        private readonly string valor;
        private readonly CodigoDeBarras codigoDeBarras;


        public LinhaDigitavel(CodigoDeBarras codigoDeBarras)
        {
            this.codigoMoeda = codigoDeBarras.codigoDaMoeda;
            this.codigoBanco = codigoDeBarras.codigoDoBanco;
            this.campoLivre = codigoDeBarras.campoLivre;
            this.fatorVencimento = codigoDeBarras.fatorVencimento;
            this.valor = UtilRemessa.FormataArquivo.FormataCampoComZerosEsquerda(codigoDeBarras.valor.ToString().Replace(",", ""), 10);
            this.codigoDeBarras = codigoDeBarras;
        }

        public string GetLinhaDigitavel()
        {
            StringBuilder primeiroCampo = new StringBuilder(10);
            StringBuilder segundoCampo = new StringBuilder(11);
            StringBuilder terceiroCampo = new StringBuilder(11);
            StringBuilder quartoCampo = new StringBuilder(1);
            StringBuilder quintoCampo = new StringBuilder(5);
            StringBuilder linhaDigitavel = new StringBuilder();

            primeiroCampo.Insert(0, codigoBanco); //Código do banco
            primeiroCampo.Insert(3, codigoMoeda); //Código da moeda
            primeiroCampo.Insert(4, campoLivre.GetStringCampoLivre().ToString().Substring(0, 5)); //Cinco primeira posições do campo livre
            primeiroCampo.Insert(9, GetDigitoVerificadorLinhaDigitavelNoveDigitos(primeiroCampo)); //Digito verificador

            segundoCampo.Insert(0, campoLivre.GetStringCampoLivre().ToString().Substring(5, 10)); //Posicao 6 a 15 do campo livre
            segundoCampo.Insert(10, GetDigitoVerificadorLinhaDigitavelDezDigitos(segundoCampo)); //Digito verificador

            terceiroCampo.Insert(0, campoLivre.GetStringCampoLivre().ToString().Substring(15, 10)); //Posicao 16 a 25 do campo livre
            terceiroCampo.Insert(10, GetDigitoVerificadorLinhaDigitavelDezDigitos(terceiroCampo)); //Digito verificador

            quartoCampo.Insert(0, codigoDeBarras.digitoVerificadorCodigoDeBarras); //Digito verificador codigo de barras

            quintoCampo.Insert(0, fatorVencimento); //Fator de vencimento
            quintoCampo.Insert(4, valor); //VALORDOCUMENTO

            linhaDigitavel.Append(primeiroCampo.ToString()).Append(segundoCampo.ToString()).Append(terceiroCampo.ToString()).Append(quartoCampo.ToString()).Append(quintoCampo.ToString());

            return linhaDigitavel.ToString();
        }

        private string GetDigitoVerificadorLinhaDigitavelNoveDigitos(StringBuilder campo)
        {
            string campoParaCalculo = campo.ToString();
            int somatoria = 0;
            const string numeroMultiplicador = "212121212";

            for (int i = 0; i < campoParaCalculo.Length; i++)
            {
                var multiplicacao = Convert.ToInt32(campoParaCalculo[i].ToString()) * Convert.ToInt32(numeroMultiplicador[i].ToString());

                if (multiplicacao >= 10)
                {
                    var calculo = multiplicacao.ToString();
                    foreach (var item in calculo)
                    {
                        somatoria += Convert.ToInt32(item.ToString());
                    }
                }
                else
                {
                    somatoria += multiplicacao;
                }
            }

            var sub = GetProximoMultiploDeDez(somatoria);

            return (sub - somatoria).ToString();
        }

        private string GetDigitoVerificadorLinhaDigitavelDezDigitos(StringBuilder campo)
        {
            string campoParaCalculo = campo.ToString();
            int somatoria = 0;
            string numeroMultiplicador = "1212121212";

            for (int i = 0; i < campoParaCalculo.Length; i++)
            {
                var multiplicacao = Convert.ToInt32(campoParaCalculo[i].ToString()) * Convert.ToInt32(numeroMultiplicador[i].ToString());

                if (multiplicacao >= 10)
                {
                    var calculo = multiplicacao.ToString();
                    foreach (var item in calculo)
                    {
                        somatoria += Convert.ToInt32(item.ToString());
                    }
                }
                else
                {
                    somatoria += multiplicacao;
                }
            }

            var sub = GetProximoMultiploDeDez(somatoria);

            return (sub - somatoria).ToString();
        }

        private int GetProximoMultiploDeDez(int somatoria)
        {
            var resto = somatoria % 10;

            if (resto == 0)
            {
                return somatoria;
            }
            else
            {
                return (somatoria - resto) + 10;
            }
        }
    }
}
