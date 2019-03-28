using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest.TransacaoDoTipo1
{
    class EmpresaBeneficiariaBanco
    {

        public string Zero { get; } = "0";
        public string CodigoCarteira { get; } = "009";
        /// <summary>
        /// Sem digito
        /// </summary>
        public string CodigoAgenciaBeneficiario { get; } = "03392";
        public string ContaCorrente { get; } = "0000340";
        public string DigitoContaCorrente { get; } = "9";

        public EmpresaBeneficiariaBanco()
        {

        }

        public EmpresaBeneficiariaBanco(string codigoCarteira, string codigoAgenciaBeneficiario, string contaCorrente, string digitoContaCorrente)
        {
            this.CodigoCarteira = CodigoCarteira;
            this.CodigoAgenciaBeneficiario = CodigoAgenciaBeneficiario;
            this.ContaCorrente = contaCorrente;
            this.DigitoContaCorrente = DigitoContaCorrente;
        }

        public override string ToString()
        {
            return Zero+CodigoCarteira+CodigoAgenciaBeneficiario+ContaCorrente+DigitoContaCorrente;
        }
    }
}
