using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRetorno
{
    public class TransacaoTipo1
    {
        private string identificacaoRegistro;
        private string tipoInscricaoEmpresa;
        private string numInscricaoEmpresa;
        private string zeros;
        private string identificacaoEmpresaBeneficiarioBanco;
        private string numControleParticipante;
        private string zeros2;
        private string identificacaoTituloBanco1;
        private string usoBanco;
        private string usoBanco2;
        private string indicadorRateioCredito;
        private string pagamentoParcial;
        private string carteira;
        private string identificacaoDeOcorrencia;
        private string dataOcorrenciaNoBanco;
        private string numeroDocumento;
        private string identificacaoTituloBanco2;
        private string dataVencimentoTitulo;
        private string valorTitulo;
        private string bancoCobrador;
        private string agenciaCobradora;
        private string especiaTitulo;
        private string despesasCobrancaCodigosOcorrencia;
        private string outrasDespesasCustasProtesto;
        private string jurosOperacaoAtraso;
        private string IOFDevido;
        private string abatimentoConcedidoSobreTitulo;
        private string descontoConcedido;
        private string valorPago;
        private string jurosMora;
        private string outrosCreditos;
        private string brancos;
        private string motivoCodigoOcorrencia25;
        private string dataCredito;
        private string origemPagamento;
        private string brancos2;
        private string quandoChequeBradesco;
        private string motivosRejeicoesCodigosOcorrencia;
        private string brancos3;
        private string numeroCartorio;
        private string numoerProtocolo;
        private string brancos4;
        private string numSequencialRegistro;

        public List<TransacaoTipo1> GeraTransacaoTipo1(string path)
        {
            List<String> lista = UtilRemessa.FormataArquivo.LeArquivoRetorno(path);
            List<TransacaoTipo1> transacoesTipo1 = new List<TransacaoTipo1>();

            foreach (var item in lista)
            {
                if (item[0].ToString().Equals("1"))
                {
                    transacoesTipo1.Add(new TransacaoTipo1
                    {
                        identificacaoRegistro = item.Substring(0, 1),
                        tipoInscricaoEmpresa = item.Substring(1, 2),
                        numInscricaoEmpresa = item.Substring(3, 14),
                        zeros = item.Substring(17, 3),
                        identificacaoEmpresaBeneficiarioBanco = item.Substring(20, 17),
                        numControleParticipante = item.Substring(37, 25),
                        zeros2 = item.Substring(62, 8),
                        identificacaoTituloBanco1 = item.Substring(70, 12),
                        usoBanco = item.Substring(82, 10),
                        usoBanco2 = item.Substring(92, 12),
                        indicadorRateioCredito = item.Substring(104, 1),
                        pagamentoParcial = item.Substring(105, 2),
                        carteira = item.Substring(107, 1),
                        identificacaoDeOcorrencia = item.Substring(108, 2),
                        dataOcorrenciaNoBanco = item.Substring(110, 6),
                        numeroDocumento = item.Substring(116, 10),
                        identificacaoTituloBanco2 = item.Substring(126, 20),
                        dataVencimentoTitulo = item.Substring(146, 6),
                        valorTitulo = item.Substring(152, 13),
                        bancoCobrador = item.Substring(165, 3),
                        agenciaCobradora = item.Substring(168, 5),
                        especiaTitulo = item.Substring(173, 2),
                        despesasCobrancaCodigosOcorrencia = item.Substring(175, 13),
                        outrasDespesasCustasProtesto = item.Substring(188, 13),
                        jurosOperacaoAtraso = item.Substring(201, 13),
                        IOFDevido = item.Substring(214, 13),
                        abatimentoConcedidoSobreTitulo = item.Substring(227, 13),
                        descontoConcedido = item.Substring(240, 13),
                        valorPago = item.Substring(253, 13),
                        jurosMora = item.Substring(266, 13),
                        outrosCreditos = item.Substring(279, 13),
                        brancos = item.Substring(292, 2),
                        motivoCodigoOcorrencia25 = item.Substring(294, 1),
                        dataCredito = item.Substring(295, 6),
                        origemPagamento = item.Substring(301, 3),
                        brancos2 = item.Substring(304, 10),
                        quandoChequeBradesco = item.Substring(314, 4),
                        motivosRejeicoesCodigosOcorrencia = item.Substring(318, 10),
                        brancos3 = item.Substring(328, 40),
                        numeroCartorio = item.Substring(368, 2),
                        numoerProtocolo = item.Substring(370, 10),
                        brancos4 = item.Substring(380, 14),
                        numSequencialRegistro = item.Substring(394, 6)
                    });
                }
            }

            return transacoesTipo1;

        }
    }
}
