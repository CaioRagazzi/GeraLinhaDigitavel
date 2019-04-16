using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArquivoRetorno
{
    public class ObjetoRetorno
    {
        public Header Header { get; set; }
        public Trailler Trailler { get; set; }
        public List<TransacaoTipo1> TransacaoTipo1 { get; set; }
        public List<TransacaoTipo3> TransacaoTipo3 { get; set; }

        public ObjetoRetorno()
        {
            TransacaoTipo1 = new List<TransacaoTipo1>();
            TransacaoTipo3 = new List<TransacaoTipo3>();
        }

        public ObjetoRetorno GeraObjetoRetorno(string arquivo)
        {
            ObjetoRetorno objRet = new ObjetoRetorno();

            using (StringReader reader = new StringReader(arquivo))
            {
                string linha = "";
                while ((linha = reader.ReadLine()) != null)
                {
                    switch (linha[0].ToString())
                    {
                        case "0":
                            objRet.Header = new Header().GetHeader(linha);
                            continue;
                        case "1":
                            objRet.TransacaoTipo1.Add(new TransacaoTipo1().GetTransacaoTipo1(linha));
                            continue;
                        case "3":
                            objRet.TransacaoTipo3.Add(new TransacaoTipo3().GetTransacaoTipo3(linha));
                            continue;
                        case "9":
                            objRet.Trailler = new Trailler().GetTrailler(linha);
                            continue;
                    }
                }
                return objRet;
            }
        }

    }
}
