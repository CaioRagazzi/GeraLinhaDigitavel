using System;
using System.Collections.Generic;
using System.Text;
using UtilRemessa;

namespace ArquivoRetorno
{
    public class TransacaoTipo3
    {
        #region propriedades
        public string IdentificacaoRegistro { get; set; }
        public string IdentificacaoEmpresaBanco { get; set; }
        public string IdentificacaiTituloBanco { get; set; }
        public string CodigoCalculoRateio { get; set; }
        public string TipoValorInformado { get; set; }
        public string Filler1 { get; set; }
        public string CodigoBancoCreditoPrimeiroBeneficiario { get; set; }
        public string CodigoAgenciaCreditoPrimeiroBeneficiario { get; set; }
        public string DigitoAgenciaCreditoPrimeiroBeneficiario { get; set; }
        public string NumeroContaCorrenteCreditoPrimeiroBeneficiario { get; set; }
        public string DigitoContaCorrenteCreditoPrimeiroBeneficiario { get; set; }
        public string ValorEfetivoRateioQuandoPagamento { get; set; }
        public string NomePrimeiroBeneficiario { get; set; }
        public string Filler2 { get; set; }
        public string Parcela1 { get; set; }
        public string FloatingParaPrimeiroBeneficiario { get; set; }
        public DateTime? DataCreditoPrimeiroBeneficiario { get; set; }
        public string StatusMotivoOcorrenciaRateio { get; set; }
        public string CodigoBancoCreditoSegundoBeneficiarioQuandoPagamento { get; set; }
        public string CodigoAgenciaCreditoSegundoBeneficiario { get; set; }
        public string DigitoAgenciaCreditoSegundoBeneficiario { get; set; }
        public string NumeroContaCorrenteCreditoSegundoBeneficiario { get; set; }
        public string DigitoContaCorrenteCreditoSegundoBeneficiario { get; set; }
        public string ValorEfetivoRateioQuandoPagamento2 { get; set; }
        public string NomeSegundoBeneficiario { get; set; }
        public string Filler3 { get; set; }
        public string Parcela2 { get; set; }
        public string FloatingParaSegundoBeneficiario { get; set; }
        public DateTime? DataCreditoSegundoBeneficiarioQuandoPagamento { get; set; }
        public string StatusMotivoOcorrenciaRateio2 { get; set; }
        public string CodigoBancoCreditoTerceiroBeneficiarioQuandoPagamento { get; set; }
        public string CodigoAgenciaCreditoTerceiroBeneficiario { get; set; }
        public string DigitoAgenciaCreditoTerceiroBeneficiario { get; set; }
        public string NumeroContaCorrenteCreditoTerceiroBeneficiario { get; set; }
        public string DigitoContaCorrenteCreditoTerceiroBeneficiario { get; set; }
        public string ValorEfetivoRateioQuandoPagamento3 { get; set; }
        public string NomeTerceiroBeneficiario { get; set; }
        public string Filler4 { get; set; }
        public string Parcela3 { get; set; }
        public string FloatingParaTerceiroBeneficiario { get; set; }
        public DateTime? DataCreditoTerceiroBeneficiarioQuandoPagamento { get; set; }
        public string StatusMotivoOcorrenciaRateio3 { get; set; }
        public string NumSequencialRegistro { get; set; }
        #endregion


        public TransacaoTipo3 GetTransacaoTipo3(string stringTransacao3)
        {
            //List<String> lista = UtilRemessa.FormataArquivo.LeArquivoRetorno(path);
            TransacaoTipo3 transacaoTipo3 = new TransacaoTipo3();

            transacaoTipo3 = new TransacaoTipo3
            {
                IdentificacaoRegistro = stringTransacao3.Substring(0, 1),
                IdentificacaoEmpresaBanco = stringTransacao3.Substring(1, 16),
                IdentificacaiTituloBanco = stringTransacao3.Substring(17, 12),
                CodigoCalculoRateio = stringTransacao3.Substring(29, 1),
                TipoValorInformado = stringTransacao3.Substring(30, 1),
                Filler1 = stringTransacao3.Substring(31, 12),
                CodigoBancoCreditoPrimeiroBeneficiario = stringTransacao3.Substring(43, 3),
                CodigoAgenciaCreditoPrimeiroBeneficiario = stringTransacao3.Substring(46, 5),
                DigitoAgenciaCreditoPrimeiroBeneficiario = stringTransacao3.Substring(51, 1),
                NumeroContaCorrenteCreditoPrimeiroBeneficiario = stringTransacao3.Substring(52, 12),
                DigitoContaCorrenteCreditoPrimeiroBeneficiario = stringTransacao3.Substring(64, 1),
                ValorEfetivoRateioQuandoPagamento = stringTransacao3.Substring(65, 15),
                NomePrimeiroBeneficiario = stringTransacao3.Substring(80, 40),
                Filler2 = stringTransacao3.Substring(120, 21),
                Parcela1 = stringTransacao3.Substring(141, 6),
                FloatingParaPrimeiroBeneficiario = stringTransacao3.Substring(147, 3),
                DataCreditoPrimeiroBeneficiario = FormataArquivo.ConverteETrataData(stringTransacao3.Substring(147, 3)),
                StatusMotivoOcorrenciaRateio = stringTransacao3.Substring(150, 8),
                CodigoBancoCreditoSegundoBeneficiarioQuandoPagamento = stringTransacao3.Substring(160, 3),
                CodigoAgenciaCreditoSegundoBeneficiario = stringTransacao3.Substring(163, 5),
                DigitoAgenciaCreditoSegundoBeneficiario = stringTransacao3.Substring(168, 1),
                NumeroContaCorrenteCreditoSegundoBeneficiario = stringTransacao3.Substring(169, 12),
                DigitoContaCorrenteCreditoSegundoBeneficiario = stringTransacao3.Substring(181, 1),
                ValorEfetivoRateioQuandoPagamento2 = stringTransacao3.Substring(182, 15),
                NomeSegundoBeneficiario = stringTransacao3.Substring(197, 40),
                Filler3 = stringTransacao3.Substring(237, 21),
                Parcela2 = stringTransacao3.Substring(258, 6),
                FloatingParaSegundoBeneficiario = stringTransacao3.Substring(264, 3),
                DataCreditoSegundoBeneficiarioQuandoPagamento = FormataArquivo.ConverteETrataData(stringTransacao3.Substring(267, 8)),
                StatusMotivoOcorrenciaRateio2 = stringTransacao3.Substring(257, 2),
                CodigoBancoCreditoTerceiroBeneficiarioQuandoPagamento = stringTransacao3.Substring(277, 3),
                CodigoAgenciaCreditoTerceiroBeneficiario = stringTransacao3.Substring(280, 5),
                DigitoAgenciaCreditoTerceiroBeneficiario = stringTransacao3.Substring(285, 1),
                NumeroContaCorrenteCreditoTerceiroBeneficiario = stringTransacao3.Substring(286, 12),
                DigitoContaCorrenteCreditoTerceiroBeneficiario = stringTransacao3.Substring(298, 1),
                ValorEfetivoRateioQuandoPagamento3 = stringTransacao3.Substring(299, 15),
                NomeTerceiroBeneficiario = stringTransacao3.Substring(314, 40),
                Filler4 = stringTransacao3.Substring(354, 21),
                Parcela3 = stringTransacao3.Substring(375, 6),
                FloatingParaTerceiroBeneficiario = stringTransacao3.Substring(381, 3),
                DataCreditoTerceiroBeneficiarioQuandoPagamento = FormataArquivo.ConverteETrataData(stringTransacao3.Substring(384, 8)),
                StatusMotivoOcorrenciaRateio3 = stringTransacao3.Substring(392, 2),
                NumSequencialRegistro = stringTransacao3.Substring(394, 6)
            };

            return transacaoTipo3;
        }

    }
}
