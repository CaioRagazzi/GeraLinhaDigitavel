using ArquivoRemessa;
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
            this.Agencia = Util.FormataCampoComZerosEsquerda(agencia, 5);
            this.DigitoAgencia = Util.FormataCampoComZerosEsquerda(digitoAgencia, 1);
            this.RazaoConta = Util.FormataCampoComZerosEsquerda(razaoConta, 5);
            this.ContaCorrente = Util.FormataCampoComZerosEsquerda(contaCorrente,7);
            this.DigitoContaCorrente = Util.FormataCampoComZerosEsquerda(DigitoContaCorrente,1);
        }

    }
}
