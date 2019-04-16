using System;
using System.Collections.Generic;
using System.Text;

namespace UtilRemessa
{
    public class CampoLivreCodigoDeBarras
    {
        private readonly string agenciaBeneficiaria;
        private readonly string carteira;
        private readonly string nossoNumero;
        private readonly string contaBeneficiario;
        private readonly string zero;

        public CampoLivreCodigoDeBarras(string agenciaBeneficiaria, string carteira, string nossoNumero, string contaBeneficiario, string zero)
        {
            this.agenciaBeneficiaria = agenciaBeneficiaria;
            this.carteira = carteira;
            this.nossoNumero = nossoNumero;
            this.contaBeneficiario = contaBeneficiario;
            this.zero = zero;
        }

        public StringBuilder GetStringCampoLivre()
        {
            StringBuilder stringCampoLivre = new StringBuilder(24);

            stringCampoLivre.Insert(0, agenciaBeneficiaria); //Agência Beneficiária (Sem o digito verificador, completar com zeros a esquerda quando necessário)
            stringCampoLivre.Insert(4, carteira); //Carteira
            stringCampoLivre.Insert(6, nossoNumero); //Número do Nosso Número (Sem o digito verificador)
            stringCampoLivre.Insert(17, contaBeneficiario); //Conta do Beneficiário (Sem o digito verificador, completar com zeros a esquerda quando necessário)
            stringCampoLivre.Insert(24, zero); //Zero

            return stringCampoLivre;
        }

        public override string ToString()
        {
            return agenciaBeneficiaria + carteira + nossoNumero + contaBeneficiario + zero;
        }
    }
}
