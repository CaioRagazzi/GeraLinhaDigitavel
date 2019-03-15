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
            string fileName = "CB" + System.DateTime.Now.ToString("dd") + System.DateTime.Now.ToString("MM") + System.DateTime.Now.ToString("ss");
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
                Branco = "",
                Branco2 = "",
                CodEmpresa = "5118770",
                CodigoServico = "01",
                DataGravacaoArquivo = "130319",
                IdentificacaoArquivoRemessa = "1",
                IdentificacaoRegistro = "0",
                IdentSistema = "MX",
                LiteralRemessa = "REMESSA",
                LiteralServico = "COBRANCA",
                NomeBanco = "BRADESCO",
                NomeEmpresa = "INTERMEIO SOLUCOES EM PAGA",
                NumeroBradesco = "237"
                
            };

            TransacaoTipo1 stringTransacaoTipo1 = new TransacaoTipo1
            {
                IdentificacaoRegistro = "1",
                AgenciaPagador = "00000",
                DigitoAgencia = "",
                RazaoConta = "00000",
                ContaCorrente = "0000000",
                DigitoContaCorrente = "",
                IdentificacaoEmpresaBeneficiaria = "00090339200003409",
                NumeroControleParticipante = "100",
                CodigoBancoDebito = "000",
                Multa = "0",
                PercentualMulta = "0000",
                IdentificacaoTituloBanco = "11345",
                DigitoAutoConferencia = "2",
                DescontoBonificacaoDia = "0000000000",
                CondicaoEmissaoBoletoCobranca = "1",
                CondicaoRegistroDebitoAutomatico = "N",
                IdentificacaoOperacaoBanco = "",
                IndicadorRateioCredito = "",
                EnderecamentoAvisoDebitoAutomatico = "2",
                PagamentoParcial = "",
                IdentificacaoOcorrencia = "02",
                NumeroDocumento = "1234567890",
                DataVencimentoTitulo = "230319",
                ValorTitulo = "5000",
                BancoEncarregadoCobranca = "000",
                AgenciaDepositaria = "00000",
                EspecieTitulo = "12",
                Identificacao = "N",
                DataEmissaoTitulo = "130319",
                PrimeiraInstrucao = "00",
                SegundaInstrucao = "00",
                ValorCobrarDiaAtraso = "0000000000000",
                DataLimiteConcessaoDesconto = "000000",
                ValorDesconto = "0000000000000",
                ValorIOF = "0000000000000",
                ValorAbatimento = "0000000000000",
                IdentificacaoTipoInscricao = "01",
                NumeroInscricaoPagador = "00014031730012",
                NomePagador = "TESTE SACADO",
                EnderecoCompleto = "AV JABAQUARA, 2819",
                PrimeiraMensagem = "",
                Cep = "04045",
                SufixoCep = "004",
                SegundaMensagem = ""
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
                stringTransacaoTipo1.GetTransacao(stringTransacaoTipo1)
                //stringTransacaoTipo2.GetTransacao(stringTransacaoTipo2),
                //stringTransacaoTipo3.GetTransacao(stringTransacaoTipo3),
                //stringTransacaoTipo6.GetTransacao(stringTransacaoTipo6),
                //stringTransacaoTipo7.GetTransacao(stringTransacaoTipo7)
            };

            using (StreamWriter sw = new StreamWriter("C:\\TesteGravacao\\" + GetFileName(test)))
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
