using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno
{
    public class TransacaoTipo3
    {
        private string identificacaoRegistro;
        private string identificacaoEmpresaBanco;
        private string identificacaiTituloBanco;
        private string codigoCalculoRateio;
        private string tipoValorInformado;
        private string filler1;
        private string codigoBancoCreditoPrimeiroBeneficiario;
        private string codigoAgenciaCreditoPrimeiroBeneficiario;
        private string digitoAgenciaCreditoPrimeiroBeneficiario;
        private string numeroContaCorrenteCreditoPrimeiroBeneficiario;
        private string digitoContaCorrenteCreditoPrimeiroBeneficiario;
        private string valorEfetivoRateioQuandoPagamento;
        private string nomePrimeiroBeneficiario;
        private string filler2;
        private string parcela1;
        private string floatingParaPrimeiroBeneficiario;
        private string dataCreditoPrimeiroBeneficiario;
        private string statusMotivoOcorrenciaRateio;
        private string codigoBancoCreditoSegundoBeneficiarioQuandoPagamento;
        private string codigoAgenciaCreditoSegundoBeneficiario;
        private string digitoAgenciaCreditoSegundoBeneficiario;
        private string numeroContaCorrenteCreditoSegundoBeneficiario;
        private string digitoContaCorrenteCreditoSegundoBeneficiario;
        private string valorEfetivoRateioQuandoPagamento2;
        private string nomeSegundoBeneficiario;
        private string filler3;
        private string parcela2;
        private string floatingParaSegundoBeneficiario;
        private string dataCreditoSegundoBeneficiarioQuandoPagamento;
        private string statusMotivoOcorrenciaRateio2;
        private string codigoBancoCreditoTerceiroBeneficiarioQuandoPagamento;
        private string codigoAgenciaCreditoTerceiroBeneficiario;
        private string digitoAgenciaCreditoTerceiroBeneficiario;
        private string numeroContaCorrenteCreditoTerceiroBeneficiario;
        private string digitoContaCorrenteCreditoTerceiroBeneficiario;
        private string valorEfetivoRateioQuandoPagamento3;
        private string nomeTerceiroBeneficiario;
        private string filler4;
        private string parcela3;
        private string floatingParaTerceiroBeneficiario;
        private string dataCreditoTerceiroBeneficiarioQuandoPagamento;
        private string statusMotivoOcorrenciaRateio3;
        private string numSequencialRegistro;



        public List<TransacaoTipo3> GeraTransacaoTipo3(string path)
        {
            List<String> lista = UtilRemessa.FormataArquivo.LeArquivoRetorno(path);
            List<TransacaoTipo3> transacoesTipo3 = new List<TransacaoTipo3>();

            foreach (var item in lista)
            {
                if (item[0].ToString().Equals("3"))
                {
                    transacoesTipo3.Add(new TransacaoTipo3
                    {
                        identificacaoRegistro = item.Substring(0, 1),
                        identificacaoEmpresaBanco = item.Substring(1, 16),
                        identificacaiTituloBanco = item.Substring(17, 12),
                        codigoCalculoRateio = item.Substring(29, 1),
                        tipoValorInformado = item.Substring(30, 1),
                        filler1 = item.Substring(31, 12),
                        codigoBancoCreditoPrimeiroBeneficiario = item.Substring(43, 3),
                        codigoAgenciaCreditoPrimeiroBeneficiario = item.Substring(46, 5),
                        digitoAgenciaCreditoPrimeiroBeneficiario = item.Substring(51, 1),
                        numeroContaCorrenteCreditoPrimeiroBeneficiario = item.Substring(52, 12),
                        digitoContaCorrenteCreditoPrimeiroBeneficiario = item.Substring(64, 1),
                        valorEfetivoRateioQuandoPagamento = item.Substring(65, 15),
                        nomePrimeiroBeneficiario = item.Substring(80, 40),
                        filler2 = item.Substring(120, 21),
                        parcela1 = item.Substring(141, 6),
                        floatingParaPrimeiroBeneficiario = item.Substring(147, 3),
                        dataCreditoPrimeiroBeneficiario = item.Substring(147, 3),
                        statusMotivoOcorrenciaRateio = item.Substring(150, 8),
                        codigoBancoCreditoSegundoBeneficiarioQuandoPagamento = item.Substring(160, 3),
                        codigoAgenciaCreditoSegundoBeneficiario = item.Substring(163, 5),
                        digitoAgenciaCreditoSegundoBeneficiario = item.Substring(168, 1),
                        numeroContaCorrenteCreditoSegundoBeneficiario = item.Substring(169, 12),
                        digitoContaCorrenteCreditoSegundoBeneficiario = item.Substring(181, 1),
                        valorEfetivoRateioQuandoPagamento2 = item.Substring(182, 15),
                        nomeSegundoBeneficiario = item.Substring(197, 40),
                        filler3 = item.Substring(237, 21),
                        parcela2 = item.Substring(258, 6),
                        floatingParaSegundoBeneficiario = item.Substring(264, 3),
                        dataCreditoSegundoBeneficiarioQuandoPagamento = item.Substring(267, 8),
                        statusMotivoOcorrenciaRateio2 = item.Substring(257, 2),
                        codigoBancoCreditoTerceiroBeneficiarioQuandoPagamento = item.Substring(277, 3),
                        codigoAgenciaCreditoTerceiroBeneficiario = item.Substring(280, 5),
                        digitoAgenciaCreditoTerceiroBeneficiario = item.Substring(285, 1),
                        numeroContaCorrenteCreditoTerceiroBeneficiario = item.Substring(286, 12),
                        digitoContaCorrenteCreditoTerceiroBeneficiario = item.Substring(298, 1),
                        valorEfetivoRateioQuandoPagamento3 = item.Substring(299, 15),
                        nomeTerceiroBeneficiario = item.Substring(314, 40),
                        filler4 = item.Substring(354, 21),
                        parcela3 = item.Substring(375, 6),
                        floatingParaTerceiroBeneficiario = item.Substring(381, 3),
                        dataCreditoTerceiroBeneficiarioQuandoPagamento = item.Substring(384, 8),
                        statusMotivoOcorrenciaRateio3 = item.Substring(392, 2),
                        numSequencialRegistro = item.Substring(394, 6)
                    });
                }
            }
            return transacoesTipo3;
        }

    }
}
