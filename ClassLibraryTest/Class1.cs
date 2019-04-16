using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TransacaoDoTipo1;

namespace ArquivoRemessa
{
    public class Class1
    {
        private string GetFileName(bool test)
        {
            string fileName = "COBN" + System.DateTime.Now.ToString("dd") + System.DateTime.Now.ToString("MM") + System.DateTime.Now.ToString("ss");
            if (test)
            {
                fileName += ".TST";
            }
            else
            {
                fileName += ".REM";
            }

            return fileName;
        }

        public void WriteFile(bool test)
        {
            Header stringHeader = new Header
            {
                CodEmpresa = "5118770",
                NomeEmpresa = "INTERMEIO SOLUCOES EM PAGA",
                NumeroBradesco = "237",
                NomeBanco = "BRADESCO",
                DataGravacaoArquivo = DateTime.Now,
                IdentSistema = "MX",
                NumSeqRemessa = "48"
            };

            Trailler stringTrailler = new Trailler();

            List<StringBuilder> listaTransacoes = new List<StringBuilder>
            {
                stringHeader.GetHeader(),
                //stringTransacaoTipo1.GetTransacao(),
                //stringTrailler.GetTrailler()
            };

            for (int i = 0; i < 100; i++)
            {
                //string nomeVariavel = "stringTransacaoTipo" + Convert.ToString(num);
                TransacaoTipo1 tr1 = new TransacaoTipo1
            {
                NumeroControleParticipante = Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                CodigoBancoDebito = "000",
                multa = Multa.ComMulta,
                PercentualMulta = 10.00m,
                IdentificacaoTituloBanco = "90890000023",
                DescontoBonificacaoDia = 0.00m,
                condicaoEmissaoBoletoCobranca = EmissaoBoletoCobranca.BancoEmiteBoleto,
                CondicaoRegistroDebitoAutomatico = "N",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                identificacaoOcorrencia = IdentificacoesOcorrencia.Remessa,
                NumeroDocumento = "0000000001",
                DataVencimentoTitulo = DateTime.Now.AddDays(30),
                ValorTitulo = 33.33m,
                BancoEncarregadoCobranca = "000",
                AgenciaDepositaria = "00000",
                especieTitulo = EspecieTitulo.DuplicataDeServ,
                DataEmissaoTitulo = DateTime.Now,
                primeiraInstrucao = Protestos.SemInteresse,
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = 00.00m,
                DataLimiteConcessaoDesconto = new DateTime(),
                ValorDesconto = 0.00m,
                ValorIOF = 0.00m,
                ValorAbatimento = 0.00m,
                identificacaoTipoInscricao = IdentificacaoTipoInscricaoPagador.CPF,
                NumeroInscricaoPagador = "36190841813",
                NomePagador = "Cáio édu@rdo Ragazzi! Gemign@ni",
                EnderecoCompleto = "Ru@ monleváde, 128",
                PrimeiraMensagem = "Gerãndo arquivo reméss@",
                Cep = "04679345",
                //SufixoCep = "345",
                SegundaMensagem = "Remessa gerada no dia 29/03 as 11:00 posição"
            };
                listaTransacoes.Add(tr1.GetTransacao());
            }

            listaTransacoes.Add(stringTrailler.GetTrailler());

            UtilRemessa.FormataArquivo.GravaArquivo(listaTransacoes, "C:\\TesteGravacao2\\" + GetFileName(false));

        }
    }
}
