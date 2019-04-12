using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno
{
    public class TransacaoTipo3
    {
        private string IdentificacaoRegistro { get; set; }
        private string IdentificacaoEmpresaBanco { get; set; }
        private string IdentificacaiTituloBanco { get; set; }
        private string CodigoCalculoRateio { get; set; }
        private string TipoValorInformado { get; set; }
        private string Filler1 { get; set; }
        private string CodigoBancoCreditoPrimeiroBeneficiario { get; set; }
        private string CodigoAgenciaCreditoPrimeiroBeneficiario { get; set; }
        private string DigitoAgenciaCreditoPrimeiroBeneficiario { get; set; }
        private string NumeroContaCorrenteCreditoPrimeiroBeneficiario { get; set; }
        private string DigitoContaCorrenteCreditoPrimeiroBeneficiario { get; set; }
        private string ValorEfetivoRateioQuandoPagamento { get; set; }
        private string NomePrimeiroBeneficiario { get; set; }
        private string Filler2 { get; set; }
        private string Parcela1 { get; set; }
        private string FloatingParaPrimeiroBeneficiario { get; set; }
        private string DataCreditoPrimeiroBeneficiario { get; set; }
        private string StatusMotivoOcorrenciaRateio { get; set; }
        private string CodigoBancoCreditoSegundoBeneficiarioQuandoPagamento { get; set; }
        private string CodigoAgenciaCreditoSegundoBeneficiario { get; set; }
        private string DigitoAgenciaCreditoSegundoBeneficiario { get; set; }
        private string NumeroContaCorrenteCreditoSegundoBeneficiario { get; set; }
        private string DigitoContaCorrenteCreditoSegundoBeneficiario { get; set; }
        private string ValorEfetivoRateioQuandoPagamento2 { get; set; }
        private string NomeSegundoBeneficiario { get; set; }
        private string Filler3 { get; set; }
        private string Parcela2 { get; set; }
        private string FloatingParaSegundoBeneficiario { get; set; }
        private string DataCreditoSegundoBeneficiarioQuandoPagamento { get; set; }
        private string StatusMotivoOcorrenciaRateio2 { get; set; }
        private string CodigoBancoCreditoTerceiroBeneficiarioQuandoPagamento { get; set; }
        private string CodigoAgenciaCreditoTerceiroBeneficiario { get; set; }
        private string DigitoAgenciaCreditoTerceiroBeneficiario { get; set; }
        private string NumeroContaCorrenteCreditoTerceiroBeneficiario { get; set; }
        private string DigitoContaCorrenteCreditoTerceiroBeneficiario { get; set; }
        private string ValorEfetivoRateioQuandoPagamento3 { get; set; }
        private string NomeTerceiroBeneficiario { get; set; }
        private string Filler4 { get; set; }
        private string Parcela3 { get; set; }
        private string FloatingParaTerceiroBeneficiario { get; set; }
        private string DataCreditoTerceiroBeneficiarioQuandoPagamento { get; set; }
        private string StatusMotivoOcorrenciaRateio3 { get; set; }
        private string NumSequencialRegistro { get; set; }



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
                        IdentificacaoRegistro = item.Substring(0, 1),
                        IdentificacaoEmpresaBanco = item.Substring(1, 16),
                        IdentificacaiTituloBanco = item.Substring(17, 12),
                        CodigoCalculoRateio = item.Substring(29, 1),
                        TipoValorInformado = item.Substring(30, 1),
                        Filler1 = item.Substring(31, 12),
                        CodigoBancoCreditoPrimeiroBeneficiario = item.Substring(43, 3),
                        CodigoAgenciaCreditoPrimeiroBeneficiario = item.Substring(46, 5),
                        DigitoAgenciaCreditoPrimeiroBeneficiario = item.Substring(51, 1),
                        NumeroContaCorrenteCreditoPrimeiroBeneficiario = item.Substring(52, 12),
                        DigitoContaCorrenteCreditoPrimeiroBeneficiario = item.Substring(64, 1),
                        ValorEfetivoRateioQuandoPagamento = item.Substring(65, 15),
                        NomePrimeiroBeneficiario = item.Substring(80, 40),
                        Filler2 = item.Substring(120, 21),
                        Parcela1 = item.Substring(141, 6),
                        FloatingParaPrimeiroBeneficiario = item.Substring(147, 3),
                        DataCreditoPrimeiroBeneficiario = item.Substring(147, 3),
                        StatusMotivoOcorrenciaRateio = item.Substring(150, 8),
                        CodigoBancoCreditoSegundoBeneficiarioQuandoPagamento = item.Substring(160, 3),
                        CodigoAgenciaCreditoSegundoBeneficiario = item.Substring(163, 5),
                        DigitoAgenciaCreditoSegundoBeneficiario = item.Substring(168, 1),
                        NumeroContaCorrenteCreditoSegundoBeneficiario = item.Substring(169, 12),
                        DigitoContaCorrenteCreditoSegundoBeneficiario = item.Substring(181, 1),
                        ValorEfetivoRateioQuandoPagamento2 = item.Substring(182, 15),
                        NomeSegundoBeneficiario = item.Substring(197, 40),
                        Filler3 = item.Substring(237, 21),
                        Parcela2 = item.Substring(258, 6),
                        FloatingParaSegundoBeneficiario = item.Substring(264, 3),
                        DataCreditoSegundoBeneficiarioQuandoPagamento = item.Substring(267, 8),
                        StatusMotivoOcorrenciaRateio2 = item.Substring(257, 2),
                        CodigoBancoCreditoTerceiroBeneficiarioQuandoPagamento = item.Substring(277, 3),
                        CodigoAgenciaCreditoTerceiroBeneficiario = item.Substring(280, 5),
                        DigitoAgenciaCreditoTerceiroBeneficiario = item.Substring(285, 1),
                        NumeroContaCorrenteCreditoTerceiroBeneficiario = item.Substring(286, 12),
                        DigitoContaCorrenteCreditoTerceiroBeneficiario = item.Substring(298, 1),
                        ValorEfetivoRateioQuandoPagamento3 = item.Substring(299, 15),
                        NomeTerceiroBeneficiario = item.Substring(314, 40),
                        Filler4 = item.Substring(354, 21),
                        Parcela3 = item.Substring(375, 6),
                        FloatingParaTerceiroBeneficiario = item.Substring(381, 3),
                        DataCreditoTerceiroBeneficiarioQuandoPagamento = item.Substring(384, 8),
                        StatusMotivoOcorrenciaRateio3 = item.Substring(392, 2),
                        NumSequencialRegistro = item.Substring(394, 6)
                    });
                }
            }
            return transacoesTipo3;
        }

    }
}
