using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TransacaoDoTipo1;
using UtilRemessa;

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
                CodEmpresa = 5118770,
                NomeEmpresa = "INTERMEIO SOLUCOES EM PAGA",
                NumeroBradesco = 237,
                NomeBanco = "BRADESCO",
                DataGravacaoArquivo = DateTime.Now,
                IdentSistema = "MX",
                NumSeqRemessa = "48"
            };

            Trailler stringTrailler = new Trailler();

            List<StringBuilder> listaTransacoes = new List<StringBuilder>
            {
                stringHeader.GetHeader().Resultado,
                //stringTransacaoTipo1.GetTransacao(),
                //stringTrailler.GetTrailler()
            };

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
                SegundaMensagem = "Remessa gerada no dia 29/03 as 11:00 posição",
                BeneficiariaBanco = new EmpresaBeneficiariaBanco("09", 0123, 0, 340, 9),
                DebitoAutomatico = new DebitoAutomaticoCC()
            };

            listaTransacoes.Add(tr1.GetTransacao().Resultado);

            listaTransacoes.Add(stringTrailler.GetTrailler());

            TransacaoTipo2 tr2 = new TransacaoTipo2
            {
                BeneficiariaBanco = new EmpresaBeneficiariaBanco("09", 01234, 123, 340, 654),
                DataLimiteDesconto2 = new DateTime(2019,04,29),
                DataLimiteDesconto3 = new DateTime(2019, 04, 29),
                Mensagem1 = "Mensagem 1",
                Mensagem2 = "Mensagem 2",
                Mensagem3 = "Mensagem 3",
                Mensagem4 = "Mensagem 4",
                NossoNumero = "12345678912",
                ValorDesconto2 = 10M,
                ValorDesconto3 = 10M
            };

            //listaTransacoes.Add(tr2.GetTransacao().Resultado);

            TransacaoTipo3 tr3 = new TransacaoTipo3
            {

            };

            //listaTransacoes.Add(tr3.GetTransacao().Resultado);

            TransacaoTipo6 tr6 = new TransacaoTipo6
            {

            };

            //listaTransacoes.Add(tr6.GetTransacao().Resultado);

            TransacaoTipo7 tr7 = new TransacaoTipo7
            {

            };

            //listaTransacoes.Add(tr7.GetTransacao().Resultado);

            FormataArquivo.GravaArquivo(listaTransacoes, "C:\\TesteGravacao2\\" + GetFileName(false));

        }
    }
}
