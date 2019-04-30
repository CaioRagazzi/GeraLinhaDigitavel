using System;
using System.Collections.Generic;
using System.Text;

namespace UtilRemessa
{
    public class EmpresaBeneficiariaBanco
    {
        #region propriedades
        public string Zero { get; } = "0";
        public string CodigoCarteira { get; } = "009";
        /// <summary>
        /// Sem digito
        /// </summary>
        public string CodigoAgenciaBeneficiario { get; } = "03392";
        public string DigitoAgencia { get; } = "0";
        public string ContaCorrente { get; } = "0000340";
        public string DigitoContaCorrente { get; } = "9";
        #endregion

        public EmpresaBeneficiariaBanco(string codigoCarteira, int codigoAgenciaBeneficiario, int digitoAgencia, int contaCorrente, int digitoContaCorrente)
        {
            this.CodigoCarteira = codigoCarteira.PadLeft(3,'0');
            this.CodigoAgenciaBeneficiario = codigoAgenciaBeneficiario.ToString().PadLeft(5,'0');
            this.DigitoAgencia = digitoAgencia.ToString().PadLeft(1,'0');
            this.ContaCorrente = contaCorrente.ToString().PadLeft(7,'0');
            this.DigitoContaCorrente = digitoContaCorrente.ToString();
        }

        public override string ToString()
        {
            return Zero + CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente + DigitoContaCorrente.PadLeft(1, '0');
        }

        public string ToStringTransacaoTipo1()
        {
            return Zero + CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente + DigitoContaCorrente.PadLeft(1, '0');
        }

        public string ToStringTransacaoTipo2()
        {
            return CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente + DigitoContaCorrente.PadLeft(1, '0');
        }

        public string ToStringTransacaoTipo3()
        {
            return CodigoAgenciaBeneficiario + DigitoAgencia + ContaCorrente + DigitoContaCorrente.PadLeft(1, '0');
        }

        public string ToStringTransacaoTipo6()
        {
            return CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente;
        }

        public string ToStringTransacaoTipo7()
        {
            return CodigoCarteira + CodigoAgenciaBeneficiario + ContaCorrente + DigitoContaCorrente.PadLeft(1, '0');
        }
    }
}
