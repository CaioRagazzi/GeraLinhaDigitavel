using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa
{
    public class Moeda
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
