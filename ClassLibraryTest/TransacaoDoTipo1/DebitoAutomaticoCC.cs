﻿using ArquivoRemessa;
using System;
using System.Collections.Generic;
using System.Text;

namespace TransacaoDoTipo1
{
    public class DebitoAutomaticoCC
    {
        public string Agencia { get; } = "00000";
        public string DigitoAgencia { get; } = "0";
        public string RazaoConta { get; } = "00000";
        public string ContaCorrente { get; } = "0000000";
        public string DigitoContaCorrente { get; } = "0";

        public DebitoAutomaticoCC()
        {

        }

        public DebitoAutomaticoCC(string agencia, string digitoAgencia, string razaoConta, string contaCorrente, string DigitoContaCorrente)
        {
            this.Agencia = Util.FormataArquivo.FormataCampoComZerosEsquerda(agencia, 5);
            this.DigitoAgencia = Util.FormataArquivo.FormataCampoComZerosEsquerda(digitoAgencia, 1);
            this.RazaoConta = Util.FormataArquivo.FormataCampoComZerosEsquerda(razaoConta, 5);
            this.ContaCorrente = Util.FormataArquivo.FormataCampoComZerosEsquerda(contaCorrente,7);
            this.DigitoContaCorrente = Util.FormataArquivo.FormataCampoComZerosEsquerda(DigitoContaCorrente,1);
        }

    }
}
