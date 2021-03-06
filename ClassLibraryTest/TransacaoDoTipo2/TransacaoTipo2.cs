﻿using System;
using System.Globalization;
using System.Text;
using UtilRemessa;

namespace ArquivoRemessa
{
    public class TransacaoTipo2
    {

        #region propriedades
        private const string tipoRegistro = "2";

        private string mensagem1;

        public string Mensagem1
        {
            get { return mensagem1; }
            set { mensagem1 = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 80); }
        }

        private string mensagem2;

        public string Mensagem2
        {
            get { return mensagem2; }
            set { mensagem2 = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 80); }
        }

        private string mensagem3;

        public string Mensagem3
        {
            get { return mensagem3; }
            set { mensagem3 = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 80); }
        }

        private string mensagem4;

        public string Mensagem4
        {
            get { return mensagem4; }
            set { mensagem4 = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 80); }
        }

        private DateTime dataLimiteDesconto2;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public DateTime DataLimiteDesconto2
        {
            get { return dataLimiteDesconto2; }
            set { dataLimiteDesconto2 = value; }
        }

        private decimal valorDesconto2;

        public decimal ValorDesconto2
        {
            get { return valorDesconto2; }
            set { valorDesconto2 = value; }
        }

        private DateTime dataLimiteDesconto3;
        /// <summary>
        /// DDMMAA
        /// </summary>
        public DateTime DataLimiteDesconto3
        {
            get { return dataLimiteDesconto3; }
            set { dataLimiteDesconto3 = value; }
        }

        private decimal valorDesconto3;

        public decimal ValorDesconto3
        {
            get { return valorDesconto3; }
            set { valorDesconto3 = value; }
        }

        private string reserva = "       ";

        public EmpresaBeneficiariaBanco BeneficiariaBanco { get; set; }

        private string nossoNumero;
        /// <summary>
        /// Número Bancário. Esses campos deverão ser preenchidos, de acordo com a posição 71 a 82 do registro de transação - tipo 1.
        /// </summary>
        public string NossoNumero
        {
            get { return nossoNumero; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception($"Nosso número deve conter 11 dígitos, possui {value.Length}");
                }
                nossoNumero = UtilRemessa.FormataArquivo.FormataCampoComEspacosDireita(value, 11);
            }
        }
        #endregion

        public DefaultOfPagination GetTransacao()
        {

            var retorno = new TransacaoDoTipo2.Validacao.ValidaTransacaoTipo2().Validate(this);

            if (retorno.Errors.Count > 0)
            {
                return new DefaultOfPagination()
                {
                    Status = false,
                    Resultado = retorno.Errors
                };
            }

            StringBuilder transacao = new StringBuilder(400);

            transacao.Insert(0, tipoRegistro);
            transacao.Insert(1, this.mensagem1);
            transacao.Insert(81, this.mensagem2);
            transacao.Insert(161, this.mensagem3);
            transacao.Insert(241, this.mensagem4);
            transacao.Insert(321, FormataArquivo.FormataCampoComZerosEsquerda(this.dataLimiteDesconto2.ToString("ddMMyy"), 6));
            if (this.valorDesconto2 == 0m)
            {
                transacao.Insert(327, FormataArquivo.FormataCampoComEspacosDireita(this.valorDesconto2.ToString().Replace(",", ""), 13));
            }
            else if (this.valorDesconto2 != 0m)
            {
                transacao.Insert(327, FormataArquivo.FormataCampoComZerosEsquerda(this.valorDesconto2.ToString().Replace(",", ""), 13));
            }
            transacao.Insert(340, FormataArquivo.FormataCampoComZerosEsquerda(this.dataLimiteDesconto3.ToString("ddMMyy"), 6));
            if (this.valorDesconto3 == 0m)
            {
                transacao.Insert(346, FormataArquivo.FormataCampoComEspacosDireita(this.valorDesconto3.ToString().Replace(",", ""), 13));
            }
            else if (this.valorDesconto3 != 0m)
            {
                transacao.Insert(346, FormataArquivo.FormataCampoComZerosEsquerda(this.valorDesconto3.ToString().Replace(",", ""), 13));
            }
            transacao.Insert(359, this.reserva);
            transacao.Insert(366, BeneficiariaBanco.ToStringTransacaoTipo2());
            transacao.Insert(382, this.nossoNumero);
            NossoNumero NN = new NossoNumero(this.nossoNumero, BeneficiariaBanco.CodigoCarteira.Substring(1, 2));
            transacao.Insert(393, NN.GetDigitoNossoNumero());

            var transacaoSemCaractereEspecial = FormataArquivo.SubstituiCaracteresEspeciais(Convert.ToString(transacao));

            transacao.Clear();
            transacao.Insert(0, transacaoSemCaractereEspecial);

            return new DefaultOfPagination()
            {
                Status = true,
                Resultado = transacao
            };
        }
    }
}
