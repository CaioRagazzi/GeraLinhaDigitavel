using ArquivoRetorno.TransacaoDoTipo1;
using System;
using System.Collections.Generic;
using System.Linq;
using UtilRemessa;

namespace ArquivoRetorno
{
    public class TransacaoTipo1
    {
        #region propriedades
        public string IdentificacaoRegistro { get; set; }
        public TipoInscricaoEmpresa TipoInscricaoEmpresa { get; set; }
        public string NumInscricaoEmpresa { get; set; }
        public string Zeros { get; set; }
        public string IdentificacaoEmpresaBeneficiarioBanco { get; set; }
        public string NumControleParticipante { get; set; }
        public string Zeros2 { get; set; }
        public string IdentificacaoTituloBanco1 { get; set; }
        public string UsoBanco { get; set; }
        public string UsoBanco2 { get; set; }
        public string IndicadorRateioCredito { get; set; }
        public string PagamentoParcial { get; set; }
        public string Carteira { get; set; }
        public IdentificacoesDeOcorrencia IdentificacaoDeOcorrencia { get; set; }
        public DateTime? DataOcorrenciaNoBanco { get; set; }
        public string NumeroDocumento { get; set; }
        public string IdentificacaoTituloBanco2 { get; set; }
        public DateTime? DataVencimentoTitulo { get; set; }
        public decimal ValorTitulo { get; set; }
        public string BancoCobrador { get; set; }
        public string AgenciaCobradora { get; set; }
        public string EspeciaTitulo { get; set; }
        public decimal DespesasCobrancaCodigosOcorrencia { get; set; }
        public decimal OutrasDespesasCustasProtesto { get; set; }
        public string JurosOperacaoAtraso { get; set; }
        public decimal IOFDevido { get; set; }
        public decimal AbatimentoConcedidoSobreTitulo { get; set; }
        public decimal DescontoConcedido { get; set; }
        public decimal ValorPago { get; set; }
        public decimal JurosMora { get; set; }
        public decimal OutrosCreditos { get; set; }
        public string Brancos { get; set; }
        public string MotivoCodigoOcorrencia25 { get; set; }
        public DateTime? DataCredito { get; set; }
        public string OrigemPagamento { get; set; }
        public string Brancos2 { get; set; }
        public string QuandoChequeBradesco { get; set; }
        public List<string> MotivoCodigosOcorrencia { get; set; }
        public string Brancos3 { get; set; }
        public string NumeroCartorio { get; set; }
        public string NumoerProtocolo { get; set; }
        public string Brancos4 { get; set; }
        public string NumSequencialRegistro { get; set; }
        #endregion

        public TransacaoTipo1 GetTransacaoTipo1(string stringTransacao1)
        {
            TransacaoTipo1 tr1;

            tr1 = new TransacaoTipo1
            {
                IdentificacaoRegistro = stringTransacao1.Substring(0, 1),
                TipoInscricaoEmpresa = (TipoInscricaoEmpresa)Convert.ToInt32(stringTransacao1.Substring(1, 2)),
                NumInscricaoEmpresa = stringTransacao1.Substring(3, 14),
                Zeros = stringTransacao1.Substring(17, 3),
                IdentificacaoEmpresaBeneficiarioBanco = stringTransacao1.Substring(20, 17),
                NumControleParticipante = stringTransacao1.Substring(37, 25),
                Zeros2 = stringTransacao1.Substring(62, 8),
                IdentificacaoTituloBanco1 = stringTransacao1.Substring(70, 12),
                UsoBanco = stringTransacao1.Substring(82, 10),
                UsoBanco2 = stringTransacao1.Substring(92, 12),
                IndicadorRateioCredito = stringTransacao1.Substring(104, 1),
                PagamentoParcial = stringTransacao1.Substring(105, 2),
                Carteira = stringTransacao1.Substring(107, 1),
                IdentificacaoDeOcorrencia = (IdentificacoesDeOcorrencia)Convert.ToInt32(stringTransacao1.Substring(108, 2)),
                DataOcorrenciaNoBanco = FormataArquivo.ConverteETrataData(stringTransacao1.Substring(110, 6).Trim()),
                NumeroDocumento = stringTransacao1.Substring(116, 10),
                IdentificacaoTituloBanco2 = stringTransacao1.Substring(126, 20),
                DataVencimentoTitulo = FormataArquivo.ConverteETrataData(stringTransacao1.Substring(146, 6).Trim()),
                ValorTitulo = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(152, 13)),
                BancoCobrador = stringTransacao1.Substring(165, 3),
                AgenciaCobradora = stringTransacao1.Substring(168, 5),
                EspeciaTitulo = stringTransacao1.Substring(173, 2),
                DespesasCobrancaCodigosOcorrencia = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(175, 13)),
                OutrasDespesasCustasProtesto = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(188, 13)),
                JurosOperacaoAtraso = stringTransacao1.Substring(201, 13),
                IOFDevido = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(214, 13)),
                AbatimentoConcedidoSobreTitulo = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(227, 13)),
                DescontoConcedido = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(240, 13)),
                ValorPago = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(253, 13)),
                JurosMora = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(266, 13)),
                OutrosCreditos = FormataArquivo.ConverteETrataDecimal(stringTransacao1.Substring(279, 13)),
                Brancos = stringTransacao1.Substring(292, 2).Trim(),
                MotivoCodigoOcorrencia25 = stringTransacao1.Substring(294, 1),
                DataCredito = FormataArquivo.ConverteETrataData(stringTransacao1.Substring(295, 6).Trim()),
                OrigemPagamento = stringTransacao1.Substring(301, 3),
                Brancos2 = stringTransacao1.Substring(304, 10).Trim(),
                QuandoChequeBradesco = stringTransacao1.Substring(314, 4),
                MotivoCodigosOcorrencia = FormataMotivo(stringTransacao1.Substring(318, 10), stringTransacao1.Substring(108, 2)),
                Brancos3 = stringTransacao1.Substring(328, 40).Trim(),
                NumeroCartorio = stringTransacao1.Substring(368, 2),
                NumoerProtocolo = stringTransacao1.Substring(370, 10),
                Brancos4 = stringTransacao1.Substring(380, 14).Trim(),
                NumSequencialRegistro = stringTransacao1.Substring(394, 6)
            };

            return tr1;
        }

        public List<string> FormataMotivo(string codigoMotivo, string codigoOcorrencia)
        {
            List<string> codigosMotivo = new List<string>
            {
                codigoMotivo.Substring(0, 2),
                codigoMotivo.Substring(2, 2),
                codigoMotivo.Substring(4, 2),
                codigoMotivo.Substring(6, 2),
                codigoMotivo.Substring(8, 2)
            }.Distinct().ToList();

            if (codigosMotivo.Count() > 1 && codigosMotivo.Last().Equals("00"))
            {
                codigosMotivo.RemoveAt(codigosMotivo.Count() - 1);
            }

            List<string> motivos = new List<string>();

            foreach (var item in codigosMotivo)
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
            return motivos;
        }
    }
}
