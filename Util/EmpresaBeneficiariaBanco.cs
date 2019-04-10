using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class EmpresaBeneficiariaBanco
    {

        public string Zero { get; } = "0";
        public string CodigoCarteira { get; } = "009";
        /// <summary>
        /// Sem digito
        /// </summary>
        public string CodigoAgenciaBeneficiario { get; } = "03392";
        public string DigitoAgencia { get; } = "0";
        public string ContaCorrente { get; } = "0000340";
        public string DigitoContaCorrente { get; } = "9";

        public EmpresaBeneficiariaBanco()
        {

        }

        public EmpresaBeneficiariaBanco(string codigoCarteira, string codigoAgenciaBeneficiario, string digitoAgencia, string contaCorrente, string digitoContaCorrente)
        {
            this.CodigoCarteira = CodigoCarteira;
            this.CodigoAgenciaBeneficiario = CodigoAgenciaBeneficiario;
            this.DigitoAgencia = digitoAgencia;
            this.ContaCorrente = contaCorrente;
            this.DigitoContaCorrente = DigitoContaCorrente;
        }

        public override string ToString()
        {
            return Zero + CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente + DigitoContaCorrente;
        }

        public string ToStringTransacaoTipo1()
        {
            return Zero + CodigoCarteira.PadLeft(3, '0') + CodigoAgenciaBeneficiario.PadLeft(5, '0') + ContaCorrente.PadLeft(7, '0') + DigitoContaCorrente;
        }

        public string ToStringTransacaoTipo2()
        {
            return CodigoCarteira.PadLeft(3, '0') + CodigoAgenciaBeneficiario + ContaCorrente.PadLeft(7, '0') + DigitoContaCorrente;
        }

        public string ToStringTransacaoTipo3()
        {
            return CodigoAgenciaBeneficiario.PadLeft(5, '0') + DigitoAgencia + ContaCorrente.PadLeft(12, '0') + DigitoContaCorrente;
        }

        public string ToStringTransacaoTipo6()
        {
            return CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente;
        }

        public string ToStringTransacaoTipo7()
        {
            return CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente + DigitoContaCorrente;
        }
    }
}
