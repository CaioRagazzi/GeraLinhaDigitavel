using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa
{
    public class NossoNumero
    {
        private string nossoNumeroSemDigito;

        public string NossoNumeroSemDigito
        {
            get { return nossoNumeroSemDigito; }
            set { nossoNumeroSemDigito = value; }
        }

        private string carteira;

        public string Carteira
        {
            get { return carteira; }
            set { carteira = value; }
        }

        public string GetDigitoNossoNumero()
        {
            string numeroCompleto = carteira + nossoNumeroSemDigito;
            int somatoria = 0;
            string numeroMultiplicador = "2765432765432";

            for (int i = 0; i < numeroCompleto.Length; i++)
            {
                somatoria += Convert.ToInt32(numeroCompleto[i].ToString()) * Convert.ToInt32(numeroMultiplicador[i].ToString());
            }

            int restoDivisao = somatoria % 11;

            var digito = "";

            if (restoDivisao == 1)
            {
                digito = "P";
            }
            else if (restoDivisao == 0)
            {
                digito = "0";
            }
            else
            {
                digito = (11 - restoDivisao).ToString();
            }

            return digito;
        }
    }
}
