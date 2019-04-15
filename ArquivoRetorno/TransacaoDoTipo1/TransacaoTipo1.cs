using ArquivoRetorno.TransacaoDoTipo1;
using System;
using System.Collections.Generic;
using System.Linq;
using UtilRemessa;

namespace ArquivoRetorno
{
    public class TransacaoTipo1
    {
        private string IdentificacaoRegistro { get; set; }
        private TipoInscricaoEmpresa TipoInscricaoEmpresa { get; set; }
        private string NumInscricaoEmpresa { get; set; }
        private string Zeros { get; set; }
        private string IdentificacaoEmpresaBeneficiarioBanco { get; set; }
        private string NumControleParticipante { get; set; }
        private string Zeros2 { get; set; }
        private string IdentificacaoTituloBanco1 { get; set; }
        private string UsoBanco { get; set; }
        private string UsoBanco2 { get; set; }
        private string IndicadorRateioCredito { get; set; }
        private string PagamentoParcial { get; set; }
        private string Carteira { get; set; }
        private IdentificacoesDeOcorrencia IdentificacaoDeOcorrencia { get; set; }
        private DateTime? DataOcorrenciaNoBanco { get; set; }
        private string NumeroDocumento { get; set; }
        private string IdentificacaoTituloBanco2 { get; set; }
        private DateTime? DataVencimentoTitulo { get; set; }
        private decimal ValorTitulo { get; set; }
        private string BancoCobrador { get; set; }
        private string AgenciaCobradora { get; set; }
        private string EspeciaTitulo { get; set; }
        private decimal DespesasCobrancaCodigosOcorrencia { get; set; }
        private decimal OutrasDespesasCustasProtesto { get; set; }
        private string JurosOperacaoAtraso { get; set; }
        private decimal IOFDevido { get; set; }
        private decimal AbatimentoConcedidoSobreTitulo { get; set; }
        private decimal DescontoConcedido { get; set; }
        private decimal ValorPago { get; set; }
        private decimal JurosMora { get; set; }
        private decimal OutrosCreditos { get; set; }
        private string Brancos { get; set; }
        private string MotivoCodigoOcorrencia25 { get; set; }
        private DateTime? DataCredito { get; set; }
        private string OrigemPagamento { get; set; }
        private string Brancos2 { get; set; }
        private string QuandoChequeBradesco { get; set; }
        private List<string> MotivoCodigosOcorrencia { get; set; }
        private string Brancos3 { get; set; }
        private string NumeroCartorio { get; set; }
        private string NumoerProtocolo { get; set; }
        private string Brancos4 { get; set; }
        private string NumSequencialRegistro { get; set; }

        public List<TransacaoTipo1> GetTransacaoTipo1(string path)
        {
            List<String> lista = UtilRemessa.FormataArquivo.LeArquivoRetorno(path);
            List<TransacaoTipo1> transacoesTipo1 = new List<TransacaoTipo1>();

            foreach (var item in lista)
            {
                if (item[0].ToString().Equals("1"))
                {
                    transacoesTipo1.Add(new TransacaoTipo1
                    {
                        IdentificacaoRegistro = item.Substring(0, 1),
                        TipoInscricaoEmpresa = (TipoInscricaoEmpresa)Convert.ToInt32(item.Substring(1, 2)),
                        NumInscricaoEmpresa = item.Substring(3, 14),
                        Zeros = item.Substring(17, 3),
                        IdentificacaoEmpresaBeneficiarioBanco = item.Substring(20, 17),
                        NumControleParticipante = item.Substring(37, 25),
                        Zeros2 = item.Substring(62, 8),
                        IdentificacaoTituloBanco1 = item.Substring(70, 12),
                        UsoBanco = item.Substring(82, 10),
                        UsoBanco2 = item.Substring(92, 12),
                        IndicadorRateioCredito = item.Substring(104, 1),
                        PagamentoParcial = item.Substring(105, 2),
                        Carteira = item.Substring(107, 1),
                        IdentificacaoDeOcorrencia = (IdentificacoesDeOcorrencia)Convert.ToInt32(item.Substring(108, 2)),
                        DataOcorrenciaNoBanco = FormataArquivo.ConverteETrataData(item.Substring(110, 6).Trim()),
                        NumeroDocumento = item.Substring(116, 10),
                        IdentificacaoTituloBanco2 = item.Substring(126, 20),
                        DataVencimentoTitulo = FormataArquivo.ConverteETrataData(item.Substring(146, 6).Trim()),
                        ValorTitulo = FormataArquivo.ConverteETrataDecimal(item.Substring(152, 13)),
                        BancoCobrador = item.Substring(165, 3),
                        AgenciaCobradora = item.Substring(168, 5),
                        EspeciaTitulo = item.Substring(173, 2),
                        DespesasCobrancaCodigosOcorrencia = FormataArquivo.ConverteETrataDecimal(item.Substring(175, 13)),
                        OutrasDespesasCustasProtesto = FormataArquivo.ConverteETrataDecimal(item.Substring(188, 13)),
                        JurosOperacaoAtraso = item.Substring(201, 13),
                        IOFDevido = FormataArquivo.ConverteETrataDecimal(item.Substring(214, 13)),
                        AbatimentoConcedidoSobreTitulo = FormataArquivo.ConverteETrataDecimal(item.Substring(227, 13)),
                        DescontoConcedido = FormataArquivo.ConverteETrataDecimal(item.Substring(240, 13)),
                        ValorPago = FormataArquivo.ConverteETrataDecimal(item.Substring(253, 13)),
                        JurosMora = FormataArquivo.ConverteETrataDecimal(item.Substring(266, 13)),
                        OutrosCreditos = FormataArquivo.ConverteETrataDecimal(item.Substring(279, 13)),
                        Brancos = item.Substring(292, 2).Trim(),
                        MotivoCodigoOcorrencia25 = item.Substring(294, 1),
                        DataCredito = FormataArquivo.ConverteETrataData(item.Substring(295, 6).Trim()),
                        OrigemPagamento = item.Substring(301, 3),
                        Brancos2 = item.Substring(304, 10).Trim(),
                        QuandoChequeBradesco = item.Substring(314, 4),
                        MotivoCodigosOcorrencia = FormataMotivo(item.Substring(318, 10), item.Substring(108, 2)),
                        Brancos3 = item.Substring(328, 40).Trim(),
                        NumeroCartorio = item.Substring(368, 2),
                        NumoerProtocolo = item.Substring(370, 10),
                        Brancos4 = item.Substring(380, 14).Trim(),
                        NumSequencialRegistro = item.Substring(394, 6)
                    });
                }
            }

            return transacoesTipo1;

        }

        public List<string> FormataMotivo(string codigoMotivo, string codigoOcorrencia)
        {
            List<string> codigosOcorrencia = new List<string>
            {
                codigoMotivo.Substring(0, 2),
                codigoMotivo.Substring(2, 2),
                codigoMotivo.Substring(4, 2),
                codigoMotivo.Substring(6, 2),
                codigoMotivo.Substring(8, 2)
            }.Distinct().ToList();

            if (codigosOcorrencia.Count() > 1 && codigosOcorrencia.Last().Equals("00"))
            {
                codigosOcorrencia.RemoveAt(codigosOcorrencia.Count() -1);
            }

            List<string> motivos = new List<string>();

            foreach (var item in codigosOcorrencia)
            {
                switch (codigoOcorrencia)
                {
                    case "02":
                        motivos.Add(Convert.ToString((CodigoOcorrencia2)Convert.ToInt32(item)));
                        continue;
                    case "03":
                        motivos.Add(Convert.ToString((CodigoOcorrencia3)Convert.ToInt32(item)));
                        continue;
                    case "06":
                        motivos.Add(Convert.ToString((CodigoOcorrencia6)Convert.ToInt32(item)));
                        continue;
                    case "09":
                        motivos.Add(Convert.ToString((CodigoOcorrencia9)Convert.ToInt32(item)));
                        continue;
                    case "10":
                        motivos.Add(Convert.ToString((CodigoOcorrencia10)Convert.ToInt32(item)));
                        continue;
                    case "15":
                        motivos.Add(Convert.ToString((CodigoOcorrencia15)Convert.ToInt32(item)));
                        continue;
                    case "17":
                        motivos.Add(Convert.ToString((CodigoOcorrencia17)Convert.ToInt32(item)));
                        continue;
                    case "19":
                        if (codigoMotivo.Equals("A"))
                        {
                            motivos.Add(Convert.ToString(CodigoOcorrencia19.Aceito));
                            continue;
                        }
                        else
                        {
                            motivos.Add(Convert.ToString(CodigoOcorrencia19.Desprezado));
                            continue;
                        }
                    case "24":
                        motivos.Add(Convert.ToString((CodigoOcorrencia24)Convert.ToInt32(item)));
                        continue;
                    case "25":
                        if (codigoMotivo.Equals("A"))
                        {
                            motivos.Add(Convert.ToString(CodigoOcorrencia25.Aceito));
                            continue;
                        }
                        else
                        {
                            motivos.Add(Convert.ToString(CodigoOcorrencia25.Desprezado));
                            continue;
                        }
                    case "27":
                        motivos.Add(Convert.ToString((CodigoOcorrencia27)Convert.ToInt32(item)));
                        continue;
                    case "28":
                        motivos.Add(Convert.ToString((CodigoOcorrencia28)Convert.ToInt32(item)));
                        continue;
                    case "29":
                        motivos.Add(Convert.ToString((CodigoOcorrencia29)Convert.ToInt32(item)));
                        continue;
                    case "30":
                        motivos.Add(Convert.ToString((CodigoOcorrencia30)Convert.ToInt32(item)));
                        continue;
                    case "32":
                        motivos.Add(Convert.ToString((CodigoOcorrencia32)Convert.ToInt32(item)));
                        continue;
                    case "35":
                        motivos.Add(Convert.ToString((CodigoOcorrencia35)Convert.ToInt32(item)));
                        continue;
                    default:
                        motivos.Add("SemMotivo");
                        continue;
                }
            }

            var retorno = motivos.Distinct().ToList();

            return retorno;
        }
    }
}
