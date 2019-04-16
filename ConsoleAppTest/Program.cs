using ArquivoRemessa;
using UtilRemessa;
using System;
using System.Collections.Generic;
using ArquivoRetorno;
using System.IO;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Class1().WriteFile(true);
            var arquivo = File.ReadAllText(@"C:\testeretorno\CB090400.RET");
            ObjetoRetorno objRet = new ObjetoRetorno().GeraObjetoRetorno(arquivo);
        }

    }
}
