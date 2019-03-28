using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ClassLibraryTest.TransacaoDoTipo1;

namespace ClassLibraryTest
{
    public class Class1
    {
        int numeroSequencial = 1;

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
            //TODO: Ver codigo remessa
            Header stringHeader = new Header
            {
                CodEmpresa = "5118770",
                NomeEmpresa = "INTERMEIO SOLUCOES EM PAGA",
                NumeroBradesco = "237",
                NomeBanco = "BRADESCO",
                DataGravacaoArquivo = DateTime.Now,
                Branco = "",
                IdentSistema = "MX",
                NumSeqRemessa = "0000000",
                Branco2 = ""
            };

            TransacaoTipo1 stringTransacaoTipo1 = new TransacaoTipo1
            {
                NumeroControleParticipante = Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                CodigoBancoDebito = "000",
                multa = Multa.SemMulta,
                PercentualMulta = 0.00m,
                IdentificacaoTituloBanco = "00000000000",
                DescontoBonificacaoDia = 0.00m,
                condicaoEmissaoBoletoCobranca = EmissaoBoletoCobranca.ClienteEmiteBoleto,
                CondicaoRegistroDebitoAutomatico = "N",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                identificacaoOcorrencia = IdentificacoesOcorrencia.Remessa,
                NumeroDocumento = "0000000001",
                DataVencimentoTitulo = DateTime.Now.AddDays(5),
                ValorTitulo = 69.23m,
                BancoEncarregadoCobranca = "000",
                AgenciaDepositaria = "00000",
                especieTitulo = EspecieTitulo.DuplicataDeServ,
                DataEmissaoTitulo = DateTime.Now,
                PrimeiraInstrucao = "00",
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = "0000000000000",
                DataLimiteConcessaoDesconto = new DateTime(),
                ValorDesconto = 0.00m,
                ValorIOF = 0.00m,
                ValorAbatimento = 0.00m,
                identificacaoTipoInscricao = IdentificacaoTipoInscricaoPagador.CPF,
                NumeroInscricaoPagador = "33531106821",
                NomePagador = "Fabio Gonçálvés",
                EnderecoCompleto = "Rua Ney Mascarenhas, 130",
                PrimeiraMensagem = "Gerando arquivo remessa",
                Cep = "08542",
                SufixoCep = "120",
                SegundaMensagem = "Remessa gerada no dia 27/03 as 16:00"
            };

            TransacaoTipo1 stringTransacaoTipo12 = new TransacaoTipo1
            {
                //IdentificacaoEmpresaBeneficiaria = "00090339200003409",
                NumeroControleParticipante = Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                CodigoBancoDebito = "000",
                multa = Multa.SemMulta,
                PercentualMulta = 20.00m,
                IdentificacaoTituloBanco = "00000000000",
                DigitoAutoConferencia = "0",
                DescontoBonificacaoDia = 0.00m,
                condicaoEmissaoBoletoCobranca = EmissaoBoletoCobranca.ClienteEmiteBoleto,
                CondicaoRegistroDebitoAutomatico = "N",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                identificacaoOcorrencia = IdentificacoesOcorrencia.Remessa,
                NumeroDocumento = "0000000002",
                DataVencimentoTitulo = DateTime.Now.AddDays(10),
                ValorTitulo = 6.32m,
                BancoEncarregadoCobranca = "000",
                AgenciaDepositaria = "00000",
                especieTitulo = EspecieTitulo.DuplicataDeServ,
                DataEmissaoTitulo = DateTime.Now,
                PrimeiraInstrucao = "00",
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = "0000000001633",
                DataLimiteConcessaoDesconto = new DateTime(),
                ValorDesconto = 3.26m,
                ValorIOF = 0.00m,
                ValorAbatimento = 0.00m,
                identificacaoTipoInscricao = IdentificacaoTipoInscricaoPagador.CPF,
                NumeroInscricaoPagador = "36190841813",
                NomePagador = "Caio Ragazzi",
                EnderecoCompleto = "Rua Monlevade, 128",
                PrimeiraMensagem = "Gerando arquivo remessa",
                Cep = "04679",
                SufixoCep = "345",
                SegundaMensagem = "Remessa gerada no dia 27/03 16:08"
            };

            TransacaoTipo1 stringTransacaoTipo13 = new TransacaoTipo1
            {
                NumeroControleParticipante = Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                CodigoBancoDebito = "000",
                multa = Multa.SemMulta,
                PercentualMulta = 40.00m,
                IdentificacaoTituloBanco = "00000000000",
                DigitoAutoConferencia = "0",
                DescontoBonificacaoDia = 0.00m,
                condicaoEmissaoBoletoCobranca = EmissaoBoletoCobranca.ClienteEmiteBoleto,
                CondicaoRegistroDebitoAutomatico = "N",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                identificacaoOcorrencia = IdentificacoesOcorrencia.Remessa,
                NumeroDocumento = "5555555555",
                DataVencimentoTitulo = DateTime.Now.AddDays(20),
                ValorTitulo = 7.63m,
                BancoEncarregadoCobranca = "237",
                AgenciaDepositaria = "00000",
                especieTitulo = EspecieTitulo.DuplicataDeServ,
                DataEmissaoTitulo = DateTime.Now,
                PrimeiraInstrucao = "00",
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = "0000000005423",
                DataLimiteConcessaoDesconto = new DateTime(),
                ValorDesconto = 6.56m,
                ValorIOF = 0.00m,
                ValorAbatimento = 0.00m,
                identificacaoTipoInscricao = IdentificacaoTipoInscricaoPagador.CPF,
                NumeroInscricaoPagador = "23322675000152",
                NomePagador = "Intermeio",
                EnderecoCompleto = "Avenida Jabaquara, 2819",
                PrimeiraMensagem = "Teste primeira mensagem Boleto Intermeio",
                Cep = "04045",
                SufixoCep = "004",
                SegundaMensagem = "Teste segunda mensagem Boleto Intermeio"
            };

            TransacaoTipo2 stringTransacaoTipo2 = new TransacaoTipo2
            {
                Agencia = "03392",
                Carteira = "009",
                ContaCorrente = "0000340",
                DacNossoNumero = "",
                DataLimiteDesconto2 = DateTime.Now,
                DataLimiteDesconto3 = DateTime.Now,
                DigitoCC = "9",
                Mensagem1 = "teste mensagem 1",
                Mensagem2 = "teste mensagem 2",
                Mensagem3 = "teste mensagem 3",
                Mensagem4 = "teste mensagem 4",
                NossoNumero = "00000000000",
                Reserva = "",
                ValorDesconto2 = "",
                ValorDesconto3 = ""
            };

            TransacaoTipo3 stringTransacaoTipo3 = new TransacaoTipo3
            {
                CodigoAgenciaCreditoPrimeiroBeneficiario = "12345",
                CodigoAgenciaCreditoSegundoBeneficiario = "",
                CodigoAgenciaCreditoTerceiroBeneficiario = "",
                CodigoBancoCreditoPrimeiroBeneficiario = "",
                CodigoBancoCreditoSegundoBeneficiario = "",
                CodigoBancoCreditoTerceiroBeneficiario = "",
                CodigoCalculoRateio = "",
                DigitoAgenciaCreditoPrimeiroBeneficiario = "",
                DigitoAgenciaCreditoSegundoBeneficiario = "",
                DigitoAgenciaCreditoTerceiroBeneficiario = "",
                DigitoContaCorrenteCreditoPrimeiroBeneficiario = "",
                DigitoContaCorrenteCreditoSegundoBeneficiario = "",
                DigitoContaCorrenteCreditoTerceiroBeneficiario = "",
                Filler = "",
                Filler2 = "",
                Filler3 = "",
                Filler4 = "",
                FloatingPrimeiroBeneficiario = "",
                FloatingSegundoBeneficiario = "",
                FloatingTerceiroBeneficiario = "",
                IdentificacaoEmpresaBanco = "",
                IdentificacaoTituloBanco = "",
                NomePrimeiroBeneficiario = "",
                NomeSegundoBeneficiario = "",
                NomeTerceiroBeneficiario = "",
                NumeroContaCorrenteCreditoPrimeiroBeneficiario = "",
                NumeroContaCorrenteCreditoSegundoBeneficiario = "",
                NumeroContaCorrenteCreditoTerceiroBeneficiario = "",
                Parcela = "",
                Parcela2 = "",
                Parcela3 = "",
                TipoValorInformado = "",
                ValorOuParcelamentoRateio = "",
                ValorOuParcelamentoRateio2 = "",
                ValorOuParcelamentoRateio3 = ""
            };

            TransacaoTipo6 stringTransacaoTipo6 = new TransacaoTipo6()
            {
                Agencia = "",
                Brancos = "",
                Carteira = "",
                ContaCorrente = "",
                DigitoNossoNumero = "",
                NossoNumero = ""
            };

            TransacaoTipo7 stringTransacaoTipo7 = new TransacaoTipo7
            {
                NossoNumero = "12345678912",
                ContaCorrente = "1234567",
                Carteira = "123",
                Agencia = "12345",
                Cep = "04679",
                Cidade = "SÃO PAULO",
                DacNossoNumero = "",
                DigitoCC = "",
                EnderecoSacadorAvalista = "",
                Reserva = "",
                SufixoCep = "345",
                Uf = ""
            };

            Trailler stringTrailler = new Trailler
            {
                Branco = "",
            };

            List<StringBuilder> listaTransacoes = new List<StringBuilder>
            {
                stringTransacaoTipo1.GetTransacao(stringTransacaoTipo1),
                //stringTransacaoTipo2.GetTransacao(stringTransacaoTipo2)
                //stringTransacaoTipo12.GetTransacao(stringTransacaoTipo12),
                //stringTransacaoTipo2.GetTransacao(stringTransacaoTipo2),
                //stringTransacaoTipo6.GetTransacao(stringTransacaoTipo6),
                //stringTransacaoTipo7.GetTransacao(stringTransacaoTipo7)
            };

            using (StreamWriter sw = new StreamWriter("C:\\TesteGravacao\\" + GetFileName(false)))
            {
                sw.WriteLine(stringHeader.GetHeader(stringHeader, GetNumSequencial()));

                foreach (var item in listaTransacoes)
                {
                    item.Insert(394, GetNumSequencial());
                    sw.WriteLine(item);
                }
                sw.WriteLine(stringTrailler.GetTrailler(stringTrailler, GetNumSequencial()));
            }
        }

        public string GetNumSequencial()
        {
            var numeroSequencialString = numeroSequencial.ToString().PadLeft(6, '0');
            numeroSequencial++;
            return numeroSequencialString;
        }

    }
}
