using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
                IdentificacaoRegistro = "0",
                IdentificacaoArquivoRemessa = "1",
                LiteralRemessa = "REMESSA",
                CodigoServico = "01",
                LiteralServico = "COBRANCA",
                CodEmpresa = "5118770",
                NomeEmpresa = "INTERMEIO SOLUCOES EM PAGA",
                NumeroBradesco = "237",
                NomeBanco = "BRADESCO",
                DataGravacaoArquivo = DateTime.Today.ToString("ddMMyy"),
                Branco = "",
                IdentSistema = "MX",
                NumSeqRemessa = "0000000",
                Branco2 = ""
            };

            TransacaoTipo1 stringTransacaoTipo1 = new TransacaoTipo1
            {
                IdentificacaoRegistro = "1",
                AgenciaPagador = "00000",
                DigitoAgencia = "",
                RazaoConta = "00000",
                ContaCorrente = "0000000",
                DigitoContaCorrente = "",
                //TODO: Ajustar valores por questões dos zeros a esquerda
                IdentificacaoEmpresaBeneficiaria = "00090339200003409",
                NumeroControleParticipante = "444",
                CodigoBancoDebito = "000",
                Multa = "0",
                PercentualMulta = "0000",
                IdentificacaoTituloBanco = "00000000000",
                DescontoBonificacaoDia = "0000000000",
                CondicaoEmissaoBoletoCobranca = "2",
                CondicaoRegistroDebitoAutomatico = "N",
                IdentificacaoOperacaoBanco = "",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                IdentificacaoOcorrencia = "01",
                NumeroDocumento = "0000000001",
                DataVencimentoTitulo = "230319",
                ValorTitulo = "1050",
                BancoEncarregadoCobranca = "237",
                AgenciaDepositaria = "00000",
                EspecieTitulo = "12",
                Identificacao = "N",
                DataEmissaoTitulo = "220319",
                PrimeiraInstrucao = "00",
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = "0000000000000",
                DataLimiteConcessaoDesconto = "000000",
                ValorDesconto = "0000000000000",
                ValorIOF = "0000000000000",
                ValorAbatimento = "0000000000000",
                IdentificacaoTipoInscricao = "01",
                NumeroInscricaoPagador = "33531106821",
                NomePagador = "Fabio Gonçálvés",
                EnderecoCompleto = "Rua Ney Mascarenhas, 130",
                PrimeiraMensagem = "Teste primeira mensagem Boleto Fabio",
                Cep = "08542",
                SufixoCep = "120",
                SegundaMensagem = "Teste segunda mensagem Boleto Fabio"
            };

            TransacaoTipo1 stringTransacaoTipo12 = new TransacaoTipo1
            {
                IdentificacaoRegistro = "1",
                AgenciaPagador = "00000",
                DigitoAgencia = "",
                RazaoConta = "00000",
                ContaCorrente = "0000000",
                DigitoContaCorrente = "",
                IdentificacaoEmpresaBeneficiaria = "00090339200003409",
                NumeroControleParticipante = "444",
                CodigoBancoDebito = "000",
                Multa = "2",
                PercentualMulta = "2000",
                IdentificacaoTituloBanco = "00000000000",
                DigitoAutoConferencia = "0",
                DescontoBonificacaoDia = "0000000000",
                CondicaoEmissaoBoletoCobranca = "2",
                CondicaoRegistroDebitoAutomatico = "N",
                IdentificacaoOperacaoBanco = "",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                IdentificacaoOcorrencia = "01",
                NumeroDocumento = "0000000002",
                DataVencimentoTitulo = "210319",
                ValorTitulo = "0956",
                BancoEncarregadoCobranca = "237",
                AgenciaDepositaria = "00000",
                EspecieTitulo = "12",
                Identificacao = "N",
                DataEmissaoTitulo = "210319",
                PrimeiraInstrucao = "00",
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = "0000000002354",
                DataLimiteConcessaoDesconto = "270319",
                ValorDesconto = "0000000000326",
                ValorIOF = "0000000000000",
                ValorAbatimento = "0000000000000",
                IdentificacaoTipoInscricao = "01",
                NumeroInscricaoPagador = "36190841813",
                NomePagador = "Caio Ragazzi",
                EnderecoCompleto = "Rua Monlevade, 128",
                PrimeiraMensagem = "Teste primeira mensagem Boleto Caio",
                Cep = "04679",
                SufixoCep = "345",
                SegundaMensagem = "Teste segunda mensagem Boleto Caio"
            };

            TransacaoTipo1 stringTransacaoTipo13 = new TransacaoTipo1
            {
                IdentificacaoRegistro = "1",
                AgenciaPagador = "00000",
                DigitoAgencia = "",
                RazaoConta = "00000",
                ContaCorrente = "0000000",
                DigitoContaCorrente = "",
                IdentificacaoEmpresaBeneficiaria = "00090339200003409",
                NumeroControleParticipante = "444",
                CodigoBancoDebito = "000",
                Multa = "2",
                PercentualMulta = "4000",
                IdentificacaoTituloBanco = "00000000000",
                DigitoAutoConferencia = "0",
                DescontoBonificacaoDia = "0000000000",
                CondicaoEmissaoBoletoCobranca = "2",
                CondicaoRegistroDebitoAutomatico = "N",
                IdentificacaoOperacaoBanco = "",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                IdentificacaoOcorrencia = "01",
                NumeroDocumento = "5555555555",
                DataVencimentoTitulo = "220319",
                ValorTitulo = "0763",
                BancoEncarregadoCobranca = "237",
                AgenciaDepositaria = "00000",
                EspecieTitulo = "12",
                Identificacao = "N",
                DataEmissaoTitulo = "200319",
                PrimeiraInstrucao = "00",
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = "0000000005423",
                DataLimiteConcessaoDesconto = "300319",
                ValorDesconto = "0000000000654",
                ValorIOF = "0000000000000",
                ValorAbatimento = "0000000000000",
                IdentificacaoTipoInscricao = "02",
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
                Agencia = "",
                Carteira = "",
                ContaCorrente = "",
                DacNossoNumero = "",
                DataLimiteDesconto2 = "",
                DataLimiteDesconto3 = "",
                DigitoCC = "",
                Mensagem1 = "Mensagem 1 teste",
                Mensagem2 = "",
                Mensagem3 = "Mensagem 3 teste 2",
                Mensagem4 = "",
                NossoNumero = "",
                Reserva = "",
                TipoRegistro = "2",
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
                IdentificacaoRegistro = "3",
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
                IdentificacaoRegistro = "6",
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
                TipoRegistro = "7",
                Uf = ""
            };

            Trailler stringTrailler = new Trailler
            {
                Branco = "",
                IdentificacaoRegistro = "9"
            };

            List<StringBuilder> listaTransacoes = new List<StringBuilder>
            {
                stringTransacaoTipo1.GetTransacao(stringTransacaoTipo1),
                stringTransacaoTipo12.GetTransacao(stringTransacaoTipo12),
                stringTransacaoTipo13.GetTransacao(stringTransacaoTipo13),
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
