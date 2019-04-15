using ArquivoRemessa;
using UtilRemessa;
using System;
using System.Collections.Generic;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Class1().WriteFile(true);
            string path = @"C:\testeretorno\CB090400.RET";
            ArquivoRetorno.Header header = new ArquivoRetorno.Header().GeraHeader(path);
            ArquivoRetorno.Trailler trailler = new ArquivoRetorno.Trailler().GetTrailler(path);
            List<ArquivoRetorno.TransacaoTipo1> trt1 = new ArquivoRetorno.TransacaoTipo1().GeraTransacaoTipo1(path);
            List<ArquivoRetorno.TransacaoTipo3> trt3 = new ArquivoRetorno.TransacaoTipo3().GeraTransacaoTipo3(path);
        }
    }
}
